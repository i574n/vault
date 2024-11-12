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
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
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
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::replicate;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
        use fable_library_rust::String_::trim;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for Documents::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(Documents::US3),
            US4_1(Documents::US3),
            US4_2(Documents::US3),
            US4_3(Documents::US3),
            US4_4(Documents::US3),
        }
        impl core::fmt::Display for Documents::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for Documents::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String),
            US6_1,
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
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(std::path::PathBuf),
            US8_1(string),
        }
        impl core::fmt::Display for Documents::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::path::PathBuf),
            US9_1,
        }
        impl core::fmt::Display for Documents::US9 {
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
        pub enum US10 {
            US10_0(std::fs::FileType),
            US10_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US11 {
            US11_0,
            US11_1,
            US11_2,
        }
        impl core::fmt::Display for Documents::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(async_walkdir::DirEntry),
            US12_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US13 {
            US13_0(string, Documents::US5),
            US13_1(string),
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
        impl core::fmt::Display for Documents::US14 {
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
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US14>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for Documents::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for Documents::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US16 {
            US16_0(char),
            US16_1,
        }
        impl core::fmt::Display for Documents::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
        }
        impl core::fmt::Display for Documents::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(
                string,
                Documents::US5,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US18_1(string),
        }
        impl core::fmt::Display for Documents::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(Documents::US16, string, LrcPtr<StringBuilder>, i32, i32),
            US19_1(string),
        }
        impl core::fmt::Display for Documents::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(Documents::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US20_1(string),
        }
        impl core::fmt::Display for Documents::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US21 {
            US21_0(Array<string>),
            US21_1(string),
        }
        impl core::fmt::Display for Documents::US21 {
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
        pub enum US22 {
            US22_0(
                LrcPtr<Documents::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US22_1(string),
        }
        impl core::fmt::Display for Documents::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US15>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl core::fmt::Display for Documents::UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US23_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US24_1,
        }
        impl core::fmt::Display for Documents::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(std::string::String),
            US25_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US26_1,
        }
        impl core::fmt::Display for Documents::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US27_1,
        }
        impl core::fmt::Display for Documents::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::process::Output),
            US28_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US29 {
            US29_0(i32),
            US29_1,
        }
        impl core::fmt::Display for Documents::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US30_1,
        }
        impl core::fmt::Display for Documents::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US31 {
            US31_0(CancellationToken),
            US31_1,
        }
        impl core::fmt::Display for Documents::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US32 {
            US32_0(Result<string, LrcPtr<(string, string)>>),
            US32_1,
        }
        impl core::fmt::Display for Documents::US32 {
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
                Func2<string, string, Documents::US32>,
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
        pub enum US33 {
            US33_0(string),
            US33_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(u64),
            US34_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US35 {
            US35_0(i32, string),
            US35_1(i32, string),
        }
        impl core::fmt::Display for Documents::US35 {
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
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0(
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
            ),
            US36_1(std::string::String),
        }
        impl core::fmt::Display for Documents::US36 {
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
            let v56: clap::Arg = v54.short('h');
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
        pub fn method4() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn method5() -> Func1<string, Documents::US5> {
            Func1::new(move |v: string| Documents::closure3((), v))
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
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: Documents::US1 = if string("Verbose") == v1_1.clone() {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v6 {
                    Documents::US1::US1_0(v6_0_0) => Documents::US1::US1_0(match &v6 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v13: Documents::US1 = if string("Debug") == v1_1.clone() {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v13 {
                            Documents::US1::US1_0(v13_0_0) => Documents::US1::US1_0(match &v13 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v20: Documents::US1 = if string("Info") == v1_1.clone() {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v20 {
                                    Documents::US1::US1_0(v20_0_0) => {
                                        Documents::US1::US1_0(match &v20 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v27: Documents::US1 =
                                            if string("Warning") == v1_1.clone() {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
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
                                                let v34: Documents::US1 =
                                                    if string("Critical") == v1_1.clone() {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Documents::US1::US1_0(v34_0_0) => {
                                                        Documents::US1::US1_0(match &v34 {
                                                            Documents::US1::US1_0(x) => x.clone(),
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
                if Documents::method3(string("AUTOMATION")) != string("True") {
                    Documents::US2::US2_1
                } else {
                    Documents::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
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
            let patternInput: (Documents::US1, Documents::US2) = Documents::method2();
            let _v1: (Documents::US1, Documents::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v132: Documents::US2 = _v1.1.clone();
            let v131: Documents::US1 = _v1.0.clone();
            (
                LrcPtr::new(Documents::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Documents::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure4((), v))),
                }),
                LrcPtr::new(Documents::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(match &v131 {
                        Documents::US1::US1_0(v131_0_0) => match &v131 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v132 {
                    Documents::US2::US2_0(v132_0_0) => Some(match &v132 {
                        Documents::US2::US2_0(x) => x.clone(),
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
        pub fn closure6(unitVar: (), unitVar_1: ()) {
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
        pub fn method6(v0_1: Documents::US0) -> bool {
            let v3: () = {
                Documents::closure6((), ());
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
            let v35: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            if (patternInput.2.clone()).l0.get().clone() == false {
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
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                )
            }
        }
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure7((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v20: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method8(), v5));
            let v116: DateTime = match &v20 {
                Documents::US2::US2_0(v20_0_0) => {
                    let v78: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v20 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v78.hours(),
                        v78.minutes(),
                        v78.seconds(),
                        v78.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let provider: string = Documents::method9();
            v116.toString(provider)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: char) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v8: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v6: string = Documents::method12(getCharAt(toLower(string("Info")), 0_i32));
            let v9: &str = inline_colorization::color_bright_green;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method16(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("args")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method17(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Array<string>,
        ) -> string {
            let v9: string = Documents::method16(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure9(v0_1: LrcPtr<Documents::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v3: () = {
                Documents::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn method18(v0_1: string) {
            let v3: () = {
                Documents::closure6((), ());
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
                Documents::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_2) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method15(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method11(),
                    v0_1,
                ))
            };
        }
        pub fn method19() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn method20() -> Func1<std::string::String, Documents::US6> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method21() -> string {
            string("dist-dir")
        }
        pub fn method22() -> string {
            string("cache-dir")
        }
        pub fn method23() -> string {
            string("hangul-spec")
        }
        pub fn method27(v0_1: string) -> string {
            v0_1
        }
        pub fn method26(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Documents::method27(v0_1))
        }
        pub fn method25(v0_1: string, v1_1: string) -> string {
            let v5: &str = &*v0_1;
            let v29: std::string::String = String::from(v5);
            let v53: std::path::PathBuf = std::path::PathBuf::from(v29);
            let v77: &str = &*v1_1;
            let v101: std::string::String = String::from(v77);
            let v124: std::path::PathBuf = v53.join(v101);
            let v127: std::path::Display = v124.display();
            let v151: std::string::String = format!("{}", v127);
            fable_library_rust::String_::fromString(v151)
        }
        pub fn method29(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_dir()
            } else {
                false
            }
        }
        pub fn method31(v0_1: string) -> Option<string> {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            let v75: Option<std::path::PathBuf> = v52.parent().map(std::path::PathBuf::from);
            let v77: bool = true;
            let _optionm_map_ = v75.map(|x| {
                //;
                let v79: std::path::PathBuf = x;
                let v82: std::path::Display = v79.display();
                let v106: std::string::String = format!("{}", v82);
                let v129: string = fable_library_rust::String_::fromString(v106);
                let v131: bool = true;
                v129
            });
            _optionm_map_
        }
        pub fn closure13(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method31(v0_1)
        }
        pub fn method30() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure13((), v))
        }
        pub fn method32(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method32: loop {
                break '_method32 (if Documents::method29(Documents::method25(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Documents::method30())(v2.get().clone());
                    let v21: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method5(), v7));
                    match &v21 {
                        Documents::US5::US5_0(v21_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v21 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method32;
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
        pub fn method28(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method29(Documents::method25(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Documents::method30())(v1_1.clone());
                let v20: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method5(), v6));
                match &v20 {
                    Documents::US5::US5_0(v20_0_0) => Documents::method32(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v20 {
                            Documents::US5::US5_0(x) => x.clone(),
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
        pub fn method33() -> string {
            let v6: string = Documents::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method35(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method34(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Documents::method35(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v9
            ))
        }
        pub fn closure14(v0_1: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_3) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method34(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method33(),
                    v0_1,
                ))
            };
        }
        pub fn method36() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v5: std::path::PathBuf = v2.unwrap();
            let v19: std::path::Display = v5.display();
            let v43: std::string::String = format!("{}", v19);
            fable_library_rust::String_::fromString(v43)
        }
        pub fn method42(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v5: std::string::String = format!("{:#?}", v0_1);
            let v38: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v5)),
                    (),
                );
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure15(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method42(v0_1)
        }
        pub fn method41() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn method43() -> Func1<std::path::PathBuf, Documents::US8> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure16((), v))
        }
        pub fn closure17(unitVar: (), v0_1: string) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method44() -> Func1<string, Documents::US8> {
            Func1::new(move |v: string| Documents::closure17((), v))
        }
        pub fn method47(v0_1: string) -> string {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            let v75: Option<&std::ffi::OsStr> = v52.file_name();
            let v77: bool = true;
            let _optionm_map_ = v75.map(|x| {
                //;
                let v79: &std::ffi::OsStr = x;
                let v81: std::ffi::OsString = v79.to_os_string();
                let v83: Option<&str> = v81.to_str();
                let v85: &str = v83.unwrap();
                let v88: std::string::String = String::from(v85);
                let v111: string = fable_library_rust::String_::fromString(v88);
                let v113: bool = true;
                v111
            });
            let v115: Option<string> = _optionm_map_;
            let v129: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method5(), v115));
            match &v129 {
                Documents::US5::US5_0(v129_0_0) => match &v129 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            }
        }
        pub fn method48(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v8: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method46(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method47(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v20: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method5(), v6));
            let v24: string = Documents::method48(v3);
            if v2 >= 11_u8 {
                let v26: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v4.clone(),
                    v5.clone()
                );
                let v29: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v26);
                Err(v29)
            } else {
                if let Documents::US5::US5_0(v20_0_0) = &v20 {
                    if v4.clone() != string("") {
                        let v72: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v20 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v73 = Documents::method41();
                        let v85: Result<std::path::PathBuf, string> = v72.map_err(|x| v73(x));
                        let v88 = Documents::method43();
                        let v89 = Documents::method44();
                        let v90: Documents::US8 = match &v85 {
                            Err(v85_1_0) => v89(v85_1_0.clone()),
                            Ok(v85_0_0) => v88(v85_0_0.clone()),
                        };
                        match &v90 {
                            Documents::US8::US8_0(v90_0_0) => {
                                let v119: string = Documents::method25(
                                    toString(v90_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v122: &str = &*v119;
                                let v146: std::string::String = String::from(v122);
                                let v170: std::path::PathBuf = std::path::PathBuf::from(v146);
                                Ok(v170)
                            }
                            Documents::US8::US8_1(v90_1_0) => {
                                let v207: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v90_1_0.clone(),
                                    v24.clone(),
                                    v5.clone()
                                );
                                let v210: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v207);
                                Err(v210)
                            }
                        }
                    } else {
                        let v248: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v24.clone(), v4.clone(),
                                     v5.clone());
                        let v251: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v248);
                        Err(v251)
                    }
                } else {
                    let v288: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1, v24, v4, v5.clone());
                    let v291: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v288);
                    Err(v291)
                }
            }
        }
        pub fn method45(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v6 = Documents::method41();
            let v18: Result<std::path::PathBuf, string> = v5.map_err(|x| v6(x));
            let v21 = Documents::method43();
            let v22 = Documents::method44();
            let v23: Documents::US8 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v23 {
                Documents::US8::US8_0(v23_0_0) => Ok(v23_0_0.clone()),
                Documents::US8::US8_1(v23_1_0) => Documents::method46(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure18(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v23_1_0.clone(),
                    v2,
                ),
            }
        }
        pub fn closure19(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method45(v0_1, v1_1, v2)
        }
        pub fn closure18(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure19(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method49(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method47(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v19: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method5(), v5));
            let v23: string = Documents::method48(v3);
            if v2 >= 11_u8 {
                let v25: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v0_1.clone(),
                    v4.clone()
                );
                let v28: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v25);
                Err(v28)
            } else {
                if let Documents::US5::US5_0(v19_0_0) = &v19 {
                    if v0_1.clone() != string("") {
                        let v71: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v19 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v72 = Documents::method41();
                        let v84: Result<std::path::PathBuf, string> = v71.map_err(|x| v72(x));
                        let v87 = Documents::method43();
                        let v88 = Documents::method44();
                        let v89: Documents::US8 = match &v84 {
                            Err(v84_1_0) => v88(v84_1_0.clone()),
                            Ok(v84_0_0) => v87(v84_0_0.clone()),
                        };
                        match &v89 {
                            Documents::US8::US8_0(v89_0_0) => {
                                let v118: string = Documents::method25(
                                    toString(v89_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v121: &str = &*v118;
                                let v145: std::string::String = String::from(v121);
                                let v169: std::path::PathBuf = std::path::PathBuf::from(v145);
                                Ok(v169)
                            }
                            Documents::US8::US8_1(v89_1_0) => {
                                let v206: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v89_1_0.clone(),
                                    v23.clone(),
                                    v4.clone()
                                );
                                let v209: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v206);
                                Err(v209)
                            }
                        }
                    } else {
                        let v247: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v23.clone(), v0_1.clone(),
                                     v4.clone());
                        let v250: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v247);
                        Err(v250)
                    }
                } else {
                    let v287: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1.clone(), v23, v0_1, v4.clone());
                    let v290: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v287);
                    Err(v290)
                }
            }
        }
        pub fn method40(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v5 = Documents::method41();
            let v17: Result<std::path::PathBuf, string> = v4.map_err(|x| v5(x));
            let v20 = Documents::method43();
            let v21 = Documents::method44();
            let v22: Documents::US8 = match &v17 {
                Err(v17_1_0) => v21(v17_1_0.clone()),
                Ok(v17_0_0) => v20(v17_0_0.clone()),
            };
            match &v22 {
                Documents::US8::US8_0(v22_0_0) => Ok(v22_0_0.clone()),
                Documents::US8::US8_1(v22_1_0) => Documents::method49(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure18(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v22_1_0.clone(),
                ),
            }
        }
        pub fn method52(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method47(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v20: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method5(), v6));
            let v24: string = Documents::method42(v3);
            if v2 >= 11_u8 {
                let v26: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v4.clone(),
                    v5.clone()
                );
                let v29: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v26);
                Err(v29)
            } else {
                if let Documents::US5::US5_0(v20_0_0) = &v20 {
                    if v4.clone() != string("") {
                        let v72: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v20 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v73 = Documents::method41();
                        let v85: Result<std::path::PathBuf, string> = v72.map_err(|x| v73(x));
                        let v88 = Documents::method43();
                        let v89 = Documents::method44();
                        let v90: Documents::US8 = match &v85 {
                            Err(v85_1_0) => v89(v85_1_0.clone()),
                            Ok(v85_0_0) => v88(v85_0_0.clone()),
                        };
                        match &v90 {
                            Documents::US8::US8_0(v90_0_0) => {
                                let v119: string = Documents::method25(
                                    toString(v90_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v122: &str = &*v119;
                                let v146: std::string::String = String::from(v122);
                                let v170: std::path::PathBuf = std::path::PathBuf::from(v146);
                                Ok(v170)
                            }
                            Documents::US8::US8_1(v90_1_0) => {
                                let v207: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v90_1_0.clone(),
                                    v24.clone(),
                                    v5.clone()
                                );
                                let v210: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v207);
                                Err(v210)
                            }
                        }
                    } else {
                        let v248: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v24.clone(), v4.clone(),
                                     v5.clone());
                        let v251: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v248);
                        Err(v251)
                    }
                } else {
                    let v288: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1, v24, v4, v5.clone());
                    let v291: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v288);
                    Err(v291)
                }
            }
        }
        pub fn method51(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: () = defaultOf();
            let v30: i32 = unbox::<i32>(&defaultOf());
            let v55: i32 = unbox::<i32>(&defaultOf());
            let v99: bool = unbox::<bool>(&defaultOf());
            if v99 {
                let v105: () = defaultOf();
                let v155: std::path::PathBuf = defaultOf();
                Ok(v155)
            } else {
                let v172: string =
                    sprintf!("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {} / result: {} / path\': {} / n: {}",
                             v0_1.clone(), v99, v2.clone(), v1_1);
                Documents::method52(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure20(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v172),
                    v2,
                )
            }
        }
        pub fn closure21(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method51(v0_1, v1_1, v2)
        }
        pub fn closure20(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure21(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method53(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method47(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v19: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method5(), v5));
            let v23: string = Documents::method42(v3);
            if v2 >= 11_u8 {
                let v25: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v0_1.clone(),
                    v4.clone()
                );
                let v28: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v25);
                Err(v28)
            } else {
                if let Documents::US5::US5_0(v19_0_0) = &v19 {
                    if v0_1.clone() != string("") {
                        let v71: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v19 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v72 = Documents::method41();
                        let v84: Result<std::path::PathBuf, string> = v71.map_err(|x| v72(x));
                        let v87 = Documents::method43();
                        let v88 = Documents::method44();
                        let v89: Documents::US8 = match &v84 {
                            Err(v84_1_0) => v88(v84_1_0.clone()),
                            Ok(v84_0_0) => v87(v84_0_0.clone()),
                        };
                        match &v89 {
                            Documents::US8::US8_0(v89_0_0) => {
                                let v118: string = Documents::method25(
                                    toString(v89_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v121: &str = &*v118;
                                let v145: std::string::String = String::from(v121);
                                let v169: std::path::PathBuf = std::path::PathBuf::from(v145);
                                Ok(v169)
                            }
                            Documents::US8::US8_1(v89_1_0) => {
                                let v206: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v89_1_0.clone(),
                                    v23.clone(),
                                    v4.clone()
                                );
                                let v209: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v206);
                                Err(v209)
                            }
                        }
                    } else {
                        let v247: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v23.clone(), v0_1.clone(),
                                     v4.clone());
                        let v250: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v247);
                        Err(v250)
                    }
                } else {
                    let v287: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1.clone(), v23, v0_1, v4.clone());
                    let v290: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v287);
                    Err(v290)
                }
            }
        }
        pub fn method50(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v3: () = defaultOf();
            let v29: i32 = unbox::<i32>(&defaultOf());
            let v54: i32 = unbox::<i32>(&defaultOf());
            let v98: bool = unbox::<bool>(&defaultOf());
            if v98 {
                let v104: () = defaultOf();
                let v154: std::path::PathBuf = defaultOf();
                Ok(v154)
            } else {
                let v171: string =
                    sprintf!("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {} / result: {} / path\': {} / n: {}",
                             v0_1.clone(), v98, v0_1.clone(), v1_1);
                Documents::method53(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure20(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v171),
                )
            }
        }
        pub fn method39(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method29(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method40(v0_1, 0_u8)
            }
        }
        pub fn closure22(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method54() -> Func1<std::path::PathBuf, Documents::US9> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure22((), v))
        }
        pub fn method56(v0_1: string) -> string {
            v0_1
        }
        pub fn method55(v0_1: string, v1_1: string, v2: string) -> string {
            let v5: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v8: regex::Regex = v5.unwrap();
            let v20: string = Documents::method56(v2);
            let v22: std::borrow::Cow<str> = v8.replace_all(&*v20, &*v1_1);
            let v24: std::string::String = String::from(v22);
            fable_library_rust::String_::fromString(v24)
        }
        pub fn method38(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method39(v0_1.clone());
                let v6: Option<std::path::PathBuf> = v3.ok();
                let v31: Documents::US9 =
                    defaultValue(Documents::US9::US9_1, map(Documents::method54(), v6));
                let v66: string = match &v31 {
                    Documents::US9::US9_0(v31_0_0) => {
                        let v60: string = toString(
                            match &v31 {
                                Documents::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .display(),
                        );
                        if v60.clone() == string("") {
                            v0_1.clone()
                        } else {
                            v60
                        }
                    }
                    _ => v0_1.clone(),
                };
                if v66.clone() == string("") {
                    string("")
                } else {
                    let v71: string =
                        Documents::method55(string("^\\\\\\\\\\?\\\\"), string(""), v66);
                    replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v71.clone(), 0_i32))),
                            getSlice(v71, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method57(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method58(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method59() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method60(v0_1: string) -> string {
            v0_1
        }
        pub fn method37(v0_1: string) -> string {
            let v4: &str = &*v0_1.clone();
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v52.exists() == false {
                let v77: string = Documents::method36();
                let v81: Array<string> = split(
                    Documents::method38(Documents::method25(v77.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v85: i32 = count_2(v81.clone());
                let v86: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method57(v85, v86.clone()) {
                    let v88: i32 = v86.l0.get().clone();
                    let v91: i32 = v88.wrapping_neg() + v85 - 1_i32;
                    let matchValue: i32 = v86.l1.get().clone();
                    let v93: Array<string> = v86.l2.get().clone();
                    let v92: i32 = matchValue;
                    let v94: string = v81[v91].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == v94.clone() {
                        (v92 + 1_i32, v93.clone())
                    } else {
                        if string(".") == v94.clone() {
                            (v92, v93.clone())
                        } else {
                            if 0_i32 == v92 {
                                if endsWith(v94.clone(), string(":"), false) {
                                    let v102: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v77.clone(), 0_i32)
                                    )]);
                                    let v103: i32 = count_2(v102.clone());
                                    let v105: i32 = v103 + count_2(v93.clone());
                                    let v106: Array<string> = new_init(&string(""), v105);
                                    let v107: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v105, v107.clone()) {
                                        let v109: i32 = v107.l0.get().clone();
                                        let v114: string = if v109 < v103 {
                                            v102[v109].clone()
                                        } else {
                                            let v112: i32 = v109 - v103;
                                            v93[v112].clone()
                                        };
                                        v106.get_mut()[v109 as usize] = v114;
                                        {
                                            let v115: i32 = v109 + 1_i32;
                                            v107.l0.set(v115);
                                            ()
                                        }
                                    }
                                    (0_i32, v106.clone())
                                } else {
                                    let v116: Array<string> = new_array(&[v94]);
                                    let v117: i32 = count_2(v116.clone());
                                    let v119: i32 = v117 + count_2(v93.clone());
                                    let v120: Array<string> = new_init(&string(""), v119);
                                    let v121: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v119, v121.clone()) {
                                        let v123: i32 = v121.l0.get().clone();
                                        let v128: string = if v123 < v117 {
                                            v116[v123].clone()
                                        } else {
                                            let v126: i32 = v123 - v117;
                                            v93[v126].clone()
                                        };
                                        v120.get_mut()[v123 as usize] = v128;
                                        {
                                            let v129: i32 = v123 + 1_i32;
                                            v121.l0.set(v129);
                                            ()
                                        }
                                    }
                                    (0_i32, v120.clone())
                                }
                            } else {
                                (v92 - 1_i32, v93.clone())
                            }
                        }
                    };
                    let v139: i32 = v88 + 1_i32;
                    v86.l0.set(v139);
                    v86.l1.set(patternInput_1.0.clone());
                    v86.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v86.l1.get().clone();
                    let v141: Array<string> = v86.l2.get().clone();
                    let _v142: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v141 = v141.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v141 = v141.clone();
                                    move |i: i32| v141[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, count_2(v141.clone()) - 1_i32),
                            )
                        }
                    }));
                    let v151: string = ofChar(Documents::method59());
                    join(
                        if v151.clone() == string("\n") {
                            Documents::method60(v151.clone())
                        } else {
                            v151
                        },
                        toArray_1(_v142),
                    )
                }
            } else {
                let v163: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v166: std::path::PathBuf = v163.unwrap();
                let v180: std::path::Display = v166.display();
                let v204: std::string::String = format!("{}", v180);
                fable_library_rust::String_::fromString(v204)
            }
        }
        pub fn method61() -> string {
            let v6: string = Documents::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v9: &str = inline_colorization::color_bright_blue;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method63(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v12: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("source_dir")), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("dist_dir")), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("cache_dir")), ());
                ()
            };
            let v97: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string("hangul_spec")), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v147: () = {
                Documents::closure8(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method62(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Documents::method63(v8, v9, v10, v11);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v12
            ))
        }
        pub fn closure23(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_1) {
                let v8: () = {
                    Documents::closure6((), ());
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
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method62(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Documents::method7(v22, v23, v24, v25, v26, v27),
                    Documents::method61(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                ))
            };
        }
        pub fn method64(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure25(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method65() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure25((), v))
        }
        pub fn closure26(unitVar: (), v0_1: std::fs::FileType) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method66() -> Func1<std::fs::FileType, Documents::US10> {
            Func1::new(move |v: std::fs::FileType| Documents::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn method67() -> Func1<std::string::String, Documents::US10> {
            Func1::new(move |v: std::string::String| Documents::closure27((), v))
        }
        pub fn method68(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method69(v0_1: Documents::US11) -> Documents::US11 {
            v0_1
        }
        pub fn method70(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure24(
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
                    let v5: async_walkdir::DirEntry = Documents::method64(v0_1.clone());
                    let v7: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v5));
                    let v9: Result<std::fs::FileType, std::io::Error> = v7.await;
                    let v10 = Documents::method65();
                    let v22: Result<std::fs::FileType, std::string::String> =
                        v9.map_err(|x| v10(x));
                    let v25 = Documents::method66();
                    let v26 = Documents::method67();
                    let v27: Documents::US10 = match &v22 {
                        Err(v22_1_0) => v26(v22_1_0.clone()),
                        Ok(v22_0_0) => v25(v22_0_0.clone()),
                    };
                    let v157: Documents::US11 =
                        Documents::method69(if let Documents::US10::US10_0(v27_0_0) = &v27 {
                            let v29: std::fs::FileType = Documents::method68(match &v27 {
                                Documents::US10::US10_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v29) {
                                Documents::US11::US11_0
                            } else {
                                let v34: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v37: std::path::Display = v34.display();
                                let v61: std::string::String = format!("{}", v37);
                                let v84: string = fable_library_rust::String_::fromString(v61);
                                if if endsWith(v84.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v84, string(".hangul.md"), false)
                                } {
                                    Documents::US11::US11_0
                                } else {
                                    Documents::US11::US11_2
                                }
                            }
                        } else {
                            let v96: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v99: std::path::Display = v96.display();
                            let v123: std::string::String = format!("{}", v99);
                            let v146: string = fable_library_rust::String_::fromString(v123);
                            if if endsWith(v146.clone(), string(".md"), false) == false {
                                true
                            } else {
                                endsWith(v146, string(".hangul.md"), false)
                            } {
                                Documents::US11::US11_0
                            } else {
                                Documents::US11::US11_2
                            }
                        });
                    let v160: string = string("}");
                    let v164: bool = true;
                    let v161 = v157;
                    let v176: string = append(
                        append(
                            append(append(string("true; v161 "), v160), string("); ")),
                            string(""),
                        ),
                        string(" // rust.fix_closure\'"),
                    );
                    let v177: bool = true;
                    v161
                }); // rust.fix_closure';
                let v179 = __future_init;
                let v181: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Documents::US11> + Send>,
                > = v179;
                let v183: Documents::US11 = v181.await;
                let v193: async_walkdir::Filtering = Documents::method70(match &v183 {
                    Documents::US11::US11_0 => async_walkdir::Filtering::Ignore,
                    Documents::US11::US11_1 => async_walkdir::Filtering::IgnoreDir,
                    _ => async_walkdir::Filtering::Continue,
                });
                let v194: string = string("}");
                let v198: bool = true;
                let v195 = v193;
                let v210: string = append(
                    append(
                        append(append(string("true; v195 "), v194), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v211: bool = true;
                v195
            }); // rust.fix_closure';
            let v213 = __future_init;
            v213
        }
        pub fn closure29(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method72() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure29((), v))
        }
        pub fn closure30(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn method73() -> Func1<async_walkdir::DirEntry, Documents::US12> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn method74() -> Func1<std::string::String, Documents::US12> {
            Func1::new(move |v: std::string::String| Documents::closure31((), v))
        }
        pub fn method75() -> string {
            let v6: string = Documents::method12(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method77(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method76(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method77(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / stream_filter_map"),
                v9
            ))
        }
        pub fn closure32(v0_1: std::string::String, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method76(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method75(),
                    v0_1,
                ))
            };
        }
        pub fn closure28(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method72();
            let v13: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v16 = Documents::method73();
            let v17 = Documents::method74();
            let v18: Documents::US12 = match &v13 {
                Err(v13_1_0) => v17(v13_1_0.clone()),
                Ok(v13_0_0) => v16(v13_0_0.clone()),
            };
            let v118: Documents::US5 = match &v18 {
                Documents::US12::US12_0(v18_0_0) => {
                    let v21: std::path::PathBuf = async_walkdir::DirEntry::path(&v18_0_0.clone());
                    let v24: std::path::Display = v21.display();
                    let v48: std::string::String = format!("{}", v24);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v48))
                }
                Documents::US12::US12_1(v18_1_0) => {
                    let v76: () = {
                        Documents::closure32(v18_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v118 {
                Documents::US5::US5_0(v118_0_0) => Some(match &v118 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method71(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure28((), v)
                },
            )
        }
        pub fn method79(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("files_len")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method78(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v9: string = Documents::method79(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v9
            ))
        }
        pub fn closure33(v0_1: Vec<string>, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_1) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method78(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method61(),
                    v0_1.len(),
                ))
            };
        }
        pub fn method80() -> string {
            string("")
        }
        pub fn method81(v0_1: string) -> string {
            Documents::method38(Documents::method37(v0_1))
        }
        pub fn method83(
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
        pub fn method85() -> string {
            string("")
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
        pub fn method86() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure36((), v))
        }
        pub fn method87(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method87: loop {
                break '_method87 (match v0_1.get().clone().as_ref() {
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
                                let v21: LrcPtr<StringBuilder> = {
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
                            continue '_method87;
                        }
                    }
                });
            }
        }
        pub fn closure35(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US14 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '\"' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method58(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method86())(b0)(b1)
                                }),
                                v45,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US14::US14_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v80: i32 = length(v0_1.clone());
                    let v87: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US14::US14_1(sprintf!(
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
                                Some(
                                    if -2_i32 == v87 {
                                        v80 + 1_i32
                                    } else {
                                        v87 + 1_i32
                                    } - 1_i32
                                )
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
        ) -> Documents::US14 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '\'' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method58(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method86())(b0)(b1)
                                }),
                                v45,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US14::US14_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v80: i32 = length(v0_1.clone());
                    let v87: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US14::US14_1(sprintf!(
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
                                Some(
                                    if -2_i32 == v87 {
                                        v80 + 1_i32
                                    } else {
                                        v87 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method88(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US14 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method88: loop {
                break '_method88 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US14::US14_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US14 = (match v2.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Documents::US14::US14_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => {
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
                                continue '_method88;
                            }
                        }
                    }
                });
            }
        }
        pub fn method89(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method89: loop {
                break '_method89 (if v1_1.get().clone() >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US16 = if v1_1.get().clone() == 0_i64 {
                        Documents::US16::US16_0('\"')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US16::US16_0('\'')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            Documents::US16::US16_1
                        }
                    };
                    if v0_1.get().clone()
                        == match &v11 {
                            Documents::US16::US16_0(v11_0_0) => match &v11 {
                                Documents::US16::US16_0(x) => x.clone(),
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
                        continue '_method89;
                    }
                });
            }
        }
        pub fn method90(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method90: loop {
                break '_method90 ({
                    let v109: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v21: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Documents::method89(v21, 0_i64) == false {
                            let v44: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v49: string = ofChar(v21);
                            let v52: i32 = length(v49.clone());
                            let v53: Array<char> = new_init(&'\u{0000}', v52);
                            let v54: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method58(v52, v54.clone()) {
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
                                    Documents::method87(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method86())(b0)(b1)
                                                },
                                            ),
                                            v59,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v21,
                                    v44,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v21,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v121: Documents::US14 = match &v109 {
                        Documents::US14::US14_0(
                            v109_0_0,
                            v109_0_1,
                            v109_0_2,
                            v109_0_3,
                            v109_0_4,
                        ) => {
                            let v110: char = v109_0_0.clone();
                            Documents::US14::US14_0(
                                if '\\' == v110 { '/' } else { v110 },
                                v109_0_1.clone(),
                                v109_0_2.clone(),
                                v109_0_3.clone(),
                                v109_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v109_1_0) => {
                            Documents::US14::US14_1(v109_1_0.clone())
                        }
                    };
                    match &v121 {
                        Documents::US14::US14_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v121_0_0.clone()));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method90;
                        }
                        _ => (
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
        pub fn method91(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH1>,
        ) -> Documents::US14 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v4.clone());
            '_method91: loop {
                break '_method91 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US14::US14_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US14 = (match v4.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US14::US14_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
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
                                continue '_method91;
                            }
                        }
                    }
                });
            }
        }
        pub fn method92(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method92: loop {
                break '_method92 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US16 = if v1_1.get().clone() == 0_i64 {
                        Documents::US16::US16_0('\"')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US16::US16_0('\'')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US16::US16_0(' ')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Documents::US16::US16_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Documents::US16::US16_0(v15_0_0) => match &v15 {
                                Documents::US16::US16_0(x) => x.clone(),
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
                        continue '_method92;
                    }
                });
            }
        }
        pub fn method93(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method93: loop {
                break '_method93 ({
                    let v115: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Documents::method92(v24, 0_i64) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method58(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = v59 + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method87(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method86())(b0)(b1)
                                                },
                                            ),
                                            v62,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v24,
                                    v47,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v24,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v127: Documents::US14 = match &v115 {
                        Documents::US14::US14_0(
                            v115_0_0,
                            v115_0_1,
                            v115_0_2,
                            v115_0_3,
                            v115_0_4,
                        ) => {
                            let v116: char = v115_0_0.clone();
                            Documents::US14::US14_0(
                                if '\\' == v116 { '/' } else { v116 },
                                v115_0_1.clone(),
                                v115_0_2.clone(),
                                v115_0_3.clone(),
                                v115_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v115_1_0) => {
                            Documents::US14::US14_1(v115_1_0.clone())
                        }
                    };
                    match &v127 {
                        Documents::US14::US14_0(
                            v127_0_0,
                            v127_0_1,
                            v127_0_2,
                            v127_0_3,
                            v127_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v127_0_0.clone()));
                            let v1_1_temp: string = v127_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v127_0_2.clone();
                            let v3_temp: i32 = v127_0_3.clone();
                            let v4_temp: i32 = v127_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method93;
                        }
                        _ => (
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
        pub fn method94(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method94: loop {
                break '_method94 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if ' ' == getCharAt(v0_1.get().clone(), v1_1.get().clone()) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method94;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method95(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method95: loop {
                break '_method95 ({
                    let v79: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v10: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v30: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v35: string = ofChar(v10);
                        let v38: i32 = length(v35.clone());
                        let v39: Array<char> = new_init(&'\u{0000}', v38);
                        let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method58(v38, v40.clone()) {
                            let v42: i32 = v40.l0.get().clone();
                            let v43: char = getCharAt(v35.clone(), v42);
                            v39.get_mut()[v42 as usize] = v43;
                            {
                                let v44: i32 = v42 + 1_i32;
                                v40.l0.set(v44);
                                ()
                            }
                        }
                        {
                            let v45: List<char> = ofArray(v39.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method86())(b0)(b1)
                                        }),
                                        v45,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US14::US14_0(
                                v10,
                                v30,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    };
                    match &v79 {
                        Documents::US14::US14_0(v79_0_0, v79_0_1, v79_0_2, v79_0_3, v79_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v79_0_0.clone()));
                            let v1_1_temp: string = v79_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v79_0_2.clone();
                            let v3_temp: i32 = v79_0_3.clone();
                            let v4_temp: i32 = v79_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method95;
                        }
                        _ => (
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
        pub fn method84(v0_1: string) -> Documents::US13 {
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
                let v12: LrcPtr<StringBuilder> =
                    StringBuilder::_ctor__Z721C83C5(Documents::method85());
                fn v15(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US14 {
                    Documents::closure35((), arg10_0040)
                }
                fn v16(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US14 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v20: Documents::US14 = Documents::method88(
                    v7.clone(),
                    v12.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v15),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v16),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v202: Documents::US15 = match &v20 {
                    Documents::US14::US14_0(v20_0_0, v20_0_1, v20_0_2, v20_0_3, v20_0_4) => {
                        let v25: i32 = v20_0_4.clone();
                        let v24: i32 = v20_0_3.clone();
                        let v23: LrcPtr<StringBuilder> = v20_0_2.clone();
                        let v22: string = v20_0_1.clone();
                        let v130: Documents::US14 = if string("") == v22.clone() {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v23.clone(), v24, v25)
                            ))
                        } else {
                            let v42: char = getCharAt(v22.clone(), 0_i32);
                            if Documents::method89(v42, 0_i64) == false {
                                let v65: string = getSlice(
                                    v22.clone(),
                                    Some(1_i32),
                                    Some(length(v22.clone()) - 1_i32),
                                );
                                let v70: string = ofChar(v42);
                                let v73: i32 = length(v70.clone());
                                let v74: Array<char> = new_init(&'\u{0000}', v73);
                                let v75: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method58(v73, v75.clone()) {
                                    let v77: i32 = v75.l0.get().clone();
                                    let v78: char = getCharAt(v70.clone(), v77);
                                    v74.get_mut()[v77 as usize] = v78;
                                    {
                                        let v79: i32 = v77 + 1_i32;
                                        v75.l0.set(v79);
                                        ()
                                    }
                                }
                                {
                                    let v80: List<char> = ofArray(v74.clone());
                                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method87(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method86())(b0)(b1)
                                                    },
                                                ),
                                                v80,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v23.clone(),
                                            v24,
                                            v25,
                                        );
                                    Documents::US14::US14_0(
                                        v42,
                                        v65,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US14::US14_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v42,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v23.clone(),
                                                                          v24,
                                                                          v25)))
                            }
                        };
                        let v142: Documents::US14 = match &v130 {
                            Documents::US14::US14_0(
                                v130_0_0,
                                v130_0_1,
                                v130_0_2,
                                v130_0_3,
                                v130_0_4,
                            ) => {
                                let v131: char = v130_0_0.clone();
                                Documents::US14::US14_0(
                                    if '\\' == v131 { '/' } else { v131 },
                                    v130_0_1.clone(),
                                    v130_0_2.clone(),
                                    v130_0_3.clone(),
                                    v130_0_4.clone(),
                                )
                            }
                            Documents::US14::US14_1(v130_1_0) => {
                                Documents::US14::US14_1(v130_1_0.clone())
                            }
                        };
                        let v161: Documents::US15 = match &v142 {
                            Documents::US14::US14_0(
                                v142_0_0,
                                v142_0_1,
                                v142_0_2,
                                v142_0_3,
                                v142_0_4,
                            ) => {
                                let patternInput_1: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method90(
                                    ofChar(v142_0_0.clone()),
                                    v142_0_1.clone(),
                                    v142_0_2.clone(),
                                    v142_0_3.clone(),
                                    v142_0_4.clone(),
                                );
                                Documents::US15::US15_0(
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                    patternInput_1.4.clone(),
                                )
                            }
                            Documents::US14::US14_1(v142_1_0) => {
                                Documents::US15::US15_1(v142_1_0.clone())
                            }
                        };
                        let v171: Documents::US15 = match &v161 {
                            Documents::US15::US15_0(
                                v161_0_0,
                                v161_0_1,
                                v161_0_2,
                                v161_0_3,
                                v161_0_4,
                            ) => Documents::US15::US15_0(
                                v161_0_0.clone(),
                                v161_0_1.clone(),
                                v161_0_2.clone(),
                                v161_0_3.clone(),
                                v161_0_4.clone(),
                            ),
                            _ => Documents::US15::US15_0(
                                string(""),
                                v22.clone(),
                                v23.clone(),
                                v24,
                                v25,
                            ),
                        };
                        match &v171 {
                            Documents::US15::US15_0(
                                v171_0_0,
                                v171_0_1,
                                v171_0_2,
                                v171_0_3,
                                v171_0_4,
                            ) => {
                                let v176: i32 = v171_0_4.clone();
                                let v175: i32 = v171_0_3.clone();
                                let v174: LrcPtr<StringBuilder> = v171_0_2.clone();
                                let v173: string = v171_0_1.clone();
                                let v180: Documents::US14 = Documents::method91(
                                    v173.clone(),
                                    v174.clone(),
                                    v175,
                                    v176,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v15),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v16),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v180 {
                                        Documents::US14::US14_0(v180_0_0,
                                                                v180_0_1,
                                                                v180_0_2,
                                                                v180_0_3,
                                                                v180_0_4) =>
                                        Documents::US15::US15_0(v171_0_0.clone(),
                                                                v180_0_1.clone(),
                                                                v180_0_2.clone(),
                                                                v180_0_3.clone(),
                                                                v180_0_4.clone()),
                                        Documents::US14::US14_1(v180_1_0) =>
                                        Documents::US15::US15_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                         v180_1_0.clone(),
                                                                         (v7.clone(),
                                                                          v12.clone(),
                                                                          1_i32,
                                                                          1_i32),
                                                                         (v22,
                                                                          v23,
                                                                          v24,
                                                                          v25),
                                                                         (v173,
                                                                          v174,
                                                                          v175,
                                                                          v176))),
                                    }
                            }
                            _ => Documents::US15::US15_1(string(
                                "parsing.between / expected content",
                            )),
                        }
                    }
                    Documents::US14::US14_1(v20_1_0) => Documents::US15::US15_1(v20_1_0.clone()),
                };
                let v414: Documents::US15 = match &v202 {
                    Documents::US15::US15_0(v202_0_0, v202_0_1, v202_0_2, v202_0_3, v202_0_4) => {
                        v202.clone()
                    }
                    _ => {
                        let v321: Documents::US14 = if string("") == v7.clone() {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v12.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v228: char = getCharAt(v7.clone(), 0_i32);
                            if Documents::method92(v228, 0_i64) == false {
                                let v251: string = getSlice(
                                    v7.clone(),
                                    Some(1_i32),
                                    Some(length(v7.clone()) - 1_i32),
                                );
                                let v256: string = ofChar(v228);
                                let v259: i32 = length(v256.clone());
                                let v260: Array<char> = new_init(&'\u{0000}', v259);
                                let v261: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method58(v259, v261.clone()) {
                                    let v263: i32 = v261.l0.get().clone();
                                    let v264: char = getCharAt(v256.clone(), v263);
                                    v260.get_mut()[v263 as usize] = v264;
                                    {
                                        let v265: i32 = v263 + 1_i32;
                                        v261.l0.set(v265);
                                        ()
                                    }
                                }
                                {
                                    let v266: List<char> = ofArray(v260.clone());
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method87(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method86())(b0)(b1)
                                                    },
                                                ),
                                                v266,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v12.clone(),
                                            1_i32,
                                            1_i32,
                                        );
                                    Documents::US14::US14_0(
                                        v228,
                                        v251,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US14::US14_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v228,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v12.clone(),
                                                                          1_i32,
                                                                          1_i32)))
                            }
                        };
                        let v333: Documents::US14 = match &v321 {
                            Documents::US14::US14_0(
                                v321_0_0,
                                v321_0_1,
                                v321_0_2,
                                v321_0_3,
                                v321_0_4,
                            ) => {
                                let v322: char = v321_0_0.clone();
                                Documents::US14::US14_0(
                                    if '\\' == v322 { '/' } else { v322 },
                                    v321_0_1.clone(),
                                    v321_0_2.clone(),
                                    v321_0_3.clone(),
                                    v321_0_4.clone(),
                                )
                            }
                            Documents::US14::US14_1(v321_1_0) => {
                                Documents::US14::US14_1(v321_1_0.clone())
                            }
                        };
                        let v352: Documents::US15 = match &v333 {
                            Documents::US14::US14_0(
                                v333_0_0,
                                v333_0_1,
                                v333_0_2,
                                v333_0_3,
                                v333_0_4,
                            ) => {
                                let patternInput_3: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method93(
                                    ofChar(v333_0_0.clone()),
                                    v333_0_1.clone(),
                                    v333_0_2.clone(),
                                    v333_0_3.clone(),
                                    v333_0_4.clone(),
                                );
                                Documents::US15::US15_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                    patternInput_3.4.clone(),
                                )
                            }
                            Documents::US14::US14_1(v333_1_0) => {
                                Documents::US15::US15_1(v333_1_0.clone())
                            }
                        };
                        match &v352 {
                            Documents::US15::US15_0(
                                v352_0_0,
                                v352_0_1,
                                v352_0_2,
                                v352_0_3,
                                v352_0_4,
                            ) => v352.clone(),
                            _ => {
                                let v366: Documents::US17 = if length(v7.clone()) == 0_i32 {
                                    Documents::US17::US17_0(v7.clone(), v12.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US17::US17_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v7.clone()
                                    ))
                                };
                                let v375: Documents::US15 = match &v366 {
                                    Documents::US17::US17_0(
                                        v366_0_0,
                                        v366_0_1,
                                        v366_0_2,
                                        v366_0_3,
                                    ) => Documents::US15::US15_0(
                                        string(""),
                                        v366_0_0.clone(),
                                        v366_0_1.clone(),
                                        v366_0_2.clone(),
                                        v366_0_3.clone(),
                                    ),
                                    Documents::US17::US17_1(v366_1_0) => {
                                        Documents::US15::US15_1(v366_1_0.clone())
                                    }
                                };
                                match &v375 {
                                    Documents::US15::US15_0(
                                        v375_0_0,
                                        v375_0_1,
                                        v375_0_2,
                                        v375_0_3,
                                        v375_0_4,
                                    ) => {
                                        let v377: string = v375_0_1.clone();
                                        Documents::US15::US15_0(
                                            v375_0_0.clone(),
                                            getSlice(
                                                v377.clone(),
                                                Some(Documents::method94(v377.clone(), 0_i32)),
                                                Some(length(v377) - 1_i32),
                                            ),
                                            v375_0_2.clone(),
                                            v375_0_3.clone(),
                                            v375_0_4.clone(),
                                        )
                                    }
                                    Documents::US15::US15_1(v375_1_0) => {
                                        Documents::US15::US15_1(v375_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v685: Documents::US18 = match &v414 {
                    Documents::US15::US15_0(v414_0_0, v414_0_1, v414_0_2, v414_0_3, v414_0_4) => {
                        let v419: i32 = v414_0_4.clone();
                        let v418: i32 = v414_0_3.clone();
                        let v417: LrcPtr<StringBuilder> = v414_0_2.clone();
                        let v416: string = v414_0_1.clone();
                        let v544: Documents::US14 = if string("") == v416.clone() {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v417.clone(), v418, v419)
                            ))
                        } else {
                            let v425: char = getCharAt(v416.clone(), 0_i32);
                            if v425 == ' ' {
                                let v446: string = getSlice(
                                    v416.clone(),
                                    Some(1_i32),
                                    Some(length(v416.clone()) - 1_i32),
                                );
                                let v451: string = ofChar(v425);
                                let v454: i32 = length(v451.clone());
                                let v455: Array<char> = new_init(&'\u{0000}', v454);
                                let v456: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method58(v454, v456.clone()) {
                                    let v458: i32 = v456.l0.get().clone();
                                    let v459: char = getCharAt(v451.clone(), v458);
                                    v455.get_mut()[v458 as usize] = v459;
                                    {
                                        let v460: i32 = v458 + 1_i32;
                                        v456.l0.set(v460);
                                        ()
                                    }
                                }
                                {
                                    let v461: List<char> = ofArray(v455.clone());
                                    let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method87(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method86())(b0)(b1)
                                                    },
                                                ),
                                                v461,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v417.clone(),
                                            v418,
                                            v419,
                                        );
                                    Documents::US14::US14_0(
                                        v425,
                                        v446,
                                        patternInput_4.0.clone(),
                                        patternInput_4.1.clone(),
                                        patternInput_4.2.clone(),
                                    )
                                }
                            } else {
                                let v496: i32 = length(v416.clone());
                                let v503: i32 = indexOf(v416.clone(), string("\n")) - 1_i32;
                                Documents::US14::US14_1(sprintf!("{}\n{}\n",
                                                                         sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                  ' ',
                                                                                  v418,
                                                                                  v419,
                                                                                  v417.clone(),
                                                                                  getSlice(v416.clone(),
                                                                                           Some(0_i32),
                                                                                           Some(if -2_i32
                                                                                                       ==
                                                                                                       v503
                                                                                                   {
                                                                                                    v496
                                                                                                        +
                                                                                                        1_i32
                                                                                                } else {
                                                                                                    v503
                                                                                                        +
                                                                                                        1_i32
                                                                                                }
                                                                                                    -
                                                                                                    1_i32))),
                                                                         append(replicate(v419
                                                                                              -
                                                                                              1_i32,
                                                                                          string(" ")),
                                                                                string("^"))))
                            }
                        };
                        let v556: Documents::US19 = match &v544 {
                            Documents::US14::US14_0(
                                v544_0_0,
                                v544_0_1,
                                v544_0_2,
                                v544_0_3,
                                v544_0_4,
                            ) => Documents::US19::US19_0(
                                Documents::US16::US16_0(v544_0_0.clone()),
                                v544_0_1.clone(),
                                v544_0_2.clone(),
                                v544_0_3.clone(),
                                v544_0_4.clone(),
                            ),
                            _ => Documents::US19::US19_0(
                                Documents::US16::US16_1,
                                v416.clone(),
                                v417.clone(),
                                v418,
                                v419,
                            ),
                        };
                        let v659: Documents::US15 = match &v556 {
                            Documents::US19::US19_0(
                                v556_0_0,
                                v556_0_1,
                                v556_0_2,
                                v556_0_3,
                                v556_0_4,
                            ) => {
                                let v561: i32 = v556_0_4.clone();
                                let v560: i32 = v556_0_3.clone();
                                let v559: LrcPtr<StringBuilder> = v556_0_2.clone();
                                let v558: string = v556_0_1.clone();
                                let v636: Documents::US14 = if string("") == v558.clone() {
                                    Documents::US14::US14_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v559.clone(), v560, v561)
                                    ))
                                } else {
                                    let v567: char = getCharAt(v558.clone(), 0_i32);
                                    let v587: string = getSlice(
                                        v558.clone(),
                                        Some(1_i32),
                                        Some(length(v558) - 1_i32),
                                    );
                                    let v592: string = ofChar(v567);
                                    let v595: i32 = length(v592.clone());
                                    let v596: Array<char> = new_init(&'\u{0000}', v595);
                                    let v597: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v595, v597.clone()) {
                                        let v599: i32 = v597.l0.get().clone();
                                        let v600: char = getCharAt(v592.clone(), v599);
                                        v596.get_mut()[v599 as usize] = v600;
                                        {
                                            let v601: i32 = v599 + 1_i32;
                                            v597.l0.set(v601);
                                            ()
                                        }
                                    }
                                    {
                                        let v602: List<char> = ofArray(v596.clone());
                                        let patternInput_5:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Documents::method87(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method86())(b0)(b1)),
                                                                                     v602,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v559,
                                                                            v560,
                                                                            v561);
                                        Documents::US14::US14_0(
                                            v567,
                                            v587,
                                            patternInput_5.0.clone(),
                                            patternInput_5.1.clone(),
                                            patternInput_5.2.clone(),
                                        )
                                    }
                                };
                                match &v636 {
                                    Documents::US14::US14_0(
                                        v636_0_0,
                                        v636_0_1,
                                        v636_0_2,
                                        v636_0_3,
                                        v636_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Documents::method95(
                                            ofChar(v636_0_0.clone()),
                                            v636_0_1.clone(),
                                            v636_0_2.clone(),
                                            v636_0_3.clone(),
                                            v636_0_4.clone(),
                                        );
                                        Documents::US15::US15_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Documents::US14::US14_1(v636_1_0) => {
                                        Documents::US15::US15_1(v636_1_0.clone())
                                    }
                                }
                            }
                            Documents::US19::US19_1(v556_1_0) => {
                                Documents::US15::US15_1(v556_1_0.clone())
                            }
                        };
                        let v671: Documents::US20 = match &v659 {
                            Documents::US15::US15_0(
                                v659_0_0,
                                v659_0_1,
                                v659_0_2,
                                v659_0_3,
                                v659_0_4,
                            ) => Documents::US20::US20_0(
                                Documents::US5::US5_0(v659_0_0.clone()),
                                v659_0_1.clone(),
                                v659_0_2.clone(),
                                v659_0_3.clone(),
                                v659_0_4.clone(),
                            ),
                            _ => Documents::US20::US20_0(
                                Documents::US5::US5_1,
                                v416,
                                v417,
                                v418,
                                v419,
                            ),
                        };
                        match &v671 {
                            Documents::US20::US20_0(
                                v671_0_0,
                                v671_0_1,
                                v671_0_2,
                                v671_0_3,
                                v671_0_4,
                            ) => Documents::US18::US18_0(
                                v414_0_0.clone(),
                                v671_0_0.clone(),
                                v671_0_1.clone(),
                                v671_0_2.clone(),
                                v671_0_3.clone(),
                                v671_0_4.clone(),
                            ),
                            Documents::US20::US20_1(v671_1_0) => {
                                Documents::US18::US18_1(v671_1_0.clone())
                            }
                        }
                    }
                    Documents::US15::US15_1(v414_1_0) => Documents::US18::US18_1(v414_1_0.clone()),
                };
                match &v685 {
                    Documents::US18::US18_0(
                        v685_0_0,
                        v685_0_1,
                        v685_0_2,
                        v685_0_3,
                        v685_0_4,
                        v685_0_5,
                    ) => Documents::US13::US13_0(v685_0_0.clone(), v685_0_1.clone()),
                    Documents::US18::US18_1(v685_1_0) => Documents::US13::US13_1(v685_1_0.clone()),
                }
            }
        }
        pub fn method98(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method98: loop {
                break '_method98 (if v1_1.get().clone() >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US16 = if v1_1.get().clone() == 0_i64 {
                        Documents::US16::US16_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US16::US16_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US16::US16_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                if v11 == 0_i64 {
                                    Documents::US16::US16_0(' ')
                                } else {
                                    let v14: i64 = v11 - 1_i64;
                                    Documents::US16::US16_1
                                }
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v19 {
                            Documents::US16::US16_0(v19_0_0) => match &v19 {
                                Documents::US16::US16_0(x) => x.clone(),
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
                        continue '_method98;
                    }
                });
            }
        }
        pub fn method99(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method99: loop {
                break '_method99 ({
                    let v121: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Documents::method98(v27, 0_i64) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method58(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
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
                                    Documents::method87(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method86())(b0)(b1)
                                                },
                                            ),
                                            v65,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v27,
                                    v50,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v27,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v121 {
                        Documents::US14::US14_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v121_0_0.clone()));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method99;
                        }
                        _ => (
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
        pub fn method101(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method101: loop {
                break '_method101 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US16 = if v1_1.get().clone() == 0_i64 {
                        Documents::US16::US16_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Documents::US16::US16_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Documents::US16::US16_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Documents::US16::US16_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Documents::US16::US16_0(v15_0_0) => match &v15 {
                                Documents::US16::US16_0(x) => x.clone(),
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
                        continue '_method101;
                    }
                });
            }
        }
        pub fn closure39(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v128: Documents::US14 = if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '\\' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method58(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method86())(b0)(b1)
                                }),
                                v45,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US14::US14_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v80: i32 = length(v0_1.clone());
                    let v87: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US14::US14_1(sprintf!(
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
                                Some(
                                    if -2_i32 == v87 {
                                        v80 + 1_i32
                                    } else {
                                        v87 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v212: Documents::US14 = match &v128 {
                Documents::US14::US14_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                    let v133: i32 = v128_0_4.clone();
                    let v132: i32 = v128_0_3.clone();
                    let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                    let v130: string = v128_0_1.clone();
                    if string("") == v130.clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v131.clone(), v132, v133)
                        ))
                    } else {
                        let v139: char = getCharAt(v130.clone(), 0_i32);
                        let v159: string =
                            getSlice(v130.clone(), Some(1_i32), Some(length(v130) - 1_i32));
                        let v164: string = ofChar(v139);
                        let v167: i32 = length(v164.clone());
                        let v168: Array<char> = new_init(&'\u{0000}', v167);
                        let v169: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method58(v167, v169.clone()) {
                            let v171: i32 = v169.l0.get().clone();
                            let v172: char = getCharAt(v164.clone(), v171);
                            v168.get_mut()[v171 as usize] = v172;
                            {
                                let v173: i32 = v171 + 1_i32;
                                v169.l0.set(v173);
                                ()
                            }
                        }
                        {
                            let v174: List<char> = ofArray(v168.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method86())(b0)(b1)
                                        }),
                                        v174,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v131,
                                    v132,
                                    v133,
                                );
                            Documents::US14::US14_0(
                                v139,
                                v159,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v128_1_0) => Documents::US14::US14_1(v128_1_0.clone()),
            };
            match &v212 {
                Documents::US14::US14_0(v212_0_0, v212_0_1, v212_0_2, v212_0_3, v212_0_4) => {
                    Documents::US15::US15_0(
                        append(ofChar('\\'), ofChar(v212_0_0.clone())),
                        v212_0_1.clone(),
                        v212_0_2.clone(),
                        v212_0_3.clone(),
                        v212_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v212_1_0) => Documents::US15::US15_1(v212_1_0.clone()),
            }
        }
        pub fn closure40(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v128: Documents::US14 = if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '`' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method58(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method87(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method86())(b0)(b1)
                                }),
                                v45,
                                LrcPtr::new(Documents::UH0::UH0_0),
                            ),
                            v1_1.clone(),
                            v2,
                            v3,
                        );
                        Documents::US14::US14_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v80: i32 = length(v0_1.clone());
                    let v87: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Documents::US14::US14_1(sprintf!(
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
                                Some(
                                    if -2_i32 == v87 {
                                        v80 + 1_i32
                                    } else {
                                        v87 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v212: Documents::US14 = match &v128 {
                Documents::US14::US14_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                    let v133: i32 = v128_0_4.clone();
                    let v132: i32 = v128_0_3.clone();
                    let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                    let v130: string = v128_0_1.clone();
                    if string("") == v130.clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v131.clone(), v132, v133)
                        ))
                    } else {
                        let v139: char = getCharAt(v130.clone(), 0_i32);
                        let v159: string =
                            getSlice(v130.clone(), Some(1_i32), Some(length(v130) - 1_i32));
                        let v164: string = ofChar(v139);
                        let v167: i32 = length(v164.clone());
                        let v168: Array<char> = new_init(&'\u{0000}', v167);
                        let v169: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method58(v167, v169.clone()) {
                            let v171: i32 = v169.l0.get().clone();
                            let v172: char = getCharAt(v164.clone(), v171);
                            v168.get_mut()[v171 as usize] = v172;
                            {
                                let v173: i32 = v171 + 1_i32;
                                v169.l0.set(v173);
                                ()
                            }
                        }
                        {
                            let v174: List<char> = ofArray(v168.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method87(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method86())(b0)(b1)
                                        }),
                                        v174,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v131,
                                    v132,
                                    v133,
                                );
                            Documents::US14::US14_0(
                                v139,
                                v159,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v128_1_0) => Documents::US14::US14_1(v128_1_0.clone()),
            };
            match &v212 {
                Documents::US14::US14_0(v212_0_0, v212_0_1, v212_0_2, v212_0_3, v212_0_4) => {
                    Documents::US15::US15_0(
                        append(ofChar('`'), ofChar(v212_0_0.clone())),
                        v212_0_1.clone(),
                        v212_0_2.clone(),
                        v212_0_3.clone(),
                        v212_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v212_1_0) => Documents::US15::US15_1(v212_1_0.clone()),
            }
        }
        pub fn method102(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH3>,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v4.clone());
            '_method102: loop {
                break '_method102 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US15::US15_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US15 = (match v4.get().clone().as_ref() {
                            Documents::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US15::US15_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
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
                                continue '_method102;
                            }
                        }
                    }
                });
            }
        }
        pub fn method103(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method103: loop {
                break '_method103 (match v0_1.get().clone().as_ref() {
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
                        continue '_method103;
                    }
                });
            }
        }
        pub fn method100(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US22 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method100: loop {
                break '_method100 ({
                    let v115: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Documents::method101(v24, 0_i64) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method58(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = v59 + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method87(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method86())(b0)(b1)
                                                },
                                            ),
                                            v62,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v24,
                                    v47,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v24,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v129: Documents::US15 = match &v115 {
                        Documents::US14::US14_0(
                            v115_0_0,
                            v115_0_1,
                            v115_0_2,
                            v115_0_3,
                            v115_0_4,
                        ) => Documents::US15::US15_0(
                            ofChar(v115_0_0.clone()),
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        ),
                        Documents::US14::US14_1(v115_1_0) => {
                            Documents::US15::US15_1(v115_1_0.clone())
                        }
                    };
                    let v143: Documents::US15 = match &v129 {
                        Documents::US15::US15_0(
                            v129_0_0,
                            v129_0_1,
                            v129_0_2,
                            v129_0_3,
                            v129_0_4,
                        ) => v129.clone(),
                        _ => Documents::method102(
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
                    match &v143 {
                        Documents::US15::US15_0(
                            v143_0_0,
                            v143_0_1,
                            v143_0_2,
                            v143_0_3,
                            v143_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v143_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v143_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v143_0_2.clone();
                            let v3_temp: i32 = v143_0_3.clone();
                            let v4_temp: i32 = v143_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method100;
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method103(
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
        pub fn method104(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method104(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method105(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US22 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method105: loop {
                break '_method105 ({
                    let v115: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Documents::method101(v24, 0_i64) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method58(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = v59 + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method87(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method86())(b0)(b1)
                                                },
                                            ),
                                            v62,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v24,
                                    v47,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v24,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v129: Documents::US15 = match &v115 {
                        Documents::US14::US14_0(
                            v115_0_0,
                            v115_0_1,
                            v115_0_2,
                            v115_0_3,
                            v115_0_4,
                        ) => Documents::US15::US15_0(
                            ofChar(v115_0_0.clone()),
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        ),
                        Documents::US14::US14_1(v115_1_0) => {
                            Documents::US15::US15_1(v115_1_0.clone())
                        }
                    };
                    match &v129 {
                        Documents::US15::US15_0(
                            v129_0_0,
                            v129_0_1,
                            v129_0_2,
                            v129_0_3,
                            v129_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v129_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v129_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v129_0_2.clone();
                            let v3_temp: i32 = v129_0_3.clone();
                            let v4_temp: i32 = v129_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method105;
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method103(
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
        pub fn method97(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US22 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method97: loop {
                break '_method97 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v121: Documents::US14 = if v5 {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Documents::method98(v27, 0_i64) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method58(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
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
                                    Documents::method87(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method86())(b0)(b1)
                                                },
                                            ),
                                            v65,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v27,
                                    v50,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v27,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v140: Documents::US15 = match &v121 {
                        Documents::US14::US14_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method99(
                                    ofChar(v121_0_0.clone()),
                                    v121_0_1.clone(),
                                    v121_0_2.clone(),
                                    v121_0_3.clone(),
                                    v121_0_4.clone(),
                                );
                            Documents::US15::US15_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v121_1_0) => {
                            Documents::US15::US15_1(v121_1_0.clone())
                        }
                    };
                    let v517: Documents::US15 = match &v140 {
                        Documents::US15::US15_0(
                            v140_0_0,
                            v140_0_1,
                            v140_0_2,
                            v140_0_3,
                            v140_0_4,
                        ) => v140.clone(),
                        _ => {
                            let v270: Documents::US14 = if v5 {
                                Documents::US14::US14_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                  '\"',
                                                                                  (v2.get().clone(),
                                                                                   v3.get().clone(),
                                                                                   v4.get().clone())))
                            } else {
                                let v151: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v151 == '\"' {
                                    let v172: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone()) - 1_i32),
                                    );
                                    let v177: string = ofChar(v151);
                                    let v180: i32 = length(v177.clone());
                                    let v181: Array<char> = new_init(&'\u{0000}', v180);
                                    let v182: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v180, v182.clone()) {
                                        let v184: i32 = v182.l0.get().clone();
                                        let v185: char = getCharAt(v177.clone(), v184);
                                        v181.get_mut()[v184 as usize] = v185;
                                        {
                                            let v186: i32 = v184 + 1_i32;
                                            v182.l0.set(v186);
                                            ()
                                        }
                                    }
                                    {
                                        let v187: List<char> = ofArray(v181.clone());
                                        let patternInput_2:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method87(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method86())(b0)(b1)),
                                                                                          v187,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US14::US14_0(
                                            v151,
                                            v172,
                                            patternInput_2.0.clone(),
                                            patternInput_2.1.clone(),
                                            patternInput_2.2.clone(),
                                        )
                                    }
                                } else {
                                    let v222: i32 = length(v1_1.get().clone());
                                    let v229: i32 =
                                        indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                    Documents::US14::US14_1(sprintf!("{}\n{}\n",
                                                                                      sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                               '\"',
                                                                                               v3.get().clone(),
                                                                                               v4.get().clone(),
                                                                                               v2.get().clone(),
                                                                                               getSlice(v1_1.get().clone(),
                                                                                                        Some(0_i32),
                                                                                                        Some(if -2_i32
                                                                                                                    ==
                                                                                                                    v229
                                                                                                                {
                                                                                                                 v222
                                                                                                                     +
                                                                                                                     1_i32
                                                                                                             } else {
                                                                                                                 v229
                                                                                                                     +
                                                                                                                     1_i32
                                                                                                             }
                                                                                                                 -
                                                                                                                 1_i32))),
                                                                                      append(replicate(v4.get().clone()
                                                                                                           -
                                                                                                           1_i32,
                                                                                                       string(" ")),
                                                                                             string("^"))))
                                }
                            };
                            let v454: Documents::US15 = match &v270 {
                                Documents::US14::US14_0(
                                    v270_0_0,
                                    v270_0_1,
                                    v270_0_2,
                                    v270_0_3,
                                    v270_0_4,
                                ) => {
                                    let v275: i32 = v270_0_4.clone();
                                    let v274: i32 = v270_0_3.clone();
                                    let v273: LrcPtr<StringBuilder> = v270_0_2.clone();
                                    let v272: string = v270_0_1.clone();
                                    let v277: Documents::US22 = Documents::method100(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v272.clone(),
                                        v273.clone(),
                                        v274,
                                        v275,
                                    );
                                    let v302: Documents::US15 = match &v277 {
                                        Documents::US22::US22_0(
                                            v277_0_0,
                                            v277_0_1,
                                            v277_0_2,
                                            v277_0_3,
                                            v277_0_4,
                                        ) => {
                                            let v284: List<string> = Documents::method104(
                                                v277_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US15::US15_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v284 = v284.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v284 = v284.clone();
                                                                    move |i: i32| {
                                                                        item(i, v284.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v284.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v277_0_1.clone(),
                                                v277_0_2.clone(),
                                                v277_0_3.clone(),
                                                v277_0_4.clone(),
                                            )
                                        }
                                        Documents::US22::US22_1(v277_1_0) => {
                                            Documents::US15::US15_1(v277_1_0.clone())
                                        }
                                    };
                                    match &v302 {
                                        Documents::US15::US15_0(
                                            v302_0_0,
                                            v302_0_1,
                                            v302_0_2,
                                            v302_0_3,
                                            v302_0_4,
                                        ) => {
                                            let v307: i32 = v302_0_4.clone();
                                            let v306: i32 = v302_0_3.clone();
                                            let v305: LrcPtr<StringBuilder> = v302_0_2.clone();
                                            let v304: string = v302_0_1.clone();
                                            let v432: Documents::US14 = if string("")
                                                == v304.clone()
                                            {
                                                Documents::US14::US14_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                                      '\"',
                                                                                                      (v305.clone(),
                                                                                                       v306,
                                                                                                       v307)))
                                            } else {
                                                let v313: char = getCharAt(v304.clone(), 0_i32);
                                                if v313 == '\"' {
                                                    let v334: string = getSlice(
                                                        v304.clone(),
                                                        Some(1_i32),
                                                        Some(length(v304.clone()) - 1_i32),
                                                    );
                                                    let v339: string = ofChar(v313);
                                                    let v342: i32 = length(v339.clone());
                                                    let v343: Array<char> =
                                                        new_init(&'\u{0000}', v342);
                                                    let v344: LrcPtr<Documents::Mut6> =
                                                        LrcPtr::new(Documents::Mut6 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method58(v342, v344.clone()) {
                                                        let v346: i32 = v344.l0.get().clone();
                                                        let v347: char =
                                                            getCharAt(v339.clone(), v346);
                                                        v343.get_mut()[v346 as usize] = v347;
                                                        {
                                                            let v348: i32 = v346 + 1_i32;
                                                            v344.l0.set(v348);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v349: List<char> =
                                                            ofArray(v343.clone());
                                                        let patternInput_3:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Documents::method87(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method86())(b0)(b1)),
                                                                                                              v349,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v305.clone(),
                                                                                                     v306,
                                                                                                     v307);
                                                        Documents::US14::US14_0(
                                                            v313,
                                                            v334,
                                                            patternInput_3.0.clone(),
                                                            patternInput_3.1.clone(),
                                                            patternInput_3.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v384: i32 = length(v304.clone());
                                                    let v391: i32 =
                                                        indexOf(v304.clone(), string("\n")) - 1_i32;
                                                    Documents::US14::US14_1(sprintf!("{}\n{}\n",
                                                                                                          sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                   '\"',
                                                                                                                   v306,
                                                                                                                   v307,
                                                                                                                   v305.clone(),
                                                                                                                   getSlice(v304.clone(),
                                                                                                                            Some(0_i32),
                                                                                                                            Some(if -2_i32
                                                                                                                                        ==
                                                                                                                                        v391
                                                                                                                                    {
                                                                                                                                     v384
                                                                                                                                         +
                                                                                                                                         1_i32
                                                                                                                                 } else {
                                                                                                                                     v391
                                                                                                                                         +
                                                                                                                                         1_i32
                                                                                                                                 }
                                                                                                                                     -
                                                                                                                                     1_i32))),
                                                                                                          append(replicate(v307
                                                                                                                               -
                                                                                                                               1_i32,
                                                                                                                           string(" ")),
                                                                                                                 string("^"))))
                                                }
                                            };
                                            match &v432 {
                                                                 Documents::US14::US14_0(v432_0_0,
                                                                                         v432_0_1,
                                                                                         v432_0_2,
                                                                                         v432_0_3,
                                                                                         v432_0_4)
                                                                 =>
                                                                 Documents::US15::US15_0(v302_0_0.clone(),
                                                                                         v432_0_1.clone(),
                                                                                         v432_0_2.clone(),
                                                                                         v432_0_3.clone(),
                                                                                         v432_0_4.clone()),
                                                                 Documents::US14::US14_1(v432_1_0)
                                                                 =>
                                                                 Documents::US15::US15_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v432_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v272,
                                                                                                   v273,
                                                                                                   v274,
                                                                                                   v275),
                                                                                                  (v304,
                                                                                                   v305,
                                                                                                   v306,
                                                                                                   v307))),
                                                             }
                                        }
                                        _ => Documents::US15::US15_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Documents::US14::US14_1(v270_1_0) => {
                                    Documents::US15::US15_1(v270_1_0.clone())
                                }
                            };
                            match &v454 {
                                Documents::US15::US15_0(
                                    v454_0_0,
                                    v454_0_1,
                                    v454_0_2,
                                    v454_0_3,
                                    v454_0_4,
                                ) => v454.clone(),
                                _ => {
                                    let v466: Documents::US15 =
                                                     Documents::method102(v1_1.get().clone(),
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
                                    let v477: Documents::US15 = match &v466 {
                                        Documents::US15::US15_0(
                                            v466_0_0,
                                            v466_0_1,
                                            v466_0_2,
                                            v466_0_3,
                                            v466_0_4,
                                        ) => Documents::US15::US15_0(
                                            string(""),
                                            v466_0_1.clone(),
                                            v466_0_2.clone(),
                                            v466_0_3.clone(),
                                            v466_0_4.clone(),
                                        ),
                                        Documents::US15::US15_1(v466_1_0) => {
                                            Documents::US15::US15_1(v466_1_0.clone())
                                        }
                                    };
                                    let v488: Documents::US22 = match &v477 {
                                        Documents::US15::US15_0(
                                            v477_0_0,
                                            v477_0_1,
                                            v477_0_2,
                                            v477_0_3,
                                            v477_0_4,
                                        ) => Documents::method105(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v477_0_1.clone(),
                                            v477_0_2.clone(),
                                            v477_0_3.clone(),
                                            v477_0_4.clone(),
                                        ),
                                        Documents::US15::US15_1(v477_1_0) => {
                                            Documents::US22::US22_1(v477_1_0.clone())
                                        }
                                    };
                                    match &v488 {
                                        Documents::US22::US22_0(
                                            v488_0_0,
                                            v488_0_1,
                                            v488_0_2,
                                            v488_0_3,
                                            v488_0_4,
                                        ) => {
                                            let v495: List<string> = Documents::method104(
                                                v488_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US15::US15_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v495 = v495.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v495 = v495.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v495.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v495.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v488_0_1.clone(),
                                                v488_0_2.clone(),
                                                v488_0_3.clone(),
                                                v488_0_4.clone(),
                                            )
                                        }
                                        Documents::US22::US22_1(v488_1_0) => {
                                            Documents::US15::US15_1(v488_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v517 {
                        Documents::US15::US15_0(
                            v517_0_0,
                            v517_0_1,
                            v517_0_2,
                            v517_0_3,
                            v517_0_4,
                        ) => {
                            let v522: i32 = v517_0_4.clone();
                            let v521: i32 = v517_0_3.clone();
                            let v520: LrcPtr<StringBuilder> = v517_0_2.clone();
                            let v519: string = v517_0_1.clone();
                            let v518: string = v517_0_0.clone();
                            let v524: i32 = Documents::method94(v519.clone(), 0_i32);
                            let v552: Documents::US17 = if 0_i32 == v524 {
                                Documents::US17::US17_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US17::US17_0(
                                    getSlice(
                                        v519.clone(),
                                        Some(v524),
                                        Some(length(v519.clone()) - 1_i32),
                                    ),
                                    v520.clone(),
                                    v521,
                                    v522,
                                )
                            };
                            match &v552 {
                                Documents::US17::US17_0(v552_0_0, v552_0_1, v552_0_2, v552_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v518.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v552_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v552_0_1.clone();
                                    let v3_temp: i32 = v552_0_2.clone();
                                    let v4_temp: i32 = v552_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method97;
                                }
                                _ => Documents::US22::US22_0(
                                    Documents::method103(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v518.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v519,
                                    v520,
                                    v521,
                                    v522,
                                ),
                            }
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method103(
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
        pub fn method96(v0_1: string) -> Documents::US21 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v18: Documents::US22 = Documents::method97(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method85()),
                    1_i32,
                    1_i32,
                );
                match &v18 {
                    Documents::US22::US22_0(v18_0_0, v18_0_1, v18_0_2, v18_0_3, v18_0_4) => {
                        Documents::US21::US21_0(toArray(Documents::method104(
                            v18_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US22::US22_1(v18_1_0) => Documents::US21::US21_1(v18_1_0.clone()),
                }
            }
        }
        pub fn method107(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v26: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("file_name")), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v52: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("arguments")), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v77: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v85: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v102: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v127: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v135: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v143: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v152: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v160: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v165: std::string::String = format!("{:#?}", v3);
            let v198: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v165)),
                    (),
                );
                ()
            };
            let v206: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v215: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v223: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v234: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
                ()
            };
            let v242: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v251: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v259: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v264: std::string::String = format!("{:#?}", v5);
            let v297: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v264)),
                    (),
                );
                ()
            };
            let v305: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v314: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v322: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v327: std::string::String = format!("{:#?}", v6);
            let v360: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v327)),
                    (),
                );
                ()
            };
            let v368: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v377: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v385: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v396: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v404: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v413: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("working_directory")), ());
                ()
            };
            let v421: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v426: std::string::String = format!("{:#?}", v8);
            let v459: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v426)),
                    (),
                );
                ()
            };
            let v468: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v476: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method106(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method107(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options"),
                v17
            ))
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
            if Documents::method6(Documents::US0::US0_1) {
                let v13: () = {
                    Documents::closure6((), ());
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method106(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method7(v27, v28, v29, v30, v31, v32),
                    Documents::method61(),
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn closure42(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method108() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method109(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US23>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method110() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn method111(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method77(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v9
            ))
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method111(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method75(),
                    v0_1,
                ))
            };
        }
        pub fn method112(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure46(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method113(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure46((), v))
        }
        pub fn closure47(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method114() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn method115() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn closure48(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method116() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure48((), v)
                },
            )
        }
        pub fn closure49(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_0(v0_1)
        }
        pub fn method117() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure49((), v))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_1(v0_1)
        }
        pub fn method118() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure50((), v))
        }
        pub fn method120(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("trace\'")), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v39: () = {
                Documents::closure8(
                    v3.clone(),
                    sprintf!(
                        "{}",
                        if v0_1 {
                            string("true")
                        } else {
                            string("false")
                        }
                    ),
                    (),
                );
                ()
            };
            let v48: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("e")), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: std::string::String = format!("{:#?}", v1_1);
            let v103: () = {
                Documents::closure8(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v70)),
                    (),
                );
                ()
            };
            let v112: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method119(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: std::string::String,
        ) -> string {
            let v10: string = Documents::method120(v8, v9);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.stdio_line"),
                v10
            ))
        }
        pub fn closure51(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_4) {
                let v6: () = {
                    Documents::closure6((), ());
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
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method119(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method7(v20, v21, v22, v23, v24, v25),
                    Documents::method75(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method121() -> string {
            let v6: string = Documents::method12(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method123() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method122(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Documents::method123();
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure52(v0_1: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_0) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(if v0_1.clone() == string("") {
                    string("")
                } else {
                    Documents::method122(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Documents::method7(v19, v20, v21, v22, v23, v24),
                        Documents::method121(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure53(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method124(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method125(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn method126() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US26,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure54((), v)
                },
            )
        }
        pub fn method127(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure55(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method128(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US27>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure55((), v)
                },
            )
        }
        pub fn method129(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method130(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure56(unitVar: (), v0_1: std::process::Output) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method131() -> Func1<std::process::Output, Documents::US28> {
            Func1::new(move |v: std::process::Output| Documents::closure56((), v))
        }
        pub fn closure57(unitVar: (), v0_1: std::string::String) -> Documents::US28 {
            Documents::US28::US28_1(v0_1)
        }
        pub fn method132() -> Func1<std::string::String, Documents::US28> {
            Func1::new(move |v: std::string::String| Documents::closure57((), v))
        }
        pub fn method133(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method77(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v9
            ))
        }
        pub fn closure58(v0_1: std::string::String, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method133(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method75(),
                    v0_1,
                ))
            };
        }
        pub fn closure59(unitVar: (), v0_1: i32) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method134() -> Func1<i32, Documents::US29> {
            Func1::new(move |v: i32| Documents::closure59((), v))
        }
        pub fn method135() -> string {
            string("\n")
        }
        pub fn method137(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("std_trace_length")), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method136(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Documents::method137(v8, v9);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_0) {
                let v6: () = {
                    Documents::closure6((), ());
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
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method136(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method7(v20, v21, v22, v23, v24, v25),
                    Documents::method121(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method140(
            v0_1: string,
            v1_1: Documents::US5,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v26: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("file_name")), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v52: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("arguments")), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", sprintf!("{:?}", v1_1)), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v97: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v105: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v146: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v155: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v163: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v168: std::string::String = format!("{:#?}", v3);
            let v201: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v168)),
                    (),
                );
                ()
            };
            let v209: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v218: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v226: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v237: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
                ()
            };
            let v245: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v262: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v267: std::string::String = format!("{:#?}", v5);
            let v300: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v267)),
                    (),
                );
                ()
            };
            let v308: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v317: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v325: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v330: std::string::String = format!("{:#?}", v6);
            let v363: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v330)),
                    (),
                );
                ()
            };
            let v371: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v380: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v388: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v399: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v407: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v416: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("working_directory")), ());
                ()
            };
            let v424: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v429: std::string::String = format!("{:#?}", v8);
            let v462: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v429)),
                    (),
                );
                ()
            };
            let v471: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v479: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method139(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: Documents::US5,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method140(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
            ))
        }
        pub fn closure61(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: Documents::US5,
            v8: string,
            unitVar: (),
        ) {
            if Documents::method6(Documents::US0::US0_1) {
                let v13: () = {
                    Documents::closure6((), ());
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method139(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method7(v27, v28, v29, v30, v31, v32),
                    Documents::method61(),
                    v8,
                    v7,
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method141(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Array<(string, string)> {
            v2
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method142() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US30> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure63((), v)
            })
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_0) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(if v0_1.clone() == string("") {
                    string("")
                } else {
                    Documents::method122(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Documents::method7(v19, v20, v21, v22, v23, v24),
                        Documents::method121(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure62(
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
        pub fn closure65(
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
        pub fn closure66(unitVar: (), v0_1: CancellationToken) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method143() -> Func1<CancellationToken, Documents::US31> {
            Func1::new(move |v: CancellationToken| Documents::closure66((), v))
        }
        pub fn closure67(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn method145(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method144(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<TaskCanceledException>,
        ) -> string {
            let v9: string = Documents::method145(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure68(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_3) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method144(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method33(),
                    v0_1,
                ))
            };
        }
        pub fn method147(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("output_length")), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method146(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Documents::method147(v8, v9);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v10
            ))
        }
        pub fn closure69(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_1) {
                let v6: () = {
                    Documents::closure6((), ());
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
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method146(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method7(v20, v21, v22, v23, v24, v25),
                    Documents::method61(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method138(
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
        pub fn method82(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Documents::US13 = Documents::method84(Documents::method83(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US5) = match &v9 {
                Documents::US13::US13_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Documents::US13::US13_1(v9_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v9_1_0.clone()),
                ),
            };
            let v21: Documents::US5 = patternInput.1.clone();
            let v20: string = patternInput.0.clone();
            let v26: Documents::US21 = Documents::method96(match &v21 {
                Documents::US5::US5_0(v21_0_0) => match &v21 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            });
            let v34: Array<string> = match &v26 {
                Documents::US21::US21_0(v26_0_0) => v26_0_0.clone(),
                Documents::US21::US21_1(v26_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v26_1_0.clone()),
                ),
            };
            let v36: Vec<string> = v34.to_vec();
            let v38: bool = true;
            let _vec_map: Vec<_> = v36
                .into_iter()
                .map(|x| {
                    //;
                    let v40: string = x;
                    let v43: &str = &*v40;
                    let v67: std::string::String = String::from(v43);
                    let v90: bool = true;
                    v67
                })
                .collect::<Vec<_>>();
            let v92: Vec<std::string::String> = _vec_map;
            let v95: () = {
                Documents::closure41(
                    v0_1,
                    v1_1,
                    v2.clone(),
                    v3,
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v20.clone(),
                    v92.clone(),
                    (),
                );
                ()
            };
            let _v138: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_3: LrcPtr<(i32, string)> = (Func0::new({
                    let v2 = v2.clone();
                    let v20 = v20.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v92 = v92.clone();
                    move || {
                        let v140: std::process::Command = std::process::Command::new(&*v20.clone());
                        let v142: bool = true;
                        let mut v140 = v140;
                        let v144: &mut std::process::Command =
                            std::process::Command::args(&mut v140, &*v92.clone());
                        let v146: std::process::Stdio = std::process::Stdio::piped();
                        let v148: &mut std::process::Command =
                            std::process::Command::stdout(v144, std::process::Stdio::piped());
                        let v150: std::process::Stdio = std::process::Stdio::piped();
                        let v152: &mut std::process::Command =
                            std::process::Command::stderr(v148, std::process::Stdio::piped());
                        let v154: std::process::Stdio = std::process::Stdio::piped();
                        let v156: &mut std::process::Command =
                            std::process::Command::stdin(v152, std::process::Stdio::piped());
                        let v170: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method5(), v6.clone()),
                        );
                        let v178: &mut std::process::Command = match &v170 {
                            Documents::US5::US5_0(v170_0_0) => std::process::Command::current_dir(
                                v156,
                                &*match &v170 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            ),
                            _ => v156,
                        };
                        let v196: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v178
                        } else {
                            let v182: Vec<(string, string)> = v2.clone().to_vec();
                            let v184: bool = true;
                            let _vec_fold_ = v182.into_iter().fold(v178, |acc, x| {
                                //;
                                let v186: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v191: &mut std::process::Command = std::process::Command::env(
                                    v186,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v193: bool = true;
                                v191
                            });
                            _vec_fold_
                        };
                        let v198: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v196);
                        let v199 = Documents::method65();
                        let v202: Result<std::process::Child, std::string::String> =
                            v198.map_err(|x| v199(x));
                        let v214 = Documents::method108();
                        let v216: bool = true;
                        let _result_map_ = v202.map(|x| {
                            //;
                            let v222: Option<std::process::Child> = v214(Some(x));
                            let v224: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v222);
                            let v226: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v224);
                            let v228: bool = true;
                            v226
                        });
                        let v230: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v231 = Documents::method109();
                        let v232 = Documents::method110();
                        let v234: Documents::US23 = match v230 {
                            Ok(x) => v231(x),
                            Err(e) => v232(e),
                        };
                        let patternInput_3: (i32, Documents::US6, Documents::US24) = match &v234 {
                            Documents::US23::US23_0(v234_0_0) => {
                                let v235: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v234_0_0.clone();
                                let v237: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v239: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v235.clone();
                                    let v241: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v239.lock();
                                    let v256: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method112(v241.unwrap());
                                    let v258: bool = true;
                                    let mut v256 = v256;
                                    let v260: &mut Option<std::process::Child> = &mut v256;
                                    let v262: Option<&mut std::process::Child> = v260.as_mut();
                                    let v264: &mut std::process::Child = v262.unwrap();
                                    let v266: &mut Option<std::process::ChildStdout> =
                                        &mut v264.stdout;
                                    let v268: Option<std::process::ChildStdout> =
                                        Option::take(v266);
                                    let v270: std::process::ChildStdout = v268.unwrap();
                                    let v272: bool = true;
                                    v270
                                })();
                                let v274: std::process::ChildStdout = _capture;
                                let v276: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v278: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v235.clone();
                                    let v280: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v278.lock();
                                    let v295: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method112(v280.unwrap());
                                    let v297: bool = true;
                                    let mut v295 = v295;
                                    let v299: &mut Option<std::process::Child> = &mut v295;
                                    let v301: Option<&mut std::process::Child> = v299.as_mut();
                                    let v303: &mut std::process::Child = v301.unwrap();
                                    let v305: &mut Option<std::process::ChildStderr> =
                                        &mut v303.stderr;
                                    let v307: Option<std::process::ChildStderr> =
                                        Option::take(v305);
                                    let v309: std::process::ChildStderr = v307.unwrap();
                                    let v311: bool = true;
                                    v309
                                })();
                                let v313: std::process::ChildStderr = _capture;
                                let v315: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v317: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v235.clone();
                                    let v319: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v317.lock();
                                    let v334: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method112(v319.unwrap());
                                    let v336: bool = true;
                                    let mut v334 = v334;
                                    let v338: &mut Option<std::process::Child> = &mut v334;
                                    let v340: Option<&mut std::process::Child> = v338.as_mut();
                                    let v342: &mut std::process::Child = v340.unwrap();
                                    let v344: &mut Option<std::process::ChildStdin> =
                                        &mut v342.stdin;
                                    let v346: Option<std::process::ChildStdin> = Option::take(v344);
                                    let v348: std::process::ChildStdin = v346.unwrap();
                                    let v353: Option<std::process::ChildStdin> =
                                        (Documents::method113())(Some(v348));
                                    let v355: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v353);
                                    let v357: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v355);
                                    let v359: bool = true;
                                    v357
                                })();
                                let v361: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v363: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v366: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method114())(v363.clone());
                                let v368: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v366);
                                let v370: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v368);
                                let v372: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method115())(v363);
                                let v374: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v372);
                                let v376: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v374);
                                let v378: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method116())(patternInput_2.1.clone());
                                let v380: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v378);
                                let v382: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v380);
                                let v384: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v386: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v274);
                                    let v388: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v386);
                                    let v390: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v388);
                                    let v392: bool = true;
                                    let mut v390 = v390;
                                    let _iter_try_for_each = v390.try_for_each(|x| {
                                        //;
                                        let v394: Result<std::string::String, std::io::Error> = x;
                                        let v396: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v370.clone();
                                        let v397 = Documents::method65();
                                        let v400: Result<std::string::String, std::string::String> =
                                            v394.map_err(|x| v397(x));
                                        let v412 = Documents::method117();
                                        let v413 = Documents::method118();
                                        let v415: Documents::US25 = match v400 {
                                            Ok(x) => v412(x),
                                            Err(e) => v413(e),
                                        };
                                        let v610: std::string::String = match &v415 {
                                            Documents::US25::US25_0(v415_0_0) => {
                                                let v418: string =
                                                    fable_library_rust::String_::fromString(
                                                        v415_0_0.clone(),
                                                    );
                                                let v420: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v422: std::borrow::Cow<[u8]> =
                                                    v420.encode(&*v418).0;
                                                let v424: &[u8] = v422.as_ref();
                                                let v426: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v424);
                                                let v429: &str = v426.unwrap();
                                                let v460: std::string::String = String::from(v429);
                                                let v467: string = sprintf!(
                                                    "> {}",
                                                    fable_library_rust::String_::fromString(
                                                        v460.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v470: () = {
                                                        Documents::closure52(v467.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v515: () = {
                                                        Documents::closure11(v467, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v460
                                            }
                                            Documents::US25::US25_1(v415_1_0) => {
                                                let v517: std::string::String = v415_1_0.clone();
                                                let v520: () = {
                                                    Documents::closure51(v5, v517.clone(), ());
                                                    ()
                                                };
                                                let v560: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v517);
                                                let v563: &str = &*v560;
                                                String::from(v563)
                                            }
                                        };
                                        let v612: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v396;
                                        let v614: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v612.lock();
                                        let v617: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v614.unwrap();
                                        let v630: &std::sync::mpsc::Sender<std::string::String> =
                                            &v617;
                                        let v632: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v630.send(v610);
                                        let v633 = Documents::method124();
                                        let v636: Result<(), std::string::String> =
                                            v632.map_err(|x| v633(x));
                                        let v649: _ = v636;
                                        let v651: bool = true;
                                        v649
                                    }); //;
                                    let v654: Result<(), string> = Documents::method125(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v657: string = string("}");
                                    let v661: bool = true;
                                    let v658 = v654;
                                    let v673: string = append(
                                        append(
                                            append(
                                                append(string("true; v658 "), v657),
                                                string("); "),
                                            ),
                                            string(""),
                                        ),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v674: bool = true;
                                    v658
                                }); // rust.fix_closure';
                                let v676: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v678: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v680: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v313);
                                    let v682: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v680);
                                    let v684: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v682);
                                    let v686: bool = true;
                                    let mut v684 = v684;
                                    let _iter_try_for_each = v684.try_for_each(|x| {
                                        //;
                                        let v688: Result<std::string::String, std::io::Error> = x;
                                        let v690: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v376.clone();
                                        let v691 = Documents::method65();
                                        let v694: Result<std::string::String, std::string::String> =
                                            v688.map_err(|x| v691(x));
                                        let v706 = Documents::method117();
                                        let v707 = Documents::method118();
                                        let v709: Documents::US25 = match v694 {
                                            Ok(x) => v706(x),
                                            Err(e) => v707(e),
                                        };
                                        let v952: std::string::String = match &v709 {
                                            Documents::US25::US25_0(v709_0_0) => {
                                                let v712: string =
                                                    fable_library_rust::String_::fromString(
                                                        v709_0_0.clone(),
                                                    );
                                                let v714: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v716: std::borrow::Cow<[u8]> =
                                                    v714.encode(&*v712).0;
                                                let v718: &[u8] = v716.as_ref();
                                                let v720: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v718);
                                                let v723: &str = v720.unwrap();
                                                let v754: std::string::String = String::from(v723);
                                                let v761: string = sprintf!(
                                                    "! {}",
                                                    fable_library_rust::String_::fromString(
                                                        v754.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v764: () = {
                                                        Documents::closure52(v761.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v808: () = {
                                                        Documents::closure11(v761, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v810: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v754
                                                    );
                                                    let v813: &str = &*v810;
                                                    String::from(v813)
                                                }
                                            }
                                            Documents::US25::US25_1(v709_1_0) => {
                                                let v859: std::string::String = v709_1_0.clone();
                                                let v862: () = {
                                                    Documents::closure51(v5, v859.clone(), ());
                                                    ()
                                                };
                                                let v902: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v859);
                                                let v905: &str = &*v902;
                                                String::from(v905)
                                            }
                                        };
                                        let v954: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v690;
                                        let v956: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v954.lock();
                                        let v959: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v956.unwrap();
                                        let v972: &std::sync::mpsc::Sender<std::string::String> =
                                            &v959;
                                        let v974: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v972.send(v952);
                                        let v975 = Documents::method124();
                                        let v978: Result<(), std::string::String> =
                                            v974.map_err(|x| v975(x));
                                        let v991: _ = v978;
                                        let v993: bool = true;
                                        v991
                                    }); //;
                                    let v996: Result<(), string> = Documents::method125(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v997: string = string("}");
                                    let v1001: bool = true;
                                    let v998 = v996;
                                    let v1013: string = append(
                                        append(
                                            append(
                                                append(string("true; v998 "), v997),
                                                string("); "),
                                            ),
                                            string(""),
                                        ),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v1014: bool = true;
                                    v998
                                }); // rust.fix_closure';
                                let v1016: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v1030: Documents::US26 = defaultValue(
                                    Documents::US26::US26_1,
                                    map(Documents::method126(), v4.clone()),
                                );
                                match &v1030 {
                                    Documents::US26::US26_0(v1030_0_0) => {
                                        let v1036: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v361;
                                        let v1038: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v1036.lock();
                                        let v1053: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method127(v1038.unwrap());
                                        let v1055: bool = true;
                                        let mut v1053 = v1053;
                                        let v1057: &mut Option<std::process::ChildStdin> =
                                            &mut v1053;
                                        let v1059: Option<std::process::ChildStdin> =
                                            Option::take(v1057);
                                        let v1061: bool = true;
                                        let _optionm_map_ = v1059.map(|x| {
                                            //;
                                            let v1063: std::process::ChildStdin = x;
                                            let v1065: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v1063);
                                            let v1067: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v1065);
                                            let v1069: bool = true;
                                            v1067
                                        });
                                        let v1071: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v1085: Documents::US27 = defaultValue(
                                            Documents::US27::US27_1,
                                            map(Documents::method128(), v1071),
                                        );
                                        match &v1085 {
                                            Documents::US27::US27_0(v1085_0_0) => {
                                                let v1089: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v1085 {
                                                    Documents::US27::US27_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                (match &v1030 {
                                                    Documents::US26::US26_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v1089.clone()
                                                );
                                                {
                                                    let v1091: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v1089;
                                                    let v1093: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v1091.lock();
                                                    let v1108: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method129(v1093.unwrap());
                                                    let v1110: bool = true;
                                                    let mut v1108 = v1108;
                                                    let v1112: bool = true;
                                                    std::io::Write::flush(&mut *v1108).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v1114: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v235;
                                    let v1116: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1114.lock();
                                    let v1131: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method112(v1116.unwrap());
                                    let v1133: bool = true;
                                    let mut v1131 = v1131;
                                    let v1135: &mut Option<std::process::Child> = &mut v1131;
                                    let v1137: Option<std::process::Child> = Option::take(v1135);
                                    let v1139: std::process::Child = v1137.unwrap();
                                    let v1141: Result<std::process::Output, std::io::Error> =
                                        v1139.wait_with_output();
                                    let v1142 = Documents::method65();
                                    let v1154: Result<std::process::Output, std::string::String> =
                                        v1141.map_err(|x| v1142(x));
                                    let v1157: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method130(v1016);
                                    let v1160: string = string("v1157");
                                    let v1161: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method130(v676);
                                    let v1166: string = append(
                                        append(string("vec!["), append(string("v1161, "), v1160)),
                                        string("]"),
                                    );
                                    let v1167: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v1161, v1157];
                                    let v1169: bool = true;
                                    v1167.into_iter().for_each(|x| {
                                        //;
                                        let v1171: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v1173: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v1171);
                                        let v1176: Result<(), string> = v1173.unwrap();
                                        v1176.unwrap();
                                        ();
                                        {
                                            let v1193: bool = true;
                                            let v1195: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v1196 = Documents::method131();
                                        let v1197 = Documents::method132();
                                        let v1198: Documents::US28 = match &v1154 {
                                            Err(v1154_1_0) => v1197(v1154_1_0.clone()),
                                            Ok(v1154_0_0) => v1196(v1154_0_0.clone()),
                                        };
                                        match &v1198 {
                                            Documents::US28::US28_0(v1198_0_0) => {
                                                let v1201: std::process::ExitStatus =
                                                    v1198_0_0.clone().status;
                                                let v1203: Option<i32> = v1201.code();
                                                let v1217: Documents::US29 = defaultValue(
                                                    Documents::US29::US29_1,
                                                    map(Documents::method134(), v1203),
                                                );
                                                match &v1217 {
                                                    Documents::US29::US29_0(v1217_0_0) => (
                                                        match &v1217 {
                                                            Documents::US29::US29_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US6::US6_1,
                                                        Documents::US24::US24_0(v382.clone()),
                                                    ),
                                                    _ => {
                                                        let v1227:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US6::US6_0(String::from(
                                                                v1227,
                                                            )),
                                                            Documents::US24::US24_0(v382.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US28::US28_1(v1198_1_0) => {
                                                let v1281: std::string::String = v1198_1_0.clone();
                                                let v1284: () = {
                                                    Documents::closure58(v1281.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US6::US6_0(v1281),
                                                    Documents::US24::US24_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US23::US23_1(v234_1_0) => {
                                let v1332: std::string::String = v234_1_0.clone();
                                let v1335: () = {
                                    Documents::closure45(v1332.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US6::US6_0(v1332),
                                    Documents::US24::US24_1,
                                )
                            }
                        };
                        let v1382: Documents::US24 = patternInput_3.2.clone();
                        let v1381: Documents::US6 = patternInput_3.1.clone();
                        let v1380: i32 = patternInput_3.0.clone();
                        let v1389: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1382 {
                            Documents::US24::US24_0(v1382_0_0) => Some(match &v1382 {
                                Documents::US24::US24_0(x) => x.clone(),
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
                        let v1391: bool = true;
                        let _optionm_map_ = v1389.map(|x| {
                            //;
                            let v1393: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1395: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1393;
                            let v1397: Result<
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
                            > = v1395.lock();
                            let v1400: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1397.unwrap();
                            let v1413 = v1400.iter();
                            let v1415: Vec<std::string::String> = v1413.collect::<Vec<_>>();
                            let v1417: bool = true;
                            let _vec_map: Vec<_> = v1415
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1419: std::string::String = x;
                                    let v1421: string =
                                        fable_library_rust::String_::fromString(v1419);
                                    let v1423: bool = true;
                                    v1421
                                })
                                .collect::<Vec<_>>();
                            let v1425: Vec<string> = _vec_map;
                            let v1428: LrcPtr<dyn IEnumerable_1<string>> =
                                ofArray_1(fable_library_rust::NativeArray_::array_from(v1425));
                            let v1434: string = join(Documents::method135(), toArray_1(v1428));
                            let v1439: bool = true;
                            v1434
                        });
                        let v1441: Option<string> = _optionm_map_;
                        let v1448: Documents::US5 = match &v1381 {
                            Documents::US6::US6_0(v1381_0_0) => Documents::US5::US5_0(
                                fable_library_rust::String_::fromString(match &v1381 {
                                    Documents::US6::US6_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Documents::US5::US5_1,
                        };
                        let v1453: string = defaultValue(
                            match &v1448 {
                                Documents::US5::US5_0(v1448_0_0) => match &v1448 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v1441,
                        );
                        let v1458: () = {
                            Documents::closure60(v1380, v1453.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1380, v1453))
                    }
                }))();
                _v138.set(Some(x_3))
            }
            {
                let v1500: LrcPtr<(i32, string)> = match &_v138.get().clone() {
                    None => panic!("{}", string("base.capture / _v138=None"),),
                    Some(_v138_0_0) => _v138_0_0.clone(),
                };
                let _v7: (i32, string) = (v1500.0.clone(), v1500.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method148(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method25(v2, Documents::method47(v1_1.clone()));
            let v8: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some(lastIndexOf(v1_1.clone(), string(".")) - 1_i32),
            );
            let v14: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some(lastIndexOf(v4.clone(), string(".")) - 1_i32),
            );
            let v20: bool = endsWith(v0_1.clone(), string(".md"), false) == false;
            (
                if v20 {
                    sprintf!("{}.{}", v1_1, v0_1.clone())
                } else {
                    sprintf!("{}.{}", v8, v0_1.clone())
                },
                if v20 {
                    sprintf!("{}.{}", v4, v0_1.clone())
                } else {
                    sprintf!("{}.{}", v14, v0_1)
                },
            )
        }
        pub fn method149() -> string {
            string("")
        }
        pub fn closure70(unitVar: (), v0_1: string) -> Documents::US33 {
            Documents::US33::US33_0(v0_1)
        }
        pub fn method150() -> Func1<string, Documents::US33> {
            Func1::new(move |v: string| Documents::closure70((), v))
        }
        pub fn closure71(unitVar: (), v0_1: std::string::String) -> Documents::US33 {
            Documents::US33::US33_1(v0_1)
        }
        pub fn method151() -> Func1<std::string::String, Documents::US33> {
            Func1::new(move |v: std::string::String| Documents::closure71((), v))
        }
        pub fn method152(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_file()
            } else {
                false
            }
        }
        pub fn method154(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: i32,
            v6: string,
            v7: string,
            v8: Documents::US5,
            v9: string,
            v10: string,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v19: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("file")), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("real_path")), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v87: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("relative_path")), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v120: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v129: () = {
                Documents::closure8(
                    v12.clone(),
                    sprintf!("{}", string("origin_hash_exit_code")),
                    (),
                );
                ()
            };
            let v137: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v153: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v162: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("origin_hash")), ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v178: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v4), ());
                ()
            };
            let v186: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v195: () = {
                Documents::closure8(
                    v12.clone(),
                    sprintf!("{}", string("local_git_hash_exit_code")),
                    (),
                );
                ()
            };
            let v203: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v211: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v219: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v228: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("local_git_hash")), ());
                ()
            };
            let v236: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v244: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v6), ());
                ()
            };
            let v252: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v261: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("hash1")), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v277: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v285: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v294: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("hash2")), ());
                ()
            };
            let v302: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v313: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", sprintf!("{:?}", v8)), ());
                ()
            };
            let v321: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v330: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("dist_path")), ());
                ()
            };
            let v338: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v346: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v354: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v363: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string("cache_path")), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v379: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v388: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v12.l0.get().clone()
        }
        pub fn method153(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
            v12: i32,
            v13: string,
            v14: i32,
            v15: string,
            v16: string,
            v17: Documents::US5,
            v18: string,
            v19: string,
        ) -> string {
            let v20: string =
                Documents::method154(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v20
            ))
        }
        pub fn closure72(
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
            v10: Documents::US5,
            unitVar: (),
        ) {
            if Documents::method6(Documents::US0::US0_2) {
                let v15: () = {
                    Documents::closure6((), ());
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
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                let v53: string =
                    string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2");
                Documents::method18(if v53.clone() == string("") {
                    string("")
                } else {
                    Documents::method153(
                        v29.clone(),
                        v30.clone(),
                        v31.clone(),
                        v32.clone(),
                        v33.clone(),
                        v34.clone(),
                        Documents::method7(v29, v30, v31, v32, v33, v34),
                        Documents::method11(),
                        v53,
                        v1_1,
                        v2,
                        v0_1,
                        v4,
                        v3,
                        v7,
                        v6,
                        v9,
                        v10,
                        v5,
                        v8,
                    )
                })
            };
        }
        pub fn method156(v0_1: string) -> string {
            v0_1
        }
        pub fn closure73(unitVar: (), v0_1: u64) -> Documents::US34 {
            Documents::US34::US34_0(v0_1)
        }
        pub fn method157() -> Func1<u64, Documents::US34> {
            Func1::new(move |v: u64| Documents::closure73((), v))
        }
        pub fn closure74(unitVar: (), v0_1: std::string::String) -> Documents::US34 {
            Documents::US34::US34_1(v0_1)
        }
        pub fn method158() -> Func1<std::string::String, Documents::US34> {
            Func1::new(move |v: std::string::String| Documents::closure74((), v))
        }
        pub fn method160(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v101: std::string::String = format!("{:#?}", v2);
            let v134: () = {
                Documents::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v101)),
                    (),
                );
                ()
            };
            let v143: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method159(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: std::string::String,
        ) -> string {
            let v11: string = Documents::method160(v8, v9, v10);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure75(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_3) {
                let v7: () = {
                    Documents::closure6((), ());
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
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method159(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method7(v21, v22, v23, v24, v25, v26),
                    Documents::method33(),
                    v0_1,
                    v1_1,
                    v2,
                ))
            };
        }
        pub fn method162(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method161(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: u64,
        ) -> string {
            let v11: string = Documents::method162(v8, v9, v10);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure76(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_1) {
                let v7: () = {
                    Documents::closure6((), ());
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
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method161(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method7(v21, v22, v23, v24, v25, v26),
                    Documents::method61(),
                    v0_1,
                    v1_1,
                    v2,
                ))
            };
        }
        pub fn method155(v0_1: string, v1_1: string) {
            let v3: string = Documents::method156(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v3);
            let v6 = Documents::method65();
            let v18: Result<u64, std::string::String> = v5.map_err(|x| v6(x));
            let v21 = Documents::method157();
            let v22 = Documents::method158();
            let v23: Documents::US34 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v23 {
                Documents::US34::US34_0(v23_0_0) => {
                    let v27: () = {
                        Documents::closure76(v1_1.clone(), v3.clone(), v23_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US34::US34_1(v23_1_0) => {
                    let v70: () = {
                        Documents::closure75(v1_1.clone(), v3.clone(), v23_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ();
            ()
        }
        pub fn method164(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method165(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method166(v0_1: string) -> string {
            v0_1
        }
        pub fn method167(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure79(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v8: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v20: string = Documents::method166(v0_1);
            let v22: &[u8] = v20.as_bytes();
            let v23: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method167(v8);
            let v25: bool = true;
            let mut v23 = v23;
            let v27: bool = true;
            std::io::Write::write_all(&mut *v23, v22).unwrap();
            ()
        }
        pub fn method168(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method169(v0_1: string) -> string {
            v0_1
        }
        pub fn method171(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("result_len")), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("output_path")), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method170(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
            v10: string,
        ) -> string {
            let v11: string = Documents::method171(v8, v9, v10);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.hangul"),
                v11
            ))
        }
        pub fn closure80(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_2) {
                let v7: () = {
                    Documents::closure6((), ());
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
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method170(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method7(v21, v22, v23, v24, v25, v26),
                    Documents::method11(),
                    v1_1,
                    length(v2),
                    v0_1,
                ))
            };
        }
        pub fn method163(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US35 {
            let v7: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v45: Vec<u8> = Documents::method164(v7.unwrap());
            let v47: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v45);
            let v50: std::string::String = v47.unwrap();
            let v86: Array<string> = split(
                fable_library_rust::String_::fromString(v50),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v89: i32 = count_2(v86.clone());
            let v90: Array<string> = new_init(&string(""), v89);
            let v91: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method58(v89, v91.clone()) {
                let v93: i32 = v91.l0.get().clone();
                let v96: string = trim(v86[v93].clone());
                v90.get_mut()[v93 as usize] = v96;
                {
                    let v99: i32 = v93 + 1_i32;
                    v91.l0.set(v99);
                    ()
                }
            }
            {
                let v100: i32 = count_2(v90.clone());
                let v101: Array<string> = new_init(&string(""), v100);
                let v102: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method165(v100, v102.clone()) {
                    let v104: i32 = v102.l0.get().clone();
                    let v105: i32 = v102.l1.get().clone();
                    let v106: string = v90[v104].clone();
                    let v112: i32 = if string("") != v106.clone() {
                        v101.get_mut()[v105 as usize] = v106;
                        v105 + 1_i32
                    } else {
                        v105
                    };
                    let v113: i32 = v104 + 1_i32;
                    v102.l0.set(v113);
                    v102.l1.set(v112);
                    ()
                }
                {
                    let v114: i32 = v102.l1.get().clone();
                    let v115: Array<string> = new_init(&string(""), v114);
                    let v116: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method58(v114, v116.clone()) {
                        let v118: i32 = v116.l0.get().clone();
                        let v119: string = v101[v118].clone();
                        v115.get_mut()[v118 as usize] = v119;
                        {
                            let v120: i32 = v118 + 1_i32;
                            v116.l0.set(v120);
                            ()
                        }
                    }
                    {
                        let _v121: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v115 = v115.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v115 = v115.clone();
                                        move |i: i32| v115[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v115.clone()) - 1_i32),
                                )
                            }
                        }));
                        let v134: string =
                            sprintf!("{}\n\n", join(Documents::method135(), toArray_1(_v121)));
                        let patternInput: (i32, string) = Documents::method82(
                            sprintf!(
                                "{} {}",
                                Documents::method25(
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
                                let v134 = v134.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure79(v134.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v178: i32 = patternInput.0.clone();
                        let v180: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v183: i32 = count_2(v180.clone());
                        let v185: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method168(v100, v185.clone()) {
                            let v187: i32 = v185.l0.get().clone();
                            let matchValue: string = v185.l1.get().clone();
                            let matchValue_1: i32 = v185.l2.get().clone();
                            let v190: i32 = v185.l3.get().clone();
                            let v189: i32 = matchValue_1;
                            let v188: string = matchValue;
                            let patternInput_2: (string, i32, i32) =
                                if v90[v187].clone() == string("") {
                                    (sprintf!("{}\n", v188.clone()), v189 + 1_i32, v190 + 1_i32)
                                } else {
                                    let v196: i32 = v189 - v190;
                                    (
                                        if v196 >= v183 {
                                            v188.clone()
                                        } else {
                                            let v198: string = v180[v196].clone();
                                            if v196 == v183 - 1_i32 {
                                                sprintf!("{}{}", v188.clone(), v198.clone())
                                            } else {
                                                sprintf!("{}{}\n", v188, v198)
                                            }
                                        },
                                        v189 + 1_i32,
                                        v190,
                                    )
                                };
                            let v211: i32 = v187 + 1_i32;
                            v185.l0.set(v211);
                            v185.l1.set(patternInput_2.0.clone());
                            v185.l2.set(patternInput_2.1.clone());
                            v185.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v185.l1.get().clone();
                            let matchValue_4: i32 = v185.l2.get().clone();
                            let matchValue_5: i32 = v185.l3.get().clone();
                            let v212: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v212.clone()).unwrap();
                            ();
                            {
                                let v220: () = {
                                    Documents::closure80(v2, v178, v212.clone(), ());
                                    ()
                                };
                                Documents::US35::US35_0(v178, v212)
                            }
                        }
                    }
                }
            }
        }
        pub fn method173(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method172(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Documents::method173(v8, v9);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.files_fn / error"),
                v10
            ))
        }
        pub fn closure81(v0_1: string, v1_1: i32, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_2) {
                let v6: () = {
                    Documents::closure6((), ());
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
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method172(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method7(v20, v21, v22, v23, v24, v25),
                    Documents::method11(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure78(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US32 {
            let patternInput: (string, string) = Documents::method148(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if Documents::method152(v6.clone()) == false {
                true
            } else {
                Documents::method152(v7.clone()) == false
            } {
                false
            } else {
                let v13: string = Documents::method38(v6.clone());
                let v15: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v13);
                let v18: std::fs::File = v15.unwrap();
                let v31: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
                let v33: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v31);
                let v35: bool = true;
                let mut v33 = v33;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v38: sha2::Sha256 = result;
                    let v40: bool = true;
                    let mut v38 = v38;
                    let v41: usize = 0_i32 as usize;
                    let v45: _ = [0_u8; 1024];
                    let v47: bool = true;
                    loop {
                        // rust.loop;
                        let v49: bool = true;
                        let mut v45 = v45;
                        let v51: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v33, &mut v45);
                        let v63: usize = v51.unwrap();
                        if v63 == v41 {
                            let v70: bool = true;
                            break;
                            ()
                        }
                        {
                            let v72: usize = v45.len();
                            let v73: u8 = v72 as u8;
                            let v76: usize = v63;
                            let v89: &_ = if v76 == v72 {
                                &v45[v41..]
                            } else {
                                &v45[v41..v76]
                            };
                            sha2::Digest::update(&mut v38, v89);
                            {
                                let v92: bool = true;
                            } // rust.loop;
                            let v94: bool = true;
                        } // rust.loop;
                        let v96: bool = true;
                    } // rust.loop;
                    let v98: bool = true;
                    {
                        // rust.loop;
                        let v100: bool = true;
                        {
                            // rust.loop;
                            let v102: &[u8] = &sha2::Digest::finalize(v38);
                            let v104: Vec<u8> = v102.iter().map(|x| *x).collect::<Vec<_>>();
                            let v106: bool = true;
                            let _vec_map: Vec<_> = v104
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v108: u8 = x;
                                    let v110: std::string::String = format!("{:02x}", v108);
                                    let v112: string =
                                        fable_library_rust::String_::fromString(v110);
                                    let v114: bool = true;
                                    v112
                                })
                                .collect::<Vec<_>>();
                            let v116: Vec<string> = _vec_map;
                            let v118: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v116);
                            let _v119: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v118 = v118.clone();
                                move || {
                                    map_1(
                                        Func1::new({
                                            let v118 = v118.clone();
                                            move |i: i32| v118[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v118.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v126: string = Documents::method149();
                            let v132: string = join(
                                if v126.clone() == string("\n") {
                                    Documents::method60(v126.clone())
                                } else {
                                    v126
                                },
                                toArray_1(_v119),
                            );
                            let v136 = Documents::method65();
                            let v139: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v132).map_err(|x| v136(x));
                            let v151 = Documents::method150();
                            let v152 = Documents::method151();
                            let v154: Documents::US33 = match v139 {
                                Ok(x) => v151(x),
                                Err(e) => v152(e),
                            };
                            let v162: string = match &v154 {
                                Documents::US33::US33_0(v154_0_0) => v154_0_0.clone(),
                                Documents::US33::US33_1(v154_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v154_1_0.clone()
                                    ),
                                ),
                            };
                            let v163: string = Documents::method38(v7.clone());
                            let v165: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v163);
                            let v168: std::fs::File = v165.unwrap();
                            let v181: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v168);
                            let v183: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v181);
                            let v185: bool = true;
                            let mut v183 = v183;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v188: sha2::Sha256 = result;
                                let v190: bool = true;
                                let mut v188 = v188;
                                let v191: usize = 0_i32 as usize;
                                let v195: _ = [0_u8; 1024];
                                let v197: bool = true;
                                loop {
                                    // rust.loop;
                                    let v199: bool = true;
                                    let mut v195 = v195;
                                    let v201: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v183, &mut v195);
                                    let v213: usize = v201.unwrap();
                                    if v213 == v191 {
                                        let v220: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v222: usize = v195.len();
                                        let v223: u8 = v222 as u8;
                                        let v226: usize = v213;
                                        let v239: &_ = if v226 == v222 {
                                            &v195[v191..]
                                        } else {
                                            &v195[v191..v226]
                                        };
                                        sha2::Digest::update(&mut v188, v239);
                                        {
                                            let v242: bool = true;
                                        } // rust.loop;
                                        let v244: bool = true;
                                    } // rust.loop;
                                    let v246: bool = true;
                                } // rust.loop;
                                let v248: bool = true;
                                {
                                    // rust.loop;
                                    let v250: bool = true;
                                    {
                                        // rust.loop;
                                        let v252: &[u8] = &sha2::Digest::finalize(v188);
                                        let v254: Vec<u8> =
                                            v252.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v256: bool = true;
                                        let _vec_map: Vec<_> = v254
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v258: u8 = x;
                                                let v260: std::string::String =
                                                    format!("{:02x}", v258);
                                                let v262: string =
                                                    fable_library_rust::String_::fromString(v260);
                                                let v264: bool = true;
                                                v262
                                            })
                                            .collect::<Vec<_>>();
                                        let v266: Vec<string> = _vec_map;
                                        let v268: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v266);
                                        let _v269: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v268 = v268.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v268 = v268.clone();
                                                            move |i_1: i32| v268[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v268.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v276: string = Documents::method149();
                                        let v282: string = join(
                                            if v276.clone() == string("\n") {
                                                Documents::method60(v276.clone())
                                            } else {
                                                v276
                                            },
                                            toArray_1(_v269),
                                        );
                                        let v286 = Documents::method65();
                                        let v289: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v282).map_err(|x| v286(x));
                                        let v301 = Documents::method150();
                                        let v302 = Documents::method151();
                                        let v304: Documents::US33 = match v289 {
                                            Ok(x) => v301(x),
                                            Err(e) => v302(e),
                                        };
                                        v162 == match &v304 {
                                            Documents::US33::US33_0(v304_0_0) => v304_0_0.clone(),
                                            Documents::US33::US33_1(v304_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v304_1_0.clone()
                                                ),
                                            ),
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US32::US32_1
            } else {
                let v316: Documents::US35 = Documents::method163(v2, v3, v6.clone(), v4);
                match &v316 {
                    Documents::US35::US35_0(v316_0_0, v316_0_1) => {
                        let v318: string = v316_0_1.clone();
                        let v317: i32 = v316_0_0.clone();
                        if v317 != 0_i32 {
                            let v324: () = {
                                Documents::closure81(v318.clone(), v317, ());
                                ()
                            };
                            Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v318)),
                            ))
                        } else {
                            if Documents::method152(v6.clone()) {
                                Documents::method155(v7, v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v6.clone()),
                                )
                            }
                            Documents::US32::US32_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US35::US35_1(v316_1_0, v316_1_1) => {
                        Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v316_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure77(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US32> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure78(
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
        pub fn method176(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("output_path")), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method175(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
        ) -> string {
            let v11: string = Documents::method176(v8, v9, v10);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.crowbook / result contains ERROR"),
                v11
            ))
        }
        pub fn closure84(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_3) {
                let v7: () = {
                    Documents::closure6((), ());
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
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method175(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method7(v21, v22, v23, v24, v25, v26),
                    Documents::method33(),
                    v2,
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method174(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US35 {
            let patternInput: (i32, string) = Documents::method82(
                append(
                    sprintf!("crowbook --verbose --to {}", v4.clone()),
                    sprintf!(
                        " --single \"{}\" --output \"{}\" {}",
                        v2,
                        v1_1.clone(),
                        if string("html") == v4.clone() {
                            string("--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
                        } else {
                            if string("pdf") == v4.clone() {
                                append(append(string("--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\""),
                                                                          (if v0_1
                                                                                  ==
                                                                                  false
                                                                              {
                                                                               string("")
                                                                           } else {
                                                                               string(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13")
                                                                           })),
                                                                   string(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""))
                            } else {
                                if string("epub") == v4 {
                                    string("--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
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
            let v75: string = patternInput.1.clone();
            let v74: i32 = patternInput.0.clone();
            if contains(v75.clone(), string("ERROR")) == false {
                Documents::US35::US35_0(v74, v75.clone())
            } else {
                let v84: () = {
                    Documents::closure84(v1_1, v75.clone(), v74, ());
                    ()
                };
                Documents::US35::US35_1(v74, v75)
            }
        }
        pub fn closure83(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (string, string) = Documents::method148(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if Documents::method152(v5.clone()) == false {
                true
            } else {
                Documents::method152(v6.clone()) == false
            } {
                false
            } else {
                let v12: string = Documents::method38(v5.clone());
                let v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
                let v17: std::fs::File = v14.unwrap();
                let v30: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v17);
                let v32: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v30);
                let v34: bool = true;
                let mut v32 = v32;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v37: sha2::Sha256 = result;
                    let v39: bool = true;
                    let mut v37 = v37;
                    let v40: usize = 0_i32 as usize;
                    let v44: _ = [0_u8; 1024];
                    let v46: bool = true;
                    loop {
                        // rust.loop;
                        let v48: bool = true;
                        let mut v44 = v44;
                        let v50: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v32, &mut v44);
                        let v62: usize = v50.unwrap();
                        if v62 == v40 {
                            let v69: bool = true;
                            break;
                            ()
                        }
                        {
                            let v71: usize = v44.len();
                            let v72: u8 = v71 as u8;
                            let v75: usize = v62;
                            let v88: &_ = if v75 == v71 {
                                &v44[v40..]
                            } else {
                                &v44[v40..v75]
                            };
                            sha2::Digest::update(&mut v37, v88);
                            {
                                let v91: bool = true;
                            } // rust.loop;
                            let v93: bool = true;
                        } // rust.loop;
                        let v95: bool = true;
                    } // rust.loop;
                    let v97: bool = true;
                    {
                        // rust.loop;
                        let v99: bool = true;
                        {
                            // rust.loop;
                            let v101: &[u8] = &sha2::Digest::finalize(v37);
                            let v103: Vec<u8> = v101.iter().map(|x| *x).collect::<Vec<_>>();
                            let v105: bool = true;
                            let _vec_map: Vec<_> = v103
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v107: u8 = x;
                                    let v109: std::string::String = format!("{:02x}", v107);
                                    let v111: string =
                                        fable_library_rust::String_::fromString(v109);
                                    let v113: bool = true;
                                    v111
                                })
                                .collect::<Vec<_>>();
                            let v115: Vec<string> = _vec_map;
                            let v117: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v115);
                            let _v118: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v117 = v117.clone();
                                move || {
                                    map_1(
                                        Func1::new({
                                            let v117 = v117.clone();
                                            move |i: i32| v117[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v117.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v125: string = Documents::method149();
                            let v131: string = join(
                                if v125.clone() == string("\n") {
                                    Documents::method60(v125.clone())
                                } else {
                                    v125
                                },
                                toArray_1(_v118),
                            );
                            let v135 = Documents::method65();
                            let v138: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v131).map_err(|x| v135(x));
                            let v150 = Documents::method150();
                            let v151 = Documents::method151();
                            let v153: Documents::US33 = match v138 {
                                Ok(x) => v150(x),
                                Err(e) => v151(e),
                            };
                            let v161: string = match &v153 {
                                Documents::US33::US33_0(v153_0_0) => v153_0_0.clone(),
                                Documents::US33::US33_1(v153_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v153_1_0.clone()
                                    ),
                                ),
                            };
                            let v162: string = Documents::method38(v6.clone());
                            let v164: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v162);
                            let v167: std::fs::File = v164.unwrap();
                            let v180: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v167);
                            let v182: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v180);
                            let v184: bool = true;
                            let mut v182 = v182;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v187: sha2::Sha256 = result;
                                let v189: bool = true;
                                let mut v187 = v187;
                                let v190: usize = 0_i32 as usize;
                                let v194: _ = [0_u8; 1024];
                                let v196: bool = true;
                                loop {
                                    // rust.loop;
                                    let v198: bool = true;
                                    let mut v194 = v194;
                                    let v200: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v182, &mut v194);
                                    let v212: usize = v200.unwrap();
                                    if v212 == v190 {
                                        let v219: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v221: usize = v194.len();
                                        let v222: u8 = v221 as u8;
                                        let v225: usize = v212;
                                        let v238: &_ = if v225 == v221 {
                                            &v194[v190..]
                                        } else {
                                            &v194[v190..v225]
                                        };
                                        sha2::Digest::update(&mut v187, v238);
                                        {
                                            let v241: bool = true;
                                        } // rust.loop;
                                        let v243: bool = true;
                                    } // rust.loop;
                                    let v245: bool = true;
                                } // rust.loop;
                                let v247: bool = true;
                                {
                                    // rust.loop;
                                    let v249: bool = true;
                                    {
                                        // rust.loop;
                                        let v251: &[u8] = &sha2::Digest::finalize(v187);
                                        let v253: Vec<u8> =
                                            v251.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v255: bool = true;
                                        let _vec_map: Vec<_> = v253
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v257: u8 = x;
                                                let v259: std::string::String =
                                                    format!("{:02x}", v257);
                                                let v261: string =
                                                    fable_library_rust::String_::fromString(v259);
                                                let v263: bool = true;
                                                v261
                                            })
                                            .collect::<Vec<_>>();
                                        let v265: Vec<string> = _vec_map;
                                        let v267: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v265);
                                        let _v268: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v267 = v267.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v267 = v267.clone();
                                                            move |i_1: i32| v267[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v267.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v275: string = Documents::method149();
                                        let v281: string = join(
                                            if v275.clone() == string("\n") {
                                                Documents::method60(v275.clone())
                                            } else {
                                                v275
                                            },
                                            toArray_1(_v268),
                                        );
                                        let v285 = Documents::method65();
                                        let v288: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v281).map_err(|x| v285(x));
                                        let v300 = Documents::method150();
                                        let v301 = Documents::method151();
                                        let v303: Documents::US33 = match v288 {
                                            Ok(x) => v300(x),
                                            Err(e) => v301(e),
                                        };
                                        v161 == match &v303 {
                                            Documents::US33::US33_0(v303_0_0) => v303_0_0.clone(),
                                            Documents::US33::US33_1(v303_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v303_1_0.clone()
                                                ),
                                            ),
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US32::US32_1
            } else {
                let v315: Documents::US35 = Documents::method174(v2, v5.clone(), v3, v1_1, v4);
                match &v315 {
                    Documents::US35::US35_0(v315_0_0, v315_0_1) => {
                        let v317: string = v315_0_1.clone();
                        let v316: i32 = v315_0_0.clone();
                        if v316 != 0_i32 {
                            let v323: () = {
                                Documents::closure81(v317.clone(), v316, ());
                                ()
                            };
                            Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v317)),
                            ))
                        } else {
                            if Documents::method152(v5.clone()) {
                                Documents::method155(v6, v5.clone())
                            } else {
                                panic!(
                                    "{}",
                                    sprintf!("documents.files_fn / {} should exist", v5.clone()),
                                )
                            }
                            Documents::US32::US32_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US35::US35_1(v315_1_0, v315_1_1) => {
                        Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v315_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure82(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US32> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure83(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method178(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("output_path")), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string("output_cache_path")), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method177(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Documents::method178(v8, v9);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / par_map / files\' = [] / listm.iter"),
                v10
            ))
        }
        pub fn closure85(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_2) {
                let v6: () = {
                    Documents::closure6((), ());
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
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method177(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method7(v20, v21, v22, v23, v24, v25),
                    Documents::method11(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method179(
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
                    Documents::method179(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method180(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method181(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US32>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US32>>,
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
                    Documents::method181(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure86(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US32>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US32 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US32::US32_0(v4_0_0) => Some(match &v4 {
                    Documents::US32::US32_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method182(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method183(
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
            let v6: string = Documents::method37(v5);
            let v9: &str = &*v6.clone();
            let v33: std::string::String = String::from(v9);
            let v57: std::path::PathBuf = std::path::PathBuf::from(v33);
            let v81: std::path::Display = v57.display();
            let v105: std::string::String = format!("{}", v81);
            let v134: string = sprintf!(
                ".{}",
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v105),
                        v3.clone(),
                        Documents::method80()
                    ),
                    string("\\"),
                    string("/")
                )
            );
            let v135: string = Documents::method38(v6);
            let v137: string = Documents::method81(Documents::method25(v2.clone(), v134.clone()));
            let patternInput: (i32, string) = Documents::method82(
                sprintf!(
                    "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                    v137.clone()
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v149: string = patternInput.1.clone();
            let v148: i32 = patternInput.0.clone();
            let v151: string = Documents::method81(Documents::method25(v3.clone(), v134.clone()));
            let patternInput_1: (i32, string) = Documents::method82(
                sprintf!("git hash-object \"{}\"", v151.clone()),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v163: string = patternInput_1.1.clone();
            let v162: i32 = patternInput_1.0.clone();
            let v165: string = Documents::method81(Documents::method25(v4.clone(), v134.clone()));
            let v167: string =
                (Documents::method148(string("hangul.md"), v151.clone(), v4.clone()))
                    .0
                    .clone();
            let v630: LrcPtr<Documents::UH4> = if contains(v149.clone(), v163.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v179: string = Documents::method38(v151.clone());
                let v181: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v179);
                let v184: std::fs::File = v181.unwrap();
                let v197: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v184);
                let v199: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v197);
                let v201: bool = true;
                let mut v199 = v199;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v204: sha2::Sha256 = result;
                    let v206: bool = true;
                    let mut v204 = v204;
                    let v207: usize = 0_i32 as usize;
                    let v211: _ = [0_u8; 1024];
                    let v213: bool = true;
                    loop {
                        // rust.loop;
                        let v215: bool = true;
                        let mut v211 = v211;
                        let v217: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v199, &mut v211);
                        let v229: usize = v217.unwrap();
                        if v229 == v207 {
                            let v236: bool = true;
                            break;
                            ()
                        }
                        {
                            let v238: usize = v211.len();
                            let v239: u8 = v238 as u8;
                            let v242: usize = v229;
                            let v255: &_ = if v242 == v238 {
                                &v211[v207..]
                            } else {
                                &v211[v207..v242]
                            };
                            sha2::Digest::update(&mut v204, v255);
                            {
                                let v258: bool = true;
                            } // rust.loop;
                            let v260: bool = true;
                        } // rust.loop;
                        let v262: bool = true;
                    } // rust.loop;
                    let v264: bool = true;
                    {
                        // rust.loop;
                        let v266: bool = true;
                        {
                            // rust.loop;
                            let v268: &[u8] = &sha2::Digest::finalize(v204);
                            let v270: Vec<u8> = v268.iter().map(|x| *x).collect::<Vec<_>>();
                            let v272: bool = true;
                            let _vec_map: Vec<_> = v270
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v274: u8 = x;
                                    let v276: std::string::String = format!("{:02x}", v274);
                                    let v278: string =
                                        fable_library_rust::String_::fromString(v276);
                                    let v280: bool = true;
                                    v278
                                })
                                .collect::<Vec<_>>();
                            let v282: Vec<string> = _vec_map;
                            let v284: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v282);
                            let _v285: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v284 = v284.clone();
                                move || {
                                    map_1(
                                        Func1::new({
                                            let v284 = v284.clone();
                                            move |i: i32| v284[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v284.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v292: string = Documents::method149();
                            let v298: string = join(
                                if v292.clone() == string("\n") {
                                    Documents::method60(v292.clone())
                                } else {
                                    v292
                                },
                                toArray_1(_v285),
                            );
                            let v302 = Documents::method65();
                            let v305: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v298).map_err(|x| v302(x));
                            let v317 = Documents::method150();
                            let v318 = Documents::method151();
                            let v320: Documents::US33 = match v305 {
                                Ok(x) => v317(x),
                                Err(e) => v318(e),
                            };
                            let v328: string = match &v320 {
                                Documents::US33::US33_0(v320_0_0) => v320_0_0.clone(),
                                Documents::US33::US33_1(v320_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v320_1_0.clone()
                                    ),
                                ),
                            };
                            let v480: Documents::US5 = if Documents::method152(v165.clone())
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v332: string = Documents::method38(v165.clone());
                                let v334: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v332);
                                let v337: std::fs::File = v334.unwrap();
                                let v350: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v337);
                                let v352: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v350);
                                let v354: bool = true;
                                let mut v352 = v352;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v357: sha2::Sha256 = result;
                                    let v359: bool = true;
                                    let mut v357 = v357;
                                    let v360: usize = 0_i32 as usize;
                                    let v364: _ = [0_u8; 1024];
                                    let v366: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v368: bool = true;
                                        let mut v364 = v364;
                                        let v370: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v352, &mut v364);
                                        let v382: usize = v370.unwrap();
                                        if v382 == v360 {
                                            let v389: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v391: usize = v364.len();
                                            let v392: u8 = v391 as u8;
                                            let v395: usize = v382;
                                            let v408: &_ = if v395 == v391 {
                                                &v364[v360..]
                                            } else {
                                                &v364[v360..v395]
                                            };
                                            sha2::Digest::update(&mut v357, v408);
                                            {
                                                let v411: bool = true;
                                            } // rust.loop;
                                            let v413: bool = true;
                                        } // rust.loop;
                                        let v415: bool = true;
                                    } // rust.loop;
                                    let v417: bool = true;
                                    {
                                        // rust.loop;
                                        let v419: bool = true;
                                        {
                                            // rust.loop;
                                            let v421: &[u8] = &sha2::Digest::finalize(v357);
                                            let v423: Vec<u8> =
                                                v421.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v425: bool = true;
                                            let _vec_map: Vec<_> = v423
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v427: u8 = x;
                                                    let v429: std::string::String =
                                                        format!("{:02x}", v427);
                                                    let v431: string =
                                                        fable_library_rust::String_::fromString(
                                                            v429,
                                                        );
                                                    let v433: bool = true;
                                                    v431
                                                })
                                                .collect::<Vec<_>>();
                                            let v435: Vec<string> = _vec_map;
                                            let v437: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(v435);
                                            let _v438: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v437 = v437.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v437 = v437.clone();
                                                                move |i_1: i32| v437[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count_2(v437.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v445: string = Documents::method149();
                                            let v451: string = join(
                                                if v445.clone() == string("\n") {
                                                    Documents::method60(v445.clone())
                                                } else {
                                                    v445
                                                },
                                                toArray_1(_v438),
                                            );
                                            let v455 = Documents::method65();
                                            let v458: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v451)
                                                    .map_err(|x| v455(x));
                                            let v470 = Documents::method150();
                                            let v471 = Documents::method151();
                                            let v473: Documents::US33 = match v458 {
                                                Ok(x) => v470(x),
                                                Err(e) => v471(e),
                                            };
                                            match &v473 {
                                                Documents::US33::US33_0(v473_0_0) => {
                                                    Documents::US5::US5_0(v473_0_0.clone())
                                                }
                                                _ => Documents::US5::US5_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US5::US5_0(v480_0_0) = &v480 {
                                if v328.clone()
                                    == match &v480 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v486: () = {
                                        Documents::closure72(
                                            v134.clone(),
                                            v135.clone(),
                                            v137.clone(),
                                            v149.clone(),
                                            v148,
                                            v151.clone(),
                                            v163.clone(),
                                            v162,
                                            v165.clone(),
                                            v328.clone(),
                                            v480.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method155(v165.clone(), v151.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v151.clone(),
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
                                                            Documents::closure77(
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
                                                v151.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure82(
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
                                                    v151.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure82(
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
                                                        v151.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure82(
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
                                                            v167.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure82(
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
                                                                v167.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure82(
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
                                                                    v167.clone(),
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
                                                                                                                                                                                                                                                                                                                                                               Documents::closure82(v4.clone(),
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
                                }
                            } else {
                                let v559: () = {
                                    Documents::closure72(
                                        v134,
                                        v135.clone(),
                                        v137,
                                        v149,
                                        v148,
                                        v151.clone(),
                                        v163,
                                        v162,
                                        v165.clone(),
                                        v328,
                                        v480,
                                        (),
                                    );
                                    ()
                                };
                                Documents::method155(v165, v151.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v151.clone(),
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
                                                    move |v_7: string| {
                                                        Documents::closure77(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            v1_1.clone(),
                                                            v0_1.clone(),
                                                            v_7,
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
                                            v151.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_8: string| {
                                                            Documents::closure82(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                false,
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
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("pdf"),
                                                v151.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_9: string| {
                                                                Documents::closure82(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
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
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("epub"),
                                                    v151.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_10: string| {
                                                                    Documents::closure82(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
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
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("html"),
                                                        v167.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_11: string| {
                                                                        Documents::closure82(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            true,
                                                                            v_11,
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
                                                            v167.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_12: string| {
                                                                            Documents::closure82(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_12,
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
                                                                v167.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_13: string| {
                                                                                Documents::closure82(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_13,
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
                            }
                        }
                    }
                }
            };
            let v1011: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method179(
                if (if let Documents::UH4::UH4_0 = v630.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v630
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method148(string("epub"), v167.clone(), v4.clone());
                    let v635: string = patternInput_3.1.clone();
                    let v634: string = patternInput_3.0.clone();
                    let v687: LrcPtr<Documents::UH5> = if if Documents::method152(v634.clone()) {
                        true
                    } else {
                        if Documents::method152(v635.clone()) == false {
                            true
                        } else {
                            let v641: () = {
                                Documents::closure85(v635.clone(), v634.clone(), ());
                                ()
                            };
                            Documents::method155(v634, v635);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v167.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_14: string| {
                                            Documents::closure82(v4.clone(), v3.clone(), true, v_14)
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
                        Documents::method148(string("pdf"), v167.clone(), v4.clone());
                    let v690: string = patternInput_4.1.clone();
                    let v689: string = patternInput_4.0.clone();
                    let v740: LrcPtr<Documents::UH5> = if if Documents::method152(v689.clone()) {
                        true
                    } else {
                        if Documents::method152(v690.clone()) == false {
                            true
                        } else {
                            let v696: () = {
                                Documents::closure85(v690.clone(), v689.clone(), ());
                                ()
                            };
                            Documents::method155(v689, v690);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v167.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_15: string| {
                                            Documents::closure82(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v687.clone(),
                        ))
                    } else {
                        v687
                    };
                    let patternInput_5: (string, string) =
                        Documents::method148(string("html"), v167.clone(), v4.clone());
                    let v743: string = patternInput_5.1.clone();
                    let v742: string = patternInput_5.0.clone();
                    let v793: LrcPtr<Documents::UH5> = if if Documents::method152(v742.clone()) {
                        true
                    } else {
                        if Documents::method152(v743.clone()) == false {
                            true
                        } else {
                            let v749: () = {
                                Documents::closure85(v743.clone(), v742.clone(), ());
                                ()
                            };
                            Documents::method155(v742, v743);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v167,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_16: string| {
                                            Documents::closure82(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v740.clone(),
                        ))
                    } else {
                        v740
                    };
                    let patternInput_6: (string, string) =
                        Documents::method148(string("epub"), v151.clone(), v4.clone());
                    let v795: string = patternInput_6.1.clone();
                    let v794: string = patternInput_6.0.clone();
                    let v845: LrcPtr<Documents::UH5> = if if Documents::method152(v794.clone()) {
                        true
                    } else {
                        if Documents::method152(v795.clone()) == false {
                            true
                        } else {
                            let v801: () = {
                                Documents::closure85(v795.clone(), v794.clone(), ());
                                ()
                            };
                            Documents::method155(v794, v795);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v151.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_17: string| {
                                            Documents::closure82(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v793.clone(),
                        ))
                    } else {
                        v793
                    };
                    let patternInput_7: (string, string) =
                        Documents::method148(string("pdf"), v151.clone(), v4.clone());
                    let v847: string = patternInput_7.1.clone();
                    let v846: string = patternInput_7.0.clone();
                    let v897: LrcPtr<Documents::UH5> = if if Documents::method152(v846.clone()) {
                        true
                    } else {
                        if Documents::method152(v847.clone()) == false {
                            true
                        } else {
                            let v853: () = {
                                Documents::closure85(v847.clone(), v846.clone(), ());
                                ()
                            };
                            Documents::method155(v846, v847);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v151.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_18: string| {
                                            Documents::closure82(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v845.clone(),
                        ))
                    } else {
                        v845
                    };
                    let patternInput_8: (string, string) =
                        Documents::method148(string("html"), v151.clone(), v4.clone());
                    let v899: string = patternInput_8.1.clone();
                    let v898: string = patternInput_8.0.clone();
                    let v949: LrcPtr<Documents::UH5> = if if Documents::method152(v898.clone()) {
                        true
                    } else {
                        if Documents::method152(v899.clone()) == false {
                            true
                        } else {
                            let v905: () = {
                                Documents::closure85(v899.clone(), v898.clone(), ());
                                ()
                            };
                            Documents::method155(v898, v899);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v151.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_19: string| {
                                            Documents::closure82(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v897.clone(),
                        ))
                    } else {
                        v897
                    };
                    let patternInput_9: (string, string) =
                        Documents::method148(string("hangul.md"), v151.clone(), v4.clone());
                    let v951: string = patternInput_9.1.clone();
                    let v950: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method152(v950.clone()) {
                            true
                        } else {
                            if Documents::method152(v951.clone()) == false {
                                true
                            } else {
                                let v957: () = {
                                    Documents::closure85(v951.clone(), v950.clone(), ());
                                    ()
                                };
                                Documents::method155(v950, v951);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v151,
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
                                            move |v_20: string| {
                                                Documents::closure77(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    v1_1.clone(),
                                                    v0_1.clone(),
                                                    v_20,
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
                            v949,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v1015: Vec<LrcPtr<Documents::UH5>> = v1011.to_vec();
            let v1018: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v1020: Array<LrcPtr<Documents::UH5>> =
                fable_library_rust::NativeArray_::array_from(v1015);
            let v1021: i32 = count_2(v1020.clone());
            let v1022: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(v1018),
            });
            while Documents::method180(v1021, v1022.clone()) {
                let v1024: i32 = v1022.l0.get().clone();
                let v1025: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    v1022.l1.get().clone();
                let v1030 = toArray(Documents::method181(
                    v1020[v1024].clone(),
                    empty::<(
                        string,
                        string,
                        Func1<string, Func1<string, Documents::US32>>,
                    )>(),
                ));
                let v1034 = v1030.to_vec();
                let v1036 = rayon::iter::IntoParallelIterator::into_par_iter(v1034);
                let v1039 = rayon::iter::ParallelIterator::map(v1036, |x| {
                    Func1::new(
                        move |arg10_0040_9: (
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US32>>,
                        )| Documents::closure86((), arg10_0040_9),
                    )(x)
                });
                let v1042: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method182(rayon::iter::ParallelIterator::collect(v1039));
                let v1043: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method183(v1025);
                let v1045: bool = true;
                let mut v1043 = v1043;
                let v1047: bool = true;
                v1043.extend(v1042);
                let v1049: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v1043;
                let v1050: i32 = v1024 + 1_i32;
                v1022.l0.set(v1050);
                v1022.l1.set(v1049);
                ()
            }
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((v135, v1022.l1.get().clone())))
        }
        pub fn method184(
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
        pub fn method24(
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
            let v8: Documents::US7 = Documents::method28(
                Documents::method25(string("polyglot"), string(".devcontainer")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v56: Documents::US5 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US5::US5_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure14(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            let v111: Documents::US5 = match &v56 {
                Documents::US5::US5_0(v56_0_0) => Documents::US5::US5_0(match &v56 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v59: string = Documents::method36();
                    let v61: Documents::US7 = Documents::method28(
                        Documents::method25(string("polyglot"), string(".devcontainer")),
                        v59,
                    );
                    match &v61 {
                        Documents::US7::US7_0(v61_0_0) => Documents::US5::US5_0(v61_0_0.clone()),
                        Documents::US7::US7_1(v61_1_0) => {
                            let v67: () = {
                                Documents::closure14(v61_1_0.clone(), ());
                                ()
                            };
                            Documents::US5::US5_1
                        }
                    }
                }
            };
            let v116: string = Documents::method25(
                match &v111 {
                    Documents::US5::US5_0(v111_0_0) => match &v111 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v117: string = Documents::method37(v3);
            let v118: string = Documents::method37(v2);
            let v119: string = Documents::method37(v1_1);
            let v122: () = {
                Documents::closure23(v0_1.clone(), v117.clone(), v118.clone(), v119.clone(), ());
                ()
            };
            let v163: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v165: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v118.clone());
                let v168: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v165, move |x| {
                    Func1::new(move |v: async_walkdir::DirEntry| Documents::closure24((), v))(x)
                });
                let v169 = Documents::method71();
                let v171 = futures::stream::StreamExt::filter_map(v168, |x| async { v169(x) });
                let v173: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                    Box::pin(futures::stream::StreamExt::collect(v171));
                let v175: Vec<string> = v173.await;
                let v178: () = {
                    Documents::closure33(v175.clone(), ());
                    ()
                };
                let v221: rayon::vec::IntoIter<string> =
                    rayon::iter::IntoParallelIterator::into_par_iter(v175);
                let v224: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                    rayon::iter::ParallelIterator::map(v221, |x| {
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            let v116 = v116.clone();
                            let v117 = v117.clone();
                            let v118 = v118.clone();
                            let v119 = v119.clone();
                            move |v_1: string| {
                                Documents::closure34(
                                    v0_1.clone(),
                                    v116.clone(),
                                    v117.clone(),
                                    v118.clone(),
                                    v119.clone(),
                                    v_1,
                                )
                            }
                        })(x)
                    });
                let v228: Result<
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
                > = Documents::method184(Ok::<
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
                >(rayon::iter::ParallelIterator::collect(
                    v224,
                )));
                let v231: string = string("}");
                let v235: bool = true;
                let v232 = v228;
                let v247: string = append(
                    append(
                        append(append(string("true; v232 "), v231), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v248: bool = true;
                v232
            }); // rust.fix_closure';
            let v250 = __future_init;
            v250
        }
        pub fn closure87(
            unitVar: (),
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
        ) -> Documents::US36 {
            Documents::US36::US36_0(v0_1)
        }
        pub fn method185() -> Func1<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            Documents::US36,
        > {
            Func1::new(
                move |v: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >| Documents::closure87((), v),
            )
        }
        pub fn closure88(unitVar: (), v0_1: std::string::String) -> Documents::US36 {
            Documents::US36::US36_1(v0_1)
        }
        pub fn method186() -> Func1<std::string::String, Documents::US36> {
            Func1::new(move |v: std::string::String| Documents::closure88((), v))
        }
        pub fn method187(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method77(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure89(v0_1: std::string::String, unitVar: ()) {
            if Documents::method6(Documents::US0::US0_4) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method187(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method75(),
                    v0_1,
                ))
            };
        }
        pub fn method189(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("result_len")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method188(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v9: string = Documents::method189(v8);
            Documents::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure90(
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
            if Documents::method6(Documents::US0::US0_2) {
                let v5: () = {
                    Documents::closure6((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method18(Documents::method188(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method7(v19, v20, v21, v22, v23, v24),
                    Documents::method11(),
                    v0_1.len(),
                ))
            };
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Documents::closure2((), ());
                ()
            };
            let v19: () = {
                Documents::closure5(v0_1, ());
                ()
            };
            let v59: clap::Command = Documents::method0();
            let v61: clap::ArgMatches = clap::Command::get_matches(v59);
            let v62: string = Documents::method19();
            let v65: &str = &*v62;
            let v88: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v65).cloned();
            let v102: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method20(), v88));
            let v109: std::string::String = match &v102 {
                Documents::US6::US6_0(v102_0_0) => match &v102 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v111: string = fable_library_rust::String_::fromString(v109);
            let v112: string = Documents::method21();
            let v115: &str = &*v112;
            let v138: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v115).cloned();
            let v152: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method20(), v138));
            let v159: std::string::String = match &v152 {
                Documents::US6::US6_0(v152_0_0) => match &v152 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v161: string = fable_library_rust::String_::fromString(v159);
            let v162: string = Documents::method22();
            let v165: &str = &*v162;
            let v188: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v165).cloned();
            let v202: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method20(), v188));
            let v209: std::string::String = match &v202 {
                Documents::US6::US6_0(v202_0_0) => match &v202 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v211: string = fable_library_rust::String_::fromString(v209);
            let v212: string = Documents::method23();
            let v215: &str = &*v212;
            let v238: Option<std::string::String> = clap::ArgMatches::get_one(&v61, v215).cloned();
            let v252: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method20(), v238));
            let v259: std::string::String = match &v252 {
                Documents::US6::US6_0(v252_0_0) => match &v252 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v262: std::pin::Pin<
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
            > = Documents::method24(
                fable_library_rust::String_::fromString(v259),
                v211,
                v161,
                v111,
            );
            let v264: Result<
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
            > = futures::executor::block_on(v262);
            let v265 = Documents::method185();
            let v266 = Documents::method186();
            let v267: Documents::US36 = match &v264 {
                Err(v264_1_0) => v266(v264_1_0.clone()),
                Ok(v264_0_0) => v265(v264_0_0.clone()),
            };
            match &v267 {
                Documents::US36::US36_0(v267_0_0) => {
                    let v271: () = {
                        Documents::closure90(v267_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US36::US36_1(v267_1_0) => {
                    let v316: () = {
                        Documents::closure89(v267_1_0.clone(), ());
                        ()
                    };
                    1_i32
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