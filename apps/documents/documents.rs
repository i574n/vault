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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(Documents::US0),
            US1_1,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0,
            US8_1,
            US8_2,
        }
        impl core::fmt::Display for Documents::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::fs::FileType),
            US9_1(std::string::String),
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
            US11_0(string, Documents::US3),
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
                Documents::US3,
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
            US18_0(Documents::US3, string, LrcPtr<StringBuilder>, i32, i32),
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
            let v2: bool = true;
            () //;
        } /* /*;
          {
              let v5: string = string("*/ #[test] fn verify_app() { //");
              let v6: bool = */
        #[test]
        fn verify_app() {
            //;
            let v7: clap::Command = Documents::method0();
            clap::Command::debug_assert(v7);
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
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v7: bool = true;
            let _result = v5.map(|x| {
                //;
                let v9: std::string::String = x;
                let v11: string = fable_library_rust::String_::fromString(v9);
                let v13: bool = true;
                v11
            });
            let v15: Result<string, std::env::VarError> = _result;
            let v16: string = Documents::method3();
            {
                let x: string = v15.unwrap_or(v16);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
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
            LrcPtr<Documents::Mut3>,
            Option<i64>,
        ) {
            let _v3: MutCell<Option<(Documents::US1, Documents::US2)>> =
                MutCell::new(None::<(Documents::US1, Documents::US2)>);
            let v5: string = Documents::method2(Documents::method1());
            let v11: Documents::US1 = if string("Verbose") == v5.clone() {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            {
                let x: (Documents::US1, Documents::US2) = (
                    match &v11 {
                        Documents::US1::US1_0(v11_0_0) => Documents::US1::US1_0(match &v11 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v19: Documents::US1 = if string("Debug") == v5.clone() {
                                Documents::US1::US1_0(Documents::US0::US0_1)
                            } else {
                                Documents::US1::US1_1
                            };
                            match &v19 {
                                Documents::US1::US1_0(v19_0_0) => {
                                    Documents::US1::US1_0(match &v19 {
                                        Documents::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v27: Documents::US1 = if string("Info") == v5.clone() {
                                        Documents::US1::US1_0(Documents::US0::US0_2)
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                    match &v27 {
                                        Documents::US1::US1_0(v27_0_0) => {
                                            Documents::US1::US1_0(match &v27 {
                                                Documents::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v35: Documents::US1 =
                                                if string("Warning") == v5.clone() {
                                                    Documents::US1::US1_0(Documents::US0::US0_3)
                                                } else {
                                                    Documents::US1::US1_1
                                                };
                                            match &v35 {
                                                Documents::US1::US1_0(v35_0_0) => {
                                                    Documents::US1::US1_0(match &v35 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v43: Documents::US1 = if string("Critical")
                                                        == v5.clone()
                                                    {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                    match &v43 {
                                                        Documents::US1::US1_0(v43_0_0) => {
                                                            Documents::US1::US1_0(match &v43 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Documents::US1::US1_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    if Documents::method2(Documents::method4()) == string("True") {
                        Documents::US2::US2_0({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        })
                    } else {
                        Documents::US2::US2_1
                    },
                );
                _v3.set(Some(x))
            }
            {
                let patternInput: (Documents::US1, Documents::US2) = match &_v3.get().clone() {
                    None => panic!("{}", string("base.run_target / _v3=None"),),
                    Some(_v3_0_0) => _v3_0_0.clone(),
                };
                let v402: Documents::US2 = patternInput.1.clone();
                let v401: Documents::US1 = patternInput.0.clone();
                (
                    LrcPtr::new(Documents::Mut0 {
                        l0: MutCell::new(0_i64),
                    }),
                    LrcPtr::new(Documents::Mut1 {
                        l0: MutCell::new(Func1::new(move |v: string| Documents::closure3((), v))),
                    }),
                    LrcPtr::new(Documents::Mut2 {
                        l0: MutCell::new(true),
                    }),
                    LrcPtr::new(Documents::Mut3 {
                        l0: MutCell::new(match &v401 {
                            Documents::US1::US1_0(v401_0_0) => match &v401 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v0_1,
                        }),
                    }),
                    match &v402 {
                        Documents::US2::US2_0(v402_0_0) => Some(match &v402 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    },
                )
            }
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("documents.main")
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) -> Array<string> {
            v0_1
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
        pub fn method10(v0_1: LrcPtr<Documents::Mut4>, v1_1: string) {
            let v4: string = sprintf!("{}", v1_1);
            let v12: string = append(v0_1.l0.get().clone(), v4);
            v0_1.l0.set(v12);
            ()
        }
        pub fn method11(v0_1: LrcPtr<Documents::Mut4>) {
            ();
        }
        pub fn method12(v0_1: LrcPtr<Documents::Mut4>, v1_1: Array<string>) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method9(v0_1: LrcPtr<Documents::Mut4>, v1_1: Array<string>) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("args"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method12(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure6(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<Array<string>>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method9(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method13(v0_1: Documents::US0, v1_1: Func0<string>) {
            fn v4(
                v: Documents::US0,
            ) -> (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                Option<i64>,
            ) {
                Documents::closure2((), v)
            }
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state().set(Some(v4(Documents::US0::US0_0)));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v13: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                if Documents::State::trace_state().get().clone().is_none() {
                    Documents::State::trace_state().set(Some(v4(Documents::US0::US0_0)));
                }
                {
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
                        let v69: i64 = v13.l0.get().clone() + 1_i64;
                        v13.l0.set(v69);
                        {
                            let v72: string = sprintf!("{}", v1_1());
                            let _v81: MutCell<Option<()>> = MutCell::new(None::<()>);
                            println!("{}", v72.clone());
                            _v81.set(Some(()));
                            match &_v81.get().clone() {
                                None => panic!("{}", string("base.run_target / _v81=None"),),
                                Some(_v81_0_0) => _v81_0_0.clone(),
                            }
                            ((patternInput.1.clone()).l0.get().clone())(v72)
                        }
                    }
                }
            }
        }
        pub fn method5(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<Array<string>>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure6(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method14() -> string {
            string("source-dir")
        }
        pub fn method15() -> string {
            string("dist-dir")
        }
        pub fn method16() -> string {
            string("cache-dir")
        }
        pub fn method17() -> string {
            string("hangul-spec")
        }
        pub fn method21(v0_1: string) -> string {
            v0_1
        }
        pub fn method20(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Documents::method21(v0_1))
        }
        pub fn method19(v0_1: string, v1_1: string) -> string {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v6: &str = &*v0_1;
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v12: &str = &*v1_1;
            let v14: std::string::String = String::from(v12);
            let v16: std::path::PathBuf = v10.join(v14);
            let v18: std::path::Display = v16.display();
            let _v21: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v18);
                _v21.set(Some(x))
            }
            {
                let v55: std::string::String = match &_v21.get().clone() {
                    None => panic!("{}", string("base.run_target / _v21=None"),),
                    Some(_v21_0_0) => _v21_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v55);
                    _v4.set(Some(x_2))
                }
                match &_v4.get().clone() {
                    None => panic!("{}", string("base.run_target / _v4=None"),),
                    Some(_v4_0_0) => _v4_0_0.clone(),
                }
            }
        }
        pub fn method23(v0_1: string) -> bool {
            let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v5: &str = &*v0_1;
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            {
                let x: bool = if v9.clone().exists() {
                    true
                } else {
                    if v9.clone().is_dir() {
                        true
                    } else {
                        v9.is_symlink()
                    }
                };
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method25(v0_1: string) -> Option<string> {
            let _v3: MutCell<Option<Documents::US3>> = MutCell::new(None::<Documents::US3>);
            let v5: &str = &*v0_1;
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v11: Option<std::path::PathBuf> = v9.parent().map(std::path::PathBuf::from);
            let v13: std::path::PathBuf = v11?;
            let v15: std::path::Display = v13.display();
            let _v18: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v15);
                _v18.set(Some(x))
            }
            {
                let v52: std::string::String = match &_v18.get().clone() {
                    None => panic!("{}", string("base.run_target / _v18=None"),),
                    Some(_v18_0_0) => _v18_0_0.clone(),
                };
                {
                    let x_2: Documents::US3 =
                        Documents::US3::US3_0(fable_library_rust::String_::fromString(v52));
                    _v3.set(Some(x_2))
                }
                {
                    let v189: Documents::US3 = match &_v3.get().clone() {
                        None => panic!("{}", string("base.run_target / _v3=None"),),
                        Some(_v3_0_0) => _v3_0_0.clone(),
                    };
                    match &v189 {
                        Documents::US3::US3_0(v189_0_0) => Some(match &v189 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<string>,
                    }
                }
            }
        }
        pub fn closure7(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method25(v0_1)
        }
        pub fn method24() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure7((), v))
        }
        pub fn method26(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method26: loop {
                break '_method26 (if Documents::method23(Documents::method19(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Documents::method24())(v2.get().clone());
                    let _v10: LrcPtr<MutCell<Option<Documents::US3>>> =
                        refCell(None::<Documents::US3>);
                    {
                        let x_2: Option<Documents::US3> = match &v7 {
                            None => None::<Documents::US3>,
                            Some(v7_0_0) => {
                                let x: string = v7_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Documents::US3::US3_0(x.clone())
                                }))())
                            }
                        };
                        _v10.set(x_2)
                    }
                    {
                        let v37: Documents::US3 =
                            defaultValue(Documents::US3::US3_1, _v10.get().clone());
                        match &v37 {
                            Documents::US3::US3_0(v37_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: string = match &v37 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method26;
                            }
                            _ => Documents::US7::US7_1(sprintf!(
                                "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                string("dir"),
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2.get().clone()
                            )),
                        }
                    }
                });
            }
        }
        pub fn method22(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method23(Documents::method19(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Documents::method24())(v1_1.clone());
                let _v9: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
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
                    _v9.set(x_2)
                }
                {
                    let v36: Documents::US3 =
                        defaultValue(Documents::US3::US3_1, _v9.get().clone());
                    match &v36 {
                        Documents::US3::US3_0(v36_0_0) => Documents::method26(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v36 {
                                Documents::US3::US3_0(x) => x.clone(),
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
        }
        pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.get_workspace_root")
        }
        pub fn closure9(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn method28(v0_1: LrcPtr<Documents::Mut4>, v1_1: string) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("error"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure10(
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method28(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method27(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure10(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method29() -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v6: std::path::PathBuf = v4.unwrap();
            let v8: std::path::Display = v6.display();
            let _v11: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v8);
                _v11.set(Some(x))
            }
            {
                let v45: std::string::String = match &_v11.get().clone() {
                    None => panic!("{}", string("base.run_target / _v11=None"),),
                    Some(_v11_0_0) => _v11_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v45);
                    _v2.set(Some(x_2))
                }
                match &_v2.get().clone() {
                    None => panic!("{}", string("base.run_target / _v2=None"),),
                    Some(_v2_0_0) => _v2_0_0.clone(),
                }
            }
        }
        pub fn method31(v0_1: string) -> string {
            v0_1
        }
        pub fn method33() -> string {
            string("")
        }
        pub fn method34(v0_1: string) -> string {
            v0_1
        }
        pub fn method35() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method32(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v4: string = Documents::method33();
                let _v7: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v8: string = Documents::method34(v0_1);
                let v11: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v13: regex::Regex = v11.unwrap();
                let v15: std::borrow::Cow<str> = v13.replace_all(&v8, &*v4);
                let v17: std::string::String = String::from(v15);
                {
                    let x: string = fable_library_rust::String_::fromString(v17);
                    _v7.set(Some(x))
                }
                {
                    let v58: string = match &_v7.get().clone() {
                        None => panic!("{}", string("base.run_target / _v7=None"),),
                        Some(_v7_0_0) => _v7_0_0.clone(),
                    };
                    replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v58.clone(), 0_i32))),
                            getSlice(v58, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method36(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method37(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method38() -> char {
            let _v2: MutCell<Option<char>> = MutCell::new(None::<char>);
            {
                let x: char = std::path::MAIN_SEPARATOR;
                _v2.set(Some(x))
            }
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
        }
        pub fn method39(v0_1: string) -> string {
            v0_1
        }
        pub fn method30(v0_1: string) -> string {
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Documents::method31(v0_1);
            let v6: &str = &*v4.clone();
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            {
                let x_2: string = if v10.exists() == false {
                    let v14: string = Documents::method29();
                    let v18: Array<string> = split(
                        Documents::method32(Documents::method19(v14.clone(), v4.clone())),
                        string("/"),
                        -1_i32,
                        0_i32,
                    );
                    let v20: i32 = count_2(v18.clone());
                    let v21: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(0_i32),
                        l2: MutCell::new(new_empty::<string>()),
                    });
                    while Documents::method36(v20, v21.clone()) {
                        let v23: i32 = v21.l0.get().clone();
                        let v26: i32 = v23.wrapping_neg() + v20 - 1_i32;
                        let matchValue: i32 = v21.l1.get().clone();
                        let v28: Array<string> = v21.l2.get().clone();
                        let v27: i32 = matchValue;
                        let v29: string = v18[v26].clone();
                        let patternInput_1: (i32, Array<string>) = if string("..") == v29.clone() {
                            (v27 + 1_i32, v28.clone())
                        } else {
                            if string(".") == v29.clone() {
                                (v27, v28.clone())
                            } else {
                                if 0_i32 == v27 {
                                    if endsWith(v29.clone(), string(":"), false) {
                                        let v37: Array<string> = new_array(&[sprintf!(
                                            "{}:",
                                            getCharAt(v14.clone(), 0_i32)
                                        )]);
                                        let v38: i32 = count_2(v37.clone());
                                        let v40: i32 = v38 + count_2(v28.clone());
                                        let v41: Array<string> = new_init(&string(""), v40);
                                        let v42: LrcPtr<Documents::Mut6> =
                                            LrcPtr::new(Documents::Mut6 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method37(v40, v42.clone()) {
                                            let v44: i32 = v42.l0.get().clone();
                                            let v49: string = if v44 < v38 {
                                                v37[v44].clone()
                                            } else {
                                                let v47: i32 = v44 - v38;
                                                v28[v47].clone()
                                            };
                                            v41.get_mut()[v44 as usize] = v49;
                                            {
                                                let v50: i32 = v44 + 1_i32;
                                                v42.l0.set(v50);
                                                ()
                                            }
                                        }
                                        (0_i32, v41.clone())
                                    } else {
                                        let v51: Array<string> = new_array(&[v29]);
                                        let v52: i32 = count_2(v51.clone());
                                        let v54: i32 = v52 + count_2(v28.clone());
                                        let v55: Array<string> = new_init(&string(""), v54);
                                        let v56: LrcPtr<Documents::Mut6> =
                                            LrcPtr::new(Documents::Mut6 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method37(v54, v56.clone()) {
                                            let v58: i32 = v56.l0.get().clone();
                                            let v63: string = if v58 < v52 {
                                                v51[v58].clone()
                                            } else {
                                                let v61: i32 = v58 - v52;
                                                v28[v61].clone()
                                            };
                                            v55.get_mut()[v58 as usize] = v63;
                                            {
                                                let v64: i32 = v58 + 1_i32;
                                                v56.l0.set(v64);
                                                ()
                                            }
                                        }
                                        (0_i32, v55.clone())
                                    }
                                } else {
                                    (v27 - 1_i32, v28.clone())
                                }
                            }
                        };
                        let v74: i32 = v23 + 1_i32;
                        v21.l0.set(v74);
                        v21.l1.set(patternInput_1.0.clone());
                        v21.l2.set(patternInput_1.1.clone());
                        ()
                    }
                    {
                        let matchValue_2: i32 = v21.l1.get().clone();
                        let v76: Array<string> = v21.l2.get().clone();
                        let v79: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v76 = v76.clone();
                            move || {
                                map(
                                    Func1::new({
                                        let v76 = v76.clone();
                                        move |i: i32| v76[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v76.clone()) - 1_i32),
                                )
                            }
                        }));
                        join(ofChar(Documents::method38()), toArray_1(v79))
                    }
                } else {
                    let v109: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v4);
                    let v111: std::path::PathBuf = v109.unwrap();
                    let v113: std::path::Display = v111.display();
                    let _v116: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v113);
                        _v116.set(Some(x))
                    }
                    {
                        let v150: std::string::String = match &_v116.get().clone() {
                            None => panic!("{}", string("base.run_target / _v116=None"),),
                            Some(_v116_0_0) => _v116_0_0.clone(),
                        };
                        fable_library_rust::String_::fromString(v150)
                    }
                };
                _v3.set(Some(x_2))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure12(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            unitVar: (),
        ) -> (string, string, string, string) {
            (v1_1, v2, v3, v0_1)
        }
        pub fn method41(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("source_dir"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("dist_dir"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v2);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("cache_dir"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v3);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("hangul_spec"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v4);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure13(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(string, string, string, string)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (string, string, string, string) = v2();
                            let v1220: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method41(
                                v1220.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            );
                            {
                                let v1221: string = v1220.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1221
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method40(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(string, string, string, string)>,
        ) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure13(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method44(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure15(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method45() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: std::fs::FileType) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US9 {
            Documents::US9::US9_1(v0_1)
        }
        pub fn method46(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method47(v0_1: Documents::US8) -> Documents::US8 {
            v0_1
        }
        pub fn method43(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US8> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method44(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method45();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US9 = match &v9 {
                        Err(v9_1_0) => Documents::closure17((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure16((), v9_0_0.clone()),
                    };
                    let v152: Documents::US8 =
                        Documents::method47(if let Documents::US9::US9_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method46(match &v12 {
                                Documents::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) {
                                Documents::US8::US8_0
                            } else {
                                let v19: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v21: std::path::Display = v19.display();
                                let _v24: MutCell<Option<std::string::String>> =
                                    MutCell::new(None::<std::string::String>);
                                {
                                    let x_2: std::string::String = format!("{}", v21);
                                    _v24.set(Some(x_2))
                                }
                                {
                                    let v58: std::string::String = match &_v24.get().clone() {
                                        None => {
                                            panic!("{}", string("base.run_target / _v24=None"),)
                                        }
                                        Some(_v24_0_0) => _v24_0_0.clone(),
                                    };
                                    let v74: string = fable_library_rust::String_::fromString(v58);
                                    if if endsWith(v74.clone(), string(".md"), false) == false {
                                        true
                                    } else {
                                        endsWith(v74, string(".hangul.md"), false)
                                    } {
                                        Documents::US8::US8_0
                                    } else {
                                        Documents::US8::US8_2
                                    }
                                }
                            }
                        } else {
                            let v86: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v88: std::path::Display = v86.display();
                            let _v91: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_4: std::string::String = format!("{}", v88);
                                _v91.set(Some(x_4))
                            }
                            {
                                let v125: std::string::String = match &_v91.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v91=None"),),
                                    Some(_v91_0_0) => _v91_0_0.clone(),
                                };
                                let v141: string = fable_library_rust::String_::fromString(v125);
                                if if endsWith(v141.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v141, string(".hangul.md"), false)
                                } {
                                    Documents::US8::US8_0
                                } else {
                                    Documents::US8::US8_2
                                }
                            }
                        });
                    let v159: string = string("v152 }}); { // rust.fix_closure\'");
                    v152
                }
            });
            {
                // rust.fix_closure';
                __result
            }
        }
        pub fn method48(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method42(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US8> + Send>,
                    > = Documents::method43(v0_1);
                    let v4: Documents::US8 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method48(match &v4 {
                        Documents::US8::US8_0 => async_walkdir::Filtering::Ignore,
                        Documents::US8::US8_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    });
                    let v21: string = string("v14 }}); { // rust.fix_closure\'");
                    v14
                }
            });
            {
                // rust.fix_closure';
                __result
            }
        }
        pub fn closure14(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Documents::method42(v0_1)
        }
        pub fn closure19(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method50() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure19((), v))
        }
        pub fn closure20(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn closure21(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / stream_filter_map")
        }
        pub fn closure23(v0_1: std::string::String, unitVar: ()) -> std::string::String {
            v0_1
        }
        pub fn method53(v0_1: LrcPtr<Documents::Mut4>, v1_1: std::string::String) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method52(v0_1: LrcPtr<Documents::Mut4>, v1_1: std::string::String) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("error"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method53(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure24(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<std::string::String>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method52(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method51(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<std::string::String>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure24(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure18(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method50();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US10 = match &v3 {
                Err(v3_1_0) => Documents::closure21((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure20((), v3_0_0.clone()),
            };
            let v72: Documents::US3 = match &v6 {
                Documents::US10::US10_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let _v14: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_2: std::string::String = format!("{}", v11);
                        _v14.set(Some(x_2))
                    }
                    {
                        let v48: std::string::String = match &_v14.get().clone() {
                            None => panic!("{}", string("base.run_target / _v14=None"),),
                            Some(_v14_0_0) => _v14_0_0.clone(),
                        };
                        Documents::US3::US3_0(fable_library_rust::String_::fromString(v48))
                    }
                }
                Documents::US10::US10_1(v6_1_0) => {
                    Documents::method51(
                        Documents::US0::US0_4,
                        Func0::new(move || Documents::closure22((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Documents::closure23(
                                    match &v6 {
                                        Documents::US10::US10_1(x) => x.clone(),
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
            match &v72 {
                Documents::US3::US3_0(v72_0_0) => Some(match &v72 {
                    Documents::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method49(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure18((), v)
                },
            )
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure26(v0_1: Vec<string>, unitVar: ()) -> usize {
            v0_1.len()
        }
        pub fn method56(v0_1: LrcPtr<Documents::Mut4>, v1_1: usize) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method55(v0_1: LrcPtr<Documents::Mut4>, v1_1: usize) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("files_len"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method56(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure27(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<usize>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method55(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method54(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<usize>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure27(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method57(v0_1: string) -> string {
            Documents::method32(Documents::method30(v0_1))
        }
        pub fn method59(
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
        pub fn closure31(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure30(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure31(v0_1, v)
            })
        }
        pub fn method61() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure30((), v))
        }
        pub fn method62(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method62: loop {
                break '_method62 (match v0_1.get().clone().as_ref() {
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
                                let v24: LrcPtr<StringBuilder> = {
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
                            continue '_method62;
                        }
                    }
                });
            }
        }
        pub fn closure29(
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
                    let v19: string = ofChar(v7);
                    let v26: i32 = length(v19.clone());
                    let v27: Array<char> = new_init(&'\u{0000}', v26);
                    let v28: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method37(v26, v28.clone()) {
                        let v30: i32 = v28.l0.get().clone();
                        let v31: char = getCharAt(v19.clone(), v30);
                        v27.get_mut()[v30 as usize] = v31;
                        {
                            let v32: i32 = v30 + 1_i32;
                            v28.l0.set(v32);
                            ()
                        }
                    }
                    {
                        let v33: List<char> = ofArray(v27.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method62(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method61())(b0)(b1)
                                }),
                                v33,
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
                    let v55: i32 = length(v0_1.clone());
                    let v58: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v58 { v55 } else { v58 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn closure32(
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
                    let v19: string = ofChar(v7);
                    let v26: i32 = length(v19.clone());
                    let v27: Array<char> = new_init(&'\u{0000}', v26);
                    let v28: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method37(v26, v28.clone()) {
                        let v30: i32 = v28.l0.get().clone();
                        let v31: char = getCharAt(v19.clone(), v30);
                        v27.get_mut()[v30 as usize] = v31;
                        {
                            let v32: i32 = v30 + 1_i32;
                            v28.l0.set(v32);
                            ()
                        }
                    }
                    {
                        let v33: List<char> = ofArray(v27.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method62(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method61())(b0)(b1)
                                }),
                                v33,
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
                    let v55: i32 = length(v0_1.clone());
                    let v58: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v58 { v55 } else { v58 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method63(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method63: loop {
                break '_method63 (match v2.get().clone().as_ref() {
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
                                continue '_method63;
                            }
                        }
                    }
                });
            }
        }
        pub fn method64(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method64: loop {
                break '_method64 (if v1_1.get().clone() >= 2_i64 {
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
                        continue '_method64;
                    }
                });
            }
        }
        pub fn method65(
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
            '_method65: loop {
                break '_method65 ({
                    let v118: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v37: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v44: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method64(v37, 0_i64) == false {
                            let v51: string = ofChar(v37);
                            let v58: i32 = length(v51.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v51.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = v62 + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method62(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method61())(b0)(b1)
                                                },
                                            ),
                                            v65,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
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
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v37,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v130: Documents::US12 = match &v118 {
                        Documents::US12::US12_0(
                            v118_0_0,
                            v118_0_1,
                            v118_0_2,
                            v118_0_3,
                            v118_0_4,
                        ) => {
                            let v119: char = v118_0_0.clone();
                            Documents::US12::US12_0(
                                if '\\' == v119 { '/' } else { v119 },
                                v118_0_1.clone(),
                                v118_0_2.clone(),
                                v118_0_3.clone(),
                                v118_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v118_1_0) => {
                            Documents::US12::US12_1(v118_1_0.clone())
                        }
                    };
                    match &v130 {
                        Documents::US12::US12_0(
                            v130_0_0,
                            v130_0_1,
                            v130_0_2,
                            v130_0_3,
                            v130_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v130_0_0.clone()));
                            let v1_1_temp: string = v130_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v130_0_2.clone();
                            let v3_temp: i32 = v130_0_3.clone();
                            let v4_temp: i32 = v130_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method65;
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
        pub fn method66(
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
            '_method66: loop {
                break '_method66 (match v4.get().clone().as_ref() {
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
                                continue '_method66;
                            }
                        }
                    }
                });
            }
        }
        pub fn method67(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method67: loop {
                break '_method67 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method67;
                    }
                });
            }
        }
        pub fn method68(
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
            '_method68: loop {
                break '_method68 ({
                    let v136: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v46: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v53: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method67(v46, 0_i64) == false {
                            let v60: string = ofChar(v46);
                            let v67: i32 = length(v60.clone());
                            let v68: Array<char> = new_init(&'\u{0000}', v67);
                            let v69: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v67, v69.clone()) {
                                let v71: i32 = v69.l0.get().clone();
                                let v72: char = getCharAt(v60.clone(), v71);
                                v68.get_mut()[v71 as usize] = v72;
                                {
                                    let v73: i32 = v71 + 1_i32;
                                    v69.l0.set(v73);
                                    ()
                                }
                            }
                            {
                                let v74: List<char> = ofArray(v68.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method62(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method61())(b0)(b1)
                                                },
                                            ),
                                            v74,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v46,
                                    v53,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v46,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v148: Documents::US12 = match &v136 {
                        Documents::US12::US12_0(
                            v136_0_0,
                            v136_0_1,
                            v136_0_2,
                            v136_0_3,
                            v136_0_4,
                        ) => {
                            let v137: char = v136_0_0.clone();
                            Documents::US12::US12_0(
                                if '\\' == v137 { '/' } else { v137 },
                                v136_0_1.clone(),
                                v136_0_2.clone(),
                                v136_0_3.clone(),
                                v136_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v136_1_0) => {
                            Documents::US12::US12_1(v136_1_0.clone())
                        }
                    };
                    match &v148 {
                        Documents::US12::US12_0(
                            v148_0_0,
                            v148_0_1,
                            v148_0_2,
                            v148_0_3,
                            v148_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v148_0_0.clone()));
                            let v1_1_temp: string = v148_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v148_0_2.clone();
                            let v3_temp: i32 = v148_0_3.clone();
                            let v4_temp: i32 = v148_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method68;
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
        pub fn method69(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method69: loop {
                break '_method69 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method69;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method70(
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
            '_method70: loop {
                break '_method70 ({
                    let v54: Documents::US12 = if string("") == v1_1.get().clone() {
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
                        let v19: string = ofChar(v8);
                        let v26: i32 = length(v19.clone());
                        let v27: Array<char> = new_init(&'\u{0000}', v26);
                        let v28: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method37(v26, v28.clone()) {
                            let v30: i32 = v28.l0.get().clone();
                            let v31: char = getCharAt(v19.clone(), v30);
                            v27.get_mut()[v30 as usize] = v31;
                            {
                                let v32: i32 = v30 + 1_i32;
                                v28.l0.set(v32);
                                ()
                            }
                        }
                        {
                            let v33: List<char> = ofArray(v27.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method62(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method61())(b0)(b1)
                                        }),
                                        v33,
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
                    match &v54 {
                        Documents::US12::US12_0(v54_0_0, v54_0_1, v54_0_2, v54_0_3, v54_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v54_0_0.clone()));
                            let v1_1_temp: string = v54_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v54_0_2.clone();
                            let v3_temp: i32 = v54_0_3.clone();
                            let v4_temp: i32 = v54_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method70;
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
        pub fn method60(v0_1: string) -> Documents::US11 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v15: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v23: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
                fn v24(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure29((), arg10_0040)
                }
                fn v25(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure32((), arg10_0040_1)
                }
                let v29: Documents::US12 = Documents::method63(
                    v15.clone(),
                    v23.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v24),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v25),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v219: Documents::US13 = match &v29 {
                    Documents::US12::US12_0(v29_0_0, v29_0_1, v29_0_2, v29_0_3, v29_0_4) => {
                        let v34: i32 = v29_0_4.clone();
                        let v33: i32 = v29_0_3.clone();
                        let v32: LrcPtr<StringBuilder> = v29_0_2.clone();
                        let v31: string = v29_0_1.clone();
                        let v148: Documents::US12 = if string("") == v31.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v32.clone(), v33, v34)
                            ))
                        } else {
                            let v67: char = getCharAt(v31.clone(), 0_i32);
                            let v74: string =
                                getSlice(v31.clone(), Some(1_i32), Some(length(v31.clone())));
                            if Documents::method64(v67, 0_i64) == false {
                                let v81: string = ofChar(v67);
                                let v88: i32 = length(v81.clone());
                                let v89: Array<char> = new_init(&'\u{0000}', v88);
                                let v90: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method37(v88, v90.clone()) {
                                    let v92: i32 = v90.l0.get().clone();
                                    let v93: char = getCharAt(v81.clone(), v92);
                                    v89.get_mut()[v92 as usize] = v93;
                                    {
                                        let v94: i32 = v92 + 1_i32;
                                        v90.l0.set(v94);
                                        ()
                                    }
                                }
                                {
                                    let v95: List<char> = ofArray(v89.clone());
                                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method62(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method61())(b0)(b1)
                                                    },
                                                ),
                                                v95,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v32.clone(),
                                            v33,
                                            v34,
                                        );
                                    Documents::US12::US12_0(
                                        v67,
                                        v74,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US12::US12_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v67,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v32.clone(),
                                                                          v33,
                                                                          v34)))
                            }
                        };
                        let v160: Documents::US12 = match &v148 {
                            Documents::US12::US12_0(
                                v148_0_0,
                                v148_0_1,
                                v148_0_2,
                                v148_0_3,
                                v148_0_4,
                            ) => {
                                let v149: char = v148_0_0.clone();
                                Documents::US12::US12_0(
                                    if '\\' == v149 { '/' } else { v149 },
                                    v148_0_1.clone(),
                                    v148_0_2.clone(),
                                    v148_0_3.clone(),
                                    v148_0_4.clone(),
                                )
                            }
                            Documents::US12::US12_1(v148_1_0) => {
                                Documents::US12::US12_1(v148_1_0.clone())
                            }
                        };
                        let v180: Documents::US13 = match &v160 {
                            Documents::US12::US12_0(
                                v160_0_0,
                                v160_0_1,
                                v160_0_2,
                                v160_0_3,
                                v160_0_4,
                            ) => Documents::method65(
                                ofChar(v160_0_0.clone()),
                                v160_0_1.clone(),
                                v160_0_2.clone(),
                                v160_0_3.clone(),
                                v160_0_4.clone(),
                            ),
                            Documents::US12::US12_1(v160_1_0) => {
                                Documents::US13::US13_1(v160_1_0.clone())
                            }
                        };
                        let v190: Documents::US13 = match &v180 {
                            Documents::US13::US13_0(
                                v180_0_0,
                                v180_0_1,
                                v180_0_2,
                                v180_0_3,
                                v180_0_4,
                            ) => Documents::US13::US13_0(
                                v180_0_0.clone(),
                                v180_0_1.clone(),
                                v180_0_2.clone(),
                                v180_0_3.clone(),
                                v180_0_4.clone(),
                            ),
                            _ => Documents::US13::US13_0(
                                string(""),
                                v31.clone(),
                                v32.clone(),
                                v33,
                                v34,
                            ),
                        };
                        match &v190 {
                            Documents::US13::US13_0(
                                v190_0_0,
                                v190_0_1,
                                v190_0_2,
                                v190_0_3,
                                v190_0_4,
                            ) => {
                                let v195: i32 = v190_0_4.clone();
                                let v194: i32 = v190_0_3.clone();
                                let v193: LrcPtr<StringBuilder> = v190_0_2.clone();
                                let v192: string = v190_0_1.clone();
                                let v199: Documents::US12 = Documents::method66(
                                    v192.clone(),
                                    v193.clone(),
                                    v194,
                                    v195,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v24),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v25),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v199 {
                                        Documents::US12::US12_0(v199_0_0,
                                                                v199_0_1,
                                                                v199_0_2,
                                                                v199_0_3,
                                                                v199_0_4) =>
                                        Documents::US13::US13_0(v190_0_0.clone(),
                                                                v199_0_1.clone(),
                                                                v199_0_2.clone(),
                                                                v199_0_3.clone(),
                                                                v199_0_4.clone()),
                                        Documents::US12::US12_1(v199_1_0) =>
                                        Documents::US13::US13_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                         v199_1_0.clone(),
                                                                         (v15.clone(),
                                                                          v23.clone(),
                                                                          1_i32,
                                                                          1_i32),
                                                                         (v31,
                                                                          v32,
                                                                          v33,
                                                                          v34),
                                                                         (v192,
                                                                          v193,
                                                                          v194,
                                                                          v195))),
                                    }
                            }
                            _ => Documents::US13::US13_1(string("between / expected content")),
                        }
                    }
                    Documents::US12::US12_1(v29_1_0) => Documents::US13::US13_1(v29_1_0.clone()),
                };
                let v435: Documents::US13 = match &v219 {
                    Documents::US13::US13_0(v219_0_0, v219_0_1, v219_0_2, v219_0_3, v219_0_4) => {
                        v219.clone()
                    }
                    _ => {
                        let v359: Documents::US12 = if string("") == v15.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v23.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v267: char = getCharAt(v15.clone(), 0_i32);
                            let v274: string =
                                getSlice(v15.clone(), Some(1_i32), Some(length(v15.clone())));
                            if Documents::method67(v267, 0_i64) == false {
                                let v281: string = ofChar(v267);
                                let v288: i32 = length(v281.clone());
                                let v289: Array<char> = new_init(&'\u{0000}', v288);
                                let v290: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method37(v288, v290.clone()) {
                                    let v292: i32 = v290.l0.get().clone();
                                    let v293: char = getCharAt(v281.clone(), v292);
                                    v289.get_mut()[v292 as usize] = v293;
                                    {
                                        let v294: i32 = v292 + 1_i32;
                                        v290.l0.set(v294);
                                        ()
                                    }
                                }
                                {
                                    let v295: List<char> = ofArray(v289.clone());
                                    let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method62(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method61())(b0)(b1)
                                                    },
                                                ),
                                                v295,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v23.clone(),
                                            1_i32,
                                            1_i32,
                                        );
                                    Documents::US12::US12_0(
                                        v267,
                                        v274,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US12::US12_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v267,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v23.clone(),
                                                                          1_i32,
                                                                          1_i32)))
                            }
                        };
                        let v371: Documents::US12 = match &v359 {
                            Documents::US12::US12_0(
                                v359_0_0,
                                v359_0_1,
                                v359_0_2,
                                v359_0_3,
                                v359_0_4,
                            ) => {
                                let v360: char = v359_0_0.clone();
                                Documents::US12::US12_0(
                                    if '\\' == v360 { '/' } else { v360 },
                                    v359_0_1.clone(),
                                    v359_0_2.clone(),
                                    v359_0_3.clone(),
                                    v359_0_4.clone(),
                                )
                            }
                            Documents::US12::US12_1(v359_1_0) => {
                                Documents::US12::US12_1(v359_1_0.clone())
                            }
                        };
                        let v391: Documents::US13 = match &v371 {
                            Documents::US12::US12_0(
                                v371_0_0,
                                v371_0_1,
                                v371_0_2,
                                v371_0_3,
                                v371_0_4,
                            ) => Documents::method68(
                                ofChar(v371_0_0.clone()),
                                v371_0_1.clone(),
                                v371_0_2.clone(),
                                v371_0_3.clone(),
                                v371_0_4.clone(),
                            ),
                            Documents::US12::US12_1(v371_1_0) => {
                                Documents::US13::US13_1(v371_1_0.clone())
                            }
                        };
                        match &v391 {
                            Documents::US13::US13_0(
                                v391_0_0,
                                v391_0_1,
                                v391_0_2,
                                v391_0_3,
                                v391_0_4,
                            ) => v391.clone(),
                            _ => {
                                let v403: Documents::US15 = if length(v15.clone()) == 0_i32 {
                                    Documents::US15::US15_0(v15.clone(), v23.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US15::US15_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v15.clone()
                                    ))
                                };
                                let v412: Documents::US13 = match &v403 {
                                    Documents::US15::US15_0(
                                        v403_0_0,
                                        v403_0_1,
                                        v403_0_2,
                                        v403_0_3,
                                    ) => Documents::US13::US13_0(
                                        string(""),
                                        v403_0_0.clone(),
                                        v403_0_1.clone(),
                                        v403_0_2.clone(),
                                        v403_0_3.clone(),
                                    ),
                                    Documents::US15::US15_1(v403_1_0) => {
                                        Documents::US13::US13_1(v403_1_0.clone())
                                    }
                                };
                                match &v412 {
                                    Documents::US13::US13_0(
                                        v412_0_0,
                                        v412_0_1,
                                        v412_0_2,
                                        v412_0_3,
                                        v412_0_4,
                                    ) => {
                                        let v414: string = v412_0_1.clone();
                                        Documents::US13::US13_0(
                                            v412_0_0.clone(),
                                            getSlice(
                                                v414.clone(),
                                                Some(Documents::method69(v414.clone(), 0_i32)),
                                                Some(length(v414)),
                                            ),
                                            v412_0_2.clone(),
                                            v412_0_3.clone(),
                                            v412_0_4.clone(),
                                        )
                                    }
                                    Documents::US13::US13_1(v412_1_0) => {
                                        Documents::US13::US13_1(v412_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v639: Documents::US16 = match &v435 {
                    Documents::US13::US13_0(v435_0_0, v435_0_1, v435_0_2, v435_0_3, v435_0_4) => {
                        let v440: i32 = v435_0_4.clone();
                        let v439: i32 = v435_0_3.clone();
                        let v438: LrcPtr<StringBuilder> = v435_0_2.clone();
                        let v437: string = v435_0_1.clone();
                        let v522: Documents::US12 = if string("") == v437.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v438.clone(), v439, v440)
                            ))
                        } else {
                            let v444: char = getCharAt(v437.clone(), 0_i32);
                            if v444 == ' ' {
                                let v452: string =
                                    getSlice(v437.clone(), Some(1_i32), Some(length(v437.clone())));
                                let v456: string = ofChar(v444);
                                let v463: i32 = length(v456.clone());
                                let v464: Array<char> = new_init(&'\u{0000}', v463);
                                let v465: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method37(v463, v465.clone()) {
                                    let v467: i32 = v465.l0.get().clone();
                                    let v468: char = getCharAt(v456.clone(), v467);
                                    v464.get_mut()[v467 as usize] = v468;
                                    {
                                        let v469: i32 = v467 + 1_i32;
                                        v465.l0.set(v469);
                                        ()
                                    }
                                }
                                {
                                    let v470: List<char> = ofArray(v464.clone());
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method62(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method61())(b0)(b1)
                                                    },
                                                ),
                                                v470,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v438.clone(),
                                            v439,
                                            v440,
                                        );
                                    Documents::US12::US12_0(
                                        v444,
                                        v452,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                let v492: i32 = length(v437.clone());
                                let v495: i32 = indexOf(v437.clone(), string("\n")) - 1_i32;
                                Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                         sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                  ' ',
                                                                                  v439,
                                                                                  v440,
                                                                                  v438.clone(),
                                                                                  getSlice(v437.clone(),
                                                                                           Some(0_i32),
                                                                                           Some(if -2_i32
                                                                                                       ==
                                                                                                       v495
                                                                                                   {
                                                                                                    v492
                                                                                                } else {
                                                                                                    v495
                                                                                                }))),
                                                                         append(replicate(v440
                                                                                              -
                                                                                              1_i32,
                                                                                          string(" ")),
                                                                                string("^"))))
                            }
                        };
                        let v534: Documents::US17 = match &v522 {
                            Documents::US12::US12_0(
                                v522_0_0,
                                v522_0_1,
                                v522_0_2,
                                v522_0_3,
                                v522_0_4,
                            ) => Documents::US17::US17_0(
                                Documents::US14::US14_0(v522_0_0.clone()),
                                v522_0_1.clone(),
                                v522_0_2.clone(),
                                v522_0_3.clone(),
                                v522_0_4.clone(),
                            ),
                            _ => Documents::US17::US17_0(
                                Documents::US14::US14_1,
                                v437.clone(),
                                v438.clone(),
                                v439,
                                v440,
                            ),
                        };
                        let v613: Documents::US13 = match &v534 {
                            Documents::US17::US17_0(
                                v534_0_0,
                                v534_0_1,
                                v534_0_2,
                                v534_0_3,
                                v534_0_4,
                            ) => {
                                let v539: i32 = v534_0_4.clone();
                                let v538: i32 = v534_0_3.clone();
                                let v537: LrcPtr<StringBuilder> = v534_0_2.clone();
                                let v536: string = v534_0_1.clone();
                                let v589: Documents::US12 = if string("") == v536.clone() {
                                    Documents::US12::US12_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v537.clone(), v538, v539)
                                    ))
                                } else {
                                    let v543: char = getCharAt(v536.clone(), 0_i32);
                                    let v550: string =
                                        getSlice(v536.clone(), Some(1_i32), Some(length(v536)));
                                    let v554: string = ofChar(v543);
                                    let v561: i32 = length(v554.clone());
                                    let v562: Array<char> = new_init(&'\u{0000}', v561);
                                    let v563: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method37(v561, v563.clone()) {
                                        let v565: i32 = v563.l0.get().clone();
                                        let v566: char = getCharAt(v554.clone(), v565);
                                        v562.get_mut()[v565 as usize] = v566;
                                        {
                                            let v567: i32 = v565 + 1_i32;
                                            v563.l0.set(v567);
                                            ()
                                        }
                                    }
                                    {
                                        let v568: List<char> = ofArray(v562.clone());
                                        let patternInput_3:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Documents::method62(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method61())(b0)(b1)),
                                                                                     v568,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v537,
                                                                            v538,
                                                                            v539);
                                        Documents::US12::US12_0(
                                            v543,
                                            v550,
                                            patternInput_3.0.clone(),
                                            patternInput_3.1.clone(),
                                            patternInput_3.2.clone(),
                                        )
                                    }
                                };
                                match &v589 {
                                    Documents::US12::US12_0(
                                        v589_0_0,
                                        v589_0_1,
                                        v589_0_2,
                                        v589_0_3,
                                        v589_0_4,
                                    ) => Documents::method70(
                                        ofChar(v589_0_0.clone()),
                                        v589_0_1.clone(),
                                        v589_0_2.clone(),
                                        v589_0_3.clone(),
                                        v589_0_4.clone(),
                                    ),
                                    Documents::US12::US12_1(v589_1_0) => {
                                        Documents::US13::US13_1(v589_1_0.clone())
                                    }
                                }
                            }
                            Documents::US17::US17_1(v534_1_0) => {
                                Documents::US13::US13_1(v534_1_0.clone())
                            }
                        };
                        let v625: Documents::US18 = match &v613 {
                            Documents::US13::US13_0(
                                v613_0_0,
                                v613_0_1,
                                v613_0_2,
                                v613_0_3,
                                v613_0_4,
                            ) => Documents::US18::US18_0(
                                Documents::US3::US3_0(v613_0_0.clone()),
                                v613_0_1.clone(),
                                v613_0_2.clone(),
                                v613_0_3.clone(),
                                v613_0_4.clone(),
                            ),
                            _ => Documents::US18::US18_0(
                                Documents::US3::US3_1,
                                v437,
                                v438,
                                v439,
                                v440,
                            ),
                        };
                        match &v625 {
                            Documents::US18::US18_0(
                                v625_0_0,
                                v625_0_1,
                                v625_0_2,
                                v625_0_3,
                                v625_0_4,
                            ) => Documents::US16::US16_0(
                                v435_0_0.clone(),
                                v625_0_0.clone(),
                                v625_0_1.clone(),
                                v625_0_2.clone(),
                                v625_0_3.clone(),
                                v625_0_4.clone(),
                            ),
                            Documents::US18::US18_1(v625_1_0) => {
                                Documents::US16::US16_1(v625_1_0.clone())
                            }
                        }
                    }
                    Documents::US13::US13_1(v435_1_0) => Documents::US16::US16_1(v435_1_0.clone()),
                };
                match &v639 {
                    Documents::US16::US16_0(
                        v639_0_0,
                        v639_0_1,
                        v639_0_2,
                        v639_0_3,
                        v639_0_4,
                        v639_0_5,
                    ) => Documents::US11::US11_0(v639_0_0.clone(), v639_0_1.clone()),
                    Documents::US16::US16_1(v639_1_0) => Documents::US11::US11_1(v639_1_0.clone()),
                }
            }
        }
        pub fn method73(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method73: loop {
                break '_method73 (if v1_1.get().clone() >= 4_i64 {
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
                        continue '_method73;
                    }
                });
            }
        }
        pub fn method74(
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
            '_method74: loop {
                break '_method74 ({
                    let v154: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v55: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v62: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method73(v55, 0_i64) == false {
                            let v69: string = ofChar(v55);
                            let v76: i32 = length(v69.clone());
                            let v77: Array<char> = new_init(&'\u{0000}', v76);
                            let v78: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v76, v78.clone()) {
                                let v80: i32 = v78.l0.get().clone();
                                let v81: char = getCharAt(v69.clone(), v80);
                                v77.get_mut()[v80 as usize] = v81;
                                {
                                    let v82: i32 = v80 + 1_i32;
                                    v78.l0.set(v82);
                                    ()
                                }
                            }
                            {
                                let v83: List<char> = ofArray(v77.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method62(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method61())(b0)(b1)
                                                },
                                            ),
                                            v83,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v55,
                                    v62,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v55,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v154 {
                        Documents::US12::US12_0(
                            v154_0_0,
                            v154_0_1,
                            v154_0_2,
                            v154_0_3,
                            v154_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v154_0_0.clone()));
                            let v1_1_temp: string = v154_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v154_0_2.clone();
                            let v3_temp: i32 = v154_0_3.clone();
                            let v4_temp: i32 = v154_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method74;
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
        pub fn method76(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method76: loop {
                break '_method76 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method76;
                    }
                });
            }
        }
        pub fn closure33(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US13 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v85: Documents::US12 = if string("") == v0_1.clone() {
                Documents::US12::US12_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\\' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v19: string = ofChar(v7);
                    let v26: i32 = length(v19.clone());
                    let v27: Array<char> = new_init(&'\u{0000}', v26);
                    let v28: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method37(v26, v28.clone()) {
                        let v30: i32 = v28.l0.get().clone();
                        let v31: char = getCharAt(v19.clone(), v30);
                        v27.get_mut()[v30 as usize] = v31;
                        {
                            let v32: i32 = v30 + 1_i32;
                            v28.l0.set(v32);
                            ()
                        }
                    }
                    {
                        let v33: List<char> = ofArray(v27.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method62(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method61())(b0)(b1)
                                }),
                                v33,
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
                    let v55: i32 = length(v0_1.clone());
                    let v58: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v58 { v55 } else { v58 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v144: Documents::US12 = match &v85 {
                Documents::US12::US12_0(v85_0_0, v85_0_1, v85_0_2, v85_0_3, v85_0_4) => {
                    let v90: i32 = v85_0_4.clone();
                    let v89: i32 = v85_0_3.clone();
                    let v88: LrcPtr<StringBuilder> = v85_0_2.clone();
                    let v87: string = v85_0_1.clone();
                    if string("") == v87.clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v88.clone(), v89, v90)
                        ))
                    } else {
                        let v94: char = getCharAt(v87.clone(), 0_i32);
                        let v101: string = getSlice(v87.clone(), Some(1_i32), Some(length(v87)));
                        let v105: string = ofChar(v94);
                        let v112: i32 = length(v105.clone());
                        let v113: Array<char> = new_init(&'\u{0000}', v112);
                        let v114: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method37(v112, v114.clone()) {
                            let v116: i32 = v114.l0.get().clone();
                            let v117: char = getCharAt(v105.clone(), v116);
                            v113.get_mut()[v116 as usize] = v117;
                            {
                                let v118: i32 = v116 + 1_i32;
                                v114.l0.set(v118);
                                ()
                            }
                        }
                        {
                            let v119: List<char> = ofArray(v113.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method62(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method61())(b0)(b1)
                                        }),
                                        v119,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v88,
                                    v89,
                                    v90,
                                );
                            Documents::US12::US12_0(
                                v94,
                                v101,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US12::US12_1(v85_1_0) => Documents::US12::US12_1(v85_1_0.clone()),
            };
            match &v144 {
                Documents::US12::US12_0(v144_0_0, v144_0_1, v144_0_2, v144_0_3, v144_0_4) => {
                    Documents::US13::US13_0(
                        sprintf!("{}{}", '\\', v144_0_0.clone()),
                        v144_0_1.clone(),
                        v144_0_2.clone(),
                        v144_0_3.clone(),
                        v144_0_4.clone(),
                    )
                }
                Documents::US12::US12_1(v144_1_0) => Documents::US13::US13_1(v144_1_0.clone()),
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
            let v85: Documents::US12 = if string("") == v0_1.clone() {
                Documents::US12::US12_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '`' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v19: string = ofChar(v7);
                    let v26: i32 = length(v19.clone());
                    let v27: Array<char> = new_init(&'\u{0000}', v26);
                    let v28: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method37(v26, v28.clone()) {
                        let v30: i32 = v28.l0.get().clone();
                        let v31: char = getCharAt(v19.clone(), v30);
                        v27.get_mut()[v30 as usize] = v31;
                        {
                            let v32: i32 = v30 + 1_i32;
                            v28.l0.set(v32);
                            ()
                        }
                    }
                    {
                        let v33: List<char> = ofArray(v27.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method62(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method61())(b0)(b1)
                                }),
                                v33,
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
                    let v55: i32 = length(v0_1.clone());
                    let v58: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v58 { v55 } else { v58 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v144: Documents::US12 = match &v85 {
                Documents::US12::US12_0(v85_0_0, v85_0_1, v85_0_2, v85_0_3, v85_0_4) => {
                    let v90: i32 = v85_0_4.clone();
                    let v89: i32 = v85_0_3.clone();
                    let v88: LrcPtr<StringBuilder> = v85_0_2.clone();
                    let v87: string = v85_0_1.clone();
                    if string("") == v87.clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v88.clone(), v89, v90)
                        ))
                    } else {
                        let v94: char = getCharAt(v87.clone(), 0_i32);
                        let v101: string = getSlice(v87.clone(), Some(1_i32), Some(length(v87)));
                        let v105: string = ofChar(v94);
                        let v112: i32 = length(v105.clone());
                        let v113: Array<char> = new_init(&'\u{0000}', v112);
                        let v114: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method37(v112, v114.clone()) {
                            let v116: i32 = v114.l0.get().clone();
                            let v117: char = getCharAt(v105.clone(), v116);
                            v113.get_mut()[v116 as usize] = v117;
                            {
                                let v118: i32 = v116 + 1_i32;
                                v114.l0.set(v118);
                                ()
                            }
                        }
                        {
                            let v119: List<char> = ofArray(v113.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method62(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method61())(b0)(b1)
                                        }),
                                        v119,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v88,
                                    v89,
                                    v90,
                                );
                            Documents::US12::US12_0(
                                v94,
                                v101,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US12::US12_1(v85_1_0) => Documents::US12::US12_1(v85_1_0.clone()),
            };
            match &v144 {
                Documents::US12::US12_0(v144_0_0, v144_0_1, v144_0_2, v144_0_3, v144_0_4) => {
                    Documents::US13::US13_0(
                        sprintf!("{}{}", '`', v144_0_0.clone()),
                        v144_0_1.clone(),
                        v144_0_2.clone(),
                        v144_0_3.clone(),
                        v144_0_4.clone(),
                    )
                }
                Documents::US12::US12_1(v144_1_0) => Documents::US13::US13_1(v144_1_0.clone()),
            }
        }
        pub fn method77(
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
            '_method77: loop {
                break '_method77 (match v4.get().clone().as_ref() {
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
                                continue '_method77;
                            }
                        }
                    }
                });
            }
        }
        pub fn method78(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method78: loop {
                break '_method78 (match v0_1.get().clone().as_ref() {
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
                        continue '_method78;
                    }
                });
            }
        }
        pub fn method75(
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
            '_method75: loop {
                break '_method75 ({
                    let v136: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v46: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v53: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method76(v46, 0_i64) == false {
                            let v60: string = ofChar(v46);
                            let v67: i32 = length(v60.clone());
                            let v68: Array<char> = new_init(&'\u{0000}', v67);
                            let v69: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v67, v69.clone()) {
                                let v71: i32 = v69.l0.get().clone();
                                let v72: char = getCharAt(v60.clone(), v71);
                                v68.get_mut()[v71 as usize] = v72;
                                {
                                    let v73: i32 = v71 + 1_i32;
                                    v69.l0.set(v73);
                                    ()
                                }
                            }
                            {
                                let v74: List<char> = ofArray(v68.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method62(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method61())(b0)(b1)
                                                },
                                            ),
                                            v74,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v46,
                                    v53,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v46,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v156: Documents::US13 = match &v136 {
                        Documents::US12::US12_0(
                            v136_0_0,
                            v136_0_1,
                            v136_0_2,
                            v136_0_3,
                            v136_0_4,
                        ) => Documents::US13::US13_0(
                            ofChar(v136_0_0.clone()),
                            v136_0_1.clone(),
                            v136_0_2.clone(),
                            v136_0_3.clone(),
                            v136_0_4.clone(),
                        ),
                        Documents::US12::US12_1(v136_1_0) => {
                            Documents::US13::US13_1(v136_1_0.clone())
                        }
                    };
                    let v170: Documents::US13 = match &v156 {
                        Documents::US13::US13_0(
                            v156_0_0,
                            v156_0_1,
                            v156_0_2,
                            v156_0_3,
                            v156_0_4,
                        ) => v156.clone(),
                        _ => Documents::method77(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure33((), arg10_0040)
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
                                            Documents::closure34((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v170 {
                        Documents::US13::US13_0(
                            v170_0_0,
                            v170_0_1,
                            v170_0_2,
                            v170_0_3,
                            v170_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v170_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v170_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v170_0_2.clone();
                            let v3_temp: i32 = v170_0_3.clone();
                            let v4_temp: i32 = v170_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method75;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method78(
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
        pub fn method79(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method79(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method80(
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
            '_method80: loop {
                break '_method80 ({
                    let v136: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v46: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v53: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method76(v46, 0_i64) == false {
                            let v60: string = ofChar(v46);
                            let v67: i32 = length(v60.clone());
                            let v68: Array<char> = new_init(&'\u{0000}', v67);
                            let v69: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v67, v69.clone()) {
                                let v71: i32 = v69.l0.get().clone();
                                let v72: char = getCharAt(v60.clone(), v71);
                                v68.get_mut()[v71 as usize] = v72;
                                {
                                    let v73: i32 = v71 + 1_i32;
                                    v69.l0.set(v73);
                                    ()
                                }
                            }
                            {
                                let v74: List<char> = ofArray(v68.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method62(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method61())(b0)(b1)
                                                },
                                            ),
                                            v74,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v46,
                                    v53,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v46,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v156: Documents::US13 = match &v136 {
                        Documents::US12::US12_0(
                            v136_0_0,
                            v136_0_1,
                            v136_0_2,
                            v136_0_3,
                            v136_0_4,
                        ) => Documents::US13::US13_0(
                            ofChar(v136_0_0.clone()),
                            v136_0_1.clone(),
                            v136_0_2.clone(),
                            v136_0_3.clone(),
                            v136_0_4.clone(),
                        ),
                        Documents::US12::US12_1(v136_1_0) => {
                            Documents::US13::US13_1(v136_1_0.clone())
                        }
                    };
                    match &v156 {
                        Documents::US13::US13_0(
                            v156_0_0,
                            v156_0_1,
                            v156_0_2,
                            v156_0_3,
                            v156_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v156_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v156_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v156_0_2.clone();
                            let v3_temp: i32 = v156_0_3.clone();
                            let v4_temp: i32 = v156_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method80;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method78(
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
        pub fn method81(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method81: loop {
                break '_method81 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method81;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method72(
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
            '_method72: loop {
                break '_method72 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v154: Documents::US12 = if v5 {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v55: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v62: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method73(v55, 0_i64) == false {
                            let v69: string = ofChar(v55);
                            let v76: i32 = length(v69.clone());
                            let v77: Array<char> = new_init(&'\u{0000}', v76);
                            let v78: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v76, v78.clone()) {
                                let v80: i32 = v78.l0.get().clone();
                                let v81: char = getCharAt(v69.clone(), v80);
                                v77.get_mut()[v80 as usize] = v81;
                                {
                                    let v82: i32 = v80 + 1_i32;
                                    v78.l0.set(v82);
                                    ()
                                }
                            }
                            {
                                let v83: List<char> = ofArray(v77.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method62(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method61())(b0)(b1)
                                                },
                                            ),
                                            v83,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v55,
                                    v62,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v55,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v174: Documents::US13 = match &v154 {
                        Documents::US12::US12_0(
                            v154_0_0,
                            v154_0_1,
                            v154_0_2,
                            v154_0_3,
                            v154_0_4,
                        ) => Documents::method74(
                            ofChar(v154_0_0.clone()),
                            v154_0_1.clone(),
                            v154_0_2.clone(),
                            v154_0_3.clone(),
                            v154_0_4.clone(),
                        ),
                        Documents::US12::US12_1(v154_1_0) => {
                            Documents::US13::US13_1(v154_1_0.clone())
                        }
                    };
                    let v479: Documents::US13 = match &v174 {
                        Documents::US13::US13_0(
                            v174_0_0,
                            v174_0_1,
                            v174_0_2,
                            v174_0_3,
                            v174_0_4,
                        ) => v174.clone(),
                        _ => {
                            let v261: Documents::US12 = if v5 {
                                Documents::US12::US12_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / s: {:?}",
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v183: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v183 == '\"' {
                                    let v191: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone())),
                                    );
                                    let v195: string = ofChar(v183);
                                    let v202: i32 = length(v195.clone());
                                    let v203: Array<char> = new_init(&'\u{0000}', v202);
                                    let v204: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method37(v202, v204.clone()) {
                                        let v206: i32 = v204.l0.get().clone();
                                        let v207: char = getCharAt(v195.clone(), v206);
                                        v203.get_mut()[v206 as usize] = v207;
                                        {
                                            let v208: i32 = v206 + 1_i32;
                                            v204.l0.set(v208);
                                            ()
                                        }
                                    }
                                    {
                                        let v209: List<char> = ofArray(v203.clone());
                                        let patternInput_1:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method62(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method61())(b0)(b1)),
                                                                                          v209,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US12::US12_0(
                                            v183,
                                            v191,
                                            patternInput_1.0.clone(),
                                            patternInput_1.1.clone(),
                                            patternInput_1.2.clone(),
                                        )
                                    }
                                } else {
                                    let v231: i32 = length(v1_1.get().clone());
                                    let v234: i32 =
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
                                                                                                                    v234
                                                                                                                {
                                                                                                                 v231
                                                                                                             } else {
                                                                                                                 v234
                                                                                                             }))),
                                                                                      append(replicate(v4.get().clone()
                                                                                                           -
                                                                                                           1_i32,
                                                                                                       string(" ")),
                                                                                             string("^"))))
                                }
                            };
                            let v408: Documents::US13 = match &v261 {
                                Documents::US12::US12_0(
                                    v261_0_0,
                                    v261_0_1,
                                    v261_0_2,
                                    v261_0_3,
                                    v261_0_4,
                                ) => {
                                    let v266: i32 = v261_0_4.clone();
                                    let v265: i32 = v261_0_3.clone();
                                    let v264: LrcPtr<StringBuilder> = v261_0_2.clone();
                                    let v263: string = v261_0_1.clone();
                                    let v268: Documents::US20 = Documents::method75(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v263.clone(),
                                        v264.clone(),
                                        v265,
                                        v266,
                                    );
                                    let v301: Documents::US13 = match &v268 {
                                        Documents::US20::US20_0(
                                            v268_0_0,
                                            v268_0_1,
                                            v268_0_2,
                                            v268_0_3,
                                            v268_0_4,
                                        ) => {
                                            let v275: List<string> = Documents::method79(
                                                v268_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US13::US13_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v275 = v275.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v275 = v275.clone();
                                                                    move |i: i32| {
                                                                        item(i, v275.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v275.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v268_0_1.clone(),
                                                v268_0_2.clone(),
                                                v268_0_3.clone(),
                                                v268_0_4.clone(),
                                            )
                                        }
                                        Documents::US20::US20_1(v268_1_0) => {
                                            Documents::US13::US13_1(v268_1_0.clone())
                                        }
                                    };
                                    match &v301 {
                                        Documents::US13::US13_0(
                                            v301_0_0,
                                            v301_0_1,
                                            v301_0_2,
                                            v301_0_3,
                                            v301_0_4,
                                        ) => {
                                            let v306: i32 = v301_0_4.clone();
                                            let v305: i32 = v301_0_3.clone();
                                            let v304: LrcPtr<StringBuilder> = v301_0_2.clone();
                                            let v303: string = v301_0_1.clone();
                                            let v388: Documents::US12 = if string("")
                                                == v303.clone()
                                            {
                                                Documents::US12::US12_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
                                                                                                      (v304.clone(),
                                                                                                       v305,
                                                                                                       v306)))
                                            } else {
                                                let v310: char = getCharAt(v303.clone(), 0_i32);
                                                if v310 == '\"' {
                                                    let v318: string = getSlice(
                                                        v303.clone(),
                                                        Some(1_i32),
                                                        Some(length(v303.clone())),
                                                    );
                                                    let v322: string = ofChar(v310);
                                                    let v329: i32 = length(v322.clone());
                                                    let v330: Array<char> =
                                                        new_init(&'\u{0000}', v329);
                                                    let v331: LrcPtr<Documents::Mut6> =
                                                        LrcPtr::new(Documents::Mut6 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method37(v329, v331.clone()) {
                                                        let v333: i32 = v331.l0.get().clone();
                                                        let v334: char =
                                                            getCharAt(v322.clone(), v333);
                                                        v330.get_mut()[v333 as usize] = v334;
                                                        {
                                                            let v335: i32 = v333 + 1_i32;
                                                            v331.l0.set(v335);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v336: List<char> =
                                                            ofArray(v330.clone());
                                                        let patternInput_2:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Documents::method62(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method61())(b0)(b1)),
                                                                                                              v336,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v304.clone(),
                                                                                                     v305,
                                                                                                     v306);
                                                        Documents::US12::US12_0(
                                                            v310,
                                                            v318,
                                                            patternInput_2.0.clone(),
                                                            patternInput_2.1.clone(),
                                                            patternInput_2.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v358: i32 = length(v303.clone());
                                                    let v361: i32 =
                                                        indexOf(v303.clone(), string("\n")) - 1_i32;
                                                    Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                                                          sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                   '\"',
                                                                                                                   v305,
                                                                                                                   v306,
                                                                                                                   v304.clone(),
                                                                                                                   getSlice(v303.clone(),
                                                                                                                            Some(0_i32),
                                                                                                                            Some(if -2_i32
                                                                                                                                        ==
                                                                                                                                        v361
                                                                                                                                    {
                                                                                                                                     v358
                                                                                                                                 } else {
                                                                                                                                     v361
                                                                                                                                 }))),
                                                                                                          append(replicate(v306
                                                                                                                               -
                                                                                                                               1_i32,
                                                                                                                           string(" ")),
                                                                                                                 string("^"))))
                                                }
                                            };
                                            match &v388 {
                                                                 Documents::US12::US12_0(v388_0_0,
                                                                                         v388_0_1,
                                                                                         v388_0_2,
                                                                                         v388_0_3,
                                                                                         v388_0_4)
                                                                 =>
                                                                 Documents::US13::US13_0(v301_0_0.clone(),
                                                                                         v388_0_1.clone(),
                                                                                         v388_0_2.clone(),
                                                                                         v388_0_3.clone(),
                                                                                         v388_0_4.clone()),
                                                                 Documents::US12::US12_1(v388_1_0)
                                                                 =>
                                                                 Documents::US13::US13_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v388_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v263,
                                                                                                   v264,
                                                                                                   v265,
                                                                                                   v266),
                                                                                                  (v303,
                                                                                                   v304,
                                                                                                   v305,
                                                                                                   v306))),
                                                             }
                                        }
                                        _ => Documents::US13::US13_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Documents::US12::US12_1(v261_1_0) => {
                                    Documents::US13::US13_1(v261_1_0.clone())
                                }
                            };
                            match &v408 {
                                Documents::US13::US13_0(
                                    v408_0_0,
                                    v408_0_1,
                                    v408_0_2,
                                    v408_0_3,
                                    v408_0_4,
                                ) => v408.clone(),
                                _ => {
                                    let v420: Documents::US13 =
                                                     Documents::method77(v1_1.get().clone(),
                                                                         v2.get().clone(),
                                                                         v3.get().clone(),
                                                                         v4.get().clone(),
                                                                         LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                          |arg10_0040:
                                                                                                                               (string,
                                                                                                                                LrcPtr<StringBuilder>,
                                                                                                                                i32,
                                                                                                                                i32)|
                                                                                                                          Documents::closure33((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure34((),
                                                                                                                                                                                 arg10_0040_1)),
                                                                                                                                             LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v431: Documents::US13 = match &v420 {
                                        Documents::US13::US13_0(
                                            v420_0_0,
                                            v420_0_1,
                                            v420_0_2,
                                            v420_0_3,
                                            v420_0_4,
                                        ) => Documents::US13::US13_0(
                                            string(""),
                                            v420_0_1.clone(),
                                            v420_0_2.clone(),
                                            v420_0_3.clone(),
                                            v420_0_4.clone(),
                                        ),
                                        Documents::US13::US13_1(v420_1_0) => {
                                            Documents::US13::US13_1(v420_1_0.clone())
                                        }
                                    };
                                    let v442: Documents::US20 = match &v431 {
                                        Documents::US13::US13_0(
                                            v431_0_0,
                                            v431_0_1,
                                            v431_0_2,
                                            v431_0_3,
                                            v431_0_4,
                                        ) => Documents::method80(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v431_0_1.clone(),
                                            v431_0_2.clone(),
                                            v431_0_3.clone(),
                                            v431_0_4.clone(),
                                        ),
                                        Documents::US13::US13_1(v431_1_0) => {
                                            Documents::US20::US20_1(v431_1_0.clone())
                                        }
                                    };
                                    match &v442 {
                                        Documents::US20::US20_0(
                                            v442_0_0,
                                            v442_0_1,
                                            v442_0_2,
                                            v442_0_3,
                                            v442_0_4,
                                        ) => {
                                            let v449: List<string> = Documents::method79(
                                                v442_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US13::US13_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v449 = v449.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v449 = v449.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v449.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v449.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v442_0_1.clone(),
                                                v442_0_2.clone(),
                                                v442_0_3.clone(),
                                                v442_0_4.clone(),
                                            )
                                        }
                                        Documents::US20::US20_1(v442_1_0) => {
                                            Documents::US13::US13_1(v442_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v479 {
                        Documents::US13::US13_0(
                            v479_0_0,
                            v479_0_1,
                            v479_0_2,
                            v479_0_3,
                            v479_0_4,
                        ) => {
                            let v488: i32 = v479_0_4.clone();
                            let v487: i32 = v479_0_3.clone();
                            let v486: LrcPtr<StringBuilder> = v479_0_2.clone();
                            let v485: string = v479_0_1.clone();
                            let v484: string = v479_0_0.clone();
                            let v490: i32 = Documents::method81(v485.clone(), 0_i32);
                            let v502: Documents::US15 = if 0_i32 == v490 {
                                Documents::US15::US15_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US15::US15_0(
                                    getSlice(v485.clone(), Some(v490), Some(length(v485.clone()))),
                                    v486.clone(),
                                    v487,
                                    v488,
                                )
                            };
                            match &v502 {
                                Documents::US15::US15_0(v502_0_0, v502_0_1, v502_0_2, v502_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v484.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v502_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v502_0_1.clone();
                                    let v3_temp: i32 = v502_0_2.clone();
                                    let v4_temp: i32 = v502_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method72;
                                }
                                _ => Documents::US20::US20_0(
                                    Documents::method78(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v484.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v485,
                                    v486,
                                    v487,
                                    v488,
                                ),
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method78(
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
        pub fn method71(v0_1: string) -> Documents::US19 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v27: Documents::US20 = Documents::method72(
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
                match &v27 {
                    Documents::US20::US20_0(v27_0_0, v27_0_1, v27_0_2, v27_0_3, v27_0_4) => {
                        Documents::US19::US19_0(toArray(Documents::method79(
                            v27_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US20::US20_1(v27_1_0) => Documents::US19::US19_1(v27_1_0.clone()),
                }
            }
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
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
        ) -> (
            string,
            Vec<std::string::String>,
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ) {
            (v7, v8, v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method84(v0_1: LrcPtr<Documents::Mut4>, v1_1: Vec<std::string::String>) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method86(v0_1: LrcPtr<Documents::Mut4>, v1_1: Option<CancellationToken>) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method87(v0_1: LrcPtr<Documents::Mut4>, v1_1: Array<(string, string)>) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method88(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        ) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method89(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        ) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method90(v0_1: LrcPtr<Documents::Mut4>, v1_1: bool) {
            let v7: string = sprintf!(
                "{}",
                if v1_1 {
                    string("true")
                } else {
                    string("false")
                }
            );
            let v15: string = append(v0_1.l0.get().clone(), v7);
            v0_1.l0.set(v15);
            ()
        }
        pub fn method91(v0_1: LrcPtr<Documents::Mut4>, v1_1: Option<string>) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method85(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("command"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("cancellation_token"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method86(v0_1.clone(), v2);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("environment_variables"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method87(v0_1.clone(), v3);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("on_line"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method88(v0_1.clone(), v4);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("stdin"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method89(v0_1.clone(), v5);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("trace"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method90(v0_1.clone(), v6);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("working_directory"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method91(v0_1.clone(), v7);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn method83(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: Vec<std::string::String>,
            v3: string,
            v4: Option<CancellationToken>,
            v5: Array<(string, string)>,
            v6: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v7: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v8: bool,
            v9: Option<string>,
        ) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("file_name"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("arguments"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method84(v0_1.clone(), v2);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("options"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method85(v0_1.clone(), v3, v4, v5, v6, v7, v8, v9);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure37(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(
                string,
                Vec<std::string::String>,
                string,
                Option<CancellationToken>,
                Array<(string, string)>,
                Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                bool,
                Option<string>,
            )>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1 = v2();
                            let v1225: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method83(
                                v1225.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                                patternInput_1.5.clone(),
                                patternInput_1.6.clone(),
                                patternInput_1.7.clone(),
                                patternInput_1.8.clone(),
                            );
                            {
                                let v1226: string = v1225.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1226
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method82(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(
                string,
                Vec<std::string::String>,
                string,
                Option<CancellationToken>,
                Array<(string, string)>,
                Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                bool,
                Option<string>,
            )>,
        ) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure37(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure38(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US21 {
            Documents::US21::US21_0(v0_1)
        }
        pub fn method92(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US21>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure38((), v)
                },
            )
        }
        pub fn closure39(unitVar: (), v0_1: std::string::String) -> Documents::US21 {
            Documents::US21::US21_1(v0_1)
        }
        pub fn method93() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure39((), v))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure41(v0_1: std::string::String, unitVar: ()) -> std::string::String {
            v0_1
        }
        pub fn method94(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure42(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method95() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure42((), v))
        }
        pub fn closure43(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method96() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure43((), v))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) -> std::string::String {
            v0_1
        }
        pub fn method98(v0_1: LrcPtr<Documents::Mut4>, v1_1: std::string::String) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("e"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method53(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure46(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<std::string::String>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method98(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method97(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<std::string::String>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure46(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure47(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn closure49(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<()>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            v2();
                            {
                                let v1216: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(string("")),
                                });
                                Documents::method11(v1216.clone());
                                {
                                    let v1217: string = v1216.l0.get().clone();
                                    trimEndChars(
                                        trimStartChars(
                                            sprintf!(
                                                "{} {} #{} {} / {}",
                                                v826,
                                                v1195,
                                                v1214,
                                                v1_1(),
                                                v1217
                                            ),
                                            toArray(empty::<char>()),
                                        ),
                                        toArray(ofArray(new_array(&[' ', '/']))),
                                    )
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn method99(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<()>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure49(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method100(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>
        {
            v0_1
        }
        pub fn closure50(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            let _v3: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method101(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure50((), v)
            })
        }
        pub fn method102(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn method103(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn method104(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method105(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method106(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure51(unitVar: (), v0_1: std::process::Output) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn closure52(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure54(v0_1: std::string::String, unitVar: ()) -> std::string::String {
            v0_1
        }
        pub fn method107(
            v0_1: std::sync::Arc<
                std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
            >,
        ) -> std::sync::Arc<
            std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        > {
            v0_1
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure56(v0_1: i32, v1_1: string, unitVar: ()) -> (i32, i32) {
            (v0_1, length(v1_1))
        }
        pub fn method110(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32) {
            let v4: string = sprintf!("{}", v1_1);
            let v12: string = append(v0_1.l0.get().clone(), v4);
            v0_1.l0.set(v12);
            ()
        }
        pub fn method109(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: i32) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("std_trace_length"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v2);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure57(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, i32)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, i32) = v2();
                            let v1218: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method109(
                                v1218.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v1219: string = v1218.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1219
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method108(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, i32)>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure57(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async")
        }
        pub fn closure59(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            unitVar: (),
        ) -> (
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ) {
            (v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method113(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("options"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method85(v0_1.clone(), v1_1, v2, v3, v4, v5, v6, v7);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure60(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(
                string,
                Option<CancellationToken>,
                Array<(string, string)>,
                Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                bool,
                Option<string>,
            )>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1 = v2();
                            let v1223: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method113(
                                v1223.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                                patternInput_1.5.clone(),
                                patternInput_1.6.clone(),
                            );
                            {
                                let v1224: string = v1223.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1224
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method112(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(
                string,
                Option<CancellationToken>,
                Array<(string, string)>,
                Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                bool,
                Option<string>,
            )>,
        ) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure60(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure62(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure61(
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
            let _v12: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v12.set(Some(x))
            }
            {
                let v125: Arc<Async<()>> = match &_v12.get().clone() {
                    None => panic!("{}", string("base.run_target / _v12=None"),),
                    Some(_v12_0_0) => _v12_0_0.clone(),
                };
                let _v142: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v142.set(Some(()));
                match &_v142.get().clone() {
                    None => panic!("{}", string("base.run_target / _v142=None"),),
                    Some(_v142_0_0) => _v142_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure63(
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
            let _v12: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v12.set(Some(x))
            }
            {
                let v126: Arc<Async<()>> = match &_v12.get().clone() {
                    None => panic!("{}", string("base.run_target / _v12=None"),),
                    Some(_v12_0_0) => _v12_0_0.clone(),
                };
                let _v143: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v143.set(Some(()));
                match &_v143.get().clone() {
                    None => panic!("{}", string("base.run_target / _v143=None"),),
                    Some(_v143_0_0) => _v143_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure64(v0_1: (), unitVar: ()) {
            let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x: bool = unbox::<bool>(&defaultOf());
                _v3.set(Some(x))
            }
            if match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            } == false
            {
                let _v68: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v68.set(Some(()));
                match &_v68.get().clone() {
                    None => panic!("{}", string("base.run_target / _v68=None"),),
                    Some(_v68_0_0) => _v68_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async / WaitForExitAsync")
        }
        pub fn closure66(
            v0_1: LrcPtr<TaskCanceledException>,
            unitVar: (),
        ) -> LrcPtr<TaskCanceledException> {
            v0_1
        }
        pub fn method116(v0_1: LrcPtr<Documents::Mut4>, v1_1: LrcPtr<TaskCanceledException>) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method115(v0_1: LrcPtr<Documents::Mut4>, v1_1: LrcPtr<TaskCanceledException>) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("ex"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method116(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure67(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<LrcPtr<TaskCanceledException>>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method115(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method114(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<LrcPtr<TaskCanceledException>>,
        ) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure67(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async")
        }
        pub fn closure69(v0_1: i32, v1_1: string, unitVar: ()) -> (i32, i32) {
            (v0_1, length(v1_1))
        }
        pub fn method118(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: i32) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("output_length"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v2);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure70(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, i32)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, i32) = v2();
                            let v1218: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method118(
                                v1218.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v1219: string = v1218.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1219
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method117(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, i32)>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure70(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method111(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            let _v9: MutCell<Option<Arc<Async<(i32, string)>>>> =
                MutCell::new(None::<Arc<Async<(i32, string)>>>);
            {
                let x: Arc<Async<(i32, string)>> = defaultOf();
                _v9.set(Some(x))
            }
            match &_v9.get().clone() {
                None => panic!("{}", string("base.run_target / _v9=None"),),
                Some(_v9_0_0) => _v9_0_0.clone(),
            }
        }
        pub fn method58(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v9: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let v11: Documents::US11 = Documents::method60(Documents::method59(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US3) = match &v11 {
                Documents::US11::US11_0(v11_0_0, v11_0_1) => (v11_0_0.clone(), v11_0_1.clone()),
                Documents::US11::US11_1(v11_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v11_1_0.clone()),
                ),
            };
            let v21: Documents::US3 = patternInput.1.clone();
            let v20: string = patternInput.0.clone();
            let v26: Documents::US19 = Documents::method71(match &v21 {
                Documents::US3::US3_0(v21_0_0) => match &v21 {
                    Documents::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            });
            let v32: Array<string> = match &v26 {
                Documents::US19::US19_0(v26_0_0) => v26_0_0.clone(),
                Documents::US19::US19_1(v26_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v26_1_0.clone()),
                ),
            };
            let v34: Vec<string> = v32.to_vec();
            let v36: bool = true;
            let _result: Vec<_> = v34
                .into_iter()
                .map(|x| {
                    //;
                    let v38: string = x;
                    let v40: &str = &*v38;
                    let v42: std::string::String = String::from(v40);
                    let v44: bool = true;
                    v42
                })
                .collect::<Vec<_>>();
            let v46: Vec<std::string::String> = _result;
            Documents::method82(
                Documents::US0::US0_1,
                Func0::new(move || Documents::closure35((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v20 = v20.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v46 = v46.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    move || {
                        Documents::closure36(
                            v0_1.clone(),
                            v1_1.clone(),
                            v2.clone(),
                            v3.clone(),
                            v4.clone(),
                            v5,
                            v6.clone(),
                            v20.clone(),
                            v46.clone(),
                            (),
                        )
                    }
                }),
            );
            {
                let _v50: MutCell<Option<LrcPtr<(i32, string)>>> =
                    MutCell::new(None::<LrcPtr<(i32, string)>>);
                {
                    let x_15: LrcPtr<(i32, string)> = (Func0::new({
                        let v2 = v2.clone();
                        let v20 = v20.clone();
                        let v4 = v4.clone();
                        let v46 = v46.clone();
                        let v5 = v5.clone();
                        let v6 = v6.clone();
                        move || {
                            let v52: std::process::Command =
                                std::process::Command::new(&*v20.clone());
                            let v54: bool = true;
                            let mut v52 = v52;
                            let v56: &mut std::process::Command =
                                std::process::Command::args(&mut v52, &*v46.clone());
                            let v58: std::process::Stdio = std::process::Stdio::piped();
                            let v60: &mut std::process::Command =
                                std::process::Command::stdout(v56, std::process::Stdio::piped());
                            let v62: std::process::Stdio = std::process::Stdio::piped();
                            let v64: &mut std::process::Command =
                                std::process::Command::stderr(v60, std::process::Stdio::piped());
                            let v66: std::process::Stdio = std::process::Stdio::piped();
                            let v68: &mut std::process::Command =
                                std::process::Command::stdin(v64, std::process::Stdio::piped());
                            let _v71: LrcPtr<MutCell<Option<Documents::US3>>> =
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
                                _v71.set(x_2)
                            }
                            {
                                let v98: Documents::US3 =
                                    defaultValue(Documents::US3::US3_1, _v71.get().clone());
                                let v110: &mut std::process::Command = match &v98 {
                                    Documents::US3::US3_0(v98_0_0) => {
                                        std::process::Command::current_dir(
                                            v68,
                                            &*match &v98 {
                                                Documents::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                        )
                                    }
                                    _ => v68,
                                };
                                let v128: &mut std::process::Command =
                                    if count_2(v2.clone()) as u64 == 0_u64 {
                                        v110
                                    } else {
                                        let v114: Vec<(string, string)> = v2.clone().to_vec();
                                        let v116: bool = true;
                                        let _result = v114.into_iter().fold(v110, |acc, x| {
                                            //;
                                            let v118: &mut std::process::Command = acc;
                                            let patternInput_1: (string, string) = x;
                                            let v123: &mut std::process::Command =
                                                std::process::Command::env(
                                                    v118,
                                                    &*patternInput_1.0.clone(),
                                                    &*patternInput_1.1.clone(),
                                                );
                                            let v125: bool = true;
                                            v123
                                        });
                                        _result
                                    };
                                let v130: Result<std::process::Child, std::io::Error> =
                                    std::process::Command::spawn(v128);
                                let v131 = Documents::method45();
                                let v133: Result<std::process::Child, std::string::String> =
                                    v130.map_err(|x| v131(x));
                                let v135: bool = true;
                                let _result = v133.map(|x| {
                                    //;
                                    let v137: std::process::Child = x;
                                    let v148: std::sync::Mutex<Option<std::process::Child>> =
                                        std::sync::Mutex::new(Some(v137));
                                    let v150: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = std::sync::Arc::new(v148);
                                    let v152: bool = true;
                                    v150
                                });
                                let v154: Result<
                                    std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                                    std::string::String,
                                > = _result;
                                let v155 = Documents::method92();
                                let v156 = Documents::method93();
                                let v158: Documents::US21 = match v154 {
                                    Ok(x) => v155(x),
                                    Err(e) => v156(e),
                                };
                                let patternInput_3: (i32, Documents::US4, Documents::US22) =
                                    match &v158 {
                                        Documents::US21::US21_0(v158_0_0) => {
                                            let v159: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = v158_0_0.clone();
                                            let v161: bool = true;
                                            let _result = (|| {
                                                // rust.capture;
                                                let v162: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method94(v159.clone());
                                                let v164: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v162.lock();
                                                let v166: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v164.unwrap();
                                                let v168: bool = true;
                                                let mut v166 = v166;
                                                let v170: &mut Option<std::process::Child> =
                                                    &mut v166;
                                                let v172: Option<&mut std::process::Child> =
                                                    v170.as_mut();
                                                let v174: &mut std::process::Child = v172.unwrap();
                                                let v176: &mut Option<std::process::ChildStdout> =
                                                    &mut v174.stdout;
                                                let v178: Option<std::process::ChildStdout> =
                                                    Option::take(v176);
                                                let v180: std::process::ChildStdout = v178.unwrap();
                                                let v182: bool = true;
                                                v180
                                            })(
                                            );
                                            let v184: std::process::ChildStdout = _result;
                                            let v186: bool = true;
                                            let _result = (|| {
                                                // rust.capture;
                                                let v187: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method94(v159.clone());
                                                let v189: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v187.lock();
                                                let v191: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v189.unwrap();
                                                let v193: bool = true;
                                                let mut v191 = v191;
                                                let v195: &mut Option<std::process::Child> =
                                                    &mut v191;
                                                let v197: Option<&mut std::process::Child> =
                                                    v195.as_mut();
                                                let v199: &mut std::process::Child = v197.unwrap();
                                                let v201: &mut Option<std::process::ChildStderr> =
                                                    &mut v199.stderr;
                                                let v203: Option<std::process::ChildStderr> =
                                                    Option::take(v201);
                                                let v205: std::process::ChildStderr = v203.unwrap();
                                                let v207: bool = true;
                                                v205
                                            })(
                                            );
                                            let v209: std::process::ChildStderr = _result;
                                            let v211: bool = true;
                                            let _result = (|| {
                                                // rust.capture;
                                                let v212: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method94(v159.clone());
                                                let v214: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v212.lock();
                                                let v216: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v214.unwrap();
                                                let v218: bool = true;
                                                let mut v216 = v216;
                                                let v220: &mut Option<std::process::Child> =
                                                    &mut v216;
                                                let v222: Option<&mut std::process::Child> =
                                                    v220.as_mut();
                                                let v224: &mut std::process::Child = v222.unwrap();
                                                let v226: &mut Option<std::process::ChildStdin> =
                                                    &mut v224.stdin;
                                                let v228: Option<std::process::ChildStdin> =
                                                    Option::take(v226);
                                                let v230: std::process::ChildStdin = v228.unwrap();
                                                let v241: std::sync::Mutex<
                                                    Option<std::process::ChildStdin>,
                                                > = std::sync::Mutex::new(Some(v230));
                                                let v243: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                > = std::sync::Arc::new(v241);
                                                let v245: bool = true;
                                                v243
                                            })(
                                            );
                                            let v247: std::sync::Arc<
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
                                            let v249: std::sync::mpsc::Sender<std::string::String> =
                                                patternInput_2.0.clone();
                                            let v252: std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = std::sync::Mutex::new(v249.clone());
                                            let v254: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = std::sync::Arc::new(v252);
                                            let v256: std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = std::sync::Mutex::new(v249);
                                            let v258: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = std::sync::Arc::new(v256);
                                            let v260: std::sync::Mutex<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            > = std::sync::Mutex::new(patternInput_2.1.clone());
                                            let v262: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = std::sync::Arc::new(v260);
                                            let v264: bool = true;
                                            let __result = std::thread::spawn(move || {
                                                //;
                                                let v266: encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                                    .utf8_passthru(true)
                                                    .build(v184);
                                                let v268: std::io::BufReader<
                                                    encoding_rs_io::DecodeReaderBytes<
                                                        std::process::ChildStdout,
                                                        Vec<u8>,
                                                    >,
                                                > = std::io::BufReader::new(v266);
                                                let v270: std::io::Lines<
                                                    std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStdout,
                                                            Vec<u8>,
                                                        >,
                                                    >,
                                                > = std::io::BufRead::lines(v268);
                                                let v272: bool = true;
                                                let mut v270 = v270;
                                                let _result = v270.try_for_each(|x| { //;
                                                                let v274:
                                                                        Result<std::string::String,
                                                                               std::io::Error> =
                                                                    x;
                                                                let v276:
                                                                        std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                    v254.clone();
                                                                let v277 =
                                                                    Documents::method45();
                                                                let v279:
                                                                        Result<std::string::String,
                                                                               std::string::String> =
                                                                    v274.map_err(|x| v277(x));
                                                                let v280 =
                                                                    Documents::method95();
                                                                let v281 =
                                                                    Documents::method96();
                                                                let v283:
                                                                        Documents::US23 =
                                                                    match v279 { Ok(x) => v280(x), Err(e) => v281(e) };
                                                                let v321:
                                                                        std::string::String =
                                                                    match &v283
                                                                        {
                                                                        Documents::US23::US23_0(v283_0_0)
                                                                        => {
                                                                            let v286:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v283_0_0.clone());
                                                                            let v288:
                                                                                    &encoding_rs::Encoding =
                                                                                encoding_rs::UTF_8;
                                                                            let v290:
                                                                                    std::borrow::Cow<[u8]> =
                                                                                v288.encode(&*v286).0;
                                                                            let v292:
                                                                                    &[u8] =
                                                                                v290.as_ref();
                                                                            let v294:
                                                                                    Result<&str,
                                                                                           std::str::Utf8Error> =
                                                                                std::str::from_utf8(v292);
                                                                            let v296:
                                                                                    &str =
                                                                                v294.unwrap();
                                                                            let v298:
                                                                                    std::string::String =
                                                                                String::from(v296);
                                                                            let v301:
                                                                                    string =
                                                                                sprintf!("> {}",
                                                                                         fable_library_rust::String_::fromString(v298.clone()));
                                                                            if v5
                                                                               {
                                                                                Documents::method99(Documents::US0::US0_0,
                                                                                                    Func0::new({
                                                                                                                   let v301
                                                                                                                       =
                                                                                                                       v301.clone();
                                                                                                                   move
                                                                                                                       ||
                                                                                                                       Documents::closure47(v301.clone(),
                                                                                                                                            ())
                                                                                                               }),
                                                                                                    Func0::new(move
                                                                                                                   ||
                                                                                                                   Documents::closure48((),
                                                                                                                                        ())))
                                                                            } else {
                                                                                printfn!("{0}",
                                                                                         v301.clone());
                                                                                ()
                                                                            }
                                                                            v298
                                                                        }
                                                                        Documents::US23::US23_1(v283_1_0)
                                                                        => {
                                                                            let v311:
                                                                                    std::string::String =
                                                                                v283_1_0.clone();
                                                                            Documents::method97(Documents::US0::US0_4,
                                                                                                Func0::new(move
                                                                                                               ||
                                                                                                               Documents::closure44((),
                                                                                                                                    ())),
                                                                                                Func0::new({
                                                                                                               let v311
                                                                                                                   =
                                                                                                                   v311.clone();
                                                                                                               move
                                                                                                                   ||
                                                                                                                   Documents::closure45(v311.clone(),
                                                                                                                                        ())
                                                                                                           }));
                                                                            {
                                                                                let v315:
                                                                                        string =
                                                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                             v311.clone());
                                                                                let v317:
                                                                                        &str =
                                                                                    &*v315;
                                                                                String::from(v317)
                                                                            }
                                                                        }
                                                                    };
                                                                let v322:
                                                                        std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                    Documents::method100(v276);
                                                                let v324:
                                                                        Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                               std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                    v322.lock();
                                                                let v326:
                                                                        std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                    v324.unwrap();
                                                                let v328:
                                                                        &std::sync::mpsc::Sender<std::string::String> =
                                                                    &v326;
                                                                let v330:
                                                                        Result<(),
                                                                               std::sync::mpsc::SendError<std::string::String>> =
                                                                    v328.send(v321);
                                                                let v331 =
                                                                    Documents::method101();
                                                                let v333:
                                                                        Result<(),
                                                                               std::string::String> =
                                                                    v330.map_err(|x| v331(x));
                                                                let v335: _ =
                                                                    v333;
                                                                let v337:
                                                                        bool =
                                                                    true; v335 }); //;
                                                let v340: Result<(), string> = Documents::method102(
                                                    _result.map_err(|x| x.into()),
                                                );
                                                let v344: string =
                                                    string("v340 });  // rust.fix_closure\'");
                                                v340
                                            }); // rust.fix_closure';
                                            {
                                                let v346: std::thread::JoinHandle<
                                                    Result<(), string>,
                                                > = __result;
                                                let v348: bool = true;
                                                let __result = std::thread::spawn(move || {
                                                    //;
                                                    let v350:
                                                                            encoding_rs_io::DecodeReaderBytes<std::process::ChildStderr, Vec<u8>> =
                                                                        encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v209);
                                                    let v352: std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStderr,
                                                            Vec<u8>,
                                                        >,
                                                    > = std::io::BufReader::new(v350);
                                                    let v354: std::io::Lines<
                                                        std::io::BufReader<
                                                            encoding_rs_io::DecodeReaderBytes<
                                                                std::process::ChildStderr,
                                                                Vec<u8>,
                                                            >,
                                                        >,
                                                    > = std::io::BufRead::lines(v352);
                                                    let v356: bool = true;
                                                    let mut v354 = v354;
                                                    let _result = v354.try_for_each(|x| { //;
                                                                    let v358:
                                                                            Result<std::string::String,
                                                                                   std::io::Error> =
                                                                        x;
                                                                    let v360:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        v258.clone();
                                                                    let v361 =
                                                                        Documents::method45();
                                                                    let v363:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v358.map_err(|x| v361(x));
                                                                    let v364 =
                                                                        Documents::method95();
                                                                    let v365 =
                                                                        Documents::method96();
                                                                    let v367:
                                                                            Documents::US23 =
                                                                        match v363 { Ok(x) => v364(x), Err(e) => v365(e) };
                                                                    let v410:
                                                                            std::string::String =
                                                                        match &v367
                                                                            {
                                                                            Documents::US23::US23_0(v367_0_0)
                                                                            =>
                                                                            {
                                                                                let v370:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v367_0_0.clone());
                                                                                let v372:
                                                                                        &encoding_rs::Encoding =
                                                                                    encoding_rs::UTF_8;
                                                                                let v374:
                                                                                        std::borrow::Cow<[u8]> =
                                                                                    v372.encode(&*v370).0;
                                                                                let v376:
                                                                                        &[u8] =
                                                                                    v374.as_ref();
                                                                                let v378:
                                                                                        Result<&str,
                                                                                               std::str::Utf8Error> =
                                                                                    std::str::from_utf8(v376);
                                                                                let v380:
                                                                                        &str =
                                                                                    v378.unwrap();
                                                                                let v382:
                                                                                        std::string::String =
                                                                                    String::from(v380);
                                                                                let v385:
                                                                                        string =
                                                                                    sprintf!("! {}",
                                                                                             fable_library_rust::String_::fromString(v382.clone()));
                                                                                if v5
                                                                                   {
                                                                                    Documents::method99(Documents::US0::US0_0,
                                                                                                        Func0::new({
                                                                                                                       let v385
                                                                                                                           =
                                                                                                                           v385.clone();
                                                                                                                       move
                                                                                                                           ||
                                                                                                                           Documents::closure47(v385.clone(),
                                                                                                                                                ())
                                                                                                                   }),
                                                                                                        Func0::new(move
                                                                                                                       ||
                                                                                                                       Documents::closure48((),
                                                                                                                                            ())))
                                                                                } else {
                                                                                    printfn!("{0}",
                                                                                             v385.clone());
                                                                                    ()
                                                                                }
                                                                                {
                                                                                    let v395:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v382);
                                                                                    let v397:
                                                                                            &str =
                                                                                        &*v395;
                                                                                    String::from(v397)
                                                                                }
                                                                            }
                                                                            Documents::US23::US23_1(v367_1_0)
                                                                            =>
                                                                            {
                                                                                let v400:
                                                                                        std::string::String =
                                                                                    v367_1_0.clone();
                                                                                Documents::method97(Documents::US0::US0_4,
                                                                                                    Func0::new(move
                                                                                                                   ||
                                                                                                                   Documents::closure44((),
                                                                                                                                        ())),
                                                                                                    Func0::new({
                                                                                                                   let v400
                                                                                                                       =
                                                                                                                       v400.clone();
                                                                                                                   move
                                                                                                                       ||
                                                                                                                       Documents::closure45(v400.clone(),
                                                                                                                                            ())
                                                                                                               }));
                                                                                {
                                                                                    let v404:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v400.clone());
                                                                                    let v406:
                                                                                            &str =
                                                                                        &*v404;
                                                                                    String::from(v406)
                                                                                }
                                                                            }
                                                                        };
                                                                    let v411:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        Documents::method100(v360);
                                                                    let v413:
                                                                            Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                        v411.lock();
                                                                    let v415:
                                                                            std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                        v413.unwrap();
                                                                    let v417:
                                                                            &std::sync::mpsc::Sender<std::string::String> =
                                                                        &v415;
                                                                    let v419:
                                                                            Result<(),
                                                                                   std::sync::mpsc::SendError<std::string::String>> =
                                                                        v417.send(v410);
                                                                    let v420 =
                                                                        Documents::method101();
                                                                    let v422:
                                                                            Result<(),
                                                                                   std::string::String> =
                                                                        v419.map_err(|x| v420(x));
                                                                    let v424:
                                                                            _ =
                                                                        v422;
                                                                    let v426:
                                                                            bool =
                                                                        true; v424 }); //;
                                                    let v429: Result<(), string> =
                                                        Documents::method102(
                                                            _result.map_err(|x| x.into()),
                                                        );
                                                    let v431: string =
                                                        string("v429 });  // rust.fix_closure\'");
                                                    v429
                                                }); // rust.fix_closure';
                                                {
                                                    let v433: std::thread::JoinHandle<
                                                        Result<(), string>,
                                                    > = __result;
                                                    let _v436: LrcPtr<
                                                        MutCell<Option<Documents::US24>>,
                                                    > = refCell(None::<Documents::US24>);
                                                    {
                                                        let x_5: Option<Documents::US24> = match &v4
                                                        {
                                                            None => None::<Documents::US24>,
                                                            Some(v4_0_0) => {
                                                                let x_3 = v4_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_3 = x_3.clone();
                                                                    move || {
                                                                        Documents::US24::US24_0(
                                                                            x_3.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                        _v436.set(x_5)
                                                    }
                                                    {
                                                        let v463: Documents::US24 = defaultValue(
                                                            Documents::US24::US24_1,
                                                            _v436.get().clone(),
                                                        );
                                                        match &v463 {
                                                            Documents::US24::US24_0(v463_0_0) => {
                                                                let v472:
                                                                                            std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> =
                                                                                        Documents::method103(v247);
                                                                let v474:
                                                                                            Result<std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<Option<std::process::ChildStdin>>>> =
                                                                                        v472.lock();
                                                                let v476: std::sync::MutexGuard<
                                                                    Option<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                > = v474.unwrap();
                                                                let v478: bool = true;
                                                                let mut v476 = v476;
                                                                let v480: &mut Option<
                                                                    std::process::ChildStdin,
                                                                > = &mut v476;
                                                                let v482: Option<
                                                                    std::process::ChildStdin,
                                                                > = Option::take(v480);
                                                                let v484: bool = true;
                                                                let _result = v482.map(|x| { //;
                                                                                    let v486:
                                                                                            std::process::ChildStdin =
                                                                                        x;
                                                                                    let v488:
                                                                                            std::sync::Mutex<std::process::ChildStdin> =
                                                                                        std::sync::Mutex::new(v486);
                                                                                    let v490:
                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                        std::sync::Arc::new(v488);
                                                                                    let v492:
                                                                                            bool =
                                                                                        true; v490 });
                                                                let v494:
                                                                                            Option<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>> =
                                                                                        _result;
                                                                let _v497: LrcPtr<
                                                                    MutCell<
                                                                        Option<Documents::US25>,
                                                                    >,
                                                                > = refCell(
                                                                    None::<Documents::US25>,
                                                                );
                                                                {
                                                                    let x_8: Option<
                                                                        Documents::US25,
                                                                    > = match &v494 {
                                                                        None => {
                                                                            None::<Documents::US25>
                                                                        }
                                                                        Some(v494_0_0) => {
                                                                            let x_6:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        v494_0_0.clone();
                                                                            Some((Func0::new({
                                                                                let x_6 =
                                                                                    x_6.clone();
                                                                                move || {
                                                                                    Documents::US25::US25_0(x_6.clone())
                                                                                }
                                                                            }))(
                                                                            ))
                                                                        }
                                                                    };
                                                                    _v497.set(x_8)
                                                                }
                                                                {
                                                                    let v524: Documents::US25 =
                                                                        defaultValue(
                                                                            Documents::US25::US25_1,
                                                                            _v497.get().clone(),
                                                                        );
                                                                    match &v524 {
                                                                        Documents::US25::US25_0(
                                                                            v524_0_0,
                                                                        ) => {
                                                                            let v532:
                                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                    match &v524
                                                                                                        {
                                                                                                        Documents::US25::US25_0(x)
                                                                                                        =>
                                                                                                        x.clone(),
                                                                                                        _
                                                                                                        =>
                                                                                                        unreachable!(),
                                                                                                    };
                                                                            (match &v463
                                                                                                     {
                                                                                                     Documents::US24::US24_0(x)
                                                                                                     =>
                                                                                                     x.clone(),
                                                                                                     _
                                                                                                     =>
                                                                                                     unreachable!(),
                                                                                                 })(v532.clone());
                                                                            {
                                                                                let v533:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        Documents::method104(v532);
                                                                                let v535:
                                                                                                            Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                        v533.lock();
                                                                                let v538:
                                                                                                            std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                        Documents::method105(v535.unwrap());
                                                                                let v540: bool =
                                                                                    true;
                                                                                let mut v538 = v538;
                                                                                let v542: bool =
                                                                                    true;
                                                                                std::io::Write::flush(&mut *v538).unwrap();
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
                                                            let v543: std::sync::Arc<
                                                                std::sync::Mutex<
                                                                    Option<std::process::Child>,
                                                                >,
                                                            > = Documents::method94(v159);
                                                            let v545: Result<
                                                                std::sync::MutexGuard<
                                                                    Option<std::process::Child>,
                                                                >,
                                                                std::sync::PoisonError<
                                                                    std::sync::MutexGuard<
                                                                        Option<std::process::Child>,
                                                                    >,
                                                                >,
                                                            > = v543.lock();
                                                            let v547: std::sync::MutexGuard<
                                                                Option<std::process::Child>,
                                                            > = v545.unwrap();
                                                            let v549: bool = true;
                                                            let mut v547 = v547;
                                                            let v551: &mut Option<
                                                                std::process::Child,
                                                            > = &mut v547;
                                                            let v553: Option<std::process::Child> =
                                                                Option::take(v551);
                                                            let v555: std::process::Child =
                                                                v553.unwrap();
                                                            let v557: Result<
                                                                std::process::Output,
                                                                std::io::Error,
                                                            > = v555.wait_with_output();
                                                            let v558 = Documents::method45();
                                                            let v560: Result<
                                                                std::process::Output,
                                                                std::string::String,
                                                            > = v557.map_err(|x| v558(x));
                                                            let v561: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method106(v433);
                                                            let v564: string = string("v561");
                                                            let v565: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method106(v346);
                                                            let v570: string = append(
                                                                append(
                                                                    string("vec!["),
                                                                    append(string("v565, "), v564),
                                                                ),
                                                                string("]"),
                                                            );
                                                            let v571: Vec<
                                                                std::thread::JoinHandle<
                                                                    Result<(), string>,
                                                                >,
                                                            > = vec![v565, v561];
                                                            let v573: bool = true;
                                                            v571.into_iter().for_each(|x| {
                                                                //;
                                                                let v575: std::thread::JoinHandle<
                                                                    Result<(), string>,
                                                                > = x;
                                                                let v577: Result<
                                                                    Result<(), string>,
                                                                    Box<
                                                                        dyn core::any::Any
                                                                            + 'static
                                                                            + Send,
                                                                    >,
                                                                > = std::thread::JoinHandle::join(
                                                                    v575,
                                                                );
                                                                let v579: Result<(), string> =
                                                                    v577.unwrap();
                                                                v579.unwrap();
                                                                {
                                                                    let v582: bool = true;
                                                                    ()
                                                                }
                                                            });
                                                            {
                                                                //;
                                                                let v585: Documents::US26 =
                                                                    match &v560 {
                                                                        Err(v560_1_0) => {
                                                                            Documents::closure52(
                                                                                (),
                                                                                v560_1_0.clone(),
                                                                            )
                                                                        }
                                                                        Ok(v560_0_0) => {
                                                                            Documents::closure51(
                                                                                (),
                                                                                v560_0_0.clone(),
                                                                            )
                                                                        }
                                                                    };
                                                                match &v585 {
                                                                    Documents::US26::US26_0(
                                                                        v585_0_0,
                                                                    ) => {
                                                                        let v588:
                                                                                                    std::process::ExitStatus =
                                                                                                v585_0_0.clone().status;
                                                                        let v590: Option<i32> =
                                                                            v588.code();
                                                                        let _v593: LrcPtr<
                                                                            MutCell<
                                                                                Option<
                                                                                    Documents::US27,
                                                                                >,
                                                                            >,
                                                                        > = refCell(
                                                                            None::<Documents::US27>,
                                                                        );
                                                                        {
                                                                            let x_13: Option<
                                                                                Documents::US27,
                                                                            > = match &v590 {
                                                                                None => None::<
                                                                                    Documents::US27,
                                                                                >,
                                                                                Some(v590_0_0) => {
                                                                                    let x_11: i32 =
                                                                                        v590_0_0
                                                                                            .clone();
                                                                                    Some((Func0::new({
                                                                                                                                 let x_11
                                                                                                                                     =
                                                                                                                                     x_11.clone();
                                                                                                                                 move
                                                                                                                                     ||
                                                                                                                                     Documents::US27::US27_0(x_11)
                                                                                                                             }))())
                                                                                }
                                                                            };
                                                                            _v593.set(x_13)
                                                                        }
                                                                        {
                                                                            let v620:
                                                                                                        Documents::US27 =
                                                                                                    defaultValue(Documents::US27::US27_1,
                                                                                                                 _v593.get().clone());
                                                                            match &v620
                                                                                                    {
                                                                                                    Documents::US27::US27_0(v620_0_0)
                                                                                                    =>
                                                                                                    (match &v620
                                                                                                         {
                                                                                                         Documents::US27::US27_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     },
                                                                                                     Documents::US4::US4_1,
                                                                                                     Documents::US22::US22_0(v262.clone())),
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v633:
                                                                                                                &str =
                                                                                                            &*string("runtime.execute_with_options / exit_code=None");
                                                                                                        (-1_i32,
                                                                                                         Documents::US4::US4_0(String::from(v633)),
                                                                                                         Documents::US22::US22_0(v262.clone()))
                                                                                                    }
                                                                                                }
                                                                        }
                                                                    }
                                                                    Documents::US26::US26_1(
                                                                        v585_1_0,
                                                                    ) => {
                                                                        let v644:
                                                                                                    std::string::String =
                                                                                                v585_1_0.clone();
                                                                        Documents::method51(
                                                                            Documents::US0::US0_4,
                                                                            Func0::new(move || {
                                                                                Documents::closure53(
                                                                                    (),
                                                                                    (),
                                                                                )
                                                                            }),
                                                                            Func0::new({
                                                                                let v644 =
                                                                                    v644.clone();
                                                                                move || {
                                                                                    Documents::closure54(v644.clone(),
                                                                                                                                                        ())
                                                                                }
                                                                            }),
                                                                        );
                                                                        (
                                                                            -2_i32,
                                                                            Documents::US4::US4_0(
                                                                                v644.clone(),
                                                                            ),
                                                                            Documents::US22::US22_1,
                                                                        )
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        Documents::US21::US21_1(v158_1_0) => {
                                            let v656: std::string::String = v158_1_0.clone();
                                            Documents::method51(
                                                Documents::US0::US0_4,
                                                Func0::new(move || Documents::closure40((), ())),
                                                Func0::new({
                                                    let v656 = v656.clone();
                                                    move || Documents::closure41(v656.clone(), ())
                                                }),
                                            );
                                            (
                                                -1_i32,
                                                Documents::US4::US4_0(v656.clone()),
                                                Documents::US22::US22_1,
                                            )
                                        }
                                    };
                                let v667: Documents::US22 = patternInput_3.2.clone();
                                let v666: Documents::US4 = patternInput_3.1.clone();
                                let v665: i32 = patternInput_3.0.clone();
                                let v680: Option<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                > = match &v667 {
                                    Documents::US22::US22_0(v667_0_0) => Some(match &v667 {
                                        Documents::US22::US22_0(x) => x.clone(),
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
                                let v682: bool = true;
                                let _result = v680.map(|x| {
                                    //;
                                    let v685: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = Documents::method107(x);
                                    let v687: Result<
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
                                    > = v685.lock();
                                    let v689: std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = v687.unwrap();
                                    let v691 = v689.iter();
                                    let v693: Vec<std::string::String> = v691.collect::<Vec<_>>();
                                    let v695: bool = true;
                                    let _result: Vec<_> = v693
                                        .into_iter()
                                        .map(|x| {
                                            //;
                                            let v697: std::string::String = x;
                                            let v699: string =
                                                fable_library_rust::String_::fromString(v697);
                                            let v701: bool = true;
                                            v699
                                        })
                                        .collect::<Vec<_>>();
                                    let v703: Vec<string> = _result;
                                    let v720: string = join(
                                        string("\n"),
                                        toArray_1(ofArray_1(
                                            fable_library_rust::NativeArray_::array_from(v703),
                                        )),
                                    );
                                    let v728: bool = true;
                                    v720
                                });
                                let v730: Option<string> = _result;
                                let v737: Documents::US3 = match &v666 {
                                    Documents::US4::US4_0(v666_0_0) => Documents::US3::US3_0(
                                        fable_library_rust::String_::fromString(match &v666 {
                                            Documents::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }),
                                    ),
                                    _ => Documents::US3::US3_1,
                                };
                                let v744: string = defaultValue(
                                    match &v737 {
                                        Documents::US3::US3_0(v737_0_0) => match &v737 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => string(""),
                                    },
                                    v730,
                                );
                                Documents::method108(
                                    Documents::US0::US0_0,
                                    Func0::new(move || Documents::closure55((), ())),
                                    Func0::new({
                                        let v665 = v665.clone();
                                        let v744 = v744.clone();
                                        move || Documents::closure56(v665, v744.clone(), ())
                                    }),
                                );
                                LrcPtr::new((v665, v744.clone()))
                            }
                        }
                    }))();
                    _v50.set(Some(x_15))
                }
                {
                    let v755: LrcPtr<(i32, string)> = match &_v50.get().clone() {
                        None => panic!("{}", string("base.capture / _v50=None"),),
                        Some(_v50_0_0) => _v50_0_0.clone(),
                    };
                    _v9.set(Some((v755.0.clone(), v755.1.clone())));
                    {
                        let patternInput_4: (i32, string) = match &_v9.get().clone() {
                            None => panic!("{}", string("base.run_target / _v9=None"),),
                            Some(_v9_0_0) => _v9_0_0.clone(),
                        };
                        (patternInput_4.0.clone(), patternInput_4.1.clone())
                    }
                }
            }
        }
        pub fn method120(v0_1: string) -> string {
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v5: &str = &*v0_1;
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
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn method119(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method19(v2, Documents::method120(v1_1.clone()));
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
        pub fn closure71(unitVar: (), v0_1: string) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method121() -> Func1<string, Documents::US31> {
            Func1::new(move |v: string| Documents::closure71((), v))
        }
        pub fn closure72(unitVar: (), v0_1: std::string::String) -> Documents::US31 {
            Documents::US31::US31_1(v0_1)
        }
        pub fn method122() -> Func1<std::string::String, Documents::US31> {
            Func1::new(move |v: std::string::String| Documents::closure72((), v))
        }
        pub fn method123(v0_1: string) -> bool {
            let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v5: &str = &*v0_1;
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            {
                let x: bool = if v9.clone().exists() {
                    v9.is_file()
                } else {
                    false
                };
                _v3.set(Some(x))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> string {
            let v0_1: string =
                string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)");
            v0_1
        }
        pub fn closure74(
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
        ) -> (
            string,
            string,
            string,
            i32,
            string,
            i32,
            string,
            string,
            Documents::US3,
            string,
            string,
        ) {
            (v1_1, v2, v0_1, v4, v3, v7, v6, v9, v10, v5, v8)
        }
        pub fn method126(v0_1: LrcPtr<Documents::Mut4>, v1_1: Documents::US3) {
            Documents::method10(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method125(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: i32,
            v7: string,
            v8: string,
            v9: Documents::US3,
            v10: string,
            v11: string,
        ) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("file"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("real_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v2);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("relative_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v3);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("origin_hash_exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v4);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("origin_hash"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v5);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("local_git_hash_exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v6);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("local_git_hash"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v7);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("hash1"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v8);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("hash2"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method126(v0_1.clone(), v9);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("dist_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v10);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("cache_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v11);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure75(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(
                string,
                string,
                string,
                i32,
                string,
                i32,
                string,
                string,
                Documents::US3,
                string,
                string,
            )>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (
                                string,
                                string,
                                string,
                                i32,
                                string,
                                i32,
                                string,
                                string,
                                Documents::US3,
                                string,
                                string,
                            ) = v2();
                            let v1227: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method125(
                                v1227.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                                patternInput_1.5.clone(),
                                patternInput_1.6.clone(),
                                patternInput_1.7.clone(),
                                patternInput_1.8.clone(),
                                patternInput_1.9.clone(),
                                patternInput_1.10.clone(),
                            );
                            {
                                let v1228: string = v1227.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1228
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method124(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(
                string,
                string,
                string,
                i32,
                string,
                i32,
                string,
                string,
                Documents::US3,
                string,
                string,
            )>,
        ) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure75(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method128(v0_1: string) -> string {
            v0_1
        }
        pub fn method127(v0_1: string, v1_1: string) {
            let _v4: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v5: string = Documents::method128(v0_1);
            let v7: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v5);
            let v9: u64 = v7.unwrap();
            _v4.set(Some(()));
            match &_v4.get().clone() {
                None => panic!("{}", string("base.run_target / _v4=None"),),
                Some(_v4_0_0) => _v4_0_0.clone(),
            }
            ()
        }
        pub fn method130(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method131(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method132(v0_1: string) -> string {
            v0_1
        }
        pub fn method133(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure78(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v2: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                Documents::method104(v1_1);
            let v4: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v2.lock();
            let v6: std::sync::MutexGuard<std::process::ChildStdin> = v4.unwrap();
            let v7: string = Documents::method132(v0_1);
            let v9: &[u8] = v7.as_bytes();
            let v10: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method133(v6);
            let v12: bool = true;
            let mut v10 = v10;
            let v14: bool = true;
            std::io::Write::write_all(&mut *v10, v9).unwrap();
            ()
        }
        pub fn method134(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method135(v0_1: string) -> string {
            v0_1
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure80(v0_1: string, v1_1: i32, v2: string, unitVar: ()) -> (i32, i32, string) {
            (v1_1, length(v2), v0_1)
        }
        pub fn method137(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: i32, v3: string) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("result_len"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v2);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("output_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v3);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure81(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, i32, string)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, i32, string) = v2();
                            let v1219: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method137(
                                v1219.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            );
                            {
                                let v1220: string = v1219.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1220
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method136(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, i32, string)>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure81(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method129(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US32 {
            let _v6: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v9: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
            {
                let x: Vec<u8> = std::fs::read(&*v3).unwrap();
                _v9.set(Some(x))
            }
            {
                let v66: Vec<u8> = Documents::method130(match &_v9.get().clone() {
                    None => panic!("{}", string("base.run_target / _v9=None"),),
                    Some(_v9_0_0) => _v9_0_0.clone(),
                });
                let v68: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v66);
                let v70: std::string::String = v68.unwrap();
                {
                    let x_2: string = fable_library_rust::String_::fromString(v70);
                    _v6.set(Some(x_2))
                }
                {
                    let v126: Array<string> = split(
                        match &_v6.get().clone() {
                            None => panic!("{}", string("base.run_target / _v6=None"),),
                            Some(_v6_0_0) => _v6_0_0.clone(),
                        },
                        string("\n"),
                        -1_i32,
                        0_i32,
                    );
                    let v127: i32 = count_2(v126.clone());
                    let v128: Array<string> = new_init(&string(""), v127);
                    let v129: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method37(v127, v129.clone()) {
                        let v131: i32 = v129.l0.get().clone();
                        let v134: string = trim(v126[v131].clone());
                        v128.get_mut()[v131 as usize] = v134;
                        {
                            let v135: i32 = v131 + 1_i32;
                            v129.l0.set(v135);
                            ()
                        }
                    }
                    {
                        let v136: i32 = count_2(v128.clone());
                        let v137: Array<string> = new_init(&string(""), v136);
                        let v138: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                        });
                        while Documents::method131(v136, v138.clone()) {
                            let v140: i32 = v138.l0.get().clone();
                            let v141: i32 = v138.l1.get().clone();
                            let v142: string = v128[v140].clone();
                            let v154: i32 = if string("") != v142.clone() {
                                v137.get_mut()[v141 as usize] = v142;
                                v141 + 1_i32
                            } else {
                                v141
                            };
                            let v155: i32 = v140 + 1_i32;
                            v138.l0.set(v155);
                            v138.l1.set(v154);
                            ()
                        }
                        {
                            let v156: i32 = v138.l1.get().clone();
                            let v157: Array<string> = new_init(&string(""), v156);
                            let v158: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method37(v156, v158.clone()) {
                                let v160: i32 = v158.l0.get().clone();
                                let v161: string = v137[v160].clone();
                                v157.get_mut()[v160 as usize] = v161;
                                {
                                    let v162: i32 = v160 + 1_i32;
                                    v158.l0.set(v162);
                                    ()
                                }
                            }
                            {
                                let v183: string = sprintf!(
                                    "{}\n\n",
                                    join(
                                        string("\n"),
                                        toArray_1(delay(Func0::new({
                                            let v157 = v157.clone();
                                            move || {
                                                map(
                                                    Func1::new({
                                                        let v157 = v157.clone();
                                                        move |i: i32| v157[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count_2(v157.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        })))
                                    )
                                );
                                let _v191: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_4: bool = cfg!(windows);
                                    _v191.set(Some(x_4))
                                }
                                {
                                    let patternInput: (i32, string) =
                                        Documents::method58(sprintf!("{} {}",
                                                                     Documents::method19(v0_1,
                                                                                         sprintf!("../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                                                                                  if match &_v191.get().clone()
                                                                                                         {
                                                                                                         None
                                                                                                         =>
                                                                                                         panic!("{}",
                                                                                                                string("base.run_target / _v191=None"),),
                                                                                                         Some(_v191_0_0)
                                                                                                         =>
                                                                                                         _v191_0_0.clone(),
                                                                                                     }
                                                                                                     {
                                                                                                      string(".exe")
                                                                                                  } else {
                                                                                                      string("")
                                                                                                  })),
                                                                     v1_1),
                                                            None::<CancellationToken>,
                                                            new_empty::<(string,
                                                                         string)>(),
                                                            None::<Func1<(i32,
                                                                          string,
                                                                          bool),
                                                                         Arc<Async<()>>>>,
                                                            Some(Func1::new({
                                                                                let v183
                                                                                    =
                                                                                    v183.clone();
                                                                                move
                                                                                    |v:
                                                                                         std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>|
                                                                                    Documents::closure78(v183.clone(),
                                                                                                         v)
                                                                            })),
                                                            true,
                                                            None::<string>);
                                    let v236: i32 = patternInput.0.clone();
                                    let v238: Array<string> =
                                        split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                                    let v239: i32 = count_2(v238.clone());
                                    let v241: LrcPtr<Documents::Mut8> =
                                        LrcPtr::new(Documents::Mut8 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(string("")),
                                            l2: MutCell::new(0_i32),
                                            l3: MutCell::new(0_i32),
                                        });
                                    while Documents::method134(v136, v241.clone()) {
                                        let v243: i32 = v241.l0.get().clone();
                                        let matchValue: string = v241.l1.get().clone();
                                        let matchValue_1: i32 = v241.l2.get().clone();
                                        let v246: i32 = v241.l3.get().clone();
                                        let v245: i32 = matchValue_1;
                                        let v244: string = matchValue;
                                        let patternInput_2: (string, i32, i32) = if v128[v243]
                                            .clone()
                                            == string("")
                                        {
                                            (
                                                sprintf!("{}\n", v244.clone()),
                                                v245 + 1_i32,
                                                v246 + 1_i32,
                                            )
                                        } else {
                                            let v252: i32 = v245 - v246;
                                            (
                                                if v252 >= v239 {
                                                    v244.clone()
                                                } else {
                                                    let v254: string = v238[v252].clone();
                                                    if v252 == v239 - 1_i32 {
                                                        sprintf!("{}{}", v244.clone(), v254.clone())
                                                    } else {
                                                        sprintf!("{}{}\n", v244, v254)
                                                    }
                                                },
                                                v245 + 1_i32,
                                                v246,
                                            )
                                        };
                                        let v265: i32 = v243 + 1_i32;
                                        v241.l0.set(v265);
                                        v241.l1.set(patternInput_2.0.clone());
                                        v241.l2.set(patternInput_2.1.clone());
                                        v241.l3.set(patternInput_2.2.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_3: string = v241.l1.get().clone();
                                        let matchValue_4: i32 = v241.l2.get().clone();
                                        let matchValue_5: i32 = v241.l3.get().clone();
                                        let v266: string = matchValue_3;
                                        let _v271: MutCell<Option<()>> = MutCell::new(None::<()>);
                                        std::fs::write(&*v2.clone(), &*v266.clone()).unwrap();
                                        _v271.set(Some(()));
                                        match &_v271.get().clone() {
                                            None => {
                                                panic!("{}", string("base.run_target / _v271=None"),)
                                            }
                                            Some(_v271_0_0) => _v271_0_0.clone(),
                                        }
                                        Documents::method136(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure79((), ())),
                                            Func0::new({
                                                let v2 = v2.clone();
                                                let v236 = v236.clone();
                                                let v266 = v266.clone();
                                                move || {
                                                    Documents::closure80(
                                                        v2.clone(),
                                                        v236,
                                                        v266.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::US32::US32_0(v236, v266.clone())
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn closure82(unitVar: (), unitVar_1: ()) -> string {
            string("documents.files_fn / error")
        }
        pub fn closure83(v0_1: string, v1_1: i32, unitVar: ()) -> (i32, string) {
            (v1_1, v0_1)
        }
        pub fn method139(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: string) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("result"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v2);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure84(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, string)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, string) = v2();
                            let v1218: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method139(
                                v1218.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v1219: string = v1218.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1219
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method138(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, string)>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure84(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure77(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method119(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method123(v6.clone()) {
                Documents::method123(v7.clone())
            } else {
                false
            } {
                let v11: string = Documents::method32(v6.clone());
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
                    let v29: usize = 0_i32 as usize;
                    let v37: _ = [0_u8; 1024];
                    let v39: bool = true;
                    loop {
                        // rust.loop;
                        let v41: bool = true;
                        let mut v37 = v37;
                        let v43: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v19, &mut v37);
                        let v45: usize = v43.unwrap();
                        if v45 == v29 {
                            let v56: bool = true;
                            break;
                            ()
                        }
                        {
                            let v58: usize = v37.len();
                            let v61: u8 = v58 as u8;
                            let v70: usize = v45;
                            let v99: &_ = if v70 == v58 {
                                &v37[v29..]
                            } else {
                                &v37[v29..v70]
                            };
                            sha2::Digest::update(&mut v24, v99);
                            {
                                let v102: bool = true;
                            } // rust.loop;
                            let v104: bool = true;
                        } // rust.loop;
                        let v106: bool = true;
                    } // rust.loop;
                    let v108: bool = true;
                    {
                        // rust.loop;
                        let v110: bool = true;
                        {
                            // rust.loop;
                            let v112: &[u8] = &sha2::Digest::finalize(v24);
                            let v114: Vec<u8> = v112.iter().map(|x| *x).collect::<Vec<_>>();
                            let v116: bool = true;
                            let _result: Vec<_> = v114
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v118: u8 = x;
                                    let v120: std::string::String = format!("{:02x}", v118);
                                    let v122: string =
                                        fable_library_rust::String_::fromString(v120);
                                    let v124: bool = true;
                                    v122
                                })
                                .collect::<Vec<_>>();
                            let v126: Vec<string> = _result;
                            let v128: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v126);
                            let v143: string = join(
                                string(""),
                                toArray_1(delay(Func0::new({
                                    let v128 = v128.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v128 = v128.clone();
                                                move |i: i32| v128[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v128.clone()) - 1_i32,
                                            ),
                                        )
                                    }
                                }))),
                            );
                            let v151 = Documents::method45();
                            let v153: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v143).map_err(|x| v151(x));
                            let v154 = Documents::method121();
                            let v155 = Documents::method122();
                            let v157: Documents::US31 = match v153 {
                                Ok(x) => v154(x),
                                Err(e) => v155(e),
                            };
                            let v163: string = match &v157 {
                                Documents::US31::US31_0(v157_0_0) => v157_0_0.clone(),
                                Documents::US31::US31_1(v157_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v157_1_0.clone()
                                    ),
                                ),
                            };
                            let v164: string = Documents::method32(v7.clone());
                            let v166: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v164);
                            let v168: std::fs::File = v166.unwrap();
                            let v170: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v168);
                            let v172: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v170);
                            let v174: bool = true;
                            let mut v172 = v172;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v177: sha2::Sha256 = result;
                                let v179: bool = true;
                                let mut v177 = v177;
                                let v182: usize = 0_i32 as usize;
                                let v190: _ = [0_u8; 1024];
                                let v192: bool = true;
                                loop {
                                    // rust.loop;
                                    let v194: bool = true;
                                    let mut v190 = v190;
                                    let v196: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v172, &mut v190);
                                    let v198: usize = v196.unwrap();
                                    if v198 == v182 {
                                        let v209: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v211: usize = v190.len();
                                        let v214: u8 = v211 as u8;
                                        let v223: usize = v198;
                                        let v252: &_ = if v223 == v211 {
                                            &v190[v182..]
                                        } else {
                                            &v190[v182..v223]
                                        };
                                        sha2::Digest::update(&mut v177, v252);
                                        {
                                            let v255: bool = true;
                                        } // rust.loop;
                                        let v257: bool = true;
                                    } // rust.loop;
                                    let v259: bool = true;
                                } // rust.loop;
                                let v261: bool = true;
                                {
                                    // rust.loop;
                                    let v263: bool = true;
                                    {
                                        // rust.loop;
                                        let v265: &[u8] = &sha2::Digest::finalize(v177);
                                        let v267: Vec<u8> =
                                            v265.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v269: bool = true;
                                        let _result: Vec<_> = v267
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v271: u8 = x;
                                                let v273: std::string::String =
                                                    format!("{:02x}", v271);
                                                let v275: string =
                                                    fable_library_rust::String_::fromString(v273);
                                                let v277: bool = true;
                                                v275
                                            })
                                            .collect::<Vec<_>>();
                                        let v279: Vec<string> = _result;
                                        let v281: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v279);
                                        let v295: string = join(
                                            string(""),
                                            toArray_1(delay(Func0::new({
                                                let v281 = v281.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v281 = v281.clone();
                                                            move |i_1: i32| v281[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v281.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v303 = Documents::method45();
                                        let v305: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v295).map_err(|x| v303(x));
                                        let v306 = Documents::method121();
                                        let v307 = Documents::method122();
                                        let v309: Documents::US31 = match v305 {
                                            Ok(x) => v306(x),
                                            Err(e) => v307(e),
                                        };
                                        v163 == match &v309 {
                                            Documents::US31::US31_0(v309_0_0) => v309_0_0.clone(),
                                            Documents::US31::US31_1(v309_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v309_1_0.clone()
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
                let v319: Documents::US32 = Documents::method129(v2, v3, v6.clone(), v4);
                match &v319 {
                    Documents::US32::US32_0(v319_0_0, v319_0_1) => {
                        let v321: string = v319_0_1.clone();
                        let v320: i32 = v319_0_0.clone();
                        if v320 != 0_i32 {
                            Documents::method138(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure82((), ())),
                                Func0::new({
                                    let v320 = v320.clone();
                                    let v321 = v321.clone();
                                    move || Documents::closure83(v321.clone(), v320, ())
                                }),
                            );
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v321.clone())),
                            ))
                        } else {
                            if Documents::method123(v6.clone()) {
                                Documents::method127(v7, v6.clone())
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
                    Documents::US32::US32_1(v319_1_0, v319_1_1) => {
                        Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v319_1_1.clone())),
                        ))
                    }
                }
            } else {
                Documents::US30::US30_1
            }
        }
        pub fn closure76(
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
                    Documents::closure77(
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
        pub fn closure87(unitVar: (), unitVar_1: ()) -> string {
            string("documents.crowbook / result contains ERROR")
        }
        pub fn closure88(
            v0_1: string,
            v1_1: string,
            v2: i32,
            unitVar: (),
        ) -> (i32, string, string) {
            (v2, v0_1, v1_1)
        }
        pub fn method142(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: string, v3: string) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("exit_code"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method110(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("output_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v2);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("result"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v3);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure89(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, string, string)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, string, string) = v2();
                            let v1219: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method142(
                                v1219.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            );
                            {
                                let v1220: string = v1219.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1220
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method141(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, string, string)>,
        ) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure89(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method140(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (i32, string) = Documents::method58(
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
            let v67: string = patternInput.1.clone();
            let v66: i32 = patternInput.0.clone();
            if contains(v67.clone(), string("ERROR")) {
                Documents::method141(
                    Documents::US0::US0_3,
                    Func0::new(move || Documents::closure87((), ())),
                    Func0::new({
                        let v1_1 = v1_1.clone();
                        let v66 = v66.clone();
                        let v67 = v67.clone();
                        move || Documents::closure88(v1_1.clone(), v67.clone(), v66, ())
                    }),
                );
                Documents::US32::US32_1(v66, v67.clone())
            } else {
                Documents::US32::US32_0(v66, v67.clone())
            }
        }
        pub fn closure86(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method119(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method123(v5.clone()) {
                Documents::method123(v6.clone())
            } else {
                false
            } {
                let v10: string = Documents::method32(v5.clone());
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
                    let v28: usize = 0_i32 as usize;
                    let v36: _ = [0_u8; 1024];
                    let v38: bool = true;
                    loop {
                        // rust.loop;
                        let v40: bool = true;
                        let mut v36 = v36;
                        let v42: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v18, &mut v36);
                        let v44: usize = v42.unwrap();
                        if v44 == v28 {
                            let v55: bool = true;
                            break;
                            ()
                        }
                        {
                            let v57: usize = v36.len();
                            let v60: u8 = v57 as u8;
                            let v69: usize = v44;
                            let v98: &_ = if v69 == v57 {
                                &v36[v28..]
                            } else {
                                &v36[v28..v69]
                            };
                            sha2::Digest::update(&mut v23, v98);
                            {
                                let v101: bool = true;
                            } // rust.loop;
                            let v103: bool = true;
                        } // rust.loop;
                        let v105: bool = true;
                    } // rust.loop;
                    let v107: bool = true;
                    {
                        // rust.loop;
                        let v109: bool = true;
                        {
                            // rust.loop;
                            let v111: &[u8] = &sha2::Digest::finalize(v23);
                            let v113: Vec<u8> = v111.iter().map(|x| *x).collect::<Vec<_>>();
                            let v115: bool = true;
                            let _result: Vec<_> = v113
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v117: u8 = x;
                                    let v119: std::string::String = format!("{:02x}", v117);
                                    let v121: string =
                                        fable_library_rust::String_::fromString(v119);
                                    let v123: bool = true;
                                    v121
                                })
                                .collect::<Vec<_>>();
                            let v125: Vec<string> = _result;
                            let v127: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v125);
                            let v142: string = join(
                                string(""),
                                toArray_1(delay(Func0::new({
                                    let v127 = v127.clone();
                                    move || {
                                        map(
                                            Func1::new({
                                                let v127 = v127.clone();
                                                move |i: i32| v127[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v127.clone()) - 1_i32,
                                            ),
                                        )
                                    }
                                }))),
                            );
                            let v150 = Documents::method45();
                            let v152: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v142).map_err(|x| v150(x));
                            let v153 = Documents::method121();
                            let v154 = Documents::method122();
                            let v156: Documents::US31 = match v152 {
                                Ok(x) => v153(x),
                                Err(e) => v154(e),
                            };
                            let v162: string = match &v156 {
                                Documents::US31::US31_0(v156_0_0) => v156_0_0.clone(),
                                Documents::US31::US31_1(v156_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v156_1_0.clone()
                                    ),
                                ),
                            };
                            let v163: string = Documents::method32(v6.clone());
                            let v165: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v163);
                            let v167: std::fs::File = v165.unwrap();
                            let v169: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v167);
                            let v171: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v169);
                            let v173: bool = true;
                            let mut v171 = v171;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v176: sha2::Sha256 = result;
                                let v178: bool = true;
                                let mut v176 = v176;
                                let v181: usize = 0_i32 as usize;
                                let v189: _ = [0_u8; 1024];
                                let v191: bool = true;
                                loop {
                                    // rust.loop;
                                    let v193: bool = true;
                                    let mut v189 = v189;
                                    let v195: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v171, &mut v189);
                                    let v197: usize = v195.unwrap();
                                    if v197 == v181 {
                                        let v208: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v210: usize = v189.len();
                                        let v213: u8 = v210 as u8;
                                        let v222: usize = v197;
                                        let v251: &_ = if v222 == v210 {
                                            &v189[v181..]
                                        } else {
                                            &v189[v181..v222]
                                        };
                                        sha2::Digest::update(&mut v176, v251);
                                        {
                                            let v254: bool = true;
                                        } // rust.loop;
                                        let v256: bool = true;
                                    } // rust.loop;
                                    let v258: bool = true;
                                } // rust.loop;
                                let v260: bool = true;
                                {
                                    // rust.loop;
                                    let v262: bool = true;
                                    {
                                        // rust.loop;
                                        let v264: &[u8] = &sha2::Digest::finalize(v176);
                                        let v266: Vec<u8> =
                                            v264.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v268: bool = true;
                                        let _result: Vec<_> = v266
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v270: u8 = x;
                                                let v272: std::string::String =
                                                    format!("{:02x}", v270);
                                                let v274: string =
                                                    fable_library_rust::String_::fromString(v272);
                                                let v276: bool = true;
                                                v274
                                            })
                                            .collect::<Vec<_>>();
                                        let v278: Vec<string> = _result;
                                        let v280: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v278);
                                        let v294: string = join(
                                            string(""),
                                            toArray_1(delay(Func0::new({
                                                let v280 = v280.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v280 = v280.clone();
                                                            move |i_1: i32| v280[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v280.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v302 = Documents::method45();
                                        let v304: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v294).map_err(|x| v302(x));
                                        let v305 = Documents::method121();
                                        let v306 = Documents::method122();
                                        let v308: Documents::US31 = match v304 {
                                            Ok(x) => v305(x),
                                            Err(e) => v306(e),
                                        };
                                        v162 == match &v308 {
                                            Documents::US31::US31_0(v308_0_0) => v308_0_0.clone(),
                                            Documents::US31::US31_1(v308_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v308_1_0.clone()
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
                let v318: Documents::US32 = Documents::method140(v2, v5.clone(), v3, v1_1, v4);
                match &v318 {
                    Documents::US32::US32_0(v318_0_0, v318_0_1) => {
                        let v320: string = v318_0_1.clone();
                        let v319: i32 = v318_0_0.clone();
                        if v319 != 0_i32 {
                            Documents::method138(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure82((), ())),
                                Func0::new({
                                    let v319 = v319.clone();
                                    let v320 = v320.clone();
                                    move || Documents::closure83(v320.clone(), v319, ())
                                }),
                            );
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v320.clone())),
                            ))
                        } else {
                            if Documents::method123(v5.clone()) {
                                Documents::method127(v6, v5.clone())
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
                    Documents::US32::US32_1(v318_1_0, v318_1_1) => {
                        Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v318_1_1.clone())),
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
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US30> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure86(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn closure90(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files\' = [] / listm.iter")
        }
        pub fn closure91(v0_1: string, v1_1: string, unitVar: ()) -> (string, string) {
            (v1_1, v0_1)
        }
        pub fn method144(v0_1: LrcPtr<Documents::Mut4>, v1_1: string, v2: string) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("output_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v1_1);
            Documents::method10(v0_1.clone(), string("; "));
            Documents::method10(v0_1.clone(), string("output_cache_path"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method10(v0_1.clone(), v2);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure92(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(string, string)>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (string, string) = v2();
                            let v1218: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method144(
                                v1218.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v1219: string = v1218.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1219
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method143(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(string, string)>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure92(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method145(
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
                    Documents::method145(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method146(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method147(
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
                    Documents::method147(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure93(
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
        pub fn method148(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method149(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn closure28(
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
            let v6: string = Documents::method30(v5);
            let v8: &str = &*v6.clone();
            let v10: std::string::String = String::from(v8);
            let v12: std::path::PathBuf = std::path::PathBuf::from(v10);
            let v14: std::path::Display = v12.display();
            let _v17: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v14);
                _v17.set(Some(x))
            }
            {
                let v51: std::string::String = match &_v17.get().clone() {
                    None => panic!("{}", string("base.run_target / _v17=None"),),
                    Some(_v17_0_0) => _v17_0_0.clone(),
                };
                let v73: string = sprintf!(
                    ".{}",
                    replace(
                        replace(
                            fable_library_rust::String_::fromString(v51),
                            v3.clone(),
                            string("")
                        ),
                        string("\\"),
                        string("/")
                    )
                );
                let v74: string = Documents::method32(v6);
                let v76: string = Documents::method57(Documents::method19(v2.clone(), v73.clone()));
                let patternInput: (i32, string) = Documents::method58(
                    sprintf!(
                        "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                        v76.clone()
                    ),
                    None::<CancellationToken>,
                    new_empty::<(string, string)>(),
                    None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v2),
                );
                let v94: string = patternInput.1.clone();
                let v96: string = Documents::method57(Documents::method19(v3.clone(), v73.clone()));
                let patternInput_1: (i32, string) = Documents::method58(
                    sprintf!("git hash-object \"{}\"", v96.clone()),
                    None::<CancellationToken>,
                    new_empty::<(string, string)>(),
                    None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v3.clone()),
                );
                let v114: string = patternInput_1.1.clone();
                let v116: string =
                    Documents::method57(Documents::method19(v4.clone(), v73.clone()));
                let v118: string =
                    (Documents::method119(string("hangul.md"), v96.clone(), v4.clone()))
                        .0
                        .clone();
                let v488: LrcPtr<Documents::UH4> = if contains(v94.clone(), v114.clone()) == false {
                    let v136: string = Documents::method32(v96.clone());
                    let v138: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v136);
                    let v140: std::fs::File = v138.unwrap();
                    let v142: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v140);
                    let v144: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                        std::io::BufReader::new(v142);
                    let v146: bool = true;
                    let mut v144 = v144;
                    let result: sha2::Sha256 = sha2::Digest::new();
                    {
                        let v149: sha2::Sha256 = result;
                        let v151: bool = true;
                        let mut v149 = v149;
                        let v154: usize = 0_i32 as usize;
                        let v162: _ = [0_u8; 1024];
                        let v164: bool = true;
                        loop {
                            // rust.loop;
                            let v166: bool = true;
                            let mut v162 = v162;
                            let v168: Result<usize, std::io::Error> =
                                std::io::Read::read(&mut v144, &mut v162);
                            let v170: usize = v168.unwrap();
                            if v170 == v154 {
                                let v181: bool = true;
                                break;
                                ()
                            }
                            {
                                let v183: usize = v162.len();
                                let v186: u8 = v183 as u8;
                                let v195: usize = v170;
                                let v224: &_ = if v195 == v183 {
                                    &v162[v154..]
                                } else {
                                    &v162[v154..v195]
                                };
                                sha2::Digest::update(&mut v149, v224);
                                {
                                    let v227: bool = true;
                                } // rust.loop;
                                let v229: bool = true;
                            } // rust.loop;
                            let v231: bool = true;
                        } // rust.loop;
                        let v233: bool = true;
                        {
                            // rust.loop;
                            let v235: bool = true;
                            {
                                // rust.loop;
                                let v237: &[u8] = &sha2::Digest::finalize(v149);
                                let v239: Vec<u8> = v237.iter().map(|x| *x).collect::<Vec<_>>();
                                let v241: bool = true;
                                let _result: Vec<_> = v239
                                    .into_iter()
                                    .map(|x| {
                                        //;
                                        let v243: u8 = x;
                                        let v245: std::string::String = format!("{:02x}", v243);
                                        let v247: string =
                                            fable_library_rust::String_::fromString(v245);
                                        let v249: bool = true;
                                        v247
                                    })
                                    .collect::<Vec<_>>();
                                let v251: Vec<string> = _result;
                                let v253: Array<string> =
                                    fable_library_rust::NativeArray_::array_from(v251);
                                let v267: string = join(
                                    string(""),
                                    toArray_1(delay(Func0::new({
                                        let v253 = v253.clone();
                                        move || {
                                            map(
                                                Func1::new({
                                                    let v253 = v253.clone();
                                                    move |i: i32| v253[i].clone()
                                                }),
                                                rangeNumeric(
                                                    0_i32,
                                                    1_i32,
                                                    count_2(v253.clone()) - 1_i32,
                                                ),
                                            )
                                        }
                                    }))),
                                );
                                let v275 = Documents::method45();
                                let v277: Result<string, std::string::String> =
                                    Ok::<string, std::io::Error>(v267).map_err(|x| v275(x));
                                let v278 = Documents::method121();
                                let v279 = Documents::method122();
                                let v281: Documents::US31 = match v277 {
                                    Ok(x) => v278(x),
                                    Err(e) => v279(e),
                                };
                                let v287: string = match &v281 {
                                    Documents::US31::US31_0(v281_0_0) => v281_0_0.clone(),
                                    Documents::US31::US31_1(v281_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v281_1_0.clone()
                                        ),
                                    ),
                                };
                                let v443: Documents::US3 = if Documents::method123(v116.clone())
                                    == false
                                {
                                    Documents::US3::US3_1
                                } else {
                                    let v291: string = Documents::method32(v116.clone());
                                    let v293: Result<std::fs::File, std::io::Error> =
                                        std::fs::File::open(&*v291);
                                    let v295: std::fs::File = v293.unwrap();
                                    let v297: std::io::BufReader<std::fs::File> =
                                        std::io::BufReader::new(v295);
                                    let v299: std::io::BufReader<
                                        std::io::BufReader<std::fs::File>,
                                    > = std::io::BufReader::new(v297);
                                    let v301: bool = true;
                                    let mut v299 = v299;
                                    let result: sha2::Sha256 = sha2::Digest::new();
                                    {
                                        let v304: sha2::Sha256 = result;
                                        let v306: bool = true;
                                        let mut v304 = v304;
                                        let v309: usize = 0_i32 as usize;
                                        let v317: _ = [0_u8; 1024];
                                        let v319: bool = true;
                                        loop {
                                            // rust.loop;
                                            let v321: bool = true;
                                            let mut v317 = v317;
                                            let v323: Result<usize, std::io::Error> =
                                                std::io::Read::read(&mut v299, &mut v317);
                                            let v325: usize = v323.unwrap();
                                            if v325 == v309 {
                                                let v336: bool = true;
                                                break;
                                                ()
                                            }
                                            {
                                                let v338: usize = v317.len();
                                                let v341: u8 = v338 as u8;
                                                let v350: usize = v325;
                                                let v379: &_ = if v350 == v338 {
                                                    &v317[v309..]
                                                } else {
                                                    &v317[v309..v350]
                                                };
                                                sha2::Digest::update(&mut v304, v379);
                                                {
                                                    let v382: bool = true;
                                                } // rust.loop;
                                                let v384: bool = true;
                                            } // rust.loop;
                                            let v386: bool = true;
                                        } // rust.loop;
                                        let v388: bool = true;
                                        {
                                            // rust.loop;
                                            let v390: bool = true;
                                            {
                                                // rust.loop;
                                                let v392: &[u8] = &sha2::Digest::finalize(v304);
                                                let v394: Vec<u8> =
                                                    v392.iter().map(|x| *x).collect::<Vec<_>>();
                                                let v396: bool = true;
                                                let _result: Vec<_> = v394
                                                    .into_iter()
                                                    .map(|x| {
                                                        //;
                                                        let v398: u8 = x;
                                                        let v400: std::string::String =
                                                            format!("{:02x}", v398);
                                                        let v402: string =
                                                            fable_library_rust::String_::fromString(
                                                                v400,
                                                            );
                                                        let v404: bool = true;
                                                        v402
                                                    })
                                                    .collect::<Vec<_>>();
                                                let v406: Vec<string> = _result;
                                                let v408: Array<string> =
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v406,
                                                    );
                                                let v422: string = join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v408 = v408.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v408 = v408.clone();
                                                                    move |i_1: i32| {
                                                                        v408[i_1].clone()
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    count_2(v408.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                );
                                                let v430 = Documents::method45();
                                                let v432: Result<string, std::string::String> =
                                                    Ok::<string, std::io::Error>(v422)
                                                        .map_err(|x| v430(x));
                                                let v433 = Documents::method121();
                                                let v434 = Documents::method122();
                                                let v436: Documents::US31 = match v432 {
                                                    Ok(x) => v433(x),
                                                    Err(e) => v434(e),
                                                };
                                                match &v436 {
                                                    Documents::US31::US31_0(v436_0_0) => {
                                                        Documents::US3::US3_0(v436_0_0.clone())
                                                    }
                                                    _ => Documents::US3::US3_1,
                                                }
                                            }
                                        }
                                    }
                                };
                                if if if let Documents::US3::US3_1 = &v443 {
                                    true
                                } else {
                                    false
                                } {
                                    true
                                } else {
                                    v287.clone()
                                        != match &v443 {
                                            Documents::US3::US3_0(v443_0_0) => match &v443 {
                                                Documents::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        }
                                } {
                                    Documents::method124(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure73((), ())),
                                        Func0::new({
                                            let patternInput = patternInput.clone();
                                            let patternInput_1 = patternInput_1.clone();
                                            let v114 = v114.clone();
                                            let v116 = v116.clone();
                                            let v287 = v287.clone();
                                            let v443 = v443.clone();
                                            let v73 = v73.clone();
                                            let v74 = v74.clone();
                                            let v76 = v76.clone();
                                            let v94 = v94.clone();
                                            let v96 = v96.clone();
                                            move || {
                                                Documents::closure74(
                                                    v73.clone(),
                                                    v74.clone(),
                                                    v76.clone(),
                                                    v94.clone(),
                                                    patternInput.0.clone(),
                                                    v96.clone(),
                                                    v114.clone(),
                                                    patternInput_1.0.clone(),
                                                    v116.clone(),
                                                    v287.clone(),
                                                    v443.clone(),
                                                    (),
                                                )
                                            }
                                        }),
                                    );
                                    Documents::method127(v116.clone(), v96.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v96.clone(),
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
                                                            Documents::closure76(
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
                                            LrcPtr::new(Documents::UH5::UH5_0),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("html"),
                                                v96.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure85(
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
                                                    v96.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure85(
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
                                                        v96.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure85(
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
                                                            v118.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure85(
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
                                                                v118.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure85(
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
                                                                    v118.clone(),
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
                                                                                                                                                                                                                                                                                                                                                               Documents::closure85(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    true,
                                                                                                                                                                                                                                                                                                                                                                                    v_6)
                                                                                                                                                                                                                                                                                                                                                       }))(b0)(b1)
                                                                    }),
                                                                    LrcPtr::new(
                                                                        Documents::UH5::UH5_0,
                                                                    ),
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
                let v599: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method145(
                    if (if let Documents::UH4::UH4_0 = v488.as_ref() {
                        true
                    } else {
                        false
                    }) != true
                    {
                        v488
                    } else {
                        let patternInput_3: (string, string) =
                            Documents::method119(string("epub"), v118.clone(), v4.clone());
                        let v494: string = patternInput_3.1.clone();
                        let v493: string = patternInput_3.0.clone();
                        let v507: LrcPtr<Documents::UH5> = if if Documents::method123(v493.clone())
                            == false
                        {
                            if Documents::method123(v494.clone()) {
                                Documents::method143(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v493 = v493.clone();
                                        let v494 = v494.clone();
                                        move || Documents::closure91(v494.clone(), v493.clone(), ())
                                    }),
                                );
                                Documents::method127(v493.clone(), v494.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("epub"),
                                v118.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_7: string| {
                                                Documents::closure85(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    true,
                                                    v_7,
                                                )
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
                            Documents::method119(string("pdf"), v118.clone(), v4.clone());
                        let v510: string = patternInput_4.1.clone();
                        let v509: string = patternInput_4.0.clone();
                        let v521: LrcPtr<Documents::UH5> = if if Documents::method123(v509.clone())
                            == false
                        {
                            if Documents::method123(v510.clone()) {
                                Documents::method143(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v509 = v509.clone();
                                        let v510 = v510.clone();
                                        move || Documents::closure91(v510.clone(), v509.clone(), ())
                                    }),
                                );
                                Documents::method127(v509.clone(), v510.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("pdf"),
                                v118.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_8: string| {
                                                Documents::closure85(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    true,
                                                    v_8,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v507.clone(),
                            ))
                        } else {
                            v507
                        };
                        let patternInput_5: (string, string) =
                            Documents::method119(string("html"), v118.clone(), v4.clone());
                        let v524: string = patternInput_5.1.clone();
                        let v523: string = patternInput_5.0.clone();
                        let v535: LrcPtr<Documents::UH5> = if if Documents::method123(v523.clone())
                            == false
                        {
                            if Documents::method123(v524.clone()) {
                                Documents::method143(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v523 = v523.clone();
                                        let v524 = v524.clone();
                                        move || Documents::closure91(v524.clone(), v523.clone(), ())
                                    }),
                                );
                                Documents::method127(v523.clone(), v524.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("html"),
                                v118,
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_9: string| {
                                                Documents::closure85(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    true,
                                                    v_9,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v521.clone(),
                            ))
                        } else {
                            v521
                        };
                        let patternInput_6: (string, string) =
                            Documents::method119(string("epub"), v96.clone(), v4.clone());
                        let v537: string = patternInput_6.1.clone();
                        let v536: string = patternInput_6.0.clone();
                        let v548: LrcPtr<Documents::UH5> = if if Documents::method123(v536.clone())
                            == false
                        {
                            if Documents::method123(v537.clone()) {
                                Documents::method143(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v536 = v536.clone();
                                        let v537 = v537.clone();
                                        move || Documents::closure91(v537.clone(), v536.clone(), ())
                                    }),
                                );
                                Documents::method127(v536.clone(), v537.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("epub"),
                                v96.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_10: string| {
                                                Documents::closure85(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_10,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v535.clone(),
                            ))
                        } else {
                            v535
                        };
                        let patternInput_7: (string, string) =
                            Documents::method119(string("pdf"), v96.clone(), v4.clone());
                        let v550: string = patternInput_7.1.clone();
                        let v549: string = patternInput_7.0.clone();
                        let v561: LrcPtr<Documents::UH5> = if if Documents::method123(v549.clone())
                            == false
                        {
                            if Documents::method123(v550.clone()) {
                                Documents::method143(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v549 = v549.clone();
                                        let v550 = v550.clone();
                                        move || Documents::closure91(v550.clone(), v549.clone(), ())
                                    }),
                                );
                                Documents::method127(v549.clone(), v550.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("pdf"),
                                v96.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_11: string| {
                                                Documents::closure85(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_11,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v548.clone(),
                            ))
                        } else {
                            v548
                        };
                        let patternInput_8: (string, string) =
                            Documents::method119(string("html"), v96.clone(), v4.clone());
                        let v563: string = patternInput_8.1.clone();
                        let v562: string = patternInput_8.0.clone();
                        let v574: LrcPtr<Documents::UH5> = if if Documents::method123(v562.clone())
                            == false
                        {
                            if Documents::method123(v563.clone()) {
                                Documents::method143(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v562 = v562.clone();
                                        let v563 = v563.clone();
                                        move || Documents::closure91(v563.clone(), v562.clone(), ())
                                    }),
                                );
                                Documents::method127(v562.clone(), v563.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("html"),
                                v96.clone(),
                                Func2::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_12: string| {
                                                Documents::closure85(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    false,
                                                    v_12,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                v561.clone(),
                            ))
                        } else {
                            v561
                        };
                        let patternInput_9: (string, string) =
                            Documents::method119(string("hangul.md"), v96.clone(), v4.clone());
                        let v576: string = patternInput_9.1.clone();
                        let v575: string = patternInput_9.0.clone();
                        LrcPtr::new(Documents::UH4::UH4_1(
                            if if Documents::method123(v575.clone()) == false {
                                if Documents::method123(v576.clone()) {
                                    Documents::method143(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure90((), ())),
                                        Func0::new({
                                            let v575 = v575.clone();
                                            let v576 = v576.clone();
                                            move || {
                                                Documents::closure91(v576.clone(), v575.clone(), ())
                                            }
                                        }),
                                    );
                                    Documents::method127(v575.clone(), v576.clone());
                                    false
                                } else {
                                    true
                                }
                            } else {
                                true
                            } {
                                LrcPtr::new(Documents::UH5::UH5_1(
                                    string("hangul.md"),
                                    v96.clone(),
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
                                                    Documents::closure76(
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
                                v574,
                                LrcPtr::new(Documents::UH4::UH4_0),
                            )),
                        ))
                    },
                    empty::<LrcPtr<Documents::UH5>>(),
                ));
                let v607: Vec<LrcPtr<Documents::UH5>> = v599.to_vec();
                let v610: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
                let v612: Array<LrcPtr<Documents::UH5>> =
                    fable_library_rust::NativeArray_::array_from(v607);
                let v613: i32 = count_2(v612.clone());
                let v614: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(v610),
                });
                while Documents::method146(v613, v614.clone()) {
                    let v616: i32 = v614.l0.get().clone();
                    let v617: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        v614.l1.get().clone();
                    let v624 = toArray(Documents::method147(
                        v612[v616].clone(),
                        empty::<(
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US30>>,
                        )>(),
                    ));
                    let v632 = v624.to_vec();
                    let v634 = rayon::iter::IntoParallelIterator::into_par_iter(v632);
                    let v637 = rayon::iter::ParallelIterator::map(v634, |x| {
                        Func1::new(
                            move |arg10_0040_16: (
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US30>>,
                            )| Documents::closure93((), arg10_0040_16),
                        )(x)
                    });
                    let v640: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        Documents::method148(rayon::iter::ParallelIterator::collect(v637));
                    let v641: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        Documents::method149(v617);
                    let v643: bool = true;
                    let mut v641 = v641;
                    let v645: bool = true;
                    v641.extend(v640);
                    let v647: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v641;
                    let v648: i32 = v616 + 1_i32;
                    v614.l0.set(v648);
                    v614.l1.set(v647);
                    ()
                }
                Ok::<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >(LrcPtr::new((v74.clone(), v614.l1.get().clone())))
            }
        }
        pub fn closure94(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure95(
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
        ) -> usize {
            v0_1.len()
        }
        pub fn method151(v0_1: LrcPtr<Documents::Mut4>, v1_1: usize) {
            Documents::method10(v0_1.clone(), string("{ "));
            Documents::method11(v0_1.clone());
            Documents::method10(v0_1.clone(), string("result_len"));
            Documents::method10(v0_1.clone(), string(" = "));
            Documents::method56(v0_1.clone(), v1_1);
            Documents::method10(v0_1, string(" }"))
        }
        pub fn closure96(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<usize>,
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
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v18: Option<i64> = patternInput.4.clone();
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v38: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v18 {
                        None => None::<Documents::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v38.set(x_2)
                }
                {
                    let v65: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v38.get().clone());
                    let v163: DateTime = match &v65 {
                        Documents::US2::US2_0(v65_0_0) => {
                            let v97: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v65 {
                                    Documents::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v97.hours(),
                                v97.minutes(),
                                v97.seconds(),
                                v97.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v163.toString(provider)
                        };
                        _v35.set(Some(x_3))
                    }
                    {
                        let v826: string = match &_v35.get().clone() {
                            None => panic!("{}", string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                        let v985: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v1034: Documents::US3 = match &v985 {
                            Documents::US3::US3_0(v985_0_0) => Documents::US3::US3_0(match &v985 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v994: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v994 {
                                    Documents::US3::US3_0(v994_0_0) => {
                                        Documents::US3::US3_0(match &v994 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v1003: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v1003 {
                                            Documents::US3::US3_0(v1003_0_0) => {
                                                Documents::US3::US3_0(match &v1003 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v1012: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Documents::US3::US3_0(v1012_0_0) => {
                                                        Documents::US3::US3_0(match &v1012 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v1021: Documents::US3 =
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
                                                        match &v1021 {
                                                            Documents::US3::US3_0(v1021_0_0) => {
                                                                Documents::US3::US3_0(
                                                                    match &v1021 {
                                                                        Documents::US3::US3_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                )
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
                        let v1051: string = padLeft(
                            toLower(match &v1034 {
                                Documents::US3::US3_0(v1034_0_0) => match &v1034 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v1098: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v1100: &str = &*v1051;
                        let v1102: &str = inline_colorization::color_reset;
                        let v1104: string = string("format!(\"{v1098}{v1100}{v1102}\")");
                        let v1105: std::string::String = format!("{v1098}{v1100}{v1102}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v1105);
                            _v1083.set(Some(x_5))
                        }
                        {
                            let v1195: string = match &_v1083.get().clone() {
                                None => panic!("{}", string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                            let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v1217: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method151(v1217.clone(), v2());
                            {
                                let v1218: string = v1217.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v826,
                                            v1195,
                                            v1214,
                                            v1_1(),
                                            v1218
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
        pub fn method150(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<usize>) {
            Documents::method13(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure96(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method152(
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
        pub fn method18(
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
            let v8: Documents::US7 = Documents::method22(
                Documents::method19(string("polyglot"), string(".devcontainer")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v17: Documents::US3 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US3::US3_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    Documents::method27(
                        Documents::US0::US0_3,
                        Func0::new(move || Documents::closure8((), ())),
                        Func0::new({
                            let v8 = v8.clone();
                            move || {
                                Documents::closure9(
                                    match &v8 {
                                        Documents::US7::US7_1(x) => x.clone(),
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
            let v33: Documents::US3 = match &v17 {
                Documents::US3::US3_0(v17_0_0) => Documents::US3::US3_0(match &v17 {
                    Documents::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v20: string = Documents::method29();
                    let v22: Documents::US7 = Documents::method22(
                        Documents::method19(string("polyglot"), string(".devcontainer")),
                        v20,
                    );
                    match &v22 {
                        Documents::US7::US7_0(v22_0_0) => Documents::US3::US3_0(v22_0_0.clone()),
                        Documents::US7::US7_1(v22_1_0) => {
                            Documents::method27(
                                Documents::US0::US0_3,
                                Func0::new(move || Documents::closure8((), ())),
                                Func0::new({
                                    let v22 = v22.clone();
                                    move || {
                                        Documents::closure9(
                                            match &v22 {
                                                Documents::US7::US7_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            (),
                                        )
                                    }
                                }),
                            );
                            Documents::US3::US3_1
                        }
                    }
                }
            };
            let v38: string = Documents::method19(
                match &v33 {
                    Documents::US3::US3_0(v33_0_0) => match &v33 {
                        Documents::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v39: string = Documents::method30(v3);
            let v40: string = Documents::method30(v2);
            let v41: string = Documents::method30(v1_1);
            Documents::method40(
                Documents::US0::US0_1,
                Func0::new(move || Documents::closure11((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v39 = v39.clone();
                    let v40 = v40.clone();
                    let v41 = v41.clone();
                    move || {
                        Documents::closure12(
                            v0_1.clone(),
                            v39.clone(),
                            v40.clone(),
                            v41.clone(),
                            (),
                        )
                    }
                }),
            );
            let __result = Box::pin(async move {
                //;
                {
                    let v47: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v40.clone());
                    let v50: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v47, |x| {
                        Func1::new(move |v: async_walkdir::DirEntry| Documents::closure14((), v))(x)
                    });
                    let v51 = Documents::method49();
                    let v53: Vec<string> = tokio_stream::StreamExt::collect(
                        tokio_stream::StreamExt::filter_map(v50, |x| v51(x)),
                    )
                    .await;
                    Documents::method54(
                        Documents::US0::US0_1,
                        Func0::new(move || Documents::closure25((), ())),
                        Func0::new({
                            let v53 = v53.clone();
                            move || Documents::closure26(v53.clone(), ())
                        }),
                    );
                    {
                        let v58: rayon::vec::IntoIter<string> =
                            rayon::iter::IntoParallelIterator::into_par_iter(v53);
                        let v61: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                            rayon::iter::ParallelIterator::map(v58, |x| {
                                Func1::new({
                                    let v0_1 = v0_1.clone();
                                    let v38 = v38.clone();
                                    let v39 = v39.clone();
                                    let v40 = v40.clone();
                                    let v41 = v41.clone();
                                    move |v_1: string| {
                                        Documents::closure28(
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
                        let v63: Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        > = rayon::iter::ParallelIterator::collect(v61);
                        Documents::method150(
                            Documents::US0::US0_2,
                            Func0::new(move || Documents::closure94((), ())),
                            Func0::new({
                                let v63 = v63.clone();
                                move || Documents::closure95(v63.clone(), ())
                            }),
                        );
                        {
                            let v68: Result<
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
                            > = Documents::method152(Ok::<
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
                            >(v63.clone()));
                            let v79: string = string("v68 }}}}); {{{ // rust.fix_closure\'");
                            v68
                        }
                    }
                }
            });
            {
                {
                    {
                        // rust.fix_closure';
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
                let v13: clap::Command = Documents::method0();
                let v15: clap::ArgMatches = clap::Command::get_matches(v13);
                let v16: string = Documents::method14();
                let v18: &str = &*v16;
                let v20: Option<std::string::String> =
                    clap::ArgMatches::get_one(&v15.clone(), v18).cloned();
                let _v23: LrcPtr<MutCell<Option<Documents::US4>>> = refCell(None::<Documents::US4>);
                {
                    let x_2: Option<Documents::US4> = match &v20 {
                        None => None::<Documents::US4>,
                        Some(v20_0_0) => {
                            let x: std::string::String = v20_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US4::US4_0(x.clone())
                            }))())
                        }
                    };
                    _v23.set(x_2)
                }
                {
                    let v50: Documents::US4 =
                        defaultValue(Documents::US4::US4_1, _v23.get().clone());
                    let v61: std::string::String = match &v50 {
                        Documents::US4::US4_0(v50_0_0) => match &v50 {
                            Documents::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v63: string = fable_library_rust::String_::fromString(v61);
                    let v64: string = Documents::method15();
                    let v66: &str = &*v64;
                    let v68: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v15.clone(), v66).cloned();
                    let _v71: LrcPtr<MutCell<Option<Documents::US4>>> =
                        refCell(None::<Documents::US4>);
                    {
                        let x_5: Option<Documents::US4> = match &v68 {
                            None => None::<Documents::US4>,
                            Some(v68_0_0) => {
                                let x_3: std::string::String = v68_0_0.clone();
                                Some((Func0::new({
                                    let x_3 = x_3.clone();
                                    move || Documents::US4::US4_0(x_3.clone())
                                }))())
                            }
                        };
                        _v71.set(x_5)
                    }
                    {
                        let v98: Documents::US4 =
                            defaultValue(Documents::US4::US4_1, _v71.get().clone());
                        let v109: std::string::String = match &v98 {
                            Documents::US4::US4_0(v98_0_0) => match &v98 {
                                Documents::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v111: string = fable_library_rust::String_::fromString(v109);
                        let v112: string = Documents::method16();
                        let v114: &str = &*v112;
                        let v116: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v15.clone(), v114).cloned();
                        let _v119: LrcPtr<MutCell<Option<Documents::US4>>> =
                            refCell(None::<Documents::US4>);
                        {
                            let x_8: Option<Documents::US4> = match &v116 {
                                None => None::<Documents::US4>,
                                Some(v116_0_0) => {
                                    let x_6: std::string::String = v116_0_0.clone();
                                    Some((Func0::new({
                                        let x_6 = x_6.clone();
                                        move || Documents::US4::US4_0(x_6.clone())
                                    }))())
                                }
                            };
                            _v119.set(x_8)
                        }
                        {
                            let v146: Documents::US4 =
                                defaultValue(Documents::US4::US4_1, _v119.get().clone());
                            let v157: std::string::String = match &v146 {
                                Documents::US4::US4_0(v146_0_0) => match &v146 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v159: string = fable_library_rust::String_::fromString(v157);
                            let v160: string = Documents::method17();
                            let v162: &str = &*v160;
                            let v164: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v15, v162).cloned();
                            let _v167: LrcPtr<MutCell<Option<Documents::US4>>> =
                                refCell(None::<Documents::US4>);
                            {
                                let x_11: Option<Documents::US4> = match &v164 {
                                    None => None::<Documents::US4>,
                                    Some(v164_0_0) => {
                                        let x_9: std::string::String = v164_0_0.clone();
                                        Some((Func0::new({
                                            let x_9 = x_9.clone();
                                            move || Documents::US4::US4_0(x_9.clone())
                                        }))())
                                    }
                                };
                                _v167.set(x_11)
                            }
                            {
                                let v194: Documents::US4 =
                                    defaultValue(Documents::US4::US4_1, _v167.get().clone());
                                let v205: std::string::String = match &v194 {
                                    Documents::US4::US4_0(v194_0_0) => match &v194 {
                                        Documents::US4::US4_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                                let v208: std::pin::Pin<
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
                                > = Documents::method18(
                                    fable_library_rust::String_::fromString(v205),
                                    v159,
                                    v111,
                                    v63,
                                );
                                let v210 = tokio::runtime::Builder::new_multi_thread()
                                    .enable_all()
                                    .build()
                                    .unwrap();
                                let v212: Result<
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
                                > = v210.handle().block_on(v208);
                                let v214: Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                > = v212.unwrap();
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
