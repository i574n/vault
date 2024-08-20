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
                let v558: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_green;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("args")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v662: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                    ()
                };
                let v671: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v674: string = v626.l0.get().clone();
                let v713: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure12((), ()),
                            v674
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v713.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v713)
            }
        }
        pub fn method10() -> string {
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
        pub fn closure17(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method21(v0_1)
        }
        pub fn method20() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure17((), v))
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
                let v558: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_yellow;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v659: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v668: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v671: string = v626.l0.get().clone();
                let v710: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure19((), ()),
                            v671
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v710.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v710)
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
                let v561: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v577: &str = inline_colorization::color_bright_blue;
                let v579: &str = &*v561;
                let v581: &str = inline_colorization::color_reset;
                let v583: string = string("format!(\"{v577}{v579}{v581}\")");
                let v584: std::string::String = format!("{v577}{v579}{v581}");
                let v586: string = fable_library_rust::String_::fromString(v584);
                let v627: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v629: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v636: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v645: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("source_dir")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v662: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v671: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v680: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("dist_dir")), ());
                    ()
                };
                let v688: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v696: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v704: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v713: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("cache_dir")), ());
                    ()
                };
                let v721: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v729: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v737: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v746: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("hangul_spec")), ());
                    ()
                };
                let v754: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v762: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v771: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v774: string = v629.l0.get().clone();
                let v813: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v169,
                            v586,
                            v627,
                            Documents::closure21((), ()),
                            v774
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v813.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v813)
            }
        }
        pub fn method30(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure23(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method31() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure23((), v))
        }
        pub fn closure24(unitVar: (), v0_1: std::fs::FileType) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn closure25(unitVar: (), v0_1: std::string::String) -> Documents::US8 {
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
        pub fn closure22(
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
                        Err(v12_1_0) => Documents::closure25((), v12_1_0.clone()),
                        Ok(v12_0_0) => Documents::closure24((), v12_0_0.clone()),
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
        pub fn closure27(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method36() -> Func1<async_walkdir::Error, std::string::String> {
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
                let v558: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_red;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Documents::closure11(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure31((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
            }
        }
        pub fn closure26(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method36();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US10 = match &v3 {
                Err(v3_1_0) => Documents::closure29((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure28((), v3_0_0.clone()),
            };
            let v802: Documents::US1 = match &v6 {
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
            match &v802 {
                Documents::US1::US1_0(v802_0_0) => Some(match &v802 {
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
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: usize = v0_1.len();
                let v628: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v635: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v644: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("files_len")), ());
                    ()
                };
                let v653: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v658: std::string::String = format!("{:#?}", v626);
                let v688: () = {
                    Documents::closure11(
                        v628.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v658)),
                        (),
                    );
                    ()
                };
                let v697: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v700: string = v628.l0.get().clone();
                let v739: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure33((), ()),
                            v700
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v739.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v739)
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
        pub fn method42() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure36((), v))
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
                    Documents::closure35((), arg10_0040)
                }
                fn v13(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure38((), arg10_0040_1)
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
                let v566: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v582: &str = inline_colorization::color_bright_blue;
                let v584: &str = &*v566;
                let v586: &str = inline_colorization::color_reset;
                let v588: string = string("format!(\"{v582}{v584}{v586}\")");
                let v589: std::string::String = format!("{v582}{v584}{v586}");
                let v591: string = fable_library_rust::String_::fromString(v589);
                let v632: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v634: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v641: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v650: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("file_name")), ());
                    ()
                };
                let v659: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v667: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v676: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v685: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("arguments")), ());
                    ()
                };
                let v693: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v698: std::string::String = format!("{:#?}", v8);
                let v728: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v698)),
                        (),
                    );
                    ()
                };
                let v736: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v745: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v753: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v761: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v770: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v778: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v786: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v794: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v803: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v811: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v816: std::string::String = format!("{:#?}", v1_1);
                let v846: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v816)),
                        (),
                    );
                    ()
                };
                let v854: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v863: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v871: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v882: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v890: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v899: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v907: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v912: std::string::String = format!("{:#?}", v3);
                let v942: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v912)),
                        (),
                    );
                    ()
                };
                let v950: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v959: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v967: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v972: std::string::String = format!("{:#?}", v4);
                let v1002: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v972)),
                        (),
                    );
                    ()
                };
                let v1010: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1019: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v1027: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1038: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v1046: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v1055: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v1063: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1068: std::string::String = format!("{:#?}", v6);
                let v1098: () = {
                    Documents::closure11(
                        v634.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v1068)),
                        (),
                    );
                    ()
                };
                let v1107: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1115: () = {
                    Documents::closure11(v634.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1118: string = v634.l0.get().clone();
                let v1157: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v174,
                            v591,
                            v632,
                            Documents::closure42((), ()),
                            v1118
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1157.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1157)
            }
        }
        pub fn closure43(
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
                    Documents::closure43((), v)
                },
            )
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method64() -> Func1<std::string::String, Documents::US21> {
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
                let v558: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_red;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Documents::closure11(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure46((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
            }
        }
        pub fn method65(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure47(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method66() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure47((), v))
        }
        pub fn closure48(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method67() -> Func1<std::string::String, Documents::US23> {
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
                let v558: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_red;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("e")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Documents::closure11(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure50((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
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
                    l0: MutCell::new(Documents::method9()),
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
        pub fn method68(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>
        {
            v0_1
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
        pub fn method71(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
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
                let v558: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_red;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Documents::closure11(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure61((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
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
        pub fn method75(
            v0_1: std::sync::Arc<
                std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
            >,
        ) -> std::sync::Arc<
            std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        > {
            v0_1
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
                    l0: MutCell::new(Documents::method9()),
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
                let v564: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v580: &str = inline_colorization::color_bright_blue;
                let v582: &str = &*v564;
                let v584: &str = inline_colorization::color_reset;
                let v586: string = string("format!(\"{v580}{v582}{v584}\")");
                let v587: std::string::String = format!("{v580}{v582}{v584}");
                let v589: string = fable_library_rust::String_::fromString(v587);
                let v630: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v632: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v639: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v648: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("options")), ());
                    ()
                };
                let v657: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v665: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v674: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("command")), ());
                    ()
                };
                let v682: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v690: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v699: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v708: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", string("cancellation_token")),
                        (),
                    );
                    ()
                };
                let v716: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v721: std::string::String = format!("{:#?}", v1_1);
                let v751: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v721)),
                        (),
                    );
                    ()
                };
                let v759: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v768: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", string("environment_variables")),
                        (),
                    );
                    ()
                };
                let v776: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v787: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                    ()
                };
                let v795: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v804: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("on_line")), ());
                    ()
                };
                let v812: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v817: std::string::String = format!("{:#?}", v3);
                let v847: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v817)),
                        (),
                    );
                    ()
                };
                let v855: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v864: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("stdin")), ());
                    ()
                };
                let v872: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v877: std::string::String = format!("{:#?}", v4);
                let v907: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v877)),
                        (),
                    );
                    ()
                };
                let v915: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v924: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("trace")), ());
                    ()
                };
                let v932: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v943: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", if v5 { string("true") } else { string("false") }),
                        (),
                    );
                    ()
                };
                let v951: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v960: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", string("working_directory")),
                        (),
                    );
                    ()
                };
                let v968: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v973: std::string::String = format!("{:#?}", v6);
                let v1003: () = {
                    Documents::closure11(
                        v632.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v973)),
                        (),
                    );
                    ()
                };
                let v1012: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1020: () = {
                    Documents::closure11(v632.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1023: string = v632.l0.get().clone();
                let v1062: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v172,
                            v589,
                            v630,
                            Documents::closure67((), ()),
                            v1023
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1062.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1062)
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
                    l0: MutCell::new(Documents::method9()),
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
                let v558: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_yellow;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v633: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string("ex")), ());
                    ()
                };
                let v651: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Documents::closure11(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Documents::closure11(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure78((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
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
                let v559: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_blue;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: i32 = length(v1_1);
                let v628: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
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
                    Documents::closure11(v628.clone(), sprintf!("{}", string("output_length")), ());
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
                            Documents::closure80((), ()),
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
            let _v1220: MutCell<Option<LrcPtr<(i32, string)>>> =
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
                        let v1222: std::process::Command =
                            std::process::Command::new(&*v18.clone());
                        let v1224: bool = true;
                        let mut v1222 = v1222;
                        let v1226: &mut std::process::Command =
                            std::process::Command::args(&mut v1222, &*v44.clone());
                        let v1228: std::process::Stdio = std::process::Stdio::piped();
                        let v1230: &mut std::process::Command =
                            std::process::Command::stdout(v1226, std::process::Stdio::piped());
                        let v1232: std::process::Stdio = std::process::Stdio::piped();
                        let v1234: &mut std::process::Command =
                            std::process::Command::stderr(v1230, std::process::Stdio::piped());
                        let v1236: std::process::Stdio = std::process::Stdio::piped();
                        let v1238: &mut std::process::Command =
                            std::process::Command::stdin(v1234, std::process::Stdio::piped());
                        let _v1239: LrcPtr<MutCell<Option<Documents::US1>>> =
                            refCell(None::<Documents::US1>);
                        let v1244: () = {
                            Documents::closure4(
                                v6.clone(),
                                Func1::new({
                                    let _v1239 = _v1239.clone();
                                    move |v: Option<Documents::US1>| {
                                        Documents::closure3(_v1239.clone(), v)
                                    }
                                }),
                                (),
                            );
                            ()
                        };
                        let v1259: Documents::US1 =
                            defaultValue(Documents::US1::US1_1, _v1239.get().clone());
                        let v1267: &mut std::process::Command = match &v1259 {
                            Documents::US1::US1_0(v1259_0_0) => std::process::Command::current_dir(
                                v1238,
                                &*match &v1259 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            ),
                            _ => v1238,
                        };
                        let v1285: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v1267
                        } else {
                            let v1271: Vec<(string, string)> = v2.clone().to_vec();
                            let v1273: bool = true;
                            let _result = v1271.into_iter().fold(v1267, |acc, x| {
                                //;
                                let v1275: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v1280: &mut std::process::Command = std::process::Command::env(
                                    v1275,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v1282: bool = true;
                                v1280
                            });
                            _result
                        };
                        let v1287: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v1285);
                        let v1288 = Documents::method31();
                        let v1290: Result<std::process::Child, std::string::String> =
                            v1287.map_err(|x| v1288(x));
                        let v1292: bool = true;
                        let _result = v1290.map(|x| {
                            //;
                            let v1294: std::process::Child = x;
                            let v1299: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(Some(v1294));
                            let v1301: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v1299);
                            let v1303: bool = true;
                            v1301
                        });
                        let v1305: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result;
                        let v1306 = Documents::method63();
                        let v1307 = Documents::method64();
                        let v1309: Documents::US21 = match v1305 {
                            Ok(x) => v1306(x),
                            Err(e) => v1307(e),
                        };
                        let patternInput_3: (i32, Documents::US4, Documents::US22) = match &v1309 {
                            Documents::US21::US21_0(v1309_0_0) => {
                                let v1310: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v1309_0_0.clone();
                                let v1312: bool = true;
                                let _result = (|| {
                                    // rust.capture;
                                    let v1313: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v1310.clone());
                                    let v1315: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1313.lock();
                                    let v1317: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1315.unwrap();
                                    let v1319: bool = true;
                                    let mut v1317 = v1317;
                                    let v1321: &mut Option<std::process::Child> = &mut v1317;
                                    let v1323: Option<&mut std::process::Child> = v1321.as_mut();
                                    let v1325: &mut std::process::Child = v1323.unwrap();
                                    let v1327: &mut Option<std::process::ChildStdout> =
                                        &mut v1325.stdout;
                                    let v1329: Option<std::process::ChildStdout> =
                                        Option::take(v1327);
                                    let v1331: std::process::ChildStdout = v1329.unwrap();
                                    let v1333: bool = true;
                                    v1331
                                })();
                                let v1335: std::process::ChildStdout = _result;
                                let v1337: bool = true;
                                let _result = (|| {
                                    // rust.capture;
                                    let v1338: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v1310.clone());
                                    let v1340: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1338.lock();
                                    let v1342: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1340.unwrap();
                                    let v1344: bool = true;
                                    let mut v1342 = v1342;
                                    let v1346: &mut Option<std::process::Child> = &mut v1342;
                                    let v1348: Option<&mut std::process::Child> = v1346.as_mut();
                                    let v1350: &mut std::process::Child = v1348.unwrap();
                                    let v1352: &mut Option<std::process::ChildStderr> =
                                        &mut v1350.stderr;
                                    let v1354: Option<std::process::ChildStderr> =
                                        Option::take(v1352);
                                    let v1356: std::process::ChildStderr = v1354.unwrap();
                                    let v1358: bool = true;
                                    v1356
                                })();
                                let v1360: std::process::ChildStderr = _result;
                                let v1362: bool = true;
                                let _result = (|| {
                                    // rust.capture;
                                    let v1363: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v1310.clone());
                                    let v1365: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1363.lock();
                                    let v1367: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v1365.unwrap();
                                    let v1369: bool = true;
                                    let mut v1367 = v1367;
                                    let v1371: &mut Option<std::process::Child> = &mut v1367;
                                    let v1373: Option<&mut std::process::Child> = v1371.as_mut();
                                    let v1375: &mut std::process::Child = v1373.unwrap();
                                    let v1377: &mut Option<std::process::ChildStdin> =
                                        &mut v1375.stdin;
                                    let v1379: Option<std::process::ChildStdin> =
                                        Option::take(v1377);
                                    let v1381: std::process::ChildStdin = v1379.unwrap();
                                    let v1386: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(Some(v1381));
                                    let v1388: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v1386);
                                    let v1390: bool = true;
                                    v1388
                                })();
                                let v1392: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _result;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v1394: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v1397: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1394.clone());
                                let v1399: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1397);
                                let v1401: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1394);
                                let v1403: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1401);
                                let v1405: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(patternInput_2.1.clone());
                                let v1407: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v1405);
                                let v1409: bool = true;
                                let __result = std::thread::spawn(move || {
                                    //;
                                    let v1411: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1335);
                                    let v1413: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1411);
                                    let v1415: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1413);
                                    let v1417: bool = true;
                                    let mut v1415 = v1415;
                                    let _result = v1415.try_for_each(|x| {
                                        //;
                                        let v1419: Result<std::string::String, std::io::Error> = x;
                                        let v1421: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1399.clone();
                                        let v1422 = Documents::method31();
                                        let v1424: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1419.map_err(|x| v1422(x));
                                        let v1425 = Documents::method66();
                                        let v1426 = Documents::method67();
                                        let v1428: Documents::US23 = match v1424 {
                                            Ok(x) => v1425(x),
                                            Err(e) => v1426(e),
                                        };
                                        let v2913: std::string::String = match &v1428 {
                                            Documents::US23::US23_0(v1428_0_0) => {
                                                let v1431: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1428_0_0.clone(),
                                                    );
                                                let v1433: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1435: std::borrow::Cow<[u8]> =
                                                    v1433.encode(&*v1431).0;
                                                let v1437: &[u8] = v1435.as_ref();
                                                let v1439: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1437);
                                                let v1441: &str = v1439.unwrap();
                                                let v1443: std::string::String =
                                                    String::from(v1441);
                                                let v1446: string = sprintf!(
                                                    "> {}",
                                                    fable_library_rust::String_::fromString(
                                                        v1443.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v1449: () = {
                                                        Documents::closure51(v1446.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v2141: () = {
                                                        Documents::closure14(v1446, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v1443
                                            }
                                            Documents::US23::US23_1(v1428_1_0) => {
                                                let v2143: std::string::String = v1428_1_0.clone();
                                                let v2146: () = {
                                                    Documents::closure49(v2143.clone(), ());
                                                    ()
                                                };
                                                let v2907: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v2143);
                                                let v2909: &str = &*v2907;
                                                String::from(v2909)
                                            }
                                        };
                                        let v2914: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = Documents::method68(v1421);
                                        let v2916: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v2914.lock();
                                        let v2918: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v2916.unwrap();
                                        let v2920: &std::sync::mpsc::Sender<std::string::String> =
                                            &v2918;
                                        let v2922: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v2920.send(v2913);
                                        let v2923 = Documents::method69();
                                        let v2925: Result<(), std::string::String> =
                                            v2922.map_err(|x| v2923(x));
                                        let v2927: _ = v2925;
                                        let v2929: bool = true;
                                        v2927
                                    }); //;
                                    let v2932: Result<(), string> =
                                        Documents::method70(_result.map_err(|x| x.into()));
                                    let v2936: string =
                                        string("true; v2932 });  // rust.fix_closure\'");
                                    let v2937: bool = true;
                                    v2932
                                }); // rust.fix_closure';
                                let v2939: std::thread::JoinHandle<Result<(), string>> = __result;
                                let v2941: bool = true;
                                let __result = std::thread::spawn(move || {
                                    //;
                                    let v2943: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1360);
                                    let v2945: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v2943);
                                    let v2947: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v2945);
                                    let v2949: bool = true;
                                    let mut v2947 = v2947;
                                    let _result = v2947.try_for_each(|x| {
                                        //;
                                        let v2951: Result<std::string::String, std::io::Error> = x;
                                        let v2953: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1403.clone();
                                        let v2954 = Documents::method31();
                                        let v2956: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v2951.map_err(|x| v2954(x));
                                        let v2957 = Documents::method66();
                                        let v2958 = Documents::method67();
                                        let v2960: Documents::US23 = match v2956 {
                                            Ok(x) => v2957(x),
                                            Err(e) => v2958(e),
                                        };
                                        let v4446: std::string::String = match &v2960 {
                                            Documents::US23::US23_0(v2960_0_0) => {
                                                let v2963: string =
                                                    fable_library_rust::String_::fromString(
                                                        v2960_0_0.clone(),
                                                    );
                                                let v2965: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v2967: std::borrow::Cow<[u8]> =
                                                    v2965.encode(&*v2963).0;
                                                let v2969: &[u8] = v2967.as_ref();
                                                let v2971: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v2969);
                                                let v2973: &str = v2971.unwrap();
                                                let v2975: std::string::String =
                                                    String::from(v2973);
                                                let v2978: string = sprintf!(
                                                    "! {}",
                                                    fable_library_rust::String_::fromString(
                                                        v2975.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v2981: () = {
                                                        Documents::closure51(v2978.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v3671: () = {
                                                        Documents::closure14(v2978, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v3673: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v2975
                                                    );
                                                    let v3675: &str = &*v3673;
                                                    String::from(v3675)
                                                }
                                            }
                                            Documents::US23::US23_1(v2960_1_0) => {
                                                let v3678: std::string::String = v2960_1_0.clone();
                                                let v3681: () = {
                                                    Documents::closure49(v3678.clone(), ());
                                                    ()
                                                };
                                                let v4440: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v3678);
                                                let v4442: &str = &*v4440;
                                                String::from(v4442)
                                            }
                                        };
                                        let v4447: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = Documents::method68(v2953);
                                        let v4449: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v4447.lock();
                                        let v4451: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v4449.unwrap();
                                        let v4453: &std::sync::mpsc::Sender<std::string::String> =
                                            &v4451;
                                        let v4455: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v4453.send(v4446);
                                        let v4456 = Documents::method69();
                                        let v4458: Result<(), std::string::String> =
                                            v4455.map_err(|x| v4456(x));
                                        let v4460: _ = v4458;
                                        let v4462: bool = true;
                                        v4460
                                    }); //;
                                    let v4465: Result<(), string> =
                                        Documents::method70(_result.map_err(|x| x.into()));
                                    let v4467: string =
                                        string("true; v4465 });  // rust.fix_closure\'");
                                    let v4468: bool = true;
                                    v4465
                                }); // rust.fix_closure';
                                let v4470: std::thread::JoinHandle<Result<(), string>> = __result;
                                let _v4471: LrcPtr<MutCell<Option<Documents::US24>>> =
                                    refCell(None::<Documents::US24>);
                                let v4476: () = {
                                    Documents::closure55(
                                        v4.clone(),
                                        Func1::new({
                                            let _v4471 = _v4471.clone();
                                            move |v_1: Option<Documents::US24>| {
                                                Documents::closure54(_v4471.clone(), v_1)
                                            }
                                        }),
                                        (),
                                    );
                                    ()
                                };
                                let v4491: Documents::US24 =
                                    defaultValue(Documents::US24::US24_1, _v4471.get().clone());
                                match &v4491 {
                                    Documents::US24::US24_0(v4491_0_0) => {
                                        let v4496: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = Documents::method71(v1392);
                                        let v4498: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v4496.lock();
                                        let v4500: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = v4498.unwrap();
                                        let v4502: bool = true;
                                        let mut v4500 = v4500;
                                        let v4504: &mut Option<std::process::ChildStdin> =
                                            &mut v4500;
                                        let v4506: Option<std::process::ChildStdin> =
                                            Option::take(v4504);
                                        let v4508: bool = true;
                                        let _result = v4506.map(|x| {
                                            //;
                                            let v4510: std::process::ChildStdin = x;
                                            let v4512: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v4510);
                                            let v4514: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v4512);
                                            let v4516: bool = true;
                                            v4514
                                        });
                                        let v4518: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _result;
                                        let _v4519: LrcPtr<MutCell<Option<Documents::US25>>> =
                                            refCell(None::<Documents::US25>);
                                        let v4524: () = {
                                            Documents::closure57(
                                                v4518,
                                                Func1::new({
                                                    let _v4519 = _v4519.clone();
                                                    move |v_2: Option<Documents::US25>| {
                                                        Documents::closure56(_v4519.clone(), v_2)
                                                    }
                                                }),
                                                (),
                                            );
                                            ()
                                        };
                                        let v4539: Documents::US25 = defaultValue(
                                            Documents::US25::US25_1,
                                            _v4519.get().clone(),
                                        );
                                        match &v4539 {
                                            Documents::US25::US25_0(v4539_0_0) => {
                                                let v4543: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v4539 {
                                                    Documents::US25::US25_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                (match &v4491 {
                                                    Documents::US24::US24_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v4543.clone()
                                                );
                                                {
                                                    let v4544: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = Documents::method72(v4543);
                                                    let v4546: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v4544.lock();
                                                    let v4549: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method73(v4546.unwrap());
                                                    let v4551: bool = true;
                                                    let mut v4549 = v4549;
                                                    let v4553: bool = true;
                                                    std::io::Write::flush(&mut *v4549).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v4554: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = Documents::method65(v1310);
                                    let v4556: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v4554.lock();
                                    let v4558: std::sync::MutexGuard<Option<std::process::Child>> =
                                        v4556.unwrap();
                                    let v4560: bool = true;
                                    let mut v4558 = v4558;
                                    let v4562: &mut Option<std::process::Child> = &mut v4558;
                                    let v4564: Option<std::process::Child> = Option::take(v4562);
                                    let v4566: std::process::Child = v4564.unwrap();
                                    let v4568: Result<std::process::Output, std::io::Error> =
                                        v4566.wait_with_output();
                                    let v4569 = Documents::method31();
                                    let v4571: Result<std::process::Output, std::string::String> =
                                        v4568.map_err(|x| v4569(x));
                                    let v4572: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method74(v4470);
                                    let v4575: string = string("v4572");
                                    let v4576: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method74(v2939);
                                    let v4581: string = append(
                                        append(string("vec!["), append(string("v4576, "), v4575)),
                                        string("]"),
                                    );
                                    let v4582: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v4576, v4572];
                                    let v4584: bool = true;
                                    v4582.into_iter().for_each(|x| {
                                        //;
                                        let v4586: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v4588: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v4586);
                                        let v4590: Result<(), string> = v4588.unwrap();
                                        v4590.unwrap();
                                        {
                                            let v4593: bool = true;
                                            ()
                                        }
                                    });
                                    {
                                        //;
                                        let v4596: Documents::US26 = match &v4571 {
                                            Err(v4571_1_0) => {
                                                Documents::closure59((), v4571_1_0.clone())
                                            }
                                            Ok(v4571_0_0) => {
                                                Documents::closure58((), v4571_0_0.clone())
                                            }
                                        };
                                        match &v4596 {
                                            Documents::US26::US26_0(v4596_0_0) => {
                                                let v4599: std::process::ExitStatus =
                                                    v4596_0_0.clone().status;
                                                let v4601: Option<i32> = v4599.code();
                                                let _v4602: LrcPtr<
                                                    MutCell<Option<Documents::US27>>,
                                                > = refCell(None::<Documents::US27>);
                                                let v4607: () = {
                                                    Documents::closure63(
                                                        v4601,
                                                        Func1::new({
                                                            let _v4602 = _v4602.clone();
                                                            move |v_5: Option<Documents::US27>| {
                                                                Documents::closure62(
                                                                    _v4602.clone(),
                                                                    v_5,
                                                                )
                                                            }
                                                        }),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                let v4622: Documents::US27 = defaultValue(
                                                    Documents::US27::US27_1,
                                                    _v4602.get().clone(),
                                                );
                                                match &v4622 {
                                                    Documents::US27::US27_0(v4622_0_0) => (
                                                        match &v4622 {
                                                            Documents::US27::US27_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US4::US4_1,
                                                        Documents::US22::US22_0(v1407.clone()),
                                                    ),
                                                    _ => {
                                                        let v4631:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US4::US4_0(String::from(
                                                                v4631,
                                                            )),
                                                            Documents::US22::US22_0(v1407.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US26::US26_1(v4596_1_0) => {
                                                let v4642: std::string::String = v4596_1_0.clone();
                                                let v4645: () = {
                                                    Documents::closure60(v4642.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US4::US4_0(v4642),
                                                    Documents::US22::US22_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US21::US21_1(v1309_1_0) => {
                                let v5412: std::string::String = v1309_1_0.clone();
                                let v5415: () = {
                                    Documents::closure45(v5412.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US4::US4_0(v5412),
                                    Documents::US22::US22_1,
                                )
                            }
                        };
                        let v6183: Documents::US22 = patternInput_3.2.clone();
                        let v6182: Documents::US4 = patternInput_3.1.clone();
                        let v6181: i32 = patternInput_3.0.clone();
                        let v6190: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v6183 {
                            Documents::US22::US22_0(v6183_0_0) => Some(match &v6183 {
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
                        let v6192: bool = true;
                        let _result = v6190.map(|x| {
                            //;
                            let v6195: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = Documents::method75(x);
                            let v6197: Result<
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
                            > = v6195.lock();
                            let v6199: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v6197.unwrap();
                            let v6201 = v6199.iter();
                            let v6203: Vec<std::string::String> = v6201.collect::<Vec<_>>();
                            let v6205: bool = true;
                            let _result: Vec<_> = v6203
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v6207: std::string::String = x;
                                    let v6209: string =
                                        fable_library_rust::String_::fromString(v6207);
                                    let v6211: bool = true;
                                    v6209
                                })
                                .collect::<Vec<_>>();
                            let v6213: Vec<string> = _result;
                            let v6222: string = join(
                                string("\n"),
                                toArray_1(ofArray_1(fable_library_rust::NativeArray_::array_from(
                                    v6213,
                                ))),
                            );
                            let v6226: bool = true;
                            v6222
                        });
                        let v6228: Option<string> = _result;
                        let v6235: Documents::US1 = match &v6182 {
                            Documents::US4::US4_0(v6182_0_0) => Documents::US1::US1_0(
                                fable_library_rust::String_::fromString(match &v6182 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Documents::US1::US1_1,
                        };
                        let v6240: string = defaultValue(
                            match &v6235 {
                                Documents::US1::US1_0(v6235_0_0) => match &v6235 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v6228,
                        );
                        let v6245: () = {
                            Documents::closure64(v6181, v6240.clone(), ());
                            ()
                        };
                        LrcPtr::new((v6181, v6240))
                    }
                }))();
                _v1220.set(Some(x_3))
            }
            {
                let v7015: LrcPtr<(i32, string)> = match &_v1220.get().clone() {
                    None => panic!("{}", string("base.capture / _v1220=None"),),
                    Some(_v1220_0_0) => _v1220_0_0.clone(),
                };
                let _v7: (i32, string) = (v7015.0.clone(), v7015.1.clone());
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
        pub fn closure81(unitVar: (), v0_1: string) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method80() -> Func1<string, Documents::US31> {
            Func1::new(move |v: string| Documents::closure81((), v))
        }
        pub fn closure82(unitVar: (), v0_1: std::string::String) -> Documents::US31 {
            Documents::US31::US31_1(v0_1)
        }
        pub fn method81() -> Func1<std::string::String, Documents::US31> {
            Func1::new(move |v: std::string::String| Documents::closure82((), v))
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
                let v568: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v584: &str = inline_colorization::color_bright_green;
                let v586: &str = &*v568;
                let v588: &str = inline_colorization::color_reset;
                let v590: string = string("format!(\"{v584}{v586}{v588}\")");
                let v591: std::string::String = format!("{v584}{v586}{v588}");
                let v593: string = fable_library_rust::String_::fromString(v591);
                let v634: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v636: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v643: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v652: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("file")), ());
                    ()
                };
                let v661: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v669: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v678: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v687: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("real_path")), ());
                    ()
                };
                let v695: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v703: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v711: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v720: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("relative_path")), ());
                    ()
                };
                let v728: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v736: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v744: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v753: () = {
                    Documents::closure11(
                        v636.clone(),
                        sprintf!("{}", string("origin_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v761: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v769: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v4), ());
                    ()
                };
                let v777: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v786: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("origin_hash")), ());
                    ()
                };
                let v794: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v802: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v3), ());
                    ()
                };
                let v810: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v819: () = {
                    Documents::closure11(
                        v636.clone(),
                        sprintf!("{}", string("local_git_hash_exit_code")),
                        (),
                    );
                    ()
                };
                let v827: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v835: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v7), ());
                    ()
                };
                let v843: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v852: () = {
                    Documents::closure11(
                        v636.clone(),
                        sprintf!("{}", string("local_git_hash")),
                        (),
                    );
                    ()
                };
                let v860: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v868: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v6), ());
                    ()
                };
                let v876: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v885: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("hash1")), ());
                    ()
                };
                let v893: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v901: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v9), ());
                    ()
                };
                let v909: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v918: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("hash2")), ());
                    ()
                };
                let v926: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v937: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", sprintf!("{:?}", v10)), ());
                    ()
                };
                let v945: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v954: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("dist_path")), ());
                    ()
                };
                let v962: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v970: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v5), ());
                    ()
                };
                let v978: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v987: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string("cache_path")), ());
                    ()
                };
                let v995: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v1003: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", v8), ());
                    ()
                };
                let v1012: () = {
                    Documents::closure11(v636.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v1015: string = v636.l0.get().clone();
                let v1054: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v176,
                            v593,
                            v634,
                            Documents::closure84((), ()),
                            v1015
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v1054.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v1054)
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
        pub fn closure87(
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
                let v560: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v576: &str = inline_colorization::color_bright_green;
                let v578: &str = &*v560;
                let v580: &str = inline_colorization::color_reset;
                let v582: string = string("format!(\"{v576}{v578}{v580}\")");
                let v583: std::string::String = format!("{v576}{v578}{v580}");
                let v585: string = fable_library_rust::String_::fromString(v583);
                let v626: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: i32 = length(v2);
                let v629: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v636: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v645: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v654: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v662: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v671: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v680: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v688: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v696: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v627), ());
                    ()
                };
                let v704: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v713: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v721: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v729: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v738: () = {
                    Documents::closure11(v629.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v741: string = v629.l0.get().clone();
                let v780: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v168,
                            v585,
                            v626,
                            Documents::closure89((), ()),
                            v741
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v780.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v780)
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
                                    Documents::closure87(v95.clone(), v)
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
                                    Documents::closure88(v2, v136, v166.clone(), ());
                                    ()
                                };
                                Documents::US32::US32_0(v136, v166)
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
                let v559: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_green;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v634: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("exit_code")), ());
                    ()
                };
                let v652: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v669: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v686: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v694: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v703: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v706: string = v627.l0.get().clone();
                let v745: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Documents::closure91((), ()),
                            v706
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
        pub fn closure86(
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
                                Documents::closure90(v226.clone(), v225, ());
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
                let v560: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v576: &str = inline_colorization::color_yellow;
                let v578: &str = &*v560;
                let v580: &str = inline_colorization::color_reset;
                let v582: string = string("format!(\"{v576}{v578}{v580}\")");
                let v583: std::string::String = format!("{v576}{v578}{v580}");
                let v585: string = fable_library_rust::String_::fromString(v583);
                let v626: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v628: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
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
                    Documents::closure11(v628.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v670: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v679: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v687: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v695: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v703: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v712: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v720: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v728: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v737: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v740: string = v628.l0.get().clone();
                let v779: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v168,
                            v585,
                            v626,
                            Documents::closure95((), ()),
                            v740
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v779.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v779)
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
                                Documents::closure90(v225.clone(), v224, ());
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
                let v559: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_green;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v634: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("output_path")), ());
                    ()
                };
                let v652: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", v1_1), ());
                    ()
                };
                let v669: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Documents::closure11(
                        v627.clone(),
                        sprintf!("{}", string("output_cache_path")),
                        (),
                    );
                    ()
                };
                let v686: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v694: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v703: () = {
                    Documents::closure11(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v706: string = v627.l0.get().clone();
                let v745: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Documents::closure97((), ()),
                            v706
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
            let v1406: LrcPtr<Documents::UH4> = if contains(v58.clone(), v72.clone()) == false {
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
            let v6883: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method93(
                if (if let Documents::UH4::UH4_0 = v1406.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v1406
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method77(string("epub"), v76.clone(), v4.clone());
                    let v1411: string = patternInput_3.1.clone();
                    let v1410: string = patternInput_3.0.clone();
                    let v2191: LrcPtr<Documents::UH5> = if if Documents::method82(v1410.clone())
                        == false
                    {
                        if Documents::method82(v1411.clone()) {
                            let v1417: () = {
                                Documents::closure96(v1411.clone(), v1410.clone(), ());
                                ()
                            };
                            Documents::method83(v1410, v1411);
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
                        Documents::method77(string("pdf"), v76.clone(), v4.clone());
                    let v2194: string = patternInput_4.1.clone();
                    let v2193: string = patternInput_4.0.clone();
                    let v2972: LrcPtr<Documents::UH5> = if if Documents::method82(v2193.clone())
                        == false
                    {
                        if Documents::method82(v2194.clone()) {
                            let v2200: () = {
                                Documents::closure96(v2194.clone(), v2193.clone(), ());
                                ()
                            };
                            Documents::method83(v2193, v2194);
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
                            v2191.clone(),
                        ))
                    } else {
                        v2191
                    };
                    let patternInput_5: (string, string) =
                        Documents::method77(string("html"), v76.clone(), v4.clone());
                    let v2975: string = patternInput_5.1.clone();
                    let v2974: string = patternInput_5.0.clone();
                    let v3753: LrcPtr<Documents::UH5> = if if Documents::method82(v2974.clone())
                        == false
                    {
                        if Documents::method82(v2975.clone()) {
                            let v2981: () = {
                                Documents::closure96(v2975.clone(), v2974.clone(), ());
                                ()
                            };
                            Documents::method83(v2974, v2975);
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
                            v2972.clone(),
                        ))
                    } else {
                        v2972
                    };
                    let patternInput_6: (string, string) =
                        Documents::method77(string("epub"), v60.clone(), v4.clone());
                    let v3755: string = patternInput_6.1.clone();
                    let v3754: string = patternInput_6.0.clone();
                    let v4533: LrcPtr<Documents::UH5> =
                        if if Documents::method82(v3754.clone()) == false {
                            if Documents::method82(v3755.clone()) {
                                let v3761: () = {
                                    Documents::closure96(v3755.clone(), v3754.clone(), ());
                                    ()
                                };
                                Documents::method83(v3754, v3755);
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
                                v3753.clone(),
                            ))
                        } else {
                            v3753
                        };
                    let patternInput_7: (string, string) =
                        Documents::method77(string("pdf"), v60.clone(), v4.clone());
                    let v4535: string = patternInput_7.1.clone();
                    let v4534: string = patternInput_7.0.clone();
                    let v5313: LrcPtr<Documents::UH5> =
                        if if Documents::method82(v4534.clone()) == false {
                            if Documents::method82(v4535.clone()) {
                                let v4541: () = {
                                    Documents::closure96(v4535.clone(), v4534.clone(), ());
                                    ()
                                };
                                Documents::method83(v4534, v4535);
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
                                v4533.clone(),
                            ))
                        } else {
                            v4533
                        };
                    let patternInput_8: (string, string) =
                        Documents::method77(string("html"), v60.clone(), v4.clone());
                    let v5315: string = patternInput_8.1.clone();
                    let v5314: string = patternInput_8.0.clone();
                    let v6093: LrcPtr<Documents::UH5> =
                        if if Documents::method82(v5314.clone()) == false {
                            if Documents::method82(v5315.clone()) {
                                let v5321: () = {
                                    Documents::closure96(v5315.clone(), v5314.clone(), ());
                                    ()
                                };
                                Documents::method83(v5314, v5315);
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
                                v5313.clone(),
                            ))
                        } else {
                            v5313
                        };
                    let patternInput_9: (string, string) =
                        Documents::method77(string("hangul.md"), v60.clone(), v4.clone());
                    let v6095: string = patternInput_9.1.clone();
                    let v6094: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method82(v6094.clone()) == false {
                            if Documents::method82(v6095.clone()) {
                                let v6101: () = {
                                    Documents::closure96(v6095.clone(), v6094.clone(), ());
                                    ()
                                };
                                Documents::method83(v6094, v6095);
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
                            v6093,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v6887: Vec<LrcPtr<Documents::UH5>> = v6883.to_vec();
            let v6890: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v6892: Array<LrcPtr<Documents::UH5>> =
                fable_library_rust::NativeArray_::array_from(v6887);
            let v6893: i32 = count_2(v6892.clone());
            let v6894: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(v6890),
            });
            while Documents::method94(v6893, v6894.clone()) {
                let v6896: i32 = v6894.l0.get().clone();
                let v6897: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    v6894.l1.get().clone();
                let v6902 = toArray(Documents::method95(
                    v6892[v6896].clone(),
                    empty::<(
                        string,
                        string,
                        Func1<string, Func1<string, Documents::US30>>,
                    )>(),
                ));
                let v6906 = v6902.to_vec();
                let v6908 = rayon::iter::IntoParallelIterator::into_par_iter(v6906);
                let v6911 = rayon::iter::ParallelIterator::map(v6908, |x| {
                    Func1::new(
                        move |arg10_0040_8: (
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US30>>,
                        )| Documents::closure98((), arg10_0040_8),
                    )(x)
                });
                let v6914: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method96(rayon::iter::ParallelIterator::collect(v6911));
                let v6915: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method97(v6897);
                let v6917: bool = true;
                let mut v6915 = v6915;
                let v6919: bool = true;
                v6915.extend(v6914);
                let v6921: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v6915;
                let v6922: i32 = v6896 + 1_i32;
                v6894.l0.set(v6922);
                v6894.l1.set(v6921);
                ()
            }
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((v44, v6894.l1.get().clone())))
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
                let v558: string = padLeft(toLower(string("Info")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_green;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: usize = v0_1.len();
                let v628: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(Documents::method9()),
                });
                let v635: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v644: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string("result_len")), ());
                    ()
                };
                let v653: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v658: std::string::String = format!("{:#?}", v626);
                let v688: () = {
                    Documents::closure11(
                        v628.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v658)),
                        (),
                    );
                    ()
                };
                let v697: () = {
                    Documents::closure11(v628.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v700: string = v628.l0.get().clone();
                let v739: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Documents::closure100((), ()),
                            v700
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v739.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v739)
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
            let v750: Documents::US1 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US1::US1_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure18(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            let v1499: Documents::US1 = match &v750 {
                Documents::US1::US1_0(v750_0_0) => Documents::US1::US1_0(match &v750 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v753: string = Documents::method23();
                    let v755: Documents::US7 = Documents::method18(
                        Documents::method15(string("polyglot"), string(".devcontainer")),
                        v753,
                    );
                    match &v755 {
                        Documents::US7::US7_0(v755_0_0) => Documents::US1::US1_0(v755_0_0.clone()),
                        Documents::US7::US7_1(v755_1_0) => {
                            let v761: () = {
                                Documents::closure18(v755_1_0.clone(), ());
                                ()
                            };
                            Documents::US1::US1_1
                        }
                    }
                }
            };
            let v1504: string = Documents::method15(
                match &v1499 {
                    Documents::US1::US1_0(v1499_0_0) => match &v1499 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v1505: string = Documents::method24(v3);
            let v1506: string = Documents::method24(v2);
            let v1507: string = Documents::method24(v1_1);
            let v1510: () = {
                Documents::closure20(
                    v0_1.clone(),
                    v1505.clone(),
                    v1506.clone(),
                    v1507.clone(),
                    (),
                );
                ()
            };
            let v2345: bool = true;
            let __result = Box::pin(async move {
                //;
                let v2347: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v1506.clone());
                let v2350: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v2347, |x| {
                    Func1::new(move |v: async_walkdir::DirEntry| Documents::closure22((), v))(x)
                });
                let v2351 = Documents::method35();
                let v2353 = tokio_stream::StreamExt::filter_map(v2350, |x| v2351(x));
                let v2355: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                    Box::pin(tokio_stream::StreamExt::collect(v2353));
                let v2357: Vec<string> = v2355.await;
                let v2360: () = {
                    Documents::closure32(v2357.clone(), ());
                    ()
                };
                let v3124: rayon::vec::IntoIter<string> =
                    rayon::iter::IntoParallelIterator::into_par_iter(v2357);
                let v3127: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                    rayon::iter::ParallelIterator::map(v3124, |x| {
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            let v1504 = v1504.clone();
                            let v1505 = v1505.clone();
                            let v1506 = v1506.clone();
                            let v1507 = v1507.clone();
                            move |v_1: string| {
                                Documents::closure34(
                                    v0_1.clone(),
                                    v1504.clone(),
                                    v1505.clone(),
                                    v1506.clone(),
                                    v1507.clone(),
                                    v_1,
                                )
                            }
                        })(x)
                    });
                let v3129: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                > = rayon::iter::ParallelIterator::collect(v3127);
                let v3132: () = {
                    Documents::closure99(v3129.clone(), ());
                    ()
                };
                let v3896: Result<
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
                >(v3129));
                let v3900: string = string("true; v3896 });  // rust.fix_closure\'");
                let v3901: bool = true;
                v3896
            }); // rust.fix_closure';
            let v3903 = __result;
            v3903
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
            let v755: clap::Command = Documents::method0();
            let v757: clap::ArgMatches = clap::Command::get_matches(v755);
            let v758: string = Documents::method10();
            let v760: &str = &*v758;
            let v762: Option<std::string::String> =
                clap::ArgMatches::get_one(&v757.clone(), v760).cloned();
            let _v763: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v768: () = {
                Documents::closure16(
                    v762,
                    Func1::new({
                        let _v763 = _v763.clone();
                        move |v: Option<Documents::US4>| Documents::closure15(_v763.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v783: Documents::US4 = defaultValue(Documents::US4::US4_1, _v763.get().clone());
            let v790: std::string::String = match &v783 {
                Documents::US4::US4_0(v783_0_0) => match &v783 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v792: string = fable_library_rust::String_::fromString(v790);
            let v793: string = Documents::method11();
            let v795: &str = &*v793;
            let v797: Option<std::string::String> =
                clap::ArgMatches::get_one(&v757.clone(), v795).cloned();
            let _v798: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v803: () = {
                Documents::closure16(
                    v797,
                    Func1::new({
                        let _v798 = _v798.clone();
                        move |v_1: Option<Documents::US4>| Documents::closure15(_v798.clone(), v_1)
                    }),
                    (),
                );
                ()
            };
            let v818: Documents::US4 = defaultValue(Documents::US4::US4_1, _v798.get().clone());
            let v825: std::string::String = match &v818 {
                Documents::US4::US4_0(v818_0_0) => match &v818 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v827: string = fable_library_rust::String_::fromString(v825);
            let v828: string = Documents::method12();
            let v830: &str = &*v828;
            let v832: Option<std::string::String> =
                clap::ArgMatches::get_one(&v757.clone(), v830).cloned();
            let _v833: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v838: () = {
                Documents::closure16(
                    v832,
                    Func1::new({
                        let _v833 = _v833.clone();
                        move |v_2: Option<Documents::US4>| Documents::closure15(_v833.clone(), v_2)
                    }),
                    (),
                );
                ()
            };
            let v853: Documents::US4 = defaultValue(Documents::US4::US4_1, _v833.get().clone());
            let v860: std::string::String = match &v853 {
                Documents::US4::US4_0(v853_0_0) => match &v853 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v862: string = fable_library_rust::String_::fromString(v860);
            let v863: string = Documents::method13();
            let v865: &str = &*v863;
            let v867: Option<std::string::String> = clap::ArgMatches::get_one(&v757, v865).cloned();
            let _v868: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
            let v873: () = {
                Documents::closure16(
                    v867,
                    Func1::new({
                        let _v868 = _v868.clone();
                        move |v_3: Option<Documents::US4>| Documents::closure15(_v868.clone(), v_3)
                    }),
                    (),
                );
                ()
            };
            let v888: Documents::US4 = defaultValue(Documents::US4::US4_1, _v868.get().clone());
            let v895: std::string::String = match &v888 {
                Documents::US4::US4_0(v888_0_0) => match &v888 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v898: std::pin::Pin<
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
                fable_library_rust::String_::fromString(v895),
                v862,
                v827,
                v792,
            );
            let v900 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v902: Result<
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
            > = v900.handle().block_on(v898);
            let v904: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            > = v902.unwrap();
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
