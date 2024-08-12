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
            let _result = v3.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result;
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
            string("\u{001b}[0m")
        }
        pub fn method9() -> string {
            string("")
        }
        pub fn closure11(v0_1: LrcPtr<Documents::Mut4>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
            string("documents.main")
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_green;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("args")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v610: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                    ()
                };
                let v617: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v618: string = v580.l0.get().clone();
                let v657: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure12((), ()),
                            v618
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v657.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v657)
            }
        }
        pub fn method10() -> string {
            string("source-dir")
        }
        pub fn closure13(
            v0_1: LrcPtr<MutCell<Option<Documents::US4>>>,
            v1_1: Option<Documents::US4>,
        ) -> LrcPtr<MutCell<Option<Documents::US4>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure14(
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
        pub fn closure15(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method21(v0_1)
        }
        pub fn method20() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure15((), v))
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
                    let v26: Documents::US1 =
                        defaultValue(Documents::US1::US1_1, _v8.get().clone());
                    match &v26 {
                        Documents::US1::US1_0(v26_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v26 {
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
                let v25: Documents::US1 = defaultValue(Documents::US1::US1_1, _v7.get().clone());
                match &v25 {
                    Documents::US1::US1_0(v25_0_0) => Documents::method22(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v25 {
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
        pub fn closure17(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.get_workspace_root")
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_yellow;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v607: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v614: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v615: string = v580.l0.get().clone();
                let v654: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure17((), ()),
                            v615
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v654.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v654)
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
                let v17: i32 = count_2(v15.clone());
                let v18: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method27(v17, v18.clone()) {
                    let v20: i32 = v18.l0.get().clone();
                    let v23: i32 = v20.wrapping_neg() + v17 - 1_i32;
                    let matchValue: i32 = v18.l1.get().clone();
                    let v25: Array<string> = v18.l2.get().clone();
                    let v24: i32 = matchValue;
                    let v26: string = v15[v23].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == v26.clone() {
                        (v24 + 1_i32, v25.clone())
                    } else {
                        if string(".") == v26.clone() {
                            (v24, v25.clone())
                        } else {
                            if 0_i32 == v24 {
                                if endsWith(v26.clone(), string(":"), false) {
                                    let v34: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v11.clone(), 0_i32)
                                    )]);
                                    let v35: i32 = count_2(v34.clone());
                                    let v37: i32 = v35 + count_2(v25.clone());
                                    let v38: Array<string> = new_init(&string(""), v37);
                                    let v39: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method28(v37, v39.clone()) {
                                        let v41: i32 = v39.l0.get().clone();
                                        let v46: string = if v41 < v35 {
                                            v34[v41].clone()
                                        } else {
                                            let v44: i32 = v41 - v35;
                                            v25[v44].clone()
                                        };
                                        v38.get_mut()[v41 as usize] = v46;
                                        {
                                            let v47: i32 = v41 + 1_i32;
                                            v39.l0.set(v47);
                                            ()
                                        }
                                    }
                                    (0_i32, v38.clone())
                                } else {
                                    let v48: Array<string> = new_array(&[v26]);
                                    let v49: i32 = count_2(v48.clone());
                                    let v51: i32 = v49 + count_2(v25.clone());
                                    let v52: Array<string> = new_init(&string(""), v51);
                                    let v53: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method28(v51, v53.clone()) {
                                        let v55: i32 = v53.l0.get().clone();
                                        let v60: string = if v55 < v49 {
                                            v48[v55].clone()
                                        } else {
                                            let v58: i32 = v55 - v49;
                                            v25[v58].clone()
                                        };
                                        v52.get_mut()[v55 as usize] = v60;
                                        {
                                            let v61: i32 = v55 + 1_i32;
                                            v53.l0.set(v61);
                                            ()
                                        }
                                    }
                                    (0_i32, v52.clone())
                                }
                            } else {
                                (v24 - 1_i32, v25.clone())
                            }
                        }
                    };
                    let v71: i32 = v20 + 1_i32;
                    v18.l0.set(v71);
                    v18.l1.set(patternInput_1.0.clone());
                    v18.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v18.l1.get().clone();
                    let v73: Array<string> = v18.l2.get().clone();
                    let v74: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v73 = v73.clone();
                        move || {
                            map(
                                Func1::new({
                                    let v73 = v73.clone();
                                    move |i: i32| v73[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, count_2(v73.clone()) - 1_i32),
                            )
                        }
                    }));
                    join(ofChar(Documents::method29()), toArray_1(v74))
                }
            } else {
                let v88: Result<std::path::PathBuf, std::io::Error> = std::fs::canonicalize(&*v0_1);
                let v90: std::path::PathBuf = v88.unwrap();
                let v92: std::path::Display = v90.display();
                let v95: std::string::String = format!("{}", v92);
                fable_library_rust::String_::fromString(v95)
            }
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
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
                Option<i64>,
            ) = getValue(Documents::State::trace_state().get().clone());
            let v25: () = {
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
            let v43: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v43,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v51: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v53: () = {
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
                let _v72: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v77: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v72 = _v72.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v72.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v90: Documents::US3 = defaultValue(Documents::US3::US3_1, _v72.get().clone());
                let v130: DateTime = match &v90 {
                    Documents::US3::US3_0(v90_0_0) => {
                        let v104: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v90 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v104.hours(),
                            v104.minutes(),
                            v104.seconds(),
                            v104.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v135: string = {
                    let provider: string = Documents::method6();
                    v130.toString(provider)
                };
                let v515: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v531: &str = inline_colorization::color_bright_blue;
                let v533: &str = &*v515;
                let v535: &str = inline_colorization::color_reset;
                let v537: string = string("format!(\"{v531}{v533}{v535}\")");
                let v538: std::string::String = format!("{v531}{v533}{v535}");
                let v540: string = fable_library_rust::String_::fromString(v538);
                let v581: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v583: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v590: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v597: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("source_dir")), ());
                    ()
                };
                let v604: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v610: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v617: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v624: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("dist_dir")), ());
                    ()
                };
                let v630: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v636: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v649: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("cache_dir")), ());
                    ()
                };
                let v655: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v661: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v667: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v674: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("hangul_spec")), ());
                    ()
                };
                let v680: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v686: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v693: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v694: string = v583.l0.get().clone();
                let v733: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v135,
                            v540,
                            v581,
                            Documents::closure19((), ()),
                            v694
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v733.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v733)
            }
        }
        pub fn method30(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method31() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure21((), v))
        }
        pub fn closure22(unitVar: (), v0_1: std::fs::FileType) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn closure23(unitVar: (), v0_1: std::string::String) -> Documents::US8 {
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
        pub fn closure20(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __result = Box::pin(async {
                //;
                let v4: bool = true;
                let __result = Box::pin(async move {
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
                        Err(v12_1_0) => Documents::closure23((), v12_1_0.clone()),
                        Ok(v12_0_0) => Documents::closure22((), v12_0_0.clone()),
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
                let v102 = __result;
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
            let v121 = __result;
            v121
        }
        pub fn closure25(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method36() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure25((), v))
        }
        pub fn closure26(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn closure27(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / stream_filter_map")
        }
        pub fn closure28(v0_1: std::string::String, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_red;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v604: std::string::String = format!("{:#?}", v0_1);
                let v634: () = {
                    Documents::closure11(
                        v580.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v604)),
                        (),
                    );
                    ()
                };
                let v641: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v580.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure29((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn closure24(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method36();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US10 = match &v3 {
                Err(v3_1_0) => Documents::closure27((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure26((), v3_0_0.clone()),
            };
            let v42: Documents::US1 = match &v6 {
                Documents::US10::US10_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let v14: std::string::String = format!("{}", v11);
                    Documents::US1::US1_0(fable_library_rust::String_::fromString(v14))
                }
                Documents::US10::US10_1(v6_1_0) => {
                    let v39: () = {
                        Documents::closure28(v6_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            match &v42 {
                Documents::US1::US1_0(v42_0_0) => Some(match &v42 {
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
                    Documents::closure24((), v)
                },
            )
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure30(v0_1: Vec<string>, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_blue;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: usize = v0_1.len();
                let v582: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v589: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v596: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("files_len")), ());
                    ()
                };
                let v603: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v606: std::string::String = format!("{:#?}", v580);
                let v636: () = {
                    Documents::closure11(
                        v582.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v606)),
                        (),
                    );
                    ()
                };
                let v643: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v644: string = v582.l0.get().clone();
                let v683: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure31((), ()),
                            v644
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v683.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v683)
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
        pub fn closure35(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure34(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure35(v0_1, v)
            })
        }
        pub fn method42() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure34((), v))
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
        pub fn closure36(
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
                    Documents::closure33((), arg10_0040)
                }
                fn v13(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure36((), arg10_0040_1)
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
        pub fn closure37(
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
        pub fn closure38(
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
                                        Documents::closure37((), arg10_0040)
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
                                            Documents::closure38((), arg10_0040_1)
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
                                                                                                                          Documents::closure37((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure38((),
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
        pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
        }
        pub fn closure39(
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
            let v30: () = {
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
            let v48: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v48,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v56: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v58: () = {
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
                let _v77: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v82: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v77 = _v77.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v77.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v95: Documents::US3 = defaultValue(Documents::US3::US3_1, _v77.get().clone());
                let v135: DateTime = match &v95 {
                    Documents::US3::US3_0(v95_0_0) => {
                        let v109: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v95 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v109.hours(),
                            v109.minutes(),
                            v109.seconds(),
                            v109.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v140: string = {
                    let provider: string = Documents::method6();
                    v135.toString(provider)
                };
                let v520: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v536: &str = inline_colorization::color_bright_blue;
                let v538: &str = &*v520;
                let v540: &str = inline_colorization::color_reset;
                let v542: string = string("format!(\"{v536}{v538}{v540}\")");
                let v543: std::string::String = format!("{v536}{v538}{v540}");
                let v545: string = fable_library_rust::String_::fromString(v543);
                let v586: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v588: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v595: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v602: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("file_name")), ());
                    ()
                };
                let v609: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v615: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v622: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v629: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("arguments")), ());
                    ()
                };
                let v635: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v638: std::string::String = format!("{:#?}", v8);
                let v668: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v638)),
                        (),
                    );
                    ()
                };
                let v674: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v681: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v687: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v693: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v700: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v706: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v712: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v718: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v725: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v731: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v734: std::string::String = format!("{:#?}", v1_1);
                let v764: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v734)),
                        (),
                    );
                    ()
                };
                let v770: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v777: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v783: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v792: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v798: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v805: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v811: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v814: std::string::String = format!("{:#?}", v3);
                let v844: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v814)),
                        (),
                    );
                    ()
                };
                let v850: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v857: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v863: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v866: std::string::String = format!("{:#?}", v4);
                let v896: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v866)),
                        (),
                    );
                    ()
                };
                let v902: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v909: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v915: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v924: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v930: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v937: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v943: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v946: std::string::String = format!("{:#?}", v6);
                let v976: () = {
                    Documents::closure11(
                        v588.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v946)),
                        (),
                    );
                    ()
                };
                let v983: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v989: () = {
                    Documents::closure11(v588.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v990: string = v588.l0.get().clone();
                let v1029: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v140,
                            v545,
                            v586,
                            Documents::closure40((), ()),
                            v990
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1029.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1029)
            }
        }
        pub fn closure41(
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
                    Documents::closure41((), v)
                },
            )
        }
        pub fn closure42(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method64() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure42((), v))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure43(v0_1: std::string::String, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_red;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v604: std::string::String = format!("{:#?}", v0_1);
                let v634: () = {
                    Documents::closure11(
                        v580.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v604)),
                        (),
                    );
                    ()
                };
                let v641: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v580.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure44((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn method65(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure45(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method66() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure45((), v))
        }
        pub fn closure46(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method67() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure46((), v))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure47(v0_1: std::string::String, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_red;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("e")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v604: std::string::String = format!("{:#?}", v0_1);
                let v634: () = {
                    Documents::closure11(
                        v580.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v604)),
                        (),
                    );
                    ()
                };
                let v641: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v580.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure48((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn closure50(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure49(v0_1: string, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_black;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v581: string = v580.l0.get().clone();
                let v620: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure50(v0_1, ()),
                            v581
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v620.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v620)
            }
        }
        pub fn closure51(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn method68(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>
        {
            v0_1
        }
        pub fn closure52(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method69(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure52((), v)
            })
        }
        pub fn method70(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure53(
            v0_1: LrcPtr<MutCell<Option<Documents::US24>>>,
            v1_1: Option<Documents::US24>,
        ) -> LrcPtr<MutCell<Option<Documents::US24>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure54(
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
        pub fn method71(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn closure55(
            v0_1: LrcPtr<MutCell<Option<Documents::US25>>>,
            v1_1: Option<Documents::US25>,
        ) -> LrcPtr<MutCell<Option<Documents::US25>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure56(
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
        pub fn method72(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method73(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method74(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure57(unitVar: (), v0_1: std::process::Output) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn closure58(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure59(v0_1: std::string::String, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_red;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v604: std::string::String = format!("{:#?}", v0_1);
                let v634: () = {
                    Documents::closure11(
                        v580.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v604)),
                        (),
                    );
                    ()
                };
                let v641: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v580.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure60((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn closure61(
            v0_1: LrcPtr<MutCell<Option<Documents::US27>>>,
            v1_1: Option<Documents::US27>,
        ) -> LrcPtr<MutCell<Option<Documents::US27>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure62(
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
        pub fn method75(
            v0_1: std::sync::Arc<
                std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
            >,
        ) -> std::sync::Arc<
            std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        > {
            v0_1
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure63(v0_1: i32, v1_1: string, unitVar: ()) {
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
            let v23: () = {
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
            let v41: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v41,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v49: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v51: () = {
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
                let _v70: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v75: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v70 = _v70.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v70.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v88: Documents::US3 = defaultValue(Documents::US3::US3_1, _v70.get().clone());
                let v128: DateTime = match &v88 {
                    Documents::US3::US3_0(v88_0_0) => {
                        let v102: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v88 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v102.hours(),
                            v102.minutes(),
                            v102.seconds(),
                            v102.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v133: string = {
                    let provider: string = Documents::method6();
                    v128.toString(provider)
                };
                let v513: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v529: &str = inline_colorization::color_bright_black;
                let v531: &str = &*v513;
                let v533: &str = inline_colorization::color_reset;
                let v535: string = string("format!(\"{v529}{v531}{v533}\")");
                let v536: std::string::String = format!("{v529}{v531}{v533}");
                let v538: string = fable_library_rust::String_::fromString(v536);
                let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: i32 = length(v1_1);
                let v582: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v589: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v596: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v603: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v609: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v616: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v623: () = {
                    Documents::closure11(
                        v582.clone(),
                        sprintf!("{}", string("std_trace_length")),
                        (),
                    );
                    ()
                };
                let v629: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v635: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v580), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v643: string = v582.l0.get().clone();
                let v682: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v133,
                            v538,
                            v579,
                            Documents::closure64((), ()),
                            v643
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v682.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v682)
            }
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async")
        }
        pub fn closure65(
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
            let v28: () = {
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
            let v46: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v46,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v54: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v56: () = {
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
                let _v75: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v80: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v75 = _v75.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v75.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v93: Documents::US3 = defaultValue(Documents::US3::US3_1, _v75.get().clone());
                let v133: DateTime = match &v93 {
                    Documents::US3::US3_0(v93_0_0) => {
                        let v107: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v93 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v107.hours(),
                            v107.minutes(),
                            v107.seconds(),
                            v107.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v138: string = {
                    let provider: string = Documents::method6();
                    v133.toString(provider)
                };
                let v518: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v534: &str = inline_colorization::color_bright_blue;
                let v536: &str = &*v518;
                let v538: &str = inline_colorization::color_reset;
                let v540: string = string("format!(\"{v534}{v536}{v538}\")");
                let v541: std::string::String = format!("{v534}{v536}{v538}");
                let v543: string = fable_library_rust::String_::fromString(v541);
                let v584: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v586: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v593: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v600: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v607: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v613: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v620: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v626: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v632: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v639: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v646: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v652: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v655: std::string::String = format!("{:#?}", v1_1);
                let v685: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v655)),
                        (),
                    );
                    ()
                };
                let v691: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v698: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v704: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v713: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v719: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v726: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v732: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v735: std::string::String = format!("{:#?}", v3);
                let v765: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v735)),
                        (),
                    );
                    ()
                };
                let v771: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v778: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v784: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v787: std::string::String = format!("{:#?}", v4);
                let v817: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v787)),
                        (),
                    );
                    ()
                };
                let v823: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v830: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v836: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v845: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v851: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v858: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v864: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v867: std::string::String = format!("{:#?}", v6);
                let v897: () = {
                    Documents::closure11(
                        v586.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v867)),
                        (),
                    );
                    ()
                };
                let v904: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v910: () = {
                    Documents::closure11(v586.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v911: string = v586.l0.get().clone();
                let v950: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v138,
                            v543,
                            v584,
                            Documents::closure66((), ()),
                            v911
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v950.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v950)
            }
        }
        pub fn closure68(
            v0_1: LrcPtr<MutCell<Option<Documents::US28>>>,
            v1_1: Option<Documents::US28>,
        ) -> LrcPtr<MutCell<Option<Documents::US28>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure69(
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
        pub fn closure71(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure70(v0_1: string, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_black;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v581: string = v580.l0.get().clone();
                let v620: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure71(v0_1, ()),
                            v581
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v620.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v620)
            }
        }
        pub fn closure67(
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
        pub fn closure72(
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
            v0_1: LrcPtr<MutCell<Option<Documents::US29>>>,
            v1_1: Option<Documents::US29>,
        ) -> LrcPtr<MutCell<Option<Documents::US29>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure74(
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
        pub fn closure75(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async / WaitForExitAsync")
        }
        pub fn closure76(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_yellow;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v587: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v594: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string("ex")), ());
                    ()
                };
                let v601: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v604: std::string::String = format!("{:#?}", v0_1);
                let v634: () = {
                    Documents::closure11(
                        v580.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v604)),
                        (),
                    );
                    ()
                };
                let v641: () = {
                    Documents::closure11(v580.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v580.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure77((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async")
        }
        pub fn closure78(v0_1: i32, v1_1: string, unitVar: ()) {
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
            let v23: () = {
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
            let v41: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v41,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v49: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v51: () = {
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
                let _v70: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v75: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v70 = _v70.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v70.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v88: Documents::US3 = defaultValue(Documents::US3::US3_1, _v70.get().clone());
                let v128: DateTime = match &v88 {
                    Documents::US3::US3_0(v88_0_0) => {
                        let v102: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v88 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v102.hours(),
                            v102.minutes(),
                            v102.seconds(),
                            v102.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v133: string = {
                    let provider: string = Documents::method6();
                    v128.toString(provider)
                };
                let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v529: &str = inline_colorization::color_bright_blue;
                let v531: &str = &*v513;
                let v533: &str = inline_colorization::color_reset;
                let v535: string = string("format!(\"{v529}{v531}{v533}\")");
                let v536: std::string::String = format!("{v529}{v531}{v533}");
                let v538: string = fable_library_rust::String_::fromString(v536);
                let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: i32 = length(v1_1);
                let v582: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v589: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v596: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v603: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v609: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v616: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v623: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("output_length")), ());
                    ()
                };
                let v629: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v635: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v580), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v643: string = v582.l0.get().clone();
                let v682: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v133,
                            v538,
                            v579,
                            Documents::closure79((), ()),
                            v643
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v682.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v682)
            }
        }
        pub fn method76(
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
            let _result: Vec<_> = v32
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
            let v44: Vec<std::string::String> = _result;
            let v47: () = {
                Documents::closure39(
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
            let _v48: MutCell<Option<LrcPtr<(i32, string)>>> =
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
                        let v50: std::process::Command = std::process::Command::new(&*v18.clone());
                        let v52: bool = true;
                        let mut v50 = v50;
                        let v54: &mut std::process::Command =
                            std::process::Command::args(&mut v50, &*v44.clone());
                        let v56: std::process::Stdio = std::process::Stdio::piped();
                        let v58: &mut std::process::Command =
                            std::process::Command::stdout(v54, std::process::Stdio::piped());
                        let v60: std::process::Stdio = std::process::Stdio::piped();
                        let v62: &mut std::process::Command =
                            std::process::Command::stderr(v58, std::process::Stdio::piped());
                        let v64: std::process::Stdio = std::process::Stdio::piped();
                        let v66: &mut std::process::Command =
                            std::process::Command::stdin(v62, std::process::Stdio::piped());
                        let _v67: LrcPtr<MutCell<Option<Documents::US1>>> =
                            refCell(None::<Documents::US1>);
                        let v72: () = {
                            Documents::closure4(
                                v6.clone(),
                                Func1::new({
                                    let _v67 = _v67.clone();
                                    move |v: Option<Documents::US1>| {
                                        Documents::closure3(_v67.clone(), v)
                                    }
                                }),
                                (),
                            );
                            ()
                        };
                        let v85: Documents::US1 =
                            defaultValue(Documents::US1::US1_1, _v67.get().clone());
                        let v93: &mut std::process::Command = match &v85 {
                            Documents::US1::US1_0(v85_0_0) => std::process::Command::current_dir(
                                v66,
                                &*match &v85 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            ),
                            _ => v66,
                        };
                        let v111: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v93
                        } else {
                            let v97: Vec<(string, string)> = v2.clone().to_vec();
                            let v99: bool = true;
                            let _result = v97.into_iter().fold(v93, |acc, x| {
                                //;
                                let v101: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v106: &mut std::process::Command = std::process::Command::env(
                                    v101,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v108: bool = true;
                                v106
                            });
                            _result
                        };
                        let v113: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v111);
                        let v114 = Documents::method31();
                        let v116: Result<std::process::Child, std::string::String> =
                            v113.map_err(|x| v114(x));
                        let v118: bool = true;
                        let _result = v116.map(|x| {
                            //;
                            let v120: std::process::Child = x;
                            let v125: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(Some(v120));
                            let v127: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v125);
                            let v129: bool = true;
                            v127
                        });
                        let v131: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result;
                        let v132 = Documents::method63();
                        let v133 = Documents::method64();
                        let v135: Documents::US21 = match v131 {
                            Ok(x) => v132(x),
                            Err(e) => v133(e),
                        };
                        let patternInput_3: (i32, Documents::US4, Documents::US22) = match &v135 {
                            Documents::US21::US21_0(v135_0_0) => {
                                let v136: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v135_0_0.clone();
                                let v138: bool = true;
                                let _result = (|| {
                                    // rust.capture;
                                    let v139: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v136.clone());
                                    let v141: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v139.lock();
                                    let v143: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v141.unwrap();
                                    let v145: bool = true;
                                    let mut v143 = v143;
                                    let v147: &mut Option<std::process::Child> = &mut v143;
                                    let v149: Option<&mut std::process::Child> = v147.as_mut();
                                    let v151: &mut std::process::Child = v149.unwrap();
                                    let v153: &mut Option<std::process::ChildStdout> =
                                        &mut v151.stdout;
                                    let v155: Option<std::process::ChildStdout> =
                                        Option::take(v153);
                                    let v157: std::process::ChildStdout = v155.unwrap();
                                    let v159: bool = true;
                                    v157
                                })();
                                let v161: std::process::ChildStdout = _result;
                                let v163: bool = true;
                                let _result = (|| {
                                    // rust.capture;
                                    let v164: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v136.clone());
                                    let v166: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v164.lock();
                                    let v168: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v166.unwrap();
                                    let v170: bool = true;
                                    let mut v168 = v168;
                                    let v172: &mut Option<std::process::Child> = &mut v168;
                                    let v174: Option<&mut std::process::Child> = v172.as_mut();
                                    let v176: &mut std::process::Child = v174.unwrap();
                                    let v178: &mut Option<std::process::ChildStderr> =
                                        &mut v176.stderr;
                                    let v180: Option<std::process::ChildStderr> =
                                        Option::take(v178);
                                    let v182: std::process::ChildStderr = v180.unwrap();
                                    let v184: bool = true;
                                    v182
                                })();
                                let v186: std::process::ChildStderr = _result;
                                let v188: bool = true;
                                let _result = (|| {
                                    // rust.capture;
                                    let v189: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v136.clone());
                                    let v191: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v189.lock();
                                    let v193: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v191.unwrap();
                                    let v195: bool = true;
                                    let mut v193 = v193;
                                    let v197: &mut Option<std::process::Child> = &mut v193;
                                    let v199: Option<&mut std::process::Child> = v197.as_mut();
                                    let v201: &mut std::process::Child = v199.unwrap();
                                    let v203: &mut Option<std::process::ChildStdin> =
                                        &mut v201.stdin;
                                    let v205: Option<std::process::ChildStdin> = Option::take(v203);
                                    let v207: std::process::ChildStdin = v205.unwrap();
                                    let v212: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(Some(v207));
                                    let v214: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v212);
                                    let v216: bool = true;
                                    v214
                                })();
                                let v218: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _result;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v220: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v223: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v220.clone());
                                let v225: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v223);
                                let v227: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v220);
                                let v229: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v227);
                                let v231: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(patternInput_2.1.clone());
                                let v233: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v231);
                                let v235: bool = true;
                                let __result = std::thread::spawn(move || {
                                    //;
                                    let v237: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v161);
                                    let v239: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v237);
                                    let v241: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v239);
                                    let v243: bool = true;
                                    let mut v241 = v241;
                                    let _result = v241.try_for_each(|x| {
                                        //;
                                        let v245: Result<std::string::String, std::io::Error> = x;
                                        let v247: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v225.clone();
                                        let v248 = Documents::method31();
                                        let v250: Result<std::string::String, std::string::String> =
                                            v245.map_err(|x| v248(x));
                                        let v251 = Documents::method66();
                                        let v252 = Documents::method67();
                                        let v254: Documents::US23 = match v250 {
                                            Ok(x) => v251(x),
                                            Err(e) => v252(e),
                                        };
                                        let v289: std::string::String = match &v254 {
                                            Documents::US23::US23_0(v254_0_0) => {
                                                let v257: string =
                                                    fable_library_rust::String_::fromString(
                                                        v254_0_0.clone(),
                                                    );
                                                let v259: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v261: std::borrow::Cow<[u8]> =
                                                    v259.encode(&*v257).0;
                                                let v263: &[u8] = v261.as_ref();
                                                let v265: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v263);
                                                let v267: &str = v265.unwrap();
                                                let v269: std::string::String = String::from(v267);
                                                let v272: string = sprintf!(
                                                    "> {}",
                                                    fable_library_rust::String_::fromString(
                                                        v269.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v275: () = {
                                                        Documents::closure49(v272.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v278: () = {
                                                        Documents::closure51(v272, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v269
                                            }
                                            Documents::US23::US23_1(v254_1_0) => {
                                                let v279: std::string::String = v254_1_0.clone();
                                                let v282: () = {
                                                    Documents::closure47(v279.clone(), ());
                                                    ()
                                                };
                                                let v283: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v279);
                                                let v285: &str = &*v283;
                                                String::from(v285)
                                            }
                                        };
                                        let v290: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = Documents::method68(v247);
                                        let v292: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v290.lock();
                                        let v294: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v292.unwrap();
                                        let v296: &std::sync::mpsc::Sender<std::string::String> =
                                            &v294;
                                        let v298: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v296.send(v289);
                                        let v299 = Documents::method69();
                                        let v301: Result<(), std::string::String> =
                                            v298.map_err(|x| v299(x));
                                        let v303: _ = v301;
                                        let v305: bool = true;
                                        v303
                                    }); //;
                                    let v308: Result<(), string> =
                                        Documents::method70(_result.map_err(|x| x.into()));
                                    let v312: string =
                                        string("true; v308 });  // rust.fix_closure\'");
                                    let v313: bool = true;
                                    v308
                                }); // rust.fix_closure';
                                let v315: std::thread::JoinHandle<Result<(), string>> = __result;
                                let v317: bool = true;
                                let __result = std::thread::spawn(move || {
                                    //;
                                    let v319: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v186);
                                    let v321: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v319);
                                    let v323: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v321);
                                    let v325: bool = true;
                                    let mut v323 = v323;
                                    let _result = v323.try_for_each(|x| {
                                        //;
                                        let v327: Result<std::string::String, std::io::Error> = x;
                                        let v329: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v229.clone();
                                        let v330 = Documents::method31();
                                        let v332: Result<std::string::String, std::string::String> =
                                            v327.map_err(|x| v330(x));
                                        let v333 = Documents::method66();
                                        let v334 = Documents::method67();
                                        let v336: Documents::US23 = match v332 {
                                            Ok(x) => v333(x),
                                            Err(e) => v334(e),
                                        };
                                        let v376: std::string::String = match &v336 {
                                            Documents::US23::US23_0(v336_0_0) => {
                                                let v339: string =
                                                    fable_library_rust::String_::fromString(
                                                        v336_0_0.clone(),
                                                    );
                                                let v341: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v343: std::borrow::Cow<[u8]> =
                                                    v341.encode(&*v339).0;
                                                let v345: &[u8] = v343.as_ref();
                                                let v347: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v345);
                                                let v349: &str = v347.unwrap();
                                                let v351: std::string::String = String::from(v349);
                                                let v354: string = sprintf!(
                                                    "! {}",
                                                    fable_library_rust::String_::fromString(
                                                        v351.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v357: () = {
                                                        Documents::closure49(v354.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v360: () = {
                                                        Documents::closure51(v354, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v361: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v351
                                                    );
                                                    let v363: &str = &*v361;
                                                    String::from(v363)
                                                }
                                            }
                                            Documents::US23::US23_1(v336_1_0) => {
                                                let v366: std::string::String = v336_1_0.clone();
                                                let v369: () = {
                                                    Documents::closure47(v366.clone(), ());
                                                    ()
                                                };
                                                let v370: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v366);
                                                let v372: &str = &*v370;
                                                String::from(v372)
                                            }
                                        };
                                        let v377: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = Documents::method68(v329);
                                        let v379: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v377.lock();
                                        let v381: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v379.unwrap();
                                        let v383: &std::sync::mpsc::Sender<std::string::String> =
                                            &v381;
                                        let v385: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v383.send(v376);
                                        let v386 = Documents::method69();
                                        let v388: Result<(), std::string::String> =
                                            v385.map_err(|x| v386(x));
                                        let v390: _ = v388;
                                        let v392: bool = true;
                                        v390
                                    }); //;
                                    let v395: Result<(), string> =
                                        Documents::method70(_result.map_err(|x| x.into()));
                                    let v397: string =
                                        string("true; v395 });  // rust.fix_closure\'");
                                    let v398: bool = true;
                                    v395
                                }); // rust.fix_closure';
                                let v400: std::thread::JoinHandle<Result<(), string>> = __result;
                                let _v401: LrcPtr<MutCell<Option<Documents::US24>>> =
                                    refCell(None::<Documents::US24>);
                                let v406: () = {
                                    Documents::closure54(
                                        v4.clone(),
                                        Func1::new({
                                            let _v401 = _v401.clone();
                                            move |v_1: Option<Documents::US24>| {
                                                Documents::closure53(_v401.clone(), v_1)
                                            }
                                        }),
                                        (),
                                    );
                                    ()
                                };
                                let v419: Documents::US24 =
                                    defaultValue(Documents::US24::US24_1, _v401.get().clone());
                                match &v419 {
                                    Documents::US24::US24_0(v419_0_0) => {
                                        let v424: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = Documents::method71(v218);
                                        let v426: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v424.lock();
                                        let v428: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = v426.unwrap();
                                        let v430: bool = true;
                                        let mut v428 = v428;
                                        let v432: &mut Option<std::process::ChildStdin> = &mut v428;
                                        let v434: Option<std::process::ChildStdin> =
                                            Option::take(v432);
                                        let v436: bool = true;
                                        let _result = v434.map(|x| {
                                            //;
                                            let v438: std::process::ChildStdin = x;
                                            let v440: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v438);
                                            let v442: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v440);
                                            let v444: bool = true;
                                            v442
                                        });
                                        let v446: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _result;
                                        let _v447: LrcPtr<MutCell<Option<Documents::US25>>> =
                                            refCell(None::<Documents::US25>);
                                        let v452: () = {
                                            Documents::closure56(
                                                v446,
                                                Func1::new({
                                                    let _v447 = _v447.clone();
                                                    move |v_2: Option<Documents::US25>| {
                                                        Documents::closure55(_v447.clone(), v_2)
                                                    }
                                                }),
                                                (),
                                            );
                                            ()
                                        };
                                        let v465: Documents::US25 = defaultValue(
                                            Documents::US25::US25_1,
                                            _v447.get().clone(),
                                        );
                                        match &v465 {
                                            Documents::US25::US25_0(v465_0_0) => {
                                                let v469: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v465 {
                                                    Documents::US25::US25_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                (match &v419 {
                                                    Documents::US24::US24_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v469.clone()
                                                );
                                                {
                                                    let v470: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = Documents::method72(v469);
                                                    let v472: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v470.lock();
                                                    let v475: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method73(v472.unwrap());
                                                    let v477: bool = true;
                                                    let mut v475 = v475;
                                                    let v479: bool = true;
                                                    std::io::Write::flush(&mut *v475).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v480: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v136);
                                    let v482: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v480.lock();
                                    let v484: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v482.unwrap();
                                    let v486: bool = true;
                                    let mut v484 = v484;
                                    let v488: &mut Option<std::process::Child> = &mut v484;
                                    let v490: Option<std::process::Child> = Option::take(v488);
                                    let v492: std::process::Child = v490.unwrap();
                                    let v494: Result<std::process::Output, std::io::Error> =
                                        v492.wait_with_output();
                                    let v495 = Documents::method31();
                                    let v497: Result<std::process::Output, std::string::String> =
                                        v494.map_err(|x| v495(x));
                                    let v498: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method74(v400);
                                    let v501: string = string("v498");
                                    let v502: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method74(v315);
                                    let v507: string = append(
                                        append(string("vec!["), append(string("v502, "), v501)),
                                        string("]"),
                                    );
                                    let v508: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v502, v498];
                                    let v510: bool = true;
                                    v508.into_iter().for_each(|x| {
                                        //;
                                        let v512: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v514: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v512);
                                        let v516: Result<(), string> = v514.unwrap();
                                        v516.unwrap();
                                        {
                                            let v519: bool = true;
                                            ()
                                        }
                                    });
                                    {
                                        //;
                                        let v522: Documents::US26 = match &v497 {
                                            Err(v497_1_0) => {
                                                Documents::closure58((), v497_1_0.clone())
                                            }
                                            Ok(v497_0_0) => {
                                                Documents::closure57((), v497_0_0.clone())
                                            }
                                        };
                                        match &v522 {
                                            Documents::US26::US26_0(v522_0_0) => {
                                                let v525: std::process::ExitStatus =
                                                    v522_0_0.clone().status;
                                                let v527: Option<i32> = v525.code();
                                                let _v528: LrcPtr<
                                                    MutCell<Option<Documents::US27>>,
                                                > = refCell(None::<Documents::US27>);
                                                let v533: () = {
                                                    Documents::closure62(
                                                        v527,
                                                        Func1::new({
                                                            let _v528 = _v528.clone();
                                                            move |v_5: Option<Documents::US27>| {
                                                                Documents::closure61(
                                                                    _v528.clone(),
                                                                    v_5,
                                                                )
                                                            }
                                                        }),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                let v546: Documents::US27 = defaultValue(
                                                    Documents::US27::US27_1,
                                                    _v528.get().clone(),
                                                );
                                                match &v546 {
                                                    Documents::US27::US27_0(v546_0_0) => (
                                                        match &v546 {
                                                            Documents::US27::US27_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US4::US4_1,
                                                        Documents::US22::US22_0(v233.clone()),
                                                    ),
                                                    _ => {
                                                        let v555:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US4::US4_0(String::from(
                                                                v555,
                                                            )),
                                                            Documents::US22::US22_0(v233.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US26::US26_1(v522_1_0) => {
                                                let v566: std::string::String = v522_1_0.clone();
                                                let v569: () = {
                                                    Documents::closure59(v566.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US4::US4_0(v566),
                                                    Documents::US22::US22_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US21::US21_1(v135_1_0) => {
                                let v578: std::string::String = v135_1_0.clone();
                                let v581: () = {
                                    Documents::closure43(v578.clone(), ());
                                    ()
                                };
                                (-1_i32, Documents::US4::US4_0(v578), Documents::US22::US22_1)
                            }
                        };
                        let v589: Documents::US22 = patternInput_3.2.clone();
                        let v588: Documents::US4 = patternInput_3.1.clone();
                        let v587: i32 = patternInput_3.0.clone();
                        let v596: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v589 {
                            Documents::US22::US22_0(v589_0_0) => Some(match &v589 {
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
                        let v598: bool = true;
                        let _result = v596.map(|x| {
                            //;
                            let v601: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = Documents::method75(x);
                            let v603: Result<
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
                            > = v601.lock();
                            let v605: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v603.unwrap();
                            let v607 = v605.iter();
                            let v609: Vec<std::string::String> = v607.collect::<Vec<_>>();
                            let v611: bool = true;
                            let _result: Vec<_> = v609
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v613: std::string::String = x;
                                    let v615: string =
                                        fable_library_rust::String_::fromString(v613);
                                    let v617: bool = true;
                                    v615
                                })
                                .collect::<Vec<_>>();
                            let v619: Vec<string> = _result;
                            let v628: string = join(
                                string("\n"),
                                toArray_1(ofArray_1(fable_library_rust::NativeArray_::array_from(
                                    v619,
                                ))),
                            );
                            let v632: bool = true;
                            v628
                        });
                        let v634: Option<string> = _result;
                        let v641: Documents::US1 = match &v588 {
                            Documents::US4::US4_0(v588_0_0) => Documents::US1::US1_0(
                                fable_library_rust::String_::fromString(match &v588 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Documents::US1::US1_1,
                        };
                        let v646: string = defaultValue(
                            match &v641 {
                                Documents::US1::US1_0(v641_0_0) => match &v641 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v634,
                        );
                        let v651: () = {
                            Documents::closure63(v587, v646.clone(), ());
                            ()
                        };
                        LrcPtr::new((v587, v646))
                    }
                }))();
                _v48.set(Some(x_3))
            }
            {
                let v653: LrcPtr<(i32, string)> = match &_v48.get().clone() {
                    None => panic!("{}", string("base.capture / _v48=None"),),
                    Some(_v48_0_0) => _v48_0_0.clone(),
                };
                let _v7: (i32, string) = (v653.0.clone(), v653.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method78(v0_1: string) -> string {
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
        pub fn method77(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method15(v2, Documents::method78(v1_1.clone()));
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
        pub fn method79() -> string {
            string("")
        }
        pub fn closure80(unitVar: (), v0_1: string) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method80() -> Func1<string, Documents::US31> {
            Func1::new(move |v: string| Documents::closure80((), v))
        }
        pub fn closure81(unitVar: (), v0_1: std::string::String) -> Documents::US31 {
            Documents::US31::US31_1(v0_1)
        }
        pub fn method81() -> Func1<std::string::String, Documents::US31> {
            Func1::new(move |v: std::string::String| Documents::closure81((), v))
        }
        pub fn method82(v0_1: string) -> bool {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.clone().exists() {
                v7.is_file()
            } else {
                false
            }
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> string {
            let v0_1: string =
                string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
            v0_1
        }
        pub fn closure82(
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
            let v32: () = {
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
            let v50: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v50,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v58: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v60: () = {
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
                let _v79: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v84: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v79 = _v79.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v79.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v97: Documents::US3 = defaultValue(Documents::US3::US3_1, _v79.get().clone());
                let v137: DateTime = match &v97 {
                    Documents::US3::US3_0(v97_0_0) => {
                        let v111: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v97 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v111.hours(),
                            v111.minutes(),
                            v111.seconds(),
                            v111.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v142: string = {
                    let provider: string = Documents::method6();
                    v137.toString(provider)
                };
                let v522: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v538: &str = inline_colorization::color_bright_green;
                let v540: &str = &*v522;
                let v542: &str = inline_colorization::color_reset;
                let v544: string = string("format!(\"{v538}{v540}{v542}\")");
                let v545: std::string::String = format!("{v538}{v540}{v542}");
                let v547: string = fable_library_rust::String_::fromString(v545);
                let v588: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v590: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v597: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v604: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("file")), ());
                    ()
                };
                let v611: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v617: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v624: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v631: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("real_path")), ());
                    ()
                };
                let v637: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v643: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v649: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v656: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("relative_path")), ());
                    ()
                };
                let v662: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v668: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v674: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v681: () = {
                    Documents::closure11(
                        v590.clone(),
                        sprintf!("{}", string("origin_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v687: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v693: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v4), ());
                    ()
                };
                let v699: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v706: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("origin_hash")), ());
                    ()
                };
                let v712: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v718: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v724: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v731: () = {
                    Documents::closure11(
                        v590.clone(),
                        sprintf!("{}", string("local_git_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v737: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v743: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v749: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v756: () = {
                    Documents::closure11(
                        v590.clone(),
                        sprintf!("{}", string("local_git_hash")),
                        (),
                    );
                    ()
                };
                let v762: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v768: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v6), ());
                    ()
                };
                let v774: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v781: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("hash1")), ());
                    ()
                };
                let v787: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v793: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v9), ());
                    ()
                };
                let v799: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v806: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("hash2")), ());
                    ()
                };
                let v812: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v821: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", sprintf!("{:?}", v10)), ());
                    ()
                };
                let v827: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v834: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("dist_path")), ());
                    ()
                };
                let v840: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v846: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v5), ());
                    ()
                };
                let v852: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v859: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string("cache_path")), ());
                    ()
                };
                let v865: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v871: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", v8), ());
                    ()
                };
                let v878: () = {
                    Documents::closure11(v590.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v879: string = v590.l0.get().clone();
                let v918: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v142,
                            v547,
                            v588,
                            Documents::closure83((), ()),
                            v879
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v918.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v918)
            }
        }
        pub fn method84(v0_1: string) -> string {
            v0_1
        }
        pub fn method83(v0_1: string, v1_1: string) {
            let v3: string = Documents::method84(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v3);
            let v7: u64 = v5.unwrap();
            ();
            ()
        }
        pub fn method86(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method87(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method88(v0_1: string) -> string {
            v0_1
        }
        pub fn method89(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure86(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v2: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                Documents::method72(v1_1);
            let v4: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v2.lock();
            let v6: std::sync::MutexGuard<std::process::ChildStdin> = v4.unwrap();
            let v7: string = Documents::method88(v0_1);
            let v9: &[u8] = v7.as_bytes();
            let v10: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method89(v6);
            let v12: bool = true;
            let mut v10 = v10;
            let v14: bool = true;
            std::io::Write::write_all(&mut *v10, v9).unwrap();
            ()
        }
        pub fn method90(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method91(v0_1: string) -> string {
            v0_1
        }
        pub fn closure88(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure87(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
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
            let v24: () = {
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
            let v42: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v42,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v50: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v52: () = {
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
                let _v71: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v76: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v71 = _v71.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v71.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v89: Documents::US3 = defaultValue(Documents::US3::US3_1, _v71.get().clone());
                let v129: DateTime = match &v89 {
                    Documents::US3::US3_0(v89_0_0) => {
                        let v103: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v89 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v103.hours(),
                            v103.minutes(),
                            v103.seconds(),
                            v103.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v134: string = {
                    let provider: string = Documents::method6();
                    v129.toString(provider)
                };
                let v514: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v530: &str = inline_colorization::color_bright_green;
                let v532: &str = &*v514;
                let v534: &str = inline_colorization::color_reset;
                let v536: string = string("format!(\"{v530}{v532}{v534}\")");
                let v537: std::string::String = format!("{v530}{v532}{v534}");
                let v539: string = fable_library_rust::String_::fromString(v537);
                let v580: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v581: i32 = length(v2);
                let v583: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v590: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v597: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v604: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v610: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v617: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v624: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v630: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v636: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v581), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v649: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v655: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v661: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v668: () = {
                    Documents::closure11(v583.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v669: string = v583.l0.get().clone();
                let v708: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v134,
                            v539,
                            v580,
                            Documents::closure88((), ()),
                            v669
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v708.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v708)
            }
        }
        pub fn method85(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US32 {
            let v7: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v30: Vec<u8> = Documents::method86(v7.unwrap());
            let v32: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v30);
            let v34: std::string::String = v32.unwrap();
            let v56: Array<string> = split(
                fable_library_rust::String_::fromString(v34),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v57: i32 = count_2(v56.clone());
            let v58: Array<string> = new_init(&string(""), v57);
            let v59: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method28(v57, v59.clone()) {
                let v61: i32 = v59.l0.get().clone();
                let v64: string = trim(v56[v61].clone());
                v58.get_mut()[v61 as usize] = v64;
                {
                    let v65: i32 = v61 + 1_i32;
                    v59.l0.set(v65);
                    ()
                }
            }
            {
                let v66: i32 = count_2(v58.clone());
                let v67: Array<string> = new_init(&string(""), v66);
                let v68: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method87(v66, v68.clone()) {
                    let v70: i32 = v68.l0.get().clone();
                    let v71: i32 = v68.l1.get().clone();
                    let v72: string = v58[v70].clone();
                    let v78: i32 = if string("") != v72.clone() {
                        v67.get_mut()[v71 as usize] = v72;
                        v71 + 1_i32
                    } else {
                        v71
                    };
                    let v79: i32 = v70 + 1_i32;
                    v68.l0.set(v79);
                    v68.l1.set(v78);
                    ()
                }
                {
                    let v80: i32 = v68.l1.get().clone();
                    let v81: Array<string> = new_init(&string(""), v80);
                    let v82: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method28(v80, v82.clone()) {
                        let v84: i32 = v82.l0.get().clone();
                        let v85: string = v67[v84].clone();
                        v81.get_mut()[v84 as usize] = v85;
                        {
                            let v86: i32 = v84 + 1_i32;
                            v82.l0.set(v86);
                            ()
                        }
                    }
                    {
                        let v95: string = sprintf!(
                            "{}\n\n",
                            join(
                                string("\n"),
                                toArray_1(delay(Func0::new({
                                    let v81 = v81.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v81 = v81.clone();
                                                move |i: i32| v81[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v81.clone()) - 1_i32,
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
                                let v95 = v95.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure86(v95.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v136: i32 = patternInput.0.clone();
                        let v138: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v139: i32 = count_2(v138.clone());
                        let v141: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method90(v66, v141.clone()) {
                            let v143: i32 = v141.l0.get().clone();
                            let matchValue: string = v141.l1.get().clone();
                            let matchValue_1: i32 = v141.l2.get().clone();
                            let v146: i32 = v141.l3.get().clone();
                            let v145: i32 = matchValue_1;
                            let v144: string = matchValue;
                            let patternInput_2: (string, i32, i32) =
                                if v58[v143].clone() == string("") {
                                    (sprintf!("{}\n", v144.clone()), v145 + 1_i32, v146 + 1_i32)
                                } else {
                                    let v152: i32 = v145 - v146;
                                    (
                                        if v152 >= v139 {
                                            v144.clone()
                                        } else {
                                            let v154: string = v138[v152].clone();
                                            if v152 == v139 - 1_i32 {
                                                sprintf!("{}{}", v144.clone(), v154.clone())
                                            } else {
                                                sprintf!("{}{}\n", v144, v154)
                                            }
                                        },
                                        v145 + 1_i32,
                                        v146,
                                    )
                                };
                            let v165: i32 = v143 + 1_i32;
                            v141.l0.set(v165);
                            v141.l1.set(patternInput_2.0.clone());
                            v141.l2.set(patternInput_2.1.clone());
                            v141.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v141.l1.get().clone();
                            let matchValue_4: i32 = v141.l2.get().clone();
                            let matchValue_5: i32 = v141.l3.get().clone();
                            let v166: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v166.clone()).unwrap();
                            ();
                            {
                                let v174: () = {
                                    Documents::closure87(v2, v136, v166.clone(), ());
                                    ()
                                };
                                Documents::US32::US32_0(v136, v166)
                            }
                        }
                    }
                }
            }
        }
        pub fn closure90(unitVar: (), unitVar_1: ()) -> string {
            string("documents.files_fn / error")
        }
        pub fn closure89(v0_1: string, v1_1: i32, unitVar: ()) {
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
            let v23: () = {
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
            let v41: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v41,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v49: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v51: () = {
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
                let _v70: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v75: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v70 = _v70.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v70.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v88: Documents::US3 = defaultValue(Documents::US3::US3_1, _v70.get().clone());
                let v128: DateTime = match &v88 {
                    Documents::US3::US3_0(v88_0_0) => {
                        let v102: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v88 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v102.hours(),
                            v102.minutes(),
                            v102.seconds(),
                            v102.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v133: string = {
                    let provider: string = Documents::method6();
                    v128.toString(provider)
                };
                let v513: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v529: &str = inline_colorization::color_bright_green;
                let v531: &str = &*v513;
                let v533: &str = inline_colorization::color_reset;
                let v535: string = string("format!(\"{v529}{v531}{v533}\")");
                let v536: std::string::String = format!("{v529}{v531}{v533}");
                let v538: string = fable_library_rust::String_::fromString(v536);
                let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v581: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v588: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v595: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v602: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v608: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v615: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v622: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v628: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v634: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v641: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v581.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v133,
                            v538,
                            v579,
                            Documents::closure90((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn closure85(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method77(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method82(v6.clone()) {
                Documents::method82(v7.clone())
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
                            let _result: Vec<_> = v78
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
                            let v90: Vec<string> = _result;
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
                            let v99: string = join(Documents::method79(), toArray_1(v93));
                            let v103 = Documents::method31();
                            let v105: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v99).map_err(|x| v103(x));
                            let v106 = Documents::method80();
                            let v107 = Documents::method81();
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
                                        let _result: Vec<_> = v183
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
                                        let v195: Vec<string> = _result;
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
                                            join(Documents::method79(), toArray_1(v198));
                                        let v208 = Documents::method31();
                                        let v210: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v204).map_err(|x| v208(x));
                                        let v211 = Documents::method80();
                                        let v212 = Documents::method81();
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
                let v224: Documents::US32 = Documents::method85(v2, v3, v6.clone(), v4);
                match &v224 {
                    Documents::US32::US32_0(v224_0_0, v224_0_1) => {
                        let v226: string = v224_0_1.clone();
                        let v225: i32 = v224_0_0.clone();
                        if v225 != 0_i32 {
                            let v232: () = {
                                Documents::closure89(v226.clone(), v225, ());
                                ()
                            };
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v226)),
                            ))
                        } else {
                            if Documents::method82(v6.clone()) {
                                Documents::method83(v7, v6.clone())
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
        pub fn closure84(
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
                    Documents::closure85(
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
        pub fn closure94(unitVar: (), unitVar_1: ()) -> string {
            string("documents.crowbook / result contains ERROR")
        }
        pub fn closure93(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
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
            let v24: () = {
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
            let v42: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v42,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v50: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v52: () = {
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
                let _v71: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v76: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v71 = _v71.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v71.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v89: Documents::US3 = defaultValue(Documents::US3::US3_1, _v71.get().clone());
                let v129: DateTime = match &v89 {
                    Documents::US3::US3_0(v89_0_0) => {
                        let v103: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v89 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v103.hours(),
                            v103.minutes(),
                            v103.seconds(),
                            v103.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v134: string = {
                    let provider: string = Documents::method6();
                    v129.toString(provider)
                };
                let v514: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v530: &str = inline_colorization::color_yellow;
                let v532: &str = &*v514;
                let v534: &str = inline_colorization::color_reset;
                let v536: string = string("format!(\"{v530}{v532}{v534}\")");
                let v537: std::string::String = format!("{v530}{v532}{v534}");
                let v539: string = fable_library_rust::String_::fromString(v537);
                let v580: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v582: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v589: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v596: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v603: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v609: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v616: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v623: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v629: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v635: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v641: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v648: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v667: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v668: string = v582.l0.get().clone();
                let v707: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v134,
                            v539,
                            v580,
                            Documents::closure94((), ()),
                            v668
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v707.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v707)
            }
        }
        pub fn method92(
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
                    Documents::closure93(v1_1, v61.clone(), v60, ());
                    ()
                };
                Documents::US32::US32_1(v60, v61.clone())
            } else {
                Documents::US32::US32_0(v60, v61)
            }
        }
        pub fn closure92(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method77(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method82(v5.clone()) {
                Documents::method82(v6.clone())
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
                            let _result: Vec<_> = v77
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
                            let v89: Vec<string> = _result;
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
                            let v98: string = join(Documents::method79(), toArray_1(v92));
                            let v102 = Documents::method31();
                            let v104: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v98).map_err(|x| v102(x));
                            let v105 = Documents::method80();
                            let v106 = Documents::method81();
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
                                        let _result: Vec<_> = v182
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
                                        let v194: Vec<string> = _result;
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
                                            join(Documents::method79(), toArray_1(v197));
                                        let v207 = Documents::method31();
                                        let v209: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v203).map_err(|x| v207(x));
                                        let v210 = Documents::method80();
                                        let v211 = Documents::method81();
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
                let v223: Documents::US32 = Documents::method92(v2, v5.clone(), v3, v1_1, v4);
                match &v223 {
                    Documents::US32::US32_0(v223_0_0, v223_0_1) => {
                        let v225: string = v223_0_1.clone();
                        let v224: i32 = v223_0_0.clone();
                        if v224 != 0_i32 {
                            let v231: () = {
                                Documents::closure89(v225.clone(), v224, ());
                                ()
                            };
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v225)),
                            ))
                        } else {
                            if Documents::method82(v5.clone()) {
                                Documents::method83(v6, v5.clone())
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
        pub fn closure91(
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
                move |v: string| Documents::closure92(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn closure96(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files\' = [] / listm.iter")
        }
        pub fn closure95(v0_1: string, v1_1: string, unitVar: ()) {
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
            let v23: () = {
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
            let v41: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v41,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v49: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v51: () = {
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
                let _v70: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v75: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v70 = _v70.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v70.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v88: Documents::US3 = defaultValue(Documents::US3::US3_1, _v70.get().clone());
                let v128: DateTime = match &v88 {
                    Documents::US3::US3_0(v88_0_0) => {
                        let v102: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v88 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v102.hours(),
                            v102.minutes(),
                            v102.seconds(),
                            v102.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v133: string = {
                    let provider: string = Documents::method6();
                    v128.toString(provider)
                };
                let v513: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v529: &str = inline_colorization::color_bright_green;
                let v531: &str = &*v513;
                let v533: &str = inline_colorization::color_reset;
                let v535: string = string("format!(\"{v529}{v531}{v533}\")");
                let v536: std::string::String = format!("{v529}{v531}{v533}");
                let v538: string = fable_library_rust::String_::fromString(v536);
                let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v581: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v588: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v595: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v602: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v608: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v615: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v622: () = {
                    Documents::closure11(
                        v581.clone(),
                        sprintf!("{}", string("output_cache_path")),
                        (),
                    );
                    ()
                };
                let v628: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v634: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v641: () = {
                    Documents::closure11(v581.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v642: string = v581.l0.get().clone();
                let v681: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v133,
                            v538,
                            v579,
                            Documents::closure96((), ()),
                            v642
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v681.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v681)
            }
        }
        pub fn method93(
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
                    Documents::method93(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method94(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method95(
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
                    Documents::method95(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure97(
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
        pub fn method96(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method97(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn closure32(
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
            let v76: string = (Documents::method77(string("hangul.md"), v60.clone(), v4.clone()))
                .0
                .clone();
            let v339: LrcPtr<Documents::UH4> = if contains(v58.clone(), v72.clone()) == false {
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
                            let _result: Vec<_> = v155
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
                            let v167: Vec<string> = _result;
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
                            let v176: string = join(Documents::method79(), toArray_1(v170));
                            let v180 = Documents::method31();
                            let v182: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v176).map_err(|x| v180(x));
                            let v183 = Documents::method80();
                            let v184 = Documents::method81();
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
                            let v301: Documents::US1 = if Documents::method82(v74.clone()) == false
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
                                            let _result: Vec<_> = v263
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
                                            let v275: Vec<string> = _result;
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
                                                join(Documents::method79(), toArray_1(v278));
                                            let v288 = Documents::method31();
                                            let v290: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v284)
                                                    .map_err(|x| v288(x));
                                            let v291 = Documents::method80();
                                            let v292 = Documents::method81();
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
                                    Documents::closure82(
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
                                Documents::method83(v74, v60.clone());
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
                                                        Documents::closure84(
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
                                                            Documents::closure91(
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
                                                                Documents::closure91(
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
                                                                    Documents::closure91(
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
                                                                        Documents::closure91(
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
                                                                            Documents::closure91(
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
                                                                                Documents::closure91(
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
            let v447: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method93(
                if (if let Documents::UH4::UH4_0 = v339.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v339
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method77(string("epub"), v76.clone(), v4.clone());
                    let v344: string = patternInput_3.1.clone();
                    let v343: string = patternInput_3.0.clone();
                    let v357: LrcPtr<Documents::UH5> = if if Documents::method82(v343.clone())
                        == false
                    {
                        if Documents::method82(v344.clone()) {
                            let v350: () = {
                                Documents::closure95(v344.clone(), v343.clone(), ());
                                ()
                            };
                            Documents::method83(v343, v344);
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
                                            Documents::closure91(v4.clone(), v3.clone(), true, v_7)
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
                        Documents::method77(string("pdf"), v76.clone(), v4.clone());
                    let v360: string = patternInput_4.1.clone();
                    let v359: string = patternInput_4.0.clone();
                    let v371: LrcPtr<Documents::UH5> = if if Documents::method82(v359.clone())
                        == false
                    {
                        if Documents::method82(v360.clone()) {
                            let v366: () = {
                                Documents::closure95(v360.clone(), v359.clone(), ());
                                ()
                            };
                            Documents::method83(v359, v360);
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
                                            Documents::closure91(v4.clone(), v3.clone(), true, v_8)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v357.clone(),
                        ))
                    } else {
                        v357
                    };
                    let patternInput_5: (string, string) =
                        Documents::method77(string("html"), v76.clone(), v4.clone());
                    let v374: string = patternInput_5.1.clone();
                    let v373: string = patternInput_5.0.clone();
                    let v385: LrcPtr<Documents::UH5> = if if Documents::method82(v373.clone())
                        == false
                    {
                        if Documents::method82(v374.clone()) {
                            let v380: () = {
                                Documents::closure95(v374.clone(), v373.clone(), ());
                                ()
                            };
                            Documents::method83(v373, v374);
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
                                            Documents::closure91(v4.clone(), v3.clone(), true, v_9)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v371.clone(),
                        ))
                    } else {
                        v371
                    };
                    let patternInput_6: (string, string) =
                        Documents::method77(string("epub"), v60.clone(), v4.clone());
                    let v387: string = patternInput_6.1.clone();
                    let v386: string = patternInput_6.0.clone();
                    let v398: LrcPtr<Documents::UH5> =
                        if if Documents::method82(v386.clone()) == false {
                            if Documents::method82(v387.clone()) {
                                let v393: () = {
                                    Documents::closure95(v387.clone(), v386.clone(), ());
                                    ()
                                };
                                Documents::method83(v386, v387);
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
                                                Documents::closure91(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_10,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v385.clone(),
                            ))
                        } else {
                            v385
                        };
                    let patternInput_7: (string, string) =
                        Documents::method77(string("pdf"), v60.clone(), v4.clone());
                    let v400: string = patternInput_7.1.clone();
                    let v399: string = patternInput_7.0.clone();
                    let v411: LrcPtr<Documents::UH5> =
                        if if Documents::method82(v399.clone()) == false {
                            if Documents::method82(v400.clone()) {
                                let v406: () = {
                                    Documents::closure95(v400.clone(), v399.clone(), ());
                                    ()
                                };
                                Documents::method83(v399, v400);
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
                                                Documents::closure91(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_11,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v398.clone(),
                            ))
                        } else {
                            v398
                        };
                    let patternInput_8: (string, string) =
                        Documents::method77(string("html"), v60.clone(), v4.clone());
                    let v413: string = patternInput_8.1.clone();
                    let v412: string = patternInput_8.0.clone();
                    let v424: LrcPtr<Documents::UH5> =
                        if if Documents::method82(v412.clone()) == false {
                            if Documents::method82(v413.clone()) {
                                let v419: () = {
                                    Documents::closure95(v413.clone(), v412.clone(), ());
                                    ()
                                };
                                Documents::method83(v412, v413);
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
                                                Documents::closure91(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_12,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v411.clone(),
                            ))
                        } else {
                            v411
                        };
                    let patternInput_9: (string, string) =
                        Documents::method77(string("hangul.md"), v60.clone(), v4.clone());
                    let v426: string = patternInput_9.1.clone();
                    let v425: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method82(v425.clone()) == false {
                            if Documents::method82(v426.clone()) {
                                let v432: () = {
                                    Documents::closure95(v426.clone(), v425.clone(), ());
                                    ()
                                };
                                Documents::method83(v425, v426);
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
                                                Documents::closure84(
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
                            v424,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v451: Vec<LrcPtr<Documents::UH5>> = v447.to_vec();
            let v454: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v456: Array<LrcPtr<Documents::UH5>> =
                fable_library_rust::NativeArray_::array_from(v451);
            let v457: i32 = count_2(v456.clone());
            let v458: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(v454),
            });
            while Documents::method94(v457, v458.clone()) {
                let v460: i32 = v458.l0.get().clone();
                let v461: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    v458.l1.get().clone();
                let v466 = toArray(Documents::method95(
                    v456[v460].clone(),
                    empty::<(
                        string,
                        string,
                        Func1<string, Func1<string, Documents::US30>>,
                    )>(),
                ));
                let v470 = v466.to_vec();
                let v472 = rayon::iter::IntoParallelIterator::into_par_iter(v470);
                let v475 = rayon::iter::ParallelIterator::map(v472, |x| {
                    Func1::new(
                        move |arg10_0040_8: (
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US30>>,
                        )| Documents::closure97((), arg10_0040_8),
                    )(x)
                });
                let v478: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method96(rayon::iter::ParallelIterator::collect(v475));
                let v479: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method97(v461);
                let v481: bool = true;
                let mut v479 = v479;
                let v483: bool = true;
                v479.extend(v478);
                let v485: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v479;
                let v486: i32 = v460 + 1_i32;
                v458.l0.set(v486);
                v458.l1.set(v485);
                ()
            }
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((v44, v458.l1.get().clone())))
        }
        pub fn closure99(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure98(
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
            let v22: () = {
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
            let v40: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                2_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    Documents::closure8(patternInput.0.clone(), ());
                    ()
                };
                let v50: () = {
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
                let _v69: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
                let v74: () = {
                    Documents::closure10(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v69 = _v69.clone();
                            move |v: Option<Documents::US3>| Documents::closure9(_v69.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v87: Documents::US3 = defaultValue(Documents::US3::US3_1, _v69.get().clone());
                let v127: DateTime = match &v87 {
                    Documents::US3::US3_0(v87_0_0) => {
                        let v101: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v87 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v101.hours(),
                            v101.minutes(),
                            v101.seconds(),
                            v101.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v132: string = {
                    let provider: string = Documents::method6();
                    v127.toString(provider)
                };
                let v512: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v528: &str = inline_colorization::color_bright_green;
                let v530: &str = &*v512;
                let v532: &str = inline_colorization::color_reset;
                let v534: string = string("format!(\"{v528}{v530}{v532}\")");
                let v535: std::string::String = format!("{v528}{v530}{v532}");
                let v537: string = fable_library_rust::String_::fromString(v535);
                let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v580: usize = v0_1.len();
                let v582: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v589: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v596: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v603: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v606: std::string::String = format!("{:#?}", v580);
                let v636: () = {
                    Documents::closure11(
                        v582.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v606)),
                        (),
                    );
                    ()
                };
                let v643: () = {
                    Documents::closure11(v582.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v644: string = v582.l0.get().clone();
                let v683: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v132,
                            v537,
                            v578,
                            Documents::closure99((), ()),
                            v644
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v683.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v683)
            }
        }
        pub fn method98(
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
            let v17: Documents::US1 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US1::US1_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure16(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            let v33: Documents::US1 = match &v17 {
                Documents::US1::US1_0(v17_0_0) => Documents::US1::US1_0(match &v17 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v20: string = Documents::method23();
                    let v22: Documents::US7 = Documents::method18(
                        Documents::method15(string("polyglot"), string(".devcontainer")),
                        v20,
                    );
                    match &v22 {
                        Documents::US7::US7_0(v22_0_0) => Documents::US1::US1_0(v22_0_0.clone()),
                        Documents::US7::US7_1(v22_1_0) => {
                            let v28: () = {
                                Documents::closure16(v22_1_0.clone(), ());
                                ()
                            };
                            Documents::US1::US1_1
                        }
                    }
                }
            };
            let v38: string = Documents::method15(
                match &v33 {
                    Documents::US1::US1_0(v33_0_0) => match &v33 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v39: string = Documents::method24(v3);
            let v40: string = Documents::method24(v2);
            let v41: string = Documents::method24(v1_1);
            let v44: () = {
                Documents::closure18(v0_1.clone(), v39.clone(), v40.clone(), v41.clone(), ());
                ()
            };
            let v46: bool = true;
            let __result = Box::pin(async move {
                //;
                let v48: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v40.clone());
                let v51: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v48, |x| {
                    Func1::new(move |v: async_walkdir::DirEntry| Documents::closure20((), v))(x)
                });
                let v52 = Documents::method35();
                let v54 = tokio_stream::StreamExt::filter_map(v51, |x| v52(x));
                let v56: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                    Box::pin(tokio_stream::StreamExt::collect(v54));
                let v58: Vec<string> = v56.await;
                let v61: () = {
                    Documents::closure30(v58.clone(), ());
                    ()
                };
                let v63: rayon::vec::IntoIter<string> =
                    rayon::iter::IntoParallelIterator::into_par_iter(v58);
                let v66: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                    rayon::iter::ParallelIterator::map(v63, |x| {
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            let v38 = v38.clone();
                            let v39 = v39.clone();
                            let v40 = v40.clone();
                            let v41 = v41.clone();
                            move |v_1: string| {
                                Documents::closure32(
                                    v0_1.clone(),
                                    v38.clone(),
                                    v39.clone(),
                                    v40.clone(),
                                    v41.clone(),
                                    v_1,
                                )
                            }
                        })(x)
                    });
                let v68: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                > = rayon::iter::ParallelIterator::collect(v66);
                let v71: () = {
                    Documents::closure98(v68.clone(), ());
                    ()
                };
                let v73: Result<
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
                > = Documents::method98(Ok::<
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
                >(v68));
                let v77: string = string("true; v73 });  // rust.fix_closure\'");
                let v78: bool = true;
                v73
            }); // rust.fix_closure';
            let v80 = __result;
            v80
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Documents::closure2((), ());
                ()
            };
            let v8: () = {
                Documents::closure6(v0_1, ());
                ()
            };
            let v9: clap::Command = Documents::method0();
            let v11: clap::ArgMatches = clap::Command::get_matches(v9);
            let v12: string = Documents::method10();
            let v14: &str = &*v12;
            let v16: Option<std::string::String> =
                clap::ArgMatches::get_one(&v11.clone(), v14).cloned();
            let _v17: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v22: () = {
                Documents::closure14(
                    v16,
                    Func1::new({
                        let _v17 = _v17.clone();
                        move |v: Option<Documents::US4>| Documents::closure13(_v17.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v35: Documents::US4 = defaultValue(Documents::US4::US4_1, _v17.get().clone());
            let v42: std::string::String = match &v35 {
                Documents::US4::US4_0(v35_0_0) => match &v35 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v44: string = fable_library_rust::String_::fromString(v42);
            let v45: string = Documents::method11();
            let v47: &str = &*v45;
            let v49: Option<std::string::String> =
                clap::ArgMatches::get_one(&v11.clone(), v47).cloned();
            let _v50: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v55: () = {
                Documents::closure14(
                    v49,
                    Func1::new({
                        let _v50 = _v50.clone();
                        move |v_1: Option<Documents::US4>| Documents::closure13(_v50.clone(), v_1)
                    }),
                    (),
                );
                ()
            };
            let v68: Documents::US4 = defaultValue(Documents::US4::US4_1, _v50.get().clone());
            let v75: std::string::String = match &v68 {
                Documents::US4::US4_0(v68_0_0) => match &v68 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v77: string = fable_library_rust::String_::fromString(v75);
            let v78: string = Documents::method12();
            let v80: &str = &*v78;
            let v82: Option<std::string::String> =
                clap::ArgMatches::get_one(&v11.clone(), v80).cloned();
            let _v83: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v88: () = {
                Documents::closure14(
                    v82,
                    Func1::new({
                        let _v83 = _v83.clone();
                        move |v_2: Option<Documents::US4>| Documents::closure13(_v83.clone(), v_2)
                    }),
                    (),
                );
                ()
            };
            let v101: Documents::US4 = defaultValue(Documents::US4::US4_1, _v83.get().clone());
            let v108: std::string::String = match &v101 {
                Documents::US4::US4_0(v101_0_0) => match &v101 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v110: string = fable_library_rust::String_::fromString(v108);
            let v111: string = Documents::method13();
            let v113: &str = &*v111;
            let v115: Option<std::string::String> = clap::ArgMatches::get_one(&v11, v113).cloned();
            let _v116: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v121: () = {
                Documents::closure14(
                    v115,
                    Func1::new({
                        let _v116 = _v116.clone();
                        move |v_3: Option<Documents::US4>| Documents::closure13(_v116.clone(), v_3)
                    }),
                    (),
                );
                ()
            };
            let v134: Documents::US4 = defaultValue(Documents::US4::US4_1, _v116.get().clone());
            let v141: std::string::String = match &v134 {
                Documents::US4::US4_0(v134_0_0) => match &v134 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v144: std::pin::Pin<
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
                fable_library_rust::String_::fromString(v141),
                v110,
                v77,
                v44,
            );
            let v146 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v148: Result<
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
            > = v146.handle().block_on(v144);
            let v150: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            > = v148.unwrap();
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
