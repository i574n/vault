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
            LrcPtr<Documents::Mut3>,
            Option<i64>,
        ) {
            let _v1: MutCell<Option<(Documents::US1, Documents::US2)>> =
                MutCell::new(None::<(Documents::US1, Documents::US2)>);
            let v3: string = Documents::method2(Documents::method1());
            let v9: Documents::US1 = if string("Verbose") == v3.clone() {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            {
                let x: (Documents::US1, Documents::US2) = (
                    match &v9 {
                        Documents::US1::US1_0(v9_0_0) => Documents::US1::US1_0(match &v9 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v17: Documents::US1 = if string("Debug") == v3.clone() {
                                Documents::US1::US1_0(Documents::US0::US0_1)
                            } else {
                                Documents::US1::US1_1
                            };
                            match &v17 {
                                Documents::US1::US1_0(v17_0_0) => {
                                    Documents::US1::US1_0(match &v17 {
                                        Documents::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v25: Documents::US1 = if string("Info") == v3.clone() {
                                        Documents::US1::US1_0(Documents::US0::US0_2)
                                    } else {
                                        Documents::US1::US1_1
                                    };
                                    match &v25 {
                                        Documents::US1::US1_0(v25_0_0) => {
                                            Documents::US1::US1_0(match &v25 {
                                                Documents::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v33: Documents::US1 =
                                                if string("Warning") == v3.clone() {
                                                    Documents::US1::US1_0(Documents::US0::US0_3)
                                                } else {
                                                    Documents::US1::US1_1
                                                };
                                            match &v33 {
                                                Documents::US1::US1_0(v33_0_0) => {
                                                    Documents::US1::US1_0(match &v33 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v41: Documents::US1 = if string("Critical")
                                                        == v3.clone()
                                                    {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                    match &v41 {
                                                        Documents::US1::US1_0(v41_0_0) => {
                                                            Documents::US1::US1_0(match &v41 {
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
                _v1.set(Some(x))
            }
            {
                let patternInput: (Documents::US1, Documents::US2) = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                let v259: Documents::US2 = patternInput.1.clone();
                let v258: Documents::US1 = patternInput.0.clone();
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
                        l0: MutCell::new(match &v258 {
                            Documents::US1::US1_0(v258_0_0) => match &v258 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v0_1,
                        }),
                    }),
                    match &v259 {
                        Documents::US2::US2_0(v259_0_0) => Some(match &v259 {
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
            string("")
        }
        pub fn method8() -> string {
            string("HH:mm:ss")
        }
        pub fn method9() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11(v0_1: LrcPtr<Documents::Mut4>, v1_1: string) {
            let v2: string = sprintf!("{}", v1_1);
            let v4: string = append(v0_1.l0.get().clone(), v2);
            v0_1.l0.set(v4);
            ()
        }
        pub fn method12(v0_1: LrcPtr<Documents::Mut4>) {
            ();
        }
        pub fn method13(v0_1: LrcPtr<Documents::Mut4>, v1_1: Array<string>) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method10(v0_1: LrcPtr<Documents::Mut4>, v1_1: Array<string>) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("args"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method13(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method10(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method14(v0_1: Documents::US0, v1_1: Func0<string>) {
            fn v2(
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
                Documents::State::trace_state().set(Some(v2(Documents::US0::US0_0)));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    Option<i64>,
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
                        LrcPtr<Documents::Mut3>,
                        Option<i64>,
                    ) = getValue(Documents::State::trace_state().get().clone());
                    let v15: Documents::US0 = (patternInput_1.3.clone()).l0.get().clone();
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
                            ((patternInput.1.clone()).l0.get().clone())(v24)
                        }
                    }
                }
            }
        }
        pub fn method5(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<Array<string>>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure6(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method15() -> string {
            string("source-dir")
        }
        pub fn method16() -> string {
            string("dist-dir")
        }
        pub fn method17() -> string {
            string("cache-dir")
        }
        pub fn method18() -> string {
            string("hangul-spec")
        }
        pub fn method22(v0_1: string) -> string {
            v0_1
        }
        pub fn method21(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Documents::method22(v0_1))
        }
        pub fn method20(v0_1: string, v1_1: string) -> string {
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
        pub fn method24(v0_1: string) -> bool {
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
        pub fn method26(v0_1: string) -> Option<string> {
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
        pub fn closure7(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method26(v0_1)
        }
        pub fn method25() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure7((), v))
        }
        pub fn method27(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method27: loop {
                break '_method27 (if Documents::method24(Documents::method20(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Documents::method25())(v2.get().clone());
                    let _v8: LrcPtr<MutCell<Option<Documents::US3>>> =
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
                        _v8.set(x_2)
                    }
                    {
                        let v13: Documents::US3 =
                            defaultValue(Documents::US3::US3_1, _v8.get().clone());
                        match &v13 {
                            Documents::US3::US3_0(v13_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: string = match &v13 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method27;
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
        pub fn method23(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method24(Documents::method20(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Documents::method25())(v1_1.clone());
                let _v7: LrcPtr<MutCell<Option<Documents::US3>>> = refCell(None::<Documents::US3>);
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
                        Documents::US3::US3_0(v12_0_0) => Documents::method27(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v12 {
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
        pub fn method29(v0_1: LrcPtr<Documents::Mut4>, v1_1: string) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("error"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method29(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method28(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure10(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method30() -> string {
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
        pub fn method32(v0_1: string) -> string {
            v0_1
        }
        pub fn method34() -> string {
            string("")
        }
        pub fn method35(v0_1: string) -> string {
            v0_1
        }
        pub fn method36() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method33(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v4: string = Documents::method34();
                let _v5: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v6: string = Documents::method35(v0_1);
                let v9: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v11: regex::Regex = v9.unwrap();
                let v13: std::borrow::Cow<str> = v11.replace_all(&v6, &*v4);
                let v15: std::string::String = String::from(v13);
                {
                    let x: string = fable_library_rust::String_::fromString(v15);
                    _v5.set(Some(x))
                }
                {
                    let v24: string = match &_v5.get().clone() {
                        None => panic!("{}", string("base.run_target / _v5=None"),),
                        Some(_v5_0_0) => _v5_0_0.clone(),
                    };
                    replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v24.clone(), 0_i32))),
                            getSlice(v24, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method37(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method38(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method39() -> char {
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
        pub fn method40(v0_1: string) -> string {
            v0_1
        }
        pub fn method31(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Documents::method32(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_2: string = if v8.exists() == false {
                    let v12: string = Documents::method30();
                    let v16: Array<string> = split(
                        Documents::method33(Documents::method20(v12.clone(), v2.clone())),
                        string("/"),
                        -1_i32,
                        0_i32,
                    );
                    let v18: i32 = count_2(v16.clone());
                    let v19: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(0_i32),
                        l2: MutCell::new(new_empty::<string>()),
                    });
                    while Documents::method37(v18, v19.clone()) {
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
                                        let v40: LrcPtr<Documents::Mut6> =
                                            LrcPtr::new(Documents::Mut6 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method38(v38, v40.clone()) {
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
                                        let v54: LrcPtr<Documents::Mut6> =
                                            LrcPtr::new(Documents::Mut6 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Documents::method38(v52, v54.clone()) {
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
                        join(ofChar(Documents::method39()), toArray_1(v75))
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
        pub fn method42(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("source_dir"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("dist_dir"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v2);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("cache_dir"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v3);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("hangul_spec"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v4);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (string, string, string, string) = v2();
                            let v335: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method42(
                                v335.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            );
                            {
                                let v336: string = v335.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v336
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
        pub fn method41(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(string, string, string, string)>,
        ) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure13(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method45(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure15(unitVar: (), v0_1: std::io::Error) -> std::string::String {
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
        pub fn method46() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: std::fs::FileType) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US9 {
            Documents::US9::US9_1(v0_1)
        }
        pub fn method47(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method48(v0_1: Documents::US8) -> Documents::US8 {
            v0_1
        }
        pub fn method44(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US8> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method45(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method46();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US9 = match &v9 {
                        Err(v9_1_0) => Documents::closure17((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure16((), v9_0_0.clone()),
                    };
                    let v72: Documents::US8 =
                        Documents::method48(if let Documents::US9::US9_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method47(match &v12 {
                                Documents::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) {
                                Documents::US8::US8_0
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
                                        Documents::US8::US8_0
                                    } else {
                                        Documents::US8::US8_2
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
                                    Documents::US8::US8_0
                                } else {
                                    Documents::US8::US8_2
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
        pub fn method49(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method43(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US8> + Send>,
                    > = Documents::method44(v0_1);
                    let v4: Documents::US8 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method49(match &v4 {
                        Documents::US8::US8_0 => async_walkdir::Filtering::Ignore,
                        Documents::US8::US8_1 => async_walkdir::Filtering::IgnoreDir,
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
        pub fn closure14(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Documents::method43(v0_1)
        }
        pub fn closure19(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
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
        pub fn method51() -> Func1<async_walkdir::Error, std::string::String> {
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
        pub fn method54(v0_1: LrcPtr<Documents::Mut4>, v1_1: std::string::String) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method53(v0_1: LrcPtr<Documents::Mut4>, v1_1: std::string::String) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("error"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method54(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method53(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method52(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<std::string::String>) {
            Documents::method14(
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
            let v1_1 = Documents::method51();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US10 = match &v3 {
                Err(v3_1_0) => Documents::closure21((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure20((), v3_0_0.clone()),
            };
            let v32: Documents::US3 = match &v6 {
                Documents::US10::US10_0(v6_0_0) => {
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
                Documents::US10::US10_1(v6_1_0) => {
                    Documents::method52(
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
            match &v32 {
                Documents::US3::US3_0(v32_0_0) => Some(match &v32 {
                    Documents::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method50(
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
        pub fn method57(v0_1: LrcPtr<Documents::Mut4>, v1_1: usize) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method56(v0_1: LrcPtr<Documents::Mut4>, v1_1: usize) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("files_len"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method57(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method56(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method55(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<usize>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure27(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method58(v0_1: string) -> string {
            Documents::method33(Documents::method31(v0_1))
        }
        pub fn method60(
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
        pub fn method62() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure30((), v))
        }
        pub fn method63(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method63: loop {
                break '_method63 (match v0_1.get().clone().as_ref() {
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
                            continue '_method63;
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
                    let v17: string = ofChar(v7);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method38(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method63(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method62())(b0)(b1)
                                }),
                                v26,
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
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v41 { v38 } else { v41 })
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
                    let v17: string = ofChar(v7);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method38(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method63(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method62())(b0)(b1)
                                }),
                                v26,
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
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method64(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method64: loop {
                break '_method64 (match v2.get().clone().as_ref() {
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
                                continue '_method64;
                            }
                        }
                    }
                });
            }
        }
        pub fn method65(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method65: loop {
                break '_method65 (if v1_1.get().clone() >= 2_i64 {
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
                        continue '_method65;
                    }
                });
            }
        }
        pub fn method66(
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
            '_method66: loop {
                break '_method66 ({
                    let v53: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v13: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v20: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method65(v13, 0_i64) == false {
                            let v25: string = ofChar(v13);
                            let v26: i32 = length(v25.clone());
                            let v27: Array<char> = new_init(&'\u{0000}', v26);
                            let v28: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v26, v28.clone()) {
                                let v30: i32 = v28.l0.get().clone();
                                let v31: char = getCharAt(v25.clone(), v30);
                                v27.get_mut()[v30 as usize] = v31;
                                {
                                    let v32: i32 = v30 + 1_i32;
                                    v28.l0.set(v32);
                                    ()
                                }
                            }
                            {
                                let v34: List<char> = ofArray(v27.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method63(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method62())(b0)(b1)
                                                },
                                            ),
                                            v34,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v13,
                                    v20,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v13,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v65: Documents::US12 = match &v53 {
                        Documents::US12::US12_0(v53_0_0, v53_0_1, v53_0_2, v53_0_3, v53_0_4) => {
                            let v54: char = v53_0_0.clone();
                            Documents::US12::US12_0(
                                if '\\' == v54 { '/' } else { v54 },
                                v53_0_1.clone(),
                                v53_0_2.clone(),
                                v53_0_3.clone(),
                                v53_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v53_1_0) => {
                            Documents::US12::US12_1(v53_1_0.clone())
                        }
                    };
                    match &v65 {
                        Documents::US12::US12_0(v65_0_0, v65_0_1, v65_0_2, v65_0_3, v65_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v65_0_0.clone()));
                            let v1_1_temp: string = v65_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v65_0_2.clone();
                            let v3_temp: i32 = v65_0_3.clone();
                            let v4_temp: i32 = v65_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method66;
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
        pub fn method67(
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
            '_method67: loop {
                break '_method67 (match v4.get().clone().as_ref() {
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
                                continue '_method67;
                            }
                        }
                    }
                });
            }
        }
        pub fn method68(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method68: loop {
                break '_method68 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method68;
                    }
                });
            }
        }
        pub fn method69(
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
            '_method69: loop {
                break '_method69 ({
                    let v55: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method68(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v27, v29.clone()) {
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
                                    Documents::method63(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method62())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Documents::US12 = match &v55 {
                        Documents::US12::US12_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            let v56: char = v55_0_0.clone();
                            Documents::US12::US12_0(
                                if '\\' == v56 { '/' } else { v56 },
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v55_1_0) => {
                            Documents::US12::US12_1(v55_1_0.clone())
                        }
                    };
                    match &v67 {
                        Documents::US12::US12_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v67_0_0.clone()));
                            let v1_1_temp: string = v67_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v67_0_2.clone();
                            let v3_temp: i32 = v67_0_3.clone();
                            let v4_temp: i32 = v67_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method69;
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
        pub fn method70(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method70: loop {
                break '_method70 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method70;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method71(
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
            '_method71: loop {
                break '_method71 ({
                    let v37: Documents::US12 = if string("") == v1_1.get().clone() {
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
                        let v18: i32 = length(v17.clone());
                        let v19: Array<char> = new_init(&'\u{0000}', v18);
                        let v20: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method38(v18, v20.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method63(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method62())(b0)(b1)
                                        }),
                                        v26,
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
                    match &v37 {
                        Documents::US12::US12_0(v37_0_0, v37_0_1, v37_0_2, v37_0_3, v37_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v37_0_0.clone()));
                            let v1_1_temp: string = v37_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v37_0_2.clone();
                            let v3_temp: i32 = v37_0_3.clone();
                            let v4_temp: i32 = v37_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method71;
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
        pub fn method61(v0_1: string) -> Documents::US11 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v5: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v7: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
                fn v8(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure29((), arg10_0040)
                }
                fn v9(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US12 {
                    Documents::closure32((), arg10_0040_1)
                }
                let v13: Documents::US12 = Documents::method64(
                    v5.clone(),
                    v7.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v8),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v9),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v130: Documents::US13 = match &v13 {
                    Documents::US12::US12_0(v13_0_0, v13_0_1, v13_0_2, v13_0_3, v13_0_4) => {
                        let v18: i32 = v13_0_4.clone();
                        let v17: i32 = v13_0_3.clone();
                        let v16: LrcPtr<StringBuilder> = v13_0_2.clone();
                        let v15: string = v13_0_1.clone();
                        let v67: Documents::US12 = if string("") == v15.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v16.clone(), v17, v18)
                            ))
                        } else {
                            let v27: char = getCharAt(v15.clone(), 0_i32);
                            let v34: string =
                                getSlice(v15.clone(), Some(1_i32), Some(length(v15.clone())));
                            if Documents::method65(v27, 0_i64) == false {
                                let v39: string = ofChar(v27);
                                let v40: i32 = length(v39.clone());
                                let v41: Array<char> = new_init(&'\u{0000}', v40);
                                let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method38(v40, v42.clone()) {
                                    let v44: i32 = v42.l0.get().clone();
                                    let v45: char = getCharAt(v39.clone(), v44);
                                    v41.get_mut()[v44 as usize] = v45;
                                    {
                                        let v46: i32 = v44 + 1_i32;
                                        v42.l0.set(v46);
                                        ()
                                    }
                                }
                                {
                                    let v48: List<char> = ofArray(v41.clone());
                                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method63(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method62())(b0)(b1)
                                                    },
                                                ),
                                                v48,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v16.clone(),
                                            v17,
                                            v18,
                                        );
                                    Documents::US12::US12_0(
                                        v27,
                                        v34,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US12::US12_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v27,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v16.clone(),
                                                                          v17,
                                                                          v18)))
                            }
                        };
                        let v79: Documents::US12 = match &v67 {
                            Documents::US12::US12_0(
                                v67_0_0,
                                v67_0_1,
                                v67_0_2,
                                v67_0_3,
                                v67_0_4,
                            ) => {
                                let v68: char = v67_0_0.clone();
                                Documents::US12::US12_0(
                                    if '\\' == v68 { '/' } else { v68 },
                                    v67_0_1.clone(),
                                    v67_0_2.clone(),
                                    v67_0_3.clone(),
                                    v67_0_4.clone(),
                                )
                            }
                            Documents::US12::US12_1(v67_1_0) => {
                                Documents::US12::US12_1(v67_1_0.clone())
                            }
                        };
                        let v91: Documents::US13 = match &v79 {
                            Documents::US12::US12_0(
                                v79_0_0,
                                v79_0_1,
                                v79_0_2,
                                v79_0_3,
                                v79_0_4,
                            ) => Documents::method66(
                                ofChar(v79_0_0.clone()),
                                v79_0_1.clone(),
                                v79_0_2.clone(),
                                v79_0_3.clone(),
                                v79_0_4.clone(),
                            ),
                            Documents::US12::US12_1(v79_1_0) => {
                                Documents::US13::US13_1(v79_1_0.clone())
                            }
                        };
                        let v101: Documents::US13 = match &v91 {
                            Documents::US13::US13_0(
                                v91_0_0,
                                v91_0_1,
                                v91_0_2,
                                v91_0_3,
                                v91_0_4,
                            ) => Documents::US13::US13_0(
                                v91_0_0.clone(),
                                v91_0_1.clone(),
                                v91_0_2.clone(),
                                v91_0_3.clone(),
                                v91_0_4.clone(),
                            ),
                            _ => Documents::US13::US13_0(
                                string(""),
                                v15.clone(),
                                v16.clone(),
                                v17,
                                v18,
                            ),
                        };
                        match &v101 {
                            Documents::US13::US13_0(
                                v101_0_0,
                                v101_0_1,
                                v101_0_2,
                                v101_0_3,
                                v101_0_4,
                            ) => {
                                let v106: i32 = v101_0_4.clone();
                                let v105: i32 = v101_0_3.clone();
                                let v104: LrcPtr<StringBuilder> = v101_0_2.clone();
                                let v103: string = v101_0_1.clone();
                                let v110: Documents::US12 = Documents::method67(
                                    v103.clone(),
                                    v104.clone(),
                                    v105,
                                    v106,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v8),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v9),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v110 {
                                        Documents::US12::US12_0(v110_0_0,
                                                                v110_0_1,
                                                                v110_0_2,
                                                                v110_0_3,
                                                                v110_0_4) =>
                                        Documents::US13::US13_0(v101_0_0.clone(),
                                                                v110_0_1.clone(),
                                                                v110_0_2.clone(),
                                                                v110_0_3.clone(),
                                                                v110_0_4.clone()),
                                        Documents::US12::US12_1(v110_1_0) =>
                                        Documents::US13::US13_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                         v110_1_0.clone(),
                                                                         (v5.clone(),
                                                                          v7.clone(),
                                                                          1_i32,
                                                                          1_i32),
                                                                         (v15,
                                                                          v16,
                                                                          v17,
                                                                          v18),
                                                                         (v103,
                                                                          v104,
                                                                          v105,
                                                                          v106))),
                                    }
                            }
                            _ => Documents::US13::US13_1(string("between / expected content")),
                        }
                    }
                    Documents::US12::US12_1(v13_1_0) => Documents::US13::US13_1(v13_1_0.clone()),
                };
                let v257: Documents::US13 = match &v130 {
                    Documents::US13::US13_0(v130_0_0, v130_0_1, v130_0_2, v130_0_3, v130_0_4) => {
                        v130.clone()
                    }
                    _ => {
                        let v189: Documents::US12 = if string("") == v5.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v7.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v146: char = getCharAt(v5.clone(), 0_i32);
                            let v153: string =
                                getSlice(v5.clone(), Some(1_i32), Some(length(v5.clone())));
                            if Documents::method68(v146, 0_i64) == false {
                                let v158: string = ofChar(v146);
                                let v159: i32 = length(v158.clone());
                                let v160: Array<char> = new_init(&'\u{0000}', v159);
                                let v161: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method38(v159, v161.clone()) {
                                    let v163: i32 = v161.l0.get().clone();
                                    let v164: char = getCharAt(v158.clone(), v163);
                                    v160.get_mut()[v163 as usize] = v164;
                                    {
                                        let v165: i32 = v163 + 1_i32;
                                        v161.l0.set(v165);
                                        ()
                                    }
                                }
                                {
                                    let v167: List<char> = ofArray(v160.clone());
                                    let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method63(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method62())(b0)(b1)
                                                    },
                                                ),
                                                v167,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v7.clone(),
                                            1_i32,
                                            1_i32,
                                        );
                                    Documents::US12::US12_0(
                                        v146,
                                        v153,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US12::US12_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v146,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v7.clone(),
                                                                          1_i32,
                                                                          1_i32)))
                            }
                        };
                        let v201: Documents::US12 = match &v189 {
                            Documents::US12::US12_0(
                                v189_0_0,
                                v189_0_1,
                                v189_0_2,
                                v189_0_3,
                                v189_0_4,
                            ) => {
                                let v190: char = v189_0_0.clone();
                                Documents::US12::US12_0(
                                    if '\\' == v190 { '/' } else { v190 },
                                    v189_0_1.clone(),
                                    v189_0_2.clone(),
                                    v189_0_3.clone(),
                                    v189_0_4.clone(),
                                )
                            }
                            Documents::US12::US12_1(v189_1_0) => {
                                Documents::US12::US12_1(v189_1_0.clone())
                            }
                        };
                        let v213: Documents::US13 = match &v201 {
                            Documents::US12::US12_0(
                                v201_0_0,
                                v201_0_1,
                                v201_0_2,
                                v201_0_3,
                                v201_0_4,
                            ) => Documents::method69(
                                ofChar(v201_0_0.clone()),
                                v201_0_1.clone(),
                                v201_0_2.clone(),
                                v201_0_3.clone(),
                                v201_0_4.clone(),
                            ),
                            Documents::US12::US12_1(v201_1_0) => {
                                Documents::US13::US13_1(v201_1_0.clone())
                            }
                        };
                        match &v213 {
                            Documents::US13::US13_0(
                                v213_0_0,
                                v213_0_1,
                                v213_0_2,
                                v213_0_3,
                                v213_0_4,
                            ) => v213.clone(),
                            _ => {
                                let v225: Documents::US15 = if length(v5.clone()) == 0_i32 {
                                    Documents::US15::US15_0(v5.clone(), v7.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US15::US15_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v5.clone()
                                    ))
                                };
                                let v234: Documents::US13 = match &v225 {
                                    Documents::US15::US15_0(
                                        v225_0_0,
                                        v225_0_1,
                                        v225_0_2,
                                        v225_0_3,
                                    ) => Documents::US13::US13_0(
                                        string(""),
                                        v225_0_0.clone(),
                                        v225_0_1.clone(),
                                        v225_0_2.clone(),
                                        v225_0_3.clone(),
                                    ),
                                    Documents::US15::US15_1(v225_1_0) => {
                                        Documents::US13::US13_1(v225_1_0.clone())
                                    }
                                };
                                match &v234 {
                                    Documents::US13::US13_0(
                                        v234_0_0,
                                        v234_0_1,
                                        v234_0_2,
                                        v234_0_3,
                                        v234_0_4,
                                    ) => {
                                        let v236: string = v234_0_1.clone();
                                        Documents::US13::US13_0(
                                            v234_0_0.clone(),
                                            getSlice(
                                                v236.clone(),
                                                Some(Documents::method70(v236.clone(), 0_i32)),
                                                Some(length(v236)),
                                            ),
                                            v234_0_2.clone(),
                                            v234_0_3.clone(),
                                            v234_0_4.clone(),
                                        )
                                    }
                                    Documents::US13::US13_1(v234_1_0) => {
                                        Documents::US13::US13_1(v234_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v411: Documents::US16 = match &v257 {
                    Documents::US13::US13_0(v257_0_0, v257_0_1, v257_0_2, v257_0_3, v257_0_4) => {
                        let v262: i32 = v257_0_4.clone();
                        let v261: i32 = v257_0_3.clone();
                        let v260: LrcPtr<StringBuilder> = v257_0_2.clone();
                        let v259: string = v257_0_1.clone();
                        let v319: Documents::US12 = if string("") == v259.clone() {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v260.clone(), v261, v262)
                            ))
                        } else {
                            let v266: char = getCharAt(v259.clone(), 0_i32);
                            if v266 == ' ' {
                                let v274: string =
                                    getSlice(v259.clone(), Some(1_i32), Some(length(v259.clone())));
                                let v276: string = ofChar(v266);
                                let v277: i32 = length(v276.clone());
                                let v278: Array<char> = new_init(&'\u{0000}', v277);
                                let v279: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method38(v277, v279.clone()) {
                                    let v281: i32 = v279.l0.get().clone();
                                    let v282: char = getCharAt(v276.clone(), v281);
                                    v278.get_mut()[v281 as usize] = v282;
                                    {
                                        let v283: i32 = v281 + 1_i32;
                                        v279.l0.set(v283);
                                        ()
                                    }
                                }
                                {
                                    let v285: List<char> = ofArray(v278.clone());
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method63(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method62())(b0)(b1)
                                                    },
                                                ),
                                                v285,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v260.clone(),
                                            v261,
                                            v262,
                                        );
                                    Documents::US12::US12_0(
                                        v266,
                                        v274,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                let v297: i32 = length(v259.clone());
                                let v300: i32 = indexOf(v259.clone(), string("\n")) - 1_i32;
                                Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                         sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                  ' ',
                                                                                  v261,
                                                                                  v262,
                                                                                  v260.clone(),
                                                                                  getSlice(v259.clone(),
                                                                                           Some(0_i32),
                                                                                           Some(if -2_i32
                                                                                                       ==
                                                                                                       v300
                                                                                                   {
                                                                                                    v297
                                                                                                } else {
                                                                                                    v300
                                                                                                }))),
                                                                         append(replicate(v262
                                                                                              -
                                                                                              1_i32,
                                                                                          string(" ")),
                                                                                string("^"))))
                            }
                        };
                        let v331: Documents::US17 = match &v319 {
                            Documents::US12::US12_0(
                                v319_0_0,
                                v319_0_1,
                                v319_0_2,
                                v319_0_3,
                                v319_0_4,
                            ) => Documents::US17::US17_0(
                                Documents::US14::US14_0(v319_0_0.clone()),
                                v319_0_1.clone(),
                                v319_0_2.clone(),
                                v319_0_3.clone(),
                                v319_0_4.clone(),
                            ),
                            _ => Documents::US17::US17_0(
                                Documents::US14::US14_1,
                                v259.clone(),
                                v260.clone(),
                                v261,
                                v262,
                            ),
                        };
                        let v385: Documents::US13 = match &v331 {
                            Documents::US17::US17_0(
                                v331_0_0,
                                v331_0_1,
                                v331_0_2,
                                v331_0_3,
                                v331_0_4,
                            ) => {
                                let v336: i32 = v331_0_4.clone();
                                let v335: i32 = v331_0_3.clone();
                                let v334: LrcPtr<StringBuilder> = v331_0_2.clone();
                                let v333: string = v331_0_1.clone();
                                let v369: Documents::US12 = if string("") == v333.clone() {
                                    Documents::US12::US12_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v334.clone(), v335, v336)
                                    ))
                                } else {
                                    let v340: char = getCharAt(v333.clone(), 0_i32);
                                    let v347: string =
                                        getSlice(v333.clone(), Some(1_i32), Some(length(v333)));
                                    let v349: string = ofChar(v340);
                                    let v350: i32 = length(v349.clone());
                                    let v351: Array<char> = new_init(&'\u{0000}', v350);
                                    let v352: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method38(v350, v352.clone()) {
                                        let v354: i32 = v352.l0.get().clone();
                                        let v355: char = getCharAt(v349.clone(), v354);
                                        v351.get_mut()[v354 as usize] = v355;
                                        {
                                            let v356: i32 = v354 + 1_i32;
                                            v352.l0.set(v356);
                                            ()
                                        }
                                    }
                                    {
                                        let v358: List<char> = ofArray(v351.clone());
                                        let patternInput_3:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Documents::method63(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method62())(b0)(b1)),
                                                                                     v358,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v334,
                                                                            v335,
                                                                            v336);
                                        Documents::US12::US12_0(
                                            v340,
                                            v347,
                                            patternInput_3.0.clone(),
                                            patternInput_3.1.clone(),
                                            patternInput_3.2.clone(),
                                        )
                                    }
                                };
                                match &v369 {
                                    Documents::US12::US12_0(
                                        v369_0_0,
                                        v369_0_1,
                                        v369_0_2,
                                        v369_0_3,
                                        v369_0_4,
                                    ) => Documents::method71(
                                        ofChar(v369_0_0.clone()),
                                        v369_0_1.clone(),
                                        v369_0_2.clone(),
                                        v369_0_3.clone(),
                                        v369_0_4.clone(),
                                    ),
                                    Documents::US12::US12_1(v369_1_0) => {
                                        Documents::US13::US13_1(v369_1_0.clone())
                                    }
                                }
                            }
                            Documents::US17::US17_1(v331_1_0) => {
                                Documents::US13::US13_1(v331_1_0.clone())
                            }
                        };
                        let v397: Documents::US18 = match &v385 {
                            Documents::US13::US13_0(
                                v385_0_0,
                                v385_0_1,
                                v385_0_2,
                                v385_0_3,
                                v385_0_4,
                            ) => Documents::US18::US18_0(
                                Documents::US3::US3_0(v385_0_0.clone()),
                                v385_0_1.clone(),
                                v385_0_2.clone(),
                                v385_0_3.clone(),
                                v385_0_4.clone(),
                            ),
                            _ => Documents::US18::US18_0(
                                Documents::US3::US3_1,
                                v259,
                                v260,
                                v261,
                                v262,
                            ),
                        };
                        match &v397 {
                            Documents::US18::US18_0(
                                v397_0_0,
                                v397_0_1,
                                v397_0_2,
                                v397_0_3,
                                v397_0_4,
                            ) => Documents::US16::US16_0(
                                v257_0_0.clone(),
                                v397_0_0.clone(),
                                v397_0_1.clone(),
                                v397_0_2.clone(),
                                v397_0_3.clone(),
                                v397_0_4.clone(),
                            ),
                            Documents::US18::US18_1(v397_1_0) => {
                                Documents::US16::US16_1(v397_1_0.clone())
                            }
                        }
                    }
                    Documents::US13::US13_1(v257_1_0) => Documents::US16::US16_1(v257_1_0.clone()),
                };
                match &v411 {
                    Documents::US16::US16_0(
                        v411_0_0,
                        v411_0_1,
                        v411_0_2,
                        v411_0_3,
                        v411_0_4,
                        v411_0_5,
                    ) => Documents::US11::US11_0(v411_0_0.clone(), v411_0_1.clone()),
                    Documents::US16::US16_1(v411_1_0) => Documents::US11::US11_1(v411_1_0.clone()),
                }
            }
        }
        pub fn method74(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method74: loop {
                break '_method74 (if v1_1.get().clone() >= 4_i64 {
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
                        continue '_method74;
                    }
                });
            }
        }
        pub fn method75(
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
            '_method75: loop {
                break '_method75 ({
                    let v57: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v22: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method74(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v28, v30.clone()) {
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
                                    Documents::method63(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method62())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v57 {
                        Documents::US12::US12_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
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
                            continue '_method75;
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
        pub fn method77(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method77: loop {
                break '_method77 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method77;
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
            let v60: Documents::US12 = if string("") == v0_1.clone() {
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
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method38(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method63(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method62())(b0)(b1)
                                }),
                                v26,
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
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v102: Documents::US12 = match &v60 {
                Documents::US12::US12_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v63.clone(), v64, v65)
                        ))
                    } else {
                        let v69: char = getCharAt(v62.clone(), 0_i32);
                        let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                        let v78: string = ofChar(v69);
                        let v79: i32 = length(v78.clone());
                        let v80: Array<char> = new_init(&'\u{0000}', v79);
                        let v81: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method38(v79, v81.clone()) {
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
                                Documents::method63(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method62())(b0)(b1)
                                        }),
                                        v87,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Documents::US12::US12_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US12::US12_1(v60_1_0) => Documents::US12::US12_1(v60_1_0.clone()),
            };
            match &v102 {
                Documents::US12::US12_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Documents::US13::US13_0(
                        sprintf!("{}{}", '\\', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Documents::US12::US12_1(v102_1_0) => Documents::US13::US13_1(v102_1_0.clone()),
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
            let v60: Documents::US12 = if string("") == v0_1.clone() {
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
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method38(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method63(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method62())(b0)(b1)
                                }),
                                v26,
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
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v102: Documents::US12 = match &v60 {
                Documents::US12::US12_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v63.clone(), v64, v65)
                        ))
                    } else {
                        let v69: char = getCharAt(v62.clone(), 0_i32);
                        let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                        let v78: string = ofChar(v69);
                        let v79: i32 = length(v78.clone());
                        let v80: Array<char> = new_init(&'\u{0000}', v79);
                        let v81: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method38(v79, v81.clone()) {
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
                                Documents::method63(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method62())(b0)(b1)
                                        }),
                                        v87,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Documents::US12::US12_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US12::US12_1(v60_1_0) => Documents::US12::US12_1(v60_1_0.clone()),
            };
            match &v102 {
                Documents::US12::US12_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Documents::US13::US13_0(
                        sprintf!("{}{}", '`', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Documents::US12::US12_1(v102_1_0) => Documents::US13::US13_1(v102_1_0.clone()),
            }
        }
        pub fn method78(
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
            '_method78: loop {
                break '_method78 (match v4.get().clone().as_ref() {
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
                                continue '_method78;
                            }
                        }
                    }
                });
            }
        }
        pub fn method79(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method79: loop {
                break '_method79 (match v0_1.get().clone().as_ref() {
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
                        continue '_method79;
                    }
                });
            }
        }
        pub fn method76(
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
            '_method76: loop {
                break '_method76 ({
                    let v55: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method77(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v27, v29.clone()) {
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
                                    Documents::method63(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method62())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Documents::US13 = match &v55 {
                        Documents::US12::US12_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            Documents::US13::US13_0(
                                ofChar(v55_0_0.clone()),
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v55_1_0) => {
                            Documents::US13::US13_1(v55_1_0.clone())
                        }
                    };
                    let v81: Documents::US13 = match &v67 {
                        Documents::US13::US13_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                            v67.clone()
                        }
                        _ => Documents::method78(
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
                    match &v81 {
                        Documents::US13::US13_0(v81_0_0, v81_0_1, v81_0_2, v81_0_3, v81_0_4) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v81_0_0.clone(), v0_1.get().clone()),
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
                            continue '_method76;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method79(
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
        pub fn method80(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method80(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method81(
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
            '_method81: loop {
                break '_method81 ({
                    let v55: Documents::US12 = if string("") == v1_1.get().clone() {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method77(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v27, v29.clone()) {
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
                                    Documents::method63(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method62())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Documents::US13 = match &v55 {
                        Documents::US12::US12_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            Documents::US13::US13_0(
                                ofChar(v55_0_0.clone()),
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v55_1_0) => {
                            Documents::US13::US13_1(v55_1_0.clone())
                        }
                    };
                    match &v67 {
                        Documents::US13::US13_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v67_0_0.clone(), v0_1.get().clone()),
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
                            continue '_method81;
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method79(
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
        pub fn method82(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method82: loop {
                break '_method82 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method82;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method73(
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
            '_method73: loop {
                break '_method73 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v57: Documents::US12 = if v5 {
                        Documents::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v22: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Documents::method74(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v28, v30.clone()) {
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
                                    Documents::method63(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method62())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US12::US12_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US12::US12_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v69: Documents::US13 = match &v57 {
                        Documents::US12::US12_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                            Documents::method75(
                                ofChar(v57_0_0.clone()),
                                v57_0_1.clone(),
                                v57_0_2.clone(),
                                v57_0_3.clone(),
                                v57_0_4.clone(),
                            )
                        }
                        Documents::US12::US12_1(v57_1_0) => {
                            Documents::US13::US13_1(v57_1_0.clone())
                        }
                    };
                    let v292: Documents::US13 = match &v69 {
                        Documents::US13::US13_0(v69_0_0, v69_0_1, v69_0_2, v69_0_3, v69_0_4) => {
                            v69.clone()
                        }
                        _ => {
                            let v131: Documents::US12 = if v5 {
                                Documents::US12::US12_1(sprintf!(
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
                                    let v91: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method38(v89, v91.clone()) {
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
                                                             Documents::method63(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method62())(b0)(b1)),
                                                                                          v97,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US12::US12_0(
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
                                                                                                                    v112
                                                                                                                {
                                                                                                                 v109
                                                                                                             } else {
                                                                                                                 v112
                                                                                                             }))),
                                                                                      append(replicate(v4.get().clone()
                                                                                                           -
                                                                                                           1_i32,
                                                                                                       string(" ")),
                                                                                             string("^"))))
                                }
                            };
                            let v237: Documents::US13 = match &v131 {
                                Documents::US12::US12_0(
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
                                    let v138: Documents::US20 = Documents::method76(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v133.clone(),
                                        v134.clone(),
                                        v135,
                                        v136,
                                    );
                                    let v155: Documents::US13 = match &v138 {
                                        Documents::US20::US20_0(
                                            v138_0_0,
                                            v138_0_1,
                                            v138_0_2,
                                            v138_0_3,
                                            v138_0_4,
                                        ) => {
                                            let v145: List<string> = Documents::method80(
                                                v138_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US13::US13_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
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
                                        Documents::US20::US20_1(v138_1_0) => {
                                            Documents::US13::US13_1(v138_1_0.clone())
                                        }
                                    };
                                    match &v155 {
                                        Documents::US13::US13_0(
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
                                            let v217: Documents::US12 = if string("")
                                                == v157.clone()
                                            {
                                                Documents::US12::US12_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                    let v177: LrcPtr<Documents::Mut6> =
                                                        LrcPtr::new(Documents::Mut6 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method38(v175, v177.clone()) {
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
                                                                                 Documents::method63(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method62())(b0)(b1)),
                                                                                                              v183,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v158.clone(),
                                                                                                     v159,
                                                                                                     v160);
                                                        Documents::US12::US12_0(
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
                                                    Documents::US12::US12_1(sprintf!("{}\n{}\n",
                                                                                                          sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                   '\"',
                                                                                                                   v159,
                                                                                                                   v160,
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
                                                                                                          append(replicate(v160
                                                                                                                               -
                                                                                                                               1_i32,
                                                                                                                           string(" ")),
                                                                                                                 string("^"))))
                                                }
                                            };
                                            match &v217 {
                                                                 Documents::US12::US12_0(v217_0_0,
                                                                                         v217_0_1,
                                                                                         v217_0_2,
                                                                                         v217_0_3,
                                                                                         v217_0_4)
                                                                 =>
                                                                 Documents::US13::US13_0(v155_0_0.clone(),
                                                                                         v217_0_1.clone(),
                                                                                         v217_0_2.clone(),
                                                                                         v217_0_3.clone(),
                                                                                         v217_0_4.clone()),
                                                                 Documents::US12::US12_1(v217_1_0)
                                                                 =>
                                                                 Documents::US13::US13_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
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
                                        _ => Documents::US13::US13_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Documents::US12::US12_1(v131_1_0) => {
                                    Documents::US13::US13_1(v131_1_0.clone())
                                }
                            };
                            match &v237 {
                                Documents::US13::US13_0(
                                    v237_0_0,
                                    v237_0_1,
                                    v237_0_2,
                                    v237_0_3,
                                    v237_0_4,
                                ) => v237.clone(),
                                _ => {
                                    let v249: Documents::US13 =
                                                     Documents::method78(v1_1.get().clone(),
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
                                    let v260: Documents::US13 = match &v249 {
                                        Documents::US13::US13_0(
                                            v249_0_0,
                                            v249_0_1,
                                            v249_0_2,
                                            v249_0_3,
                                            v249_0_4,
                                        ) => Documents::US13::US13_0(
                                            string(""),
                                            v249_0_1.clone(),
                                            v249_0_2.clone(),
                                            v249_0_3.clone(),
                                            v249_0_4.clone(),
                                        ),
                                        Documents::US13::US13_1(v249_1_0) => {
                                            Documents::US13::US13_1(v249_1_0.clone())
                                        }
                                    };
                                    let v271: Documents::US20 = match &v260 {
                                        Documents::US13::US13_0(
                                            v260_0_0,
                                            v260_0_1,
                                            v260_0_2,
                                            v260_0_3,
                                            v260_0_4,
                                        ) => Documents::method81(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v260_0_1.clone(),
                                            v260_0_2.clone(),
                                            v260_0_3.clone(),
                                            v260_0_4.clone(),
                                        ),
                                        Documents::US13::US13_1(v260_1_0) => {
                                            Documents::US20::US20_1(v260_1_0.clone())
                                        }
                                    };
                                    match &v271 {
                                        Documents::US20::US20_0(
                                            v271_0_0,
                                            v271_0_1,
                                            v271_0_2,
                                            v271_0_3,
                                            v271_0_4,
                                        ) => {
                                            let v278: List<string> = Documents::method80(
                                                v271_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US13::US13_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
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
                                        Documents::US20::US20_1(v271_1_0) => {
                                            Documents::US13::US13_1(v271_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v292 {
                        Documents::US13::US13_0(
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
                            let v303: i32 = Documents::method82(v298.clone(), 0_i32);
                            let v315: Documents::US15 = if 0_i32 == v303 {
                                Documents::US15::US15_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US15::US15_0(
                                    getSlice(v298.clone(), Some(v303), Some(length(v298.clone()))),
                                    v299.clone(),
                                    v300,
                                    v301,
                                )
                            };
                            match &v315 {
                                Documents::US15::US15_0(v315_0_0, v315_0_1, v315_0_2, v315_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v297.clone(), v0_1.get().clone()),
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
                                    continue '_method73;
                                }
                                _ => Documents::US20::US20_0(
                                    Documents::method79(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v297.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v298,
                                    v299,
                                    v300,
                                    v301,
                                ),
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Documents::method79(
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
        pub fn method72(v0_1: string) -> Documents::US19 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v11: Documents::US20 = Documents::method73(
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
                match &v11 {
                    Documents::US20::US20_0(v11_0_0, v11_0_1, v11_0_2, v11_0_3, v11_0_4) => {
                        Documents::US19::US19_0(toArray(Documents::method80(
                            v11_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US20::US20_1(v11_1_0) => Documents::US19::US19_1(v11_1_0.clone()),
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
        pub fn method85(v0_1: LrcPtr<Documents::Mut4>, v1_1: Vec<std::string::String>) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method87(v0_1: LrcPtr<Documents::Mut4>, v1_1: Option<CancellationToken>) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method88(v0_1: LrcPtr<Documents::Mut4>, v1_1: Array<(string, string)>) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method89(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        ) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method90(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        ) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method91(v0_1: LrcPtr<Documents::Mut4>, v1_1: bool) {
            let v5: string = sprintf!(
                "{}",
                if v1_1 {
                    string("true")
                } else {
                    string("false")
                }
            );
            let v7: string = append(v0_1.l0.get().clone(), v5);
            v0_1.l0.set(v7);
            ()
        }
        pub fn method92(v0_1: LrcPtr<Documents::Mut4>, v1_1: Option<string>) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method86(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("command"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("cancellation_token"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method87(v0_1.clone(), v2);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("environment_variables"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method88(v0_1.clone(), v3);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("on_line"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method89(v0_1.clone(), v4);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("stdin"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method90(v0_1.clone(), v5);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("trace"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method91(v0_1.clone(), v6);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("working_directory"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method92(v0_1.clone(), v7);
            Documents::method11(v0_1, string(" }"))
        }
        pub fn method84(
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
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("file_name"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("arguments"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method85(v0_1.clone(), v2);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("options"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method86(v0_1.clone(), v3, v4, v5, v6, v7, v8, v9);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1 = v2();
                            let v340: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method84(
                                v340.clone(),
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
                                let v341: string = v340.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v341
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
        pub fn method83(
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
            Documents::method14(
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
        pub fn method93(
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
        pub fn method94() -> Func1<std::string::String, Documents::US21> {
            Func1::new(move |v: std::string::String| Documents::closure39((), v))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure41(v0_1: std::string::String, unitVar: ()) -> std::string::String {
            v0_1
        }
        pub fn method95(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure42(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method96() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure42((), v))
        }
        pub fn closure43(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method97() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure43((), v))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) -> std::string::String {
            v0_1
        }
        pub fn method99(v0_1: LrcPtr<Documents::Mut4>, v1_1: std::string::String) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("e"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method54(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method99(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method98(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<std::string::String>) {
            Documents::method14(
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            v2();
                            {
                                let v331: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(string("")),
                                });
                                Documents::method12(v331.clone());
                                {
                                    let v332: string = v331.l0.get().clone();
                                    trimEndChars(
                                        trimStartChars(
                                            sprintf!(
                                                "{} {} #{} {} / {}",
                                                v152,
                                                v328,
                                                v329,
                                                v1_1(),
                                                v332
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
        pub fn method100(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<()>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure49(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method101(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>
        {
            v0_1
        }
        pub fn closure50(
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
        pub fn method102(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure50((), v)
            })
        }
        pub fn method103(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn method104(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn method105(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method106(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method107(
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
        pub fn method108(
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
        pub fn method111(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32) {
            let v2: string = sprintf!("{}", v1_1);
            let v4: string = append(v0_1.l0.get().clone(), v2);
            v0_1.l0.set(v4);
            ()
        }
        pub fn method110(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: i32) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("std_trace_length"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v2);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, i32) = v2();
                            let v333: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method110(
                                v333.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v334: string = v333.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v334
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
        pub fn method109(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, i32)>) {
            Documents::method14(
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
        pub fn method114(
            v0_1: LrcPtr<Documents::Mut4>,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("options"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method86(v0_1.clone(), v1_1, v2, v3, v4, v5, v6, v7);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1 = v2();
                            let v338: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method114(
                                v338.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                                patternInput_1.5.clone(),
                                patternInput_1.6.clone(),
                            );
                            {
                                let v339: string = v338.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v339
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
        pub fn method113(
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
            Documents::method14(
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
        pub fn closure64(v0_1: (), unitVar: ()) {
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
        pub fn closure65(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options_async / WaitForExitAsync")
        }
        pub fn closure66(
            v0_1: LrcPtr<TaskCanceledException>,
            unitVar: (),
        ) -> LrcPtr<TaskCanceledException> {
            v0_1
        }
        pub fn method117(v0_1: LrcPtr<Documents::Mut4>, v1_1: LrcPtr<TaskCanceledException>) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method116(v0_1: LrcPtr<Documents::Mut4>, v1_1: LrcPtr<TaskCanceledException>) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("ex"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method117(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method116(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method115(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<LrcPtr<TaskCanceledException>>,
        ) {
            Documents::method14(
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
        pub fn method119(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: i32) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("output_length"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v2);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, i32) = v2();
                            let v333: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method119(
                                v333.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v334: string = v333.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v334
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
        pub fn method118(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, i32)>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure70(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method112(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
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
        pub fn method59(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v7: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let v9: Documents::US11 = Documents::method61(Documents::method60(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US3) = match &v9 {
                Documents::US11::US11_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Documents::US11::US11_1(v9_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v9_1_0.clone()),
                ),
            };
            let v19: Documents::US3 = patternInput.1.clone();
            let v18: string = patternInput.0.clone();
            let v24: Documents::US19 = Documents::method72(match &v19 {
                Documents::US3::US3_0(v19_0_0) => match &v19 {
                    Documents::US3::US3_0(x) => x.clone(),
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
            Documents::method83(
                Documents::US0::US0_1,
                Func0::new(move || Documents::closure35((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v18 = v18.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v44 = v44.clone();
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
                            v18.clone(),
                            v44.clone(),
                            (),
                        )
                    }
                }),
            );
            {
                let _v48: MutCell<Option<LrcPtr<(i32, string)>>> =
                    MutCell::new(None::<LrcPtr<(i32, string)>>);
                {
                    let x_15: LrcPtr<(i32, string)> = (Func0::new({
                        let v18 = v18.clone();
                        let v2 = v2.clone();
                        let v4 = v4.clone();
                        let v44 = v44.clone();
                        let v5 = v5.clone();
                        let v6 = v6.clone();
                        move || {
                            let v50: std::process::Command =
                                std::process::Command::new(&*v18.clone());
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
                                        }))())
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
                                let v95: &mut std::process::Command =
                                    if count_2(v2.clone()) as u64 == 0_u64 {
                                        v77
                                    } else {
                                        let v81: Vec<(string, string)> = v2.clone().to_vec();
                                        let v83: bool = true;
                                        let _result = v81.into_iter().fold(v77, |acc, x| {
                                            //;
                                            let v85: &mut std::process::Command = acc;
                                            let patternInput_1: (string, string) = x;
                                            let v90: &mut std::process::Command =
                                                std::process::Command::env(
                                                    v85,
                                                    &*patternInput_1.0.clone(),
                                                    &*patternInput_1.1.clone(),
                                                );
                                            let v92: bool = true;
                                            v90
                                        });
                                        _result
                                    };
                                let v97: Result<std::process::Child, std::io::Error> =
                                    std::process::Command::spawn(v95);
                                let v98 = Documents::method46();
                                let v100: Result<std::process::Child, std::string::String> =
                                    v97.map_err(|x| v98(x));
                                let v102: bool = true;
                                let _result = v100.map(|x| {
                                    //;
                                    let v104: std::process::Child = x;
                                    let v107: std::sync::Mutex<Option<std::process::Child>> =
                                        std::sync::Mutex::new(Some(v104));
                                    let v109: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = std::sync::Arc::new(v107);
                                    let v111: bool = true;
                                    v109
                                });
                                let v113: Result<
                                    std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                                    std::string::String,
                                > = _result;
                                let v114 = Documents::method93();
                                let v115 = Documents::method94();
                                let v117: Documents::US21 = match v113 {
                                    Ok(x) => v114(x),
                                    Err(e) => v115(e),
                                };
                                let patternInput_3: (i32, Documents::US4, Documents::US22) =
                                    match &v117 {
                                        Documents::US21::US21_0(v117_0_0) => {
                                            let v118: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = v117_0_0.clone();
                                            let v120: bool = true;
                                            let _result = (|| {
                                                //;
                                                let v121: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method95(v118.clone());
                                                let v123: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v121.lock();
                                                let v125: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v123.unwrap();
                                                let v127: bool = true;
                                                let mut v125 = v125;
                                                let v129: &mut Option<std::process::Child> =
                                                    &mut v125;
                                                let v131: Option<&mut std::process::Child> =
                                                    v129.as_mut();
                                                let v133: &mut std::process::Child = v131.unwrap();
                                                let v135: &mut Option<std::process::ChildStdout> =
                                                    &mut v133.stdout;
                                                let v137: Option<std::process::ChildStdout> =
                                                    Option::take(v135);
                                                let v139: std::process::ChildStdout = v137.unwrap();
                                                let v141: bool = true;
                                                v139
                                            })(
                                            );
                                            let v143: std::process::ChildStdout = _result;
                                            let v145: bool = true;
                                            let _result = (|| {
                                                //;
                                                let v146: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method95(v118.clone());
                                                let v148: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v146.lock();
                                                let v150: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v148.unwrap();
                                                let v152: bool = true;
                                                let mut v150 = v150;
                                                let v154: &mut Option<std::process::Child> =
                                                    &mut v150;
                                                let v156: Option<&mut std::process::Child> =
                                                    v154.as_mut();
                                                let v158: &mut std::process::Child = v156.unwrap();
                                                let v160: &mut Option<std::process::ChildStderr> =
                                                    &mut v158.stderr;
                                                let v162: Option<std::process::ChildStderr> =
                                                    Option::take(v160);
                                                let v164: std::process::ChildStderr = v162.unwrap();
                                                let v166: bool = true;
                                                v164
                                            })(
                                            );
                                            let v168: std::process::ChildStderr = _result;
                                            let v170: bool = true;
                                            let _result = (|| {
                                                //;
                                                let v171: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = Documents::method95(v118.clone());
                                                let v173: Result<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        >,
                                                    >,
                                                > = v171.lock();
                                                let v175: std::sync::MutexGuard<
                                                    Option<std::process::Child>,
                                                > = v173.unwrap();
                                                let v177: bool = true;
                                                let mut v175 = v175;
                                                let v179: &mut Option<std::process::Child> =
                                                    &mut v175;
                                                let v181: Option<&mut std::process::Child> =
                                                    v179.as_mut();
                                                let v183: &mut std::process::Child = v181.unwrap();
                                                let v185: &mut Option<std::process::ChildStdin> =
                                                    &mut v183.stdin;
                                                let v187: Option<std::process::ChildStdin> =
                                                    Option::take(v185);
                                                let v189: std::process::ChildStdin = v187.unwrap();
                                                let v192: std::sync::Mutex<
                                                    Option<std::process::ChildStdin>,
                                                > = std::sync::Mutex::new(Some(v189));
                                                let v194: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                > = std::sync::Arc::new(v192);
                                                let v196: bool = true;
                                                v194
                                            })(
                                            );
                                            let v198: std::sync::Arc<
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
                                            let v200: std::sync::mpsc::Sender<std::string::String> =
                                                patternInput_2.0.clone();
                                            let v203: std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = std::sync::Mutex::new(v200.clone());
                                            let v205: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = std::sync::Arc::new(v203);
                                            let v207: std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = std::sync::Mutex::new(v200);
                                            let v209: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = std::sync::Arc::new(v207);
                                            let v211: std::sync::Mutex<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            > = std::sync::Mutex::new(patternInput_2.1.clone());
                                            let v213: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = std::sync::Arc::new(v211);
                                            let v215: bool = true;
                                            let __result = std::thread::spawn(move || {
                                                //;
                                                let v217: encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                                    .utf8_passthru(true)
                                                    .build(v143);
                                                let v219: std::io::BufReader<
                                                    encoding_rs_io::DecodeReaderBytes<
                                                        std::process::ChildStdout,
                                                        Vec<u8>,
                                                    >,
                                                > = std::io::BufReader::new(v217);
                                                let v221: std::io::Lines<
                                                    std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStdout,
                                                            Vec<u8>,
                                                        >,
                                                    >,
                                                > = std::io::BufRead::lines(v219);
                                                let v223: bool = true;
                                                let mut v221 = v221;
                                                let _result = v221.try_for_each(|x| { //;
                                                                let v225:
                                                                        Result<std::string::String,
                                                                               std::io::Error> =
                                                                    x;
                                                                let v227:
                                                                        std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                    v205.clone();
                                                                let v228 =
                                                                    Documents::method46();
                                                                let v230:
                                                                        Result<std::string::String,
                                                                               std::string::String> =
                                                                    v225.map_err(|x| v228(x));
                                                                let v231 =
                                                                    Documents::method96();
                                                                let v232 =
                                                                    Documents::method97();
                                                                let v234:
                                                                        Documents::US23 =
                                                                    match v230 { Ok(x) => v231(x), Err(e) => v232(e) };
                                                                let v267:
                                                                        std::string::String =
                                                                    match &v234
                                                                        {
                                                                        Documents::US23::US23_0(v234_0_0)
                                                                        => {
                                                                            let v237:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v234_0_0.clone());
                                                                            let v239:
                                                                                    &encoding_rs::Encoding =
                                                                                encoding_rs::UTF_8;
                                                                            let v241:
                                                                                    std::borrow::Cow<[u8]> =
                                                                                v239.encode(&*v237).0;
                                                                            let v243:
                                                                                    &[u8] =
                                                                                v241.as_ref();
                                                                            let v245:
                                                                                    Result<&str,
                                                                                           std::str::Utf8Error> =
                                                                                std::str::from_utf8(v243);
                                                                            let v247:
                                                                                    &str =
                                                                                v245.unwrap();
                                                                            let v249:
                                                                                    std::string::String =
                                                                                String::from(v247);
                                                                            let v252:
                                                                                    string =
                                                                                sprintf!("> {}",
                                                                                         fable_library_rust::String_::fromString(v249.clone()));
                                                                            if v5
                                                                               {
                                                                                Documents::method100(Documents::US0::US0_0,
                                                                                                     Func0::new({
                                                                                                                    let v252
                                                                                                                        =
                                                                                                                        v252.clone();
                                                                                                                    move
                                                                                                                        ||
                                                                                                                        Documents::closure47(v252.clone(),
                                                                                                                                             ())
                                                                                                                }),
                                                                                                     Func0::new(move
                                                                                                                    ||
                                                                                                                    Documents::closure48((),
                                                                                                                                         ())))
                                                                            } else {
                                                                                printfn!("{0}",
                                                                                         v252.clone())
                                                                            }
                                                                            v249
                                                                        }
                                                                        Documents::US23::US23_1(v234_1_0)
                                                                        => {
                                                                            let v257:
                                                                                    std::string::String =
                                                                                v234_1_0.clone();
                                                                            Documents::method98(Documents::US0::US0_4,
                                                                                                Func0::new(move
                                                                                                               ||
                                                                                                               Documents::closure44((),
                                                                                                                                    ())),
                                                                                                Func0::new({
                                                                                                               let v257
                                                                                                                   =
                                                                                                                   v257.clone();
                                                                                                               move
                                                                                                                   ||
                                                                                                                   Documents::closure45(v257.clone(),
                                                                                                                                        ())
                                                                                                           }));
                                                                            {
                                                                                let v261:
                                                                                        string =
                                                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                             v257.clone());
                                                                                let v263:
                                                                                        &str =
                                                                                    &*v261;
                                                                                String::from(v263)
                                                                            }
                                                                        }
                                                                    };
                                                                let v268:
                                                                        std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                    Documents::method101(v227);
                                                                let v270:
                                                                        Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                               std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                    v268.lock();
                                                                let v272:
                                                                        std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                    v270.unwrap();
                                                                let v274:
                                                                        &std::sync::mpsc::Sender<std::string::String> =
                                                                    &v272;
                                                                let v276:
                                                                        Result<(),
                                                                               std::sync::mpsc::SendError<std::string::String>> =
                                                                    v274.send(v267);
                                                                let v277 =
                                                                    Documents::method102();
                                                                let v279:
                                                                        Result<(),
                                                                               std::string::String> =
                                                                    v276.map_err(|x| v277(x));
                                                                let v281: _ =
                                                                    v279;
                                                                let v283:
                                                                        bool =
                                                                    true; v281 }); //;
                                                let v286: Result<(), string> = Documents::method103(
                                                    _result.map_err(|x| x.into()),
                                                );
                                                let v290: string = string("v286 });  //");
                                                v286
                                            }); //;
                                            {
                                                let v292: std::thread::JoinHandle<
                                                    Result<(), string>,
                                                > = __result;
                                                let v294: bool = true;
                                                let __result = std::thread::spawn(move || {
                                                    //;
                                                    let v296:
                                                                            encoding_rs_io::DecodeReaderBytes<std::process::ChildStderr, Vec<u8>> =
                                                                        encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v168);
                                                    let v298: std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStderr,
                                                            Vec<u8>,
                                                        >,
                                                    > = std::io::BufReader::new(v296);
                                                    let v300: std::io::Lines<
                                                        std::io::BufReader<
                                                            encoding_rs_io::DecodeReaderBytes<
                                                                std::process::ChildStderr,
                                                                Vec<u8>,
                                                            >,
                                                        >,
                                                    > = std::io::BufRead::lines(v298);
                                                    let v302: bool = true;
                                                    let mut v300 = v300;
                                                    let _result = v300.try_for_each(|x| { //;
                                                                    let v304:
                                                                            Result<std::string::String,
                                                                                   std::io::Error> =
                                                                        x;
                                                                    let v306:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        v209.clone();
                                                                    let v307 =
                                                                        Documents::method46();
                                                                    let v309:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v304.map_err(|x| v307(x));
                                                                    let v310 =
                                                                        Documents::method96();
                                                                    let v311 =
                                                                        Documents::method97();
                                                                    let v313:
                                                                            Documents::US23 =
                                                                        match v309 { Ok(x) => v310(x), Err(e) => v311(e) };
                                                                    let v351:
                                                                            std::string::String =
                                                                        match &v313
                                                                            {
                                                                            Documents::US23::US23_0(v313_0_0)
                                                                            =>
                                                                            {
                                                                                let v316:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v313_0_0.clone());
                                                                                let v318:
                                                                                        &encoding_rs::Encoding =
                                                                                    encoding_rs::UTF_8;
                                                                                let v320:
                                                                                        std::borrow::Cow<[u8]> =
                                                                                    v318.encode(&*v316).0;
                                                                                let v322:
                                                                                        &[u8] =
                                                                                    v320.as_ref();
                                                                                let v324:
                                                                                        Result<&str,
                                                                                               std::str::Utf8Error> =
                                                                                    std::str::from_utf8(v322);
                                                                                let v326:
                                                                                        &str =
                                                                                    v324.unwrap();
                                                                                let v328:
                                                                                        std::string::String =
                                                                                    String::from(v326);
                                                                                let v331:
                                                                                        string =
                                                                                    sprintf!("! {}",
                                                                                             fable_library_rust::String_::fromString(v328.clone()));
                                                                                if v5
                                                                                   {
                                                                                    Documents::method100(Documents::US0::US0_0,
                                                                                                         Func0::new({
                                                                                                                        let v331
                                                                                                                            =
                                                                                                                            v331.clone();
                                                                                                                        move
                                                                                                                            ||
                                                                                                                            Documents::closure47(v331.clone(),
                                                                                                                                                 ())
                                                                                                                    }),
                                                                                                         Func0::new(move
                                                                                                                        ||
                                                                                                                        Documents::closure48((),
                                                                                                                                             ())))
                                                                                } else {
                                                                                    printfn!("{0}",
                                                                                             v331.clone())
                                                                                }
                                                                                {
                                                                                    let v336:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v328);
                                                                                    let v338:
                                                                                            &str =
                                                                                        &*v336;
                                                                                    String::from(v338)
                                                                                }
                                                                            }
                                                                            Documents::US23::US23_1(v313_1_0)
                                                                            =>
                                                                            {
                                                                                let v341:
                                                                                        std::string::String =
                                                                                    v313_1_0.clone();
                                                                                Documents::method98(Documents::US0::US0_4,
                                                                                                    Func0::new(move
                                                                                                                   ||
                                                                                                                   Documents::closure44((),
                                                                                                                                        ())),
                                                                                                    Func0::new({
                                                                                                                   let v341
                                                                                                                       =
                                                                                                                       v341.clone();
                                                                                                                   move
                                                                                                                       ||
                                                                                                                       Documents::closure45(v341.clone(),
                                                                                                                                            ())
                                                                                                               }));
                                                                                {
                                                                                    let v345:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v341.clone());
                                                                                    let v347:
                                                                                            &str =
                                                                                        &*v345;
                                                                                    String::from(v347)
                                                                                }
                                                                            }
                                                                        };
                                                                    let v352:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        Documents::method101(v306);
                                                                    let v354:
                                                                            Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                        v352.lock();
                                                                    let v356:
                                                                            std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                        v354.unwrap();
                                                                    let v358:
                                                                            &std::sync::mpsc::Sender<std::string::String> =
                                                                        &v356;
                                                                    let v360:
                                                                            Result<(),
                                                                                   std::sync::mpsc::SendError<std::string::String>> =
                                                                        v358.send(v351);
                                                                    let v361 =
                                                                        Documents::method102();
                                                                    let v363:
                                                                            Result<(),
                                                                                   std::string::String> =
                                                                        v360.map_err(|x| v361(x));
                                                                    let v365:
                                                                            _ =
                                                                        v363;
                                                                    let v367:
                                                                            bool =
                                                                        true; v365 }); //;
                                                    let v370: Result<(), string> =
                                                        Documents::method103(
                                                            _result.map_err(|x| x.into()),
                                                        );
                                                    let v372: string = string("v370 });  //");
                                                    v370
                                                }); //;
                                                {
                                                    let v374: std::thread::JoinHandle<
                                                        Result<(), string>,
                                                    > = __result;
                                                    let _v375: LrcPtr<
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
                                                        _v375.set(x_5)
                                                    }
                                                    {
                                                        let v380: Documents::US24 = defaultValue(
                                                            Documents::US24::US24_1,
                                                            _v375.get().clone(),
                                                        );
                                                        match &v380 {
                                                            Documents::US24::US24_0(v380_0_0) => {
                                                                let v382:
                                                                                            std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> =
                                                                                        Documents::method104(v198);
                                                                let v384:
                                                                                            Result<std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<Option<std::process::ChildStdin>>>> =
                                                                                        v382.lock();
                                                                let v386: std::sync::MutexGuard<
                                                                    Option<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                > = v384.unwrap();
                                                                let v388: bool = true;
                                                                let mut v386 = v386;
                                                                let v390: &mut Option<
                                                                    std::process::ChildStdin,
                                                                > = &mut v386;
                                                                let v392: Option<
                                                                    std::process::ChildStdin,
                                                                > = Option::take(v390);
                                                                let v394: bool = true;
                                                                let _result = v392.map(|x| { //;
                                                                                    let v396:
                                                                                            std::process::ChildStdin =
                                                                                        x;
                                                                                    let v398:
                                                                                            std::sync::Mutex<std::process::ChildStdin> =
                                                                                        std::sync::Mutex::new(v396);
                                                                                    let v400:
                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                        std::sync::Arc::new(v398);
                                                                                    let v402:
                                                                                            bool =
                                                                                        true; v400 });
                                                                let v404:
                                                                                            Option<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>> =
                                                                                        _result;
                                                                let _v405: LrcPtr<
                                                                    MutCell<
                                                                        Option<Documents::US25>,
                                                                    >,
                                                                > = refCell(
                                                                    None::<Documents::US25>,
                                                                );
                                                                {
                                                                    let x_8: Option<
                                                                        Documents::US25,
                                                                    > = match &v404 {
                                                                        None => {
                                                                            None::<Documents::US25>
                                                                        }
                                                                        Some(v404_0_0) => {
                                                                            let x_6:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        v404_0_0.clone();
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
                                                                    _v405.set(x_8)
                                                                }
                                                                {
                                                                    let v410: Documents::US25 =
                                                                        defaultValue(
                                                                            Documents::US25::US25_1,
                                                                            _v405.get().clone(),
                                                                        );
                                                                    match &v410 {
                                                                        Documents::US25::US25_0(
                                                                            v410_0_0,
                                                                        ) => {
                                                                            let v411:
                                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                    match &v410
                                                                                                        {
                                                                                                        Documents::US25::US25_0(x)
                                                                                                        =>
                                                                                                        x.clone(),
                                                                                                        _
                                                                                                        =>
                                                                                                        unreachable!(),
                                                                                                    };
                                                                            (match &v380
                                                                                                     {
                                                                                                     Documents::US24::US24_0(x)
                                                                                                     =>
                                                                                                     x.clone(),
                                                                                                     _
                                                                                                     =>
                                                                                                     unreachable!(),
                                                                                                 })(v411.clone());
                                                                            {
                                                                                let v412:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        Documents::method105(v411);
                                                                                let v414:
                                                                                                            Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                        v412.lock();
                                                                                let v417:
                                                                                                            std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                        Documents::method106(v414.unwrap());
                                                                                let v419: bool =
                                                                                    true;
                                                                                let mut v417 = v417;
                                                                                let v421: bool =
                                                                                    true;
                                                                                std::io::Write::flush(&mut *v417).unwrap();
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
                                                            let v422: std::sync::Arc<
                                                                std::sync::Mutex<
                                                                    Option<std::process::Child>,
                                                                >,
                                                            > = Documents::method95(v118);
                                                            let v424: Result<
                                                                std::sync::MutexGuard<
                                                                    Option<std::process::Child>,
                                                                >,
                                                                std::sync::PoisonError<
                                                                    std::sync::MutexGuard<
                                                                        Option<std::process::Child>,
                                                                    >,
                                                                >,
                                                            > = v422.lock();
                                                            let v426: std::sync::MutexGuard<
                                                                Option<std::process::Child>,
                                                            > = v424.unwrap();
                                                            let v428: bool = true;
                                                            let mut v426 = v426;
                                                            let v430: &mut Option<
                                                                std::process::Child,
                                                            > = &mut v426;
                                                            let v432: Option<std::process::Child> =
                                                                Option::take(v430);
                                                            let v434: std::process::Child =
                                                                v432.unwrap();
                                                            let v436: Result<
                                                                std::process::Output,
                                                                std::io::Error,
                                                            > = v434.wait_with_output();
                                                            let v437 = Documents::method46();
                                                            let v439: Result<
                                                                std::process::Output,
                                                                std::string::String,
                                                            > = v436.map_err(|x| v437(x));
                                                            let v440: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method107(v374);
                                                            let v443: string = string("v440");
                                                            let v444: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = Documents::method107(v292);
                                                            let v449: string = append(
                                                                append(
                                                                    string("vec!["),
                                                                    append(string("v444, "), v443),
                                                                ),
                                                                string("]"),
                                                            );
                                                            let v450: Vec<
                                                                std::thread::JoinHandle<
                                                                    Result<(), string>,
                                                                >,
                                                            > = vec![v444, v440];
                                                            let v452: bool = true;
                                                            v450.into_iter().for_each(|x| {
                                                                //;
                                                                let v454: std::thread::JoinHandle<
                                                                    Result<(), string>,
                                                                > = x;
                                                                let v456: Result<
                                                                    Result<(), string>,
                                                                    Box<
                                                                        dyn core::any::Any
                                                                            + 'static
                                                                            + Send,
                                                                    >,
                                                                > = std::thread::JoinHandle::join(
                                                                    v454,
                                                                );
                                                                let v458: Result<(), string> =
                                                                    v456.unwrap();
                                                                v458.unwrap();
                                                                {
                                                                    let v461: bool = true;
                                                                    ()
                                                                }
                                                            });
                                                            {
                                                                //;
                                                                let v464: Documents::US26 =
                                                                    match &v439 {
                                                                        Err(v439_1_0) => {
                                                                            Documents::closure52(
                                                                                (),
                                                                                v439_1_0.clone(),
                                                                            )
                                                                        }
                                                                        Ok(v439_0_0) => {
                                                                            Documents::closure51(
                                                                                (),
                                                                                v439_0_0.clone(),
                                                                            )
                                                                        }
                                                                    };
                                                                match &v464 {
                                                                    Documents::US26::US26_0(
                                                                        v464_0_0,
                                                                    ) => {
                                                                        let v467:
                                                                                                    std::process::ExitStatus =
                                                                                                v464_0_0.clone().status;
                                                                        let v469: Option<i32> =
                                                                            v467.code();
                                                                        let _v470: LrcPtr<
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
                                                                            > = match &v469 {
                                                                                None => None::<
                                                                                    Documents::US27,
                                                                                >,
                                                                                Some(v469_0_0) => {
                                                                                    let x_11: i32 =
                                                                                        v469_0_0
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
                                                                            _v470.set(x_13)
                                                                        }
                                                                        {
                                                                            let v475:
                                                                                                        Documents::US27 =
                                                                                                    defaultValue(Documents::US27::US27_1,
                                                                                                                 _v470.get().clone());
                                                                            match &v475
                                                                                                    {
                                                                                                    Documents::US27::US27_0(v475_0_0)
                                                                                                    =>
                                                                                                    (match &v475
                                                                                                         {
                                                                                                         Documents::US27::US27_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     },
                                                                                                     Documents::US4::US4_1,
                                                                                                     Documents::US22::US22_0(v213.clone())),
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v481:
                                                                                                                &str =
                                                                                                            &*string("runtime.execute_with_options / exit_code=None");
                                                                                                        (-1_i32,
                                                                                                         Documents::US4::US4_0(String::from(v481)),
                                                                                                         Documents::US22::US22_0(v213.clone()))
                                                                                                    }
                                                                                                }
                                                                        }
                                                                    }
                                                                    Documents::US26::US26_1(
                                                                        v464_1_0,
                                                                    ) => {
                                                                        let v492:
                                                                                                    std::string::String =
                                                                                                v464_1_0.clone();
                                                                        Documents::method52(
                                                                            Documents::US0::US0_4,
                                                                            Func0::new(move || {
                                                                                Documents::closure53(
                                                                                    (),
                                                                                    (),
                                                                                )
                                                                            }),
                                                                            Func0::new({
                                                                                let v492 =
                                                                                    v492.clone();
                                                                                move || {
                                                                                    Documents::closure54(v492.clone(),
                                                                                                                                                        ())
                                                                                }
                                                                            }),
                                                                        );
                                                                        (
                                                                            -2_i32,
                                                                            Documents::US4::US4_0(
                                                                                v492.clone(),
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
                                        Documents::US21::US21_1(v117_1_0) => {
                                            let v504: std::string::String = v117_1_0.clone();
                                            Documents::method52(
                                                Documents::US0::US0_4,
                                                Func0::new(move || Documents::closure40((), ())),
                                                Func0::new({
                                                    let v504 = v504.clone();
                                                    move || Documents::closure41(v504.clone(), ())
                                                }),
                                            );
                                            (
                                                -1_i32,
                                                Documents::US4::US4_0(v504.clone()),
                                                Documents::US22::US22_1,
                                            )
                                        }
                                    };
                                let v515: Documents::US22 = patternInput_3.2.clone();
                                let v514: Documents::US4 = patternInput_3.1.clone();
                                let v513: i32 = patternInput_3.0.clone();
                                let v520: Option<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                > = match &v515 {
                                    Documents::US22::US22_0(v515_0_0) => Some(match &v515 {
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
                                let v522: bool = true;
                                let _result = v520.map(|x| {
                                    //;
                                    let v525: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = Documents::method108(x);
                                    let v527: Result<
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
                                    > = v525.lock();
                                    let v529: std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = v527.unwrap();
                                    let v531 = v529.iter();
                                    let v533: Vec<std::string::String> = v531.collect::<Vec<_>>();
                                    let v535: bool = true;
                                    let _result: Vec<_> = v533
                                        .into_iter()
                                        .map(|x| {
                                            //;
                                            let v537: std::string::String = x;
                                            let v539: string =
                                                fable_library_rust::String_::fromString(v537);
                                            let v541: bool = true;
                                            v539
                                        })
                                        .collect::<Vec<_>>();
                                    let v543: Vec<string> = _result;
                                    let v551: string = join(
                                        string("\n"),
                                        toArray_1(ofArray_1(
                                            fable_library_rust::NativeArray_::array_from(v543),
                                        )),
                                    );
                                    let v553: bool = true;
                                    v551
                                });
                                let v555: Option<string> = _result;
                                let v562: Documents::US3 = match &v514 {
                                    Documents::US4::US4_0(v514_0_0) => Documents::US3::US3_0(
                                        fable_library_rust::String_::fromString(match &v514 {
                                            Documents::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }),
                                    ),
                                    _ => Documents::US3::US3_1,
                                };
                                let v567: string = defaultValue(
                                    match &v562 {
                                        Documents::US3::US3_0(v562_0_0) => match &v562 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => string(""),
                                    },
                                    v555,
                                );
                                Documents::method109(
                                    Documents::US0::US0_0,
                                    Func0::new(move || Documents::closure55((), ())),
                                    Func0::new({
                                        let v513 = v513.clone();
                                        let v567 = v567.clone();
                                        move || Documents::closure56(v513, v567.clone(), ())
                                    }),
                                );
                                LrcPtr::new((v513, v567.clone()))
                            }
                        }
                    }))();
                    _v48.set(Some(x_15))
                }
                {
                    let v572: LrcPtr<(i32, string)> = match &_v48.get().clone() {
                        None => panic!("{}", string("base.capture / _v48=None"),),
                        Some(_v48_0_0) => _v48_0_0.clone(),
                    };
                    _v7.set(Some((v572.0.clone(), v572.1.clone())));
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
        pub fn method121(v0_1: string) -> string {
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
        pub fn method120(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method20(v2, Documents::method121(v1_1.clone()));
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
        pub fn method122() -> Func1<string, Documents::US31> {
            Func1::new(move |v: string| Documents::closure71((), v))
        }
        pub fn closure72(unitVar: (), v0_1: std::string::String) -> Documents::US31 {
            Documents::US31::US31_1(v0_1)
        }
        pub fn method123() -> Func1<std::string::String, Documents::US31> {
            Func1::new(move |v: std::string::String| Documents::closure72((), v))
        }
        pub fn method124(v0_1: string) -> bool {
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
        pub fn method127(v0_1: LrcPtr<Documents::Mut4>, v1_1: Documents::US3) {
            Documents::method11(v0_1, sprintf!("{:?}", v1_1));
        }
        pub fn method126(
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
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("file"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("real_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v2);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("relative_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v3);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("origin_hash_exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v4);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("origin_hash"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v5);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("local_git_hash_exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v6);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("local_git_hash"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v7);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("hash1"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v8);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("hash2"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method127(v0_1.clone(), v9);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("dist_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v10);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("cache_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v11);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
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
                            let v342: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method126(
                                v342.clone(),
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
                                let v343: string = v342.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v343
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
        pub fn method125(
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
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure75(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method129(v0_1: string) -> string {
            v0_1
        }
        pub fn method128(v0_1: string, v1_1: string) {
            let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v3: string = Documents::method129(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1, &*v3);
            let v7: u64 = v5.unwrap();
            _v2.set(Some(()));
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
            ()
        }
        pub fn method131(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method132(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method133(v0_1: string) -> string {
            v0_1
        }
        pub fn method134(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure78(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v2: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                Documents::method105(v1_1);
            let v4: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v2.lock();
            let v6: std::sync::MutexGuard<std::process::ChildStdin> = v4.unwrap();
            let v7: string = Documents::method133(v0_1);
            let v9: &[u8] = v7.as_bytes();
            let v10: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method134(v6);
            let v12: bool = true;
            let mut v10 = v10;
            let v14: bool = true;
            std::io::Write::write_all(&mut *v10, v9).unwrap();
            ()
        }
        pub fn method135(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method136(v0_1: string) -> string {
            v0_1
        }
        pub fn closure79(unitVar: (), unitVar_1: ()) -> string {
            string("documents.hangul")
        }
        pub fn closure80(v0_1: string, v1_1: i32, v2: string, unitVar: ()) -> (i32, i32, string) {
            (v1_1, length(v2), v0_1)
        }
        pub fn method138(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: i32, v3: string) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("result_len"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v2);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("output_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v3);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, i32, string) = v2();
                            let v334: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method138(
                                v334.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            );
                            {
                                let v335: string = v334.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v335
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
        pub fn method137(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, i32, string)>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure81(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method130(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US32 {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v5: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
            {
                let x: Vec<u8> = std::fs::read(&*v3).unwrap();
                _v5.set(Some(x))
            }
            {
                let v16: Vec<u8> = Documents::method131(match &_v5.get().clone() {
                    None => panic!("{}", string("base.run_target / _v5=None"),),
                    Some(_v5_0_0) => _v5_0_0.clone(),
                });
                let v18: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v16);
                let v20: std::string::String = v18.unwrap();
                {
                    let x_2: string = fable_library_rust::String_::fromString(v20);
                    _v4.set(Some(x_2))
                }
                {
                    let v30: Array<string> = split(
                        match &_v4.get().clone() {
                            None => panic!("{}", string("base.run_target / _v4=None"),),
                            Some(_v4_0_0) => _v4_0_0.clone(),
                        },
                        string("\n"),
                        -1_i32,
                        0_i32,
                    );
                    let v31: i32 = count_2(v30.clone());
                    let v32: Array<string> = new_init(&string(""), v31);
                    let v33: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method38(v31, v33.clone()) {
                        let v35: i32 = v33.l0.get().clone();
                        let v38: string = trim(v30[v35].clone());
                        v32.get_mut()[v35 as usize] = v38;
                        {
                            let v39: i32 = v35 + 1_i32;
                            v33.l0.set(v39);
                            ()
                        }
                    }
                    {
                        let v40: i32 = count_2(v32.clone());
                        let v41: Array<string> = new_init(&string(""), v40);
                        let v42: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                        });
                        while Documents::method132(v40, v42.clone()) {
                            let v44: i32 = v42.l0.get().clone();
                            let v45: i32 = v42.l1.get().clone();
                            let v46: string = v32[v44].clone();
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
                            let v54: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method38(v52, v54.clone()) {
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
                                let v63: string = sprintf!(
                                    "{}\n\n",
                                    join(
                                        string("\n"),
                                        toArray_1(delay(Func0::new({
                                            let v53 = v53.clone();
                                            move || {
                                                map(
                                                    Func1::new({
                                                        let v53 = v53.clone();
                                                        move |i: i32| v53[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count_2(v53.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        })))
                                    )
                                );
                                let _v69: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                                {
                                    let x_4: bool = cfg!(windows);
                                    _v69.set(Some(x_4))
                                }
                                {
                                    let patternInput: (i32, string) =
                                        Documents::method59(sprintf!("{} {}",
                                                                     Documents::method20(v0_1,
                                                                                         sprintf!("../vault/deps/hangulize/cmd/hangulize/hangulize{}",
                                                                                                  if match &_v69.get().clone()
                                                                                                         {
                                                                                                         None
                                                                                                         =>
                                                                                                         panic!("{}",
                                                                                                                string("base.run_target / _v69=None"),),
                                                                                                         Some(_v69_0_0)
                                                                                                         =>
                                                                                                         _v69_0_0.clone(),
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
                                                                                let v63
                                                                                    =
                                                                                    v63.clone();
                                                                                move
                                                                                    |v:
                                                                                         std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>|
                                                                                    Documents::closure78(v63.clone(),
                                                                                                         v)
                                                                            })),
                                                            true,
                                                            None::<string>);
                                    let v97: i32 = patternInput.0.clone();
                                    let v99: Array<string> =
                                        split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                                    let v100: i32 = count_2(v99.clone());
                                    let v102: LrcPtr<Documents::Mut8> =
                                        LrcPtr::new(Documents::Mut8 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(string("")),
                                            l2: MutCell::new(0_i32),
                                            l3: MutCell::new(0_i32),
                                        });
                                    while Documents::method135(v40, v102.clone()) {
                                        let v104: i32 = v102.l0.get().clone();
                                        let matchValue: string = v102.l1.get().clone();
                                        let matchValue_1: i32 = v102.l2.get().clone();
                                        let v107: i32 = v102.l3.get().clone();
                                        let v106: i32 = matchValue_1;
                                        let v105: string = matchValue;
                                        let patternInput_2: (string, i32, i32) = if v32[v104]
                                            .clone()
                                            == string("")
                                        {
                                            (
                                                sprintf!("{}\n", v105.clone()),
                                                v106 + 1_i32,
                                                v107 + 1_i32,
                                            )
                                        } else {
                                            let v113: i32 = v106 - v107;
                                            (
                                                if v113 >= v100 {
                                                    v105.clone()
                                                } else {
                                                    let v115: string = v99[v113].clone();
                                                    if v113 == v100 - 1_i32 {
                                                        sprintf!("{}{}", v105.clone(), v115.clone())
                                                    } else {
                                                        sprintf!("{}{}\n", v105, v115)
                                                    }
                                                },
                                                v106 + 1_i32,
                                                v107,
                                            )
                                        };
                                        let v126: i32 = v104 + 1_i32;
                                        v102.l0.set(v126);
                                        v102.l1.set(patternInput_2.0.clone());
                                        v102.l2.set(patternInput_2.1.clone());
                                        v102.l3.set(patternInput_2.2.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_3: string = v102.l1.get().clone();
                                        let matchValue_4: i32 = v102.l2.get().clone();
                                        let matchValue_5: i32 = v102.l3.get().clone();
                                        let v127: string = matchValue_3;
                                        let _v130: MutCell<Option<()>> = MutCell::new(None::<()>);
                                        std::fs::write(&*v2.clone(), &*v127.clone()).unwrap();
                                        _v130.set(Some(()));
                                        match &_v130.get().clone() {
                                            None => {
                                                panic!("{}", string("base.run_target / _v130=None"),)
                                            }
                                            Some(_v130_0_0) => _v130_0_0.clone(),
                                        }
                                        Documents::method137(
                                            Documents::US0::US0_2,
                                            Func0::new(move || Documents::closure79((), ())),
                                            Func0::new({
                                                let v127 = v127.clone();
                                                let v2 = v2.clone();
                                                let v97 = v97.clone();
                                                move || {
                                                    Documents::closure80(
                                                        v2.clone(),
                                                        v97,
                                                        v127.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        Documents::US32::US32_0(v97, v127.clone())
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
        pub fn method140(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: string) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("result"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v2);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, string) = v2();
                            let v333: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method140(
                                v333.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v334: string = v333.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v334
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
        pub fn method139(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(i32, string)>) {
            Documents::method14(
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
            let patternInput: (string, string) = Documents::method120(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if (if if Documents::method124(v6.clone()) {
                Documents::method124(v7.clone())
            } else {
                false
            } {
                let v11: string = Documents::method33(v6.clone());
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
                                toArray_1(delay(Func0::new({
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
                            let v87 = Documents::method46();
                            let v89: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v85).map_err(|x| v87(x));
                            let v90 = Documents::method122();
                            let v91 = Documents::method123();
                            let v93: Documents::US31 = match v89 {
                                Ok(x) => v90(x),
                                Err(e) => v91(e),
                            };
                            let v99: string = match &v93 {
                                Documents::US31::US31_0(v93_0_0) => v93_0_0.clone(),
                                Documents::US31::US31_1(v93_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v93_1_0.clone()
                                    ),
                                ),
                            };
                            let v100: string = Documents::method33(v7.clone());
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
                                            toArray_1(delay(Func0::new({
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
                                        let v175 = Documents::method46();
                                        let v177: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v173).map_err(|x| v175(x));
                                        let v178 = Documents::method122();
                                        let v179 = Documents::method123();
                                        let v181: Documents::US31 = match v177 {
                                            Ok(x) => v178(x),
                                            Err(e) => v179(e),
                                        };
                                        v99 == match &v181 {
                                            Documents::US31::US31_0(v181_0_0) => v181_0_0.clone(),
                                            Documents::US31::US31_1(v181_1_0) => panic!(
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
                let v191: Documents::US32 = Documents::method130(v2, v3, v6.clone(), v4);
                match &v191 {
                    Documents::US32::US32_0(v191_0_0, v191_0_1) => {
                        let v193: string = v191_0_1.clone();
                        let v192: i32 = v191_0_0.clone();
                        if v192 != 0_i32 {
                            Documents::method139(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure82((), ())),
                                Func0::new({
                                    let v192 = v192.clone();
                                    let v193 = v193.clone();
                                    move || Documents::closure83(v193.clone(), v192, ())
                                }),
                            );
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v193.clone())),
                            ))
                        } else {
                            if Documents::method124(v6.clone()) {
                                Documents::method128(v7, v6.clone())
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
                    Documents::US32::US32_1(v191_1_0, v191_1_1) => {
                        Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v191_1_1.clone())),
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
        pub fn method143(v0_1: LrcPtr<Documents::Mut4>, v1_1: i32, v2: string, v3: string) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("exit_code"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method111(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("output_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v2);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("result"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v3);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (i32, string, string) = v2();
                            let v334: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method143(
                                v334.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            );
                            {
                                let v335: string = v334.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v335
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
        pub fn method142(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<(i32, string, string)>,
        ) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure89(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method141(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (i32, string) = Documents::method59(
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
            let v59: string = patternInput.1.clone();
            let v58: i32 = patternInput.0.clone();
            if contains(v59.clone(), string("ERROR")) {
                Documents::method142(
                    Documents::US0::US0_3,
                    Func0::new(move || Documents::closure87((), ())),
                    Func0::new({
                        let v1_1 = v1_1.clone();
                        let v58 = v58.clone();
                        let v59 = v59.clone();
                        move || Documents::closure88(v1_1.clone(), v59.clone(), v58, ())
                    }),
                );
                Documents::US32::US32_1(v58, v59.clone())
            } else {
                Documents::US32::US32_0(v58, v59.clone())
            }
        }
        pub fn closure86(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US30 {
            let patternInput: (string, string) = Documents::method120(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if (if if Documents::method124(v5.clone()) {
                Documents::method124(v6.clone())
            } else {
                false
            } {
                let v10: string = Documents::method33(v5.clone());
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
                                toArray_1(delay(Func0::new({
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
                            let v86 = Documents::method46();
                            let v88: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v84).map_err(|x| v86(x));
                            let v89 = Documents::method122();
                            let v90 = Documents::method123();
                            let v92: Documents::US31 = match v88 {
                                Ok(x) => v89(x),
                                Err(e) => v90(e),
                            };
                            let v98: string = match &v92 {
                                Documents::US31::US31_0(v92_0_0) => v92_0_0.clone(),
                                Documents::US31::US31_1(v92_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v92_1_0.clone()
                                    ),
                                ),
                            };
                            let v99: string = Documents::method33(v6.clone());
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
                                            toArray_1(delay(Func0::new({
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
                                        let v174 = Documents::method46();
                                        let v176: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v172).map_err(|x| v174(x));
                                        let v177 = Documents::method122();
                                        let v178 = Documents::method123();
                                        let v180: Documents::US31 = match v176 {
                                            Ok(x) => v177(x),
                                            Err(e) => v178(e),
                                        };
                                        v98 == match &v180 {
                                            Documents::US31::US31_0(v180_0_0) => v180_0_0.clone(),
                                            Documents::US31::US31_1(v180_1_0) => panic!(
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
                let v190: Documents::US32 = Documents::method141(v2, v5.clone(), v3, v1_1, v4);
                match &v190 {
                    Documents::US32::US32_0(v190_0_0, v190_0_1) => {
                        let v192: string = v190_0_1.clone();
                        let v191: i32 = v190_0_0.clone();
                        if v191 != 0_i32 {
                            Documents::method139(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure82((), ())),
                                Func0::new({
                                    let v191 = v191.clone();
                                    let v192 = v192.clone();
                                    move || Documents::closure83(v192.clone(), v191, ())
                                }),
                            );
                            Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v192.clone())),
                            ))
                        } else {
                            if Documents::method124(v5.clone()) {
                                Documents::method128(v6, v5.clone())
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
                    Documents::US32::US32_1(v190_1_0, v190_1_1) => {
                        Documents::US30::US30_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v190_1_1.clone())),
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
        pub fn method145(v0_1: LrcPtr<Documents::Mut4>, v1_1: string, v2: string) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("output_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v1_1);
            Documents::method11(v0_1.clone(), string("; "));
            Documents::method11(v0_1.clone(), string("output_cache_path"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method11(v0_1.clone(), v2);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let patternInput_1: (string, string) = v2();
                            let v333: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method145(
                                v333.clone(),
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                            );
                            {
                                let v334: string = v333.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v334
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
        pub fn method144(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<(string, string)>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure92(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method146(
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
                    Documents::method146(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method147(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method148(
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
                    Documents::method148(
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
        pub fn method149(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method150(
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
            let v6: string = Documents::method31(v5);
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
                let v34: string = Documents::method33(v6);
                let v36: string = Documents::method58(Documents::method20(v2.clone(), v33.clone()));
                let patternInput: (i32, string) = Documents::method59(
                    sprintf!(
                        "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                        v36.clone()
                    ),
                    None::<CancellationToken>,
                    new_empty::<(string, string)>(),
                    None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v2),
                );
                let v46: string = patternInput.1.clone();
                let v48: string = Documents::method58(Documents::method20(v3.clone(), v33.clone()));
                let patternInput_1: (i32, string) = Documents::method59(
                    sprintf!("git hash-object \"{}\"", v48.clone()),
                    None::<CancellationToken>,
                    new_empty::<(string, string)>(),
                    None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v3.clone()),
                );
                let v58: string = patternInput_1.1.clone();
                let v60: string = Documents::method58(Documents::method20(v4.clone(), v33.clone()));
                let v62: string =
                    (Documents::method120(string("hangul.md"), v48.clone(), v4.clone()))
                        .0
                        .clone();
                let v288: LrcPtr<Documents::UH4> = if contains(v46.clone(), v58.clone()) == false {
                    let v72: string = Documents::method33(v48.clone());
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
                                    toArray_1(delay(Func0::new({
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
                                let v147 = Documents::method46();
                                let v149: Result<string, std::string::String> =
                                    Ok::<string, std::io::Error>(v145).map_err(|x| v147(x));
                                let v150 = Documents::method122();
                                let v151 = Documents::method123();
                                let v153: Documents::US31 = match v149 {
                                    Ok(x) => v150(x),
                                    Err(e) => v151(e),
                                };
                                let v159: string = match &v153 {
                                    Documents::US31::US31_0(v153_0_0) => v153_0_0.clone(),
                                    Documents::US31::US31_1(v153_1_0) => panic!(
                                        "{}",
                                        sprintf!(
                                            "resultm.get / Result value was Error: {}",
                                            v153_1_0.clone()
                                        ),
                                    ),
                                };
                                let v251: Documents::US3 = if Documents::method124(v60.clone())
                                    == false
                                {
                                    Documents::US3::US3_1
                                } else {
                                    let v163: string = Documents::method33(v60.clone());
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
                                                    toArray_1(delay(Func0::new({
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
                                                let v238 = Documents::method46();
                                                let v240: Result<string, std::string::String> =
                                                    Ok::<string, std::io::Error>(v236)
                                                        .map_err(|x| v238(x));
                                                let v241 = Documents::method122();
                                                let v242 = Documents::method123();
                                                let v244: Documents::US31 = match v240 {
                                                    Ok(x) => v241(x),
                                                    Err(e) => v242(e),
                                                };
                                                match &v244 {
                                                    Documents::US31::US31_0(v244_0_0) => {
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
                                    Documents::method125(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure73((), ())),
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
                                                Documents::closure74(
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
                                    Documents::method128(v60.clone(), v48.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
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
                                                v48.clone(),
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
                                                    v48.clone(),
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
                                                        v48.clone(),
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
                                                            v62.clone(),
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
                                                                v62.clone(),
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
                                                                    v62.clone(),
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
                let v397: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method146(
                    if (if let Documents::UH4::UH4_0 = v288.as_ref() {
                        true
                    } else {
                        false
                    }) != true
                    {
                        v288
                    } else {
                        let patternInput_3: (string, string) =
                            Documents::method120(string("epub"), v62.clone(), v4.clone());
                        let v294: string = patternInput_3.1.clone();
                        let v293: string = patternInput_3.0.clone();
                        let v307: LrcPtr<Documents::UH5> = if if Documents::method124(v293.clone())
                            == false
                        {
                            if Documents::method124(v294.clone()) {
                                Documents::method144(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v293 = v293.clone();
                                        let v294 = v294.clone();
                                        move || Documents::closure91(v294.clone(), v293.clone(), ())
                                    }),
                                );
                                Documents::method128(v293.clone(), v294.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("epub"),
                                v62.clone(),
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
                            Documents::method120(string("pdf"), v62.clone(), v4.clone());
                        let v310: string = patternInput_4.1.clone();
                        let v309: string = patternInput_4.0.clone();
                        let v321: LrcPtr<Documents::UH5> = if if Documents::method124(v309.clone())
                            == false
                        {
                            if Documents::method124(v310.clone()) {
                                Documents::method144(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v309 = v309.clone();
                                        let v310 = v310.clone();
                                        move || Documents::closure91(v310.clone(), v309.clone(), ())
                                    }),
                                );
                                Documents::method128(v309.clone(), v310.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("pdf"),
                                v62.clone(),
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
                                v307.clone(),
                            ))
                        } else {
                            v307
                        };
                        let patternInput_5: (string, string) =
                            Documents::method120(string("html"), v62.clone(), v4.clone());
                        let v324: string = patternInput_5.1.clone();
                        let v323: string = patternInput_5.0.clone();
                        let v335: LrcPtr<Documents::UH5> = if if Documents::method124(v323.clone())
                            == false
                        {
                            if Documents::method124(v324.clone()) {
                                Documents::method144(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v323 = v323.clone();
                                        let v324 = v324.clone();
                                        move || Documents::closure91(v324.clone(), v323.clone(), ())
                                    }),
                                );
                                Documents::method128(v323.clone(), v324.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("html"),
                                v62,
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
                                v321.clone(),
                            ))
                        } else {
                            v321
                        };
                        let patternInput_6: (string, string) =
                            Documents::method120(string("epub"), v48.clone(), v4.clone());
                        let v337: string = patternInput_6.1.clone();
                        let v336: string = patternInput_6.0.clone();
                        let v348: LrcPtr<Documents::UH5> = if if Documents::method124(v336.clone())
                            == false
                        {
                            if Documents::method124(v337.clone()) {
                                Documents::method144(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v336 = v336.clone();
                                        let v337 = v337.clone();
                                        move || Documents::closure91(v337.clone(), v336.clone(), ())
                                    }),
                                );
                                Documents::method128(v336.clone(), v337.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
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
                                v335.clone(),
                            ))
                        } else {
                            v335
                        };
                        let patternInput_7: (string, string) =
                            Documents::method120(string("pdf"), v48.clone(), v4.clone());
                        let v350: string = patternInput_7.1.clone();
                        let v349: string = patternInput_7.0.clone();
                        let v361: LrcPtr<Documents::UH5> = if if Documents::method124(v349.clone())
                            == false
                        {
                            if Documents::method124(v350.clone()) {
                                Documents::method144(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v349 = v349.clone();
                                        let v350 = v350.clone();
                                        move || Documents::closure91(v350.clone(), v349.clone(), ())
                                    }),
                                );
                                Documents::method128(v349.clone(), v350.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
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
                                v348.clone(),
                            ))
                        } else {
                            v348
                        };
                        let patternInput_8: (string, string) =
                            Documents::method120(string("html"), v48.clone(), v4.clone());
                        let v363: string = patternInput_8.1.clone();
                        let v362: string = patternInput_8.0.clone();
                        let v374: LrcPtr<Documents::UH5> = if if Documents::method124(v362.clone())
                            == false
                        {
                            if Documents::method124(v363.clone()) {
                                Documents::method144(
                                    Documents::US0::US0_2,
                                    Func0::new(move || Documents::closure90((), ())),
                                    Func0::new({
                                        let v362 = v362.clone();
                                        let v363 = v363.clone();
                                        move || Documents::closure91(v363.clone(), v362.clone(), ())
                                    }),
                                );
                                Documents::method128(v362.clone(), v363.clone());
                                false
                            } else {
                                true
                            }
                        } else {
                            true
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
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
                                v361.clone(),
                            ))
                        } else {
                            v361
                        };
                        let patternInput_9: (string, string) =
                            Documents::method120(string("hangul.md"), v48.clone(), v4.clone());
                        let v376: string = patternInput_9.1.clone();
                        let v375: string = patternInput_9.0.clone();
                        LrcPtr::new(Documents::UH4::UH4_1(
                            if if Documents::method124(v375.clone()) == false {
                                if Documents::method124(v376.clone()) {
                                    Documents::method144(
                                        Documents::US0::US0_2,
                                        Func0::new(move || Documents::closure90((), ())),
                                        Func0::new({
                                            let v375 = v375.clone();
                                            let v376 = v376.clone();
                                            move || {
                                                Documents::closure91(v376.clone(), v375.clone(), ())
                                            }
                                        }),
                                    );
                                    Documents::method128(v375.clone(), v376.clone());
                                    false
                                } else {
                                    true
                                }
                            } else {
                                true
                            } {
                                LrcPtr::new(Documents::UH5::UH5_1(
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
                                v374,
                                LrcPtr::new(Documents::UH4::UH4_0),
                            )),
                        ))
                    },
                    empty::<LrcPtr<Documents::UH5>>(),
                ));
                let v399: Vec<LrcPtr<Documents::UH5>> = v397.to_vec();
                let v402: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
                let v404: Array<LrcPtr<Documents::UH5>> =
                    fable_library_rust::NativeArray_::array_from(v399);
                let v405: i32 = count_2(v404.clone());
                let v406: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(v402),
                });
                while Documents::method147(v405, v406.clone()) {
                    let v408: i32 = v406.l0.get().clone();
                    let v409: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        v406.l1.get().clone();
                    let v414 = toArray(Documents::method148(
                        v404[v408].clone(),
                        empty::<(
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US30>>,
                        )>(),
                    ));
                    let v416 = v414.to_vec();
                    let v418 = rayon::iter::IntoParallelIterator::into_par_iter(v416);
                    let v421 = rayon::iter::ParallelIterator::map(v418, |x| {
                        Func1::new(
                            move |arg10_0040_16: (
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US30>>,
                            )| Documents::closure93((), arg10_0040_16),
                        )(x)
                    });
                    let v424: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        Documents::method149(rayon::iter::ParallelIterator::collect(v421));
                    let v425: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                        Documents::method150(v409);
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
        pub fn method152(v0_1: LrcPtr<Documents::Mut4>, v1_1: usize) {
            Documents::method11(v0_1.clone(), string("{ "));
            Documents::method12(v0_1.clone());
            Documents::method11(v0_1.clone(), string("result_len"));
            Documents::method11(v0_1.clone(), string(" = "));
            Documents::method57(v0_1.clone(), v1_1);
            Documents::method11(v0_1, string(" }"))
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
                let v9: Option<i64> = patternInput.4.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Documents::US2>>> = refCell(None::<Documents::US2>);
                {
                    let x_2: Option<Documents::US2> = match &v9 {
                        None => None::<Documents::US2>,
                        Some(v9_0_0) => {
                            let x: i64 = v9_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Documents::US2::US2_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Documents::US2 =
                        defaultValue(Documents::US2::US2_1, _v11.get().clone());
                    let v35: DateTime = match &v16 {
                        Documents::US2::US2_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Documents::US2::US2_0(x) => x.clone(),
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
                    {
                        let x_3: string = {
                            let provider: string = Documents::method6();
                            v35.toString(provider)
                        };
                        _v10.set(Some(x_3))
                    }
                    {
                        let v152: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v159: Documents::US3 = if if let Documents::US0::US0_0 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Documents::US3::US3_0(string("Verbose"))
                        } else {
                            Documents::US3::US3_1
                        };
                        let v208: Documents::US3 = match &v159 {
                            Documents::US3::US3_0(v159_0_0) => Documents::US3::US3_0(match &v159 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v168: Documents::US3 = if if let Documents::US0::US0_1 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Documents::US3::US3_0(string("Debug"))
                                } else {
                                    Documents::US3::US3_1
                                };
                                match &v168 {
                                    Documents::US3::US3_0(v168_0_0) => {
                                        Documents::US3::US3_0(match &v168 {
                                            Documents::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v177: Documents::US3 =
                                            if if let Documents::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Documents::US3::US3_0(string("Info"))
                                            } else {
                                                Documents::US3::US3_1
                                            };
                                        match &v177 {
                                            Documents::US3::US3_0(v177_0_0) => {
                                                Documents::US3::US3_0(match &v177 {
                                                    Documents::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v186: Documents::US3 =
                                                    if if let Documents::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Documents::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Documents::US3::US3_1
                                                    };
                                                match &v186 {
                                                    Documents::US3::US3_0(v186_0_0) => {
                                                        Documents::US3::US3_0(match &v186 {
                                                            Documents::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v195: Documents::US3 =
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
                                                        match &v195 {
                                                            Documents::US3::US3_0(v195_0_0) => {
                                                                Documents::US3::US3_0(match &v195 {
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
                        let v215: string = padLeft(
                            toLower(match &v208 {
                                Documents::US3::US3_0(v208_0_0) => match &v208 {
                                    Documents::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v231: &str = match &v0_1 {
                            Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                            Documents::US0::US0_2 => inline_colorization::color_bright_green,
                            Documents::US0::US0_0 => inline_colorization::color_bright_black,
                            Documents::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v233: &str = &*v215;
                        let v235: &str = inline_colorization::color_reset;
                        let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                        let v238: std::string::String = format!("{v231}{v233}{v235}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v238);
                            _v216.set(Some(x_5))
                        }
                        {
                            let v328: string = match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            };
                            let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                            let v332: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Documents::method152(v332.clone(), v2());
                            {
                                let v333: string = v332.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v333
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
        pub fn method151(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<usize>) {
            Documents::method14(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure96(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method153(
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
        pub fn method19(
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
            let v8: Documents::US7 = Documents::method23(
                Documents::method20(string("polyglot"), string(".devcontainer")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v17: Documents::US3 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US3::US3_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    Documents::method28(
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
                    let v20: string = Documents::method30();
                    let v22: Documents::US7 = Documents::method23(
                        Documents::method20(string("polyglot"), string(".devcontainer")),
                        v20,
                    );
                    match &v22 {
                        Documents::US7::US7_0(v22_0_0) => Documents::US3::US3_0(v22_0_0.clone()),
                        Documents::US7::US7_1(v22_1_0) => {
                            Documents::method28(
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
            let v38: string = Documents::method20(
                match &v33 {
                    Documents::US3::US3_0(v33_0_0) => match &v33 {
                        Documents::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v39: string = Documents::method31(v3);
            let v40: string = Documents::method31(v2);
            let v41: string = Documents::method31(v1_1);
            Documents::method41(
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
                    let v51 = Documents::method50();
                    let v53: Vec<string> = tokio_stream::StreamExt::collect(
                        tokio_stream::StreamExt::filter_map(v50, |x| v51(x)),
                    )
                    .await;
                    Documents::method55(
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
                        Documents::method151(
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
                            > = Documents::method153(Ok::<
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
                            let v79: string = string("v68 }}}}); {{{ //");
                            v68
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
                let v9: string = Documents::method15();
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
                    let v26: string = Documents::method16();
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
                        let v43: string = Documents::method17();
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
                            let v60: string = Documents::method18();
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
                                > = Documents::method19(
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
