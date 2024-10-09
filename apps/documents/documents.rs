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
            US13_0(string, Documents::US1),
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
                Documents::US1,
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
            US20_0(Documents::US1, string, LrcPtr<StringBuilder>, i32, i32),
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
        pub fn method2() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US1 {
            Documents::US1::US1_0(v0_1)
        }
        pub fn method5() -> Func1<string, Documents::US1> {
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
        pub fn method6() -> string {
            string("AUTOMATION")
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
                if Documents::method3(Documents::method6()) == string("True") {
                    Documents::US3::US3_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Documents::US3::US3_1
                },
            );
            let v352: Documents::US3 = _v1.1.clone();
            let v351: Documents::US2 = _v1.0.clone();
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
                    l0: MutCell::new(match &v351 {
                        Documents::US2::US2_0(v351_0_0) => match &v351 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v352 {
                    Documents::US3::US3_0(v352_0_0) => Some(match &v352 {
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
        pub fn method7(v0_1: Documents::US0) -> bool {
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
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US3 {
            Documents::US3::US3_0(v0_1)
        }
        pub fn method9() -> Func1<i64, Documents::US3> {
            Func1::new(move |v: i64| Documents::closure7((), v))
        }
        pub fn method10() -> string {
            string("hh:mm:ss")
        }
        pub fn method11() -> string {
            string("HH:mm:ss")
        }
        pub fn method8(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v20: Documents::US3 =
                defaultValue(Documents::US3::US3_1, map(Documents::method9(), v5));
            let v60: DateTime = match &v20 {
                Documents::US3::US3_0(v20_0_0) => {
                    let v34: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v20 {
                            Documents::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v34.hours(),
                        v34.minutes(),
                        v34.seconds(),
                        v34.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let provider: string = Documents::method10();
            v60.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method13(v0_1: char) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v8: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method15() -> string {
            string("\u{001b}[0m")
        }
        pub fn method12() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Info")), 0_i32));
            let v9: &str = inline_colorization::color_bright_green;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method18(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method16(
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
            let v9: string = Documents::method17(v8);
            Documents::method18(sprintf!(
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
        pub fn method19(v0_1: string) {
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
            if Documents::method7(Documents::US0::US0_2) {
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
                Documents::method19(Documents::method16(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method12(),
                    v0_1,
                ))
            };
        }
        pub fn method20() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US4 {
            Documents::US4::US4_0(v0_1)
        }
        pub fn method21() -> Func1<std::string::String, Documents::US4> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method22() -> string {
            string("dist-dir")
        }
        pub fn method23() -> string {
            string("cache-dir")
        }
        pub fn method24() -> string {
            string("hangul-spec")
        }
        pub fn method28(v0_1: string) -> string {
            v0_1
        }
        pub fn method27(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Documents::method28(v0_1))
        }
        pub fn method26(v0_1: string, v1_1: string) -> string {
            let v5: &str = &*v0_1;
            let v26: std::string::String = String::from(v5);
            let v47: std::path::PathBuf = std::path::PathBuf::from(v26);
            let v68: &str = &*v1_1;
            let v89: std::string::String = String::from(v68);
            let v109: std::path::PathBuf = v47.join(v89);
            let v112: std::path::Display = v109.display();
            let v133: std::string::String = format!("{}", v112);
            fable_library_rust::String_::fromString(v133)
        }
        pub fn method30(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v25: std::string::String = String::from(v4);
            let v60: std::path::PathBuf = std::path::PathBuf::from(v25);
            if v60.clone().exists() {
                v60.is_dir()
            } else {
                false
            }
        }
        pub fn method33(v0_1: string) -> string {
            let v4: &str = &*v0_1;
            let v25: std::string::String = String::from(v4);
            let v46: std::path::PathBuf = std::path::PathBuf::from(v25);
            let v66: Option<std::path::PathBuf> = v46.parent().map(std::path::PathBuf::from);
            let v68: bool = true;
            let _optionm_map_ = v66.map(|x| {
                //;
                let v70: std::path::PathBuf = x;
                let v73: std::path::Display = v70.display();
                let v94: std::string::String = format!("{}", v73);
                let v114: string = fable_library_rust::String_::fromString(v94);
                let v116: bool = true;
                v114
            });
            defaultValue(string(""), _optionm_map_)
        }
        pub fn method32(v0_1: string) -> Option<string> {
            let v51: Documents::US1 = Documents::US1::US1_0(Documents::method33(v0_1));
            match &v51 {
                Documents::US1::US1_0(v51_0_0) => Some(match &v51 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn closure13(unitVar: (), v0_1: string) -> Option<string> {
            Documents::method32(v0_1)
        }
        pub fn method31() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure13((), v))
        }
        pub fn method34(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method34: loop {
                break '_method34 (if Documents::method30(Documents::method26(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Documents::method31())(v2.get().clone());
                    let v21: Documents::US1 =
                        defaultValue(Documents::US1::US1_1, map(Documents::method5(), v7));
                    match &v21 {
                        Documents::US1::US1_0(v21_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v21 {
                                Documents::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method34;
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
        pub fn method29(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method30(Documents::method26(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Documents::method31())(v1_1.clone());
                let v20: Documents::US1 =
                    defaultValue(Documents::US1::US1_1, map(Documents::method5(), v6));
                match &v20 {
                    Documents::US1::US1_0(v20_0_0) => Documents::method34(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v20 {
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
        pub fn method35() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method37(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method36(
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
            let v9: string = Documents::method37(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v9
            ))
        }
        pub fn closure14(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
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
                Documents::method19(Documents::method36(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method35(),
                    v0_1,
                ))
            };
        }
        pub fn method38() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v5: std::path::PathBuf = v2.unwrap();
            let v18: std::path::Display = v5.display();
            let v39: std::string::String = format!("{}", v18);
            fable_library_rust::String_::fromString(v39)
        }
        pub fn method42(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v5: std::string::String = format!("{:#?}", v0_1);
            let v35: () = {
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
        pub fn closure17(unitVar: (), v0_1: string) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method43(v0_1: string) -> string {
            let v4: &str = &*v0_1;
            let v25: std::string::String = String::from(v4);
            let v46: std::path::PathBuf = std::path::PathBuf::from(v25);
            let v66: Option<&std::ffi::OsStr> = v46.file_name();
            let v68: bool = true;
            let _optionm_map_ = v66.map(|x| {
                //;
                let v70: &std::ffi::OsStr = x;
                let v72: std::ffi::OsString = v70.to_os_string();
                let v74: Option<&str> = v72.to_str();
                let v76: &str = v74.unwrap();
                let v79: std::string::String = String::from(v76);
                let v99: string = fable_library_rust::String_::fromString(v79);
                let v101: bool = true;
                v99
            });
            let v103: Option<string> = _optionm_map_;
            let v117: Documents::US1 =
                defaultValue(Documents::US1::US1_1, map(Documents::method5(), v103));
            match &v117 {
                Documents::US1::US1_0(v117_0_0) => match &v117 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            }
        }
        pub fn closure18(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method44() -> Func1<std::path::PathBuf, Documents::US9> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure18((), v))
        }
        pub fn method45(v0_1: string) -> string {
            v0_1
        }
        pub fn method40(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v2950: Result<std::path::PathBuf, std::io::Error> = if Documents::method30(
                    v0_1.clone(),
                ) {
                    std::fs::read_link(&*v0_1.clone())
                } else {
                    let v8: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v0_1.clone());
                    let v9 = Documents::method41();
                    let v20: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
                    fn v23(v: std::path::PathBuf) -> Documents::US8 {
                        Documents::closure16((), v)
                    }
                    fn v24(v_1: string) -> Documents::US8 {
                        Documents::closure17((), v_1)
                    }
                    let v25: Documents::US8 = match &v20 {
                        Err(v20_1_0) => v24(v20_1_0.clone()),
                        Ok(v20_0_0) => v23(v20_0_0.clone()),
                    };
                    match &v25 {
                        Documents::US8::US8_0(v25_0_0) => Ok(v25_0_0.clone()),
                        Documents::US8::US8_1(v25_1_0) => {
                            let v40: string = v25_1_0.clone();
                            let v41: string = Documents::method43(v0_1.clone());
                            let v42: Option<string> = Documents::method32(v0_1.clone());
                            let v56: Documents::US1 =
                                defaultValue(Documents::US1::US1_1, map(Documents::method5(), v42));
                            if let Documents::US1::US1_0(v56_0_0) = &v56 {
                                let v60: string = match &v56 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v0_1.clone() != string("") {
                                    let v66: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v60.clone());
                                    let v67 = Documents::method41();
                                    let v78: Result<std::path::PathBuf, string> =
                                        v66.map_err(|x| v67(x));
                                    let v81: Documents::US8 = match &v78 {
                                        Err(v78_1_0) => v24(v78_1_0.clone()),
                                        Ok(v78_0_0) => v23(v78_0_0.clone()),
                                    };
                                    let v2744: Result<std::path::PathBuf, std::io::Error> =
                                        match &v81 {
                                            Documents::US8::US8_0(v81_0_0) => Ok(v81_0_0.clone()),
                                            Documents::US8::US8_1(v81_1_0) => {
                                                let v96: string = v81_1_0.clone();
                                                let v97: string = Documents::method43(v60.clone());
                                                let v98: Option<string> =
                                                    Documents::method32(v60.clone());
                                                let v112: Documents::US1 = defaultValue(
                                                    Documents::US1::US1_1,
                                                    map(Documents::method5(), v98),
                                                );
                                                if let Documents::US1::US1_0(v112_0_0) = &v112 {
                                                    let v116: string = match &v112 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v60.clone() != string("") {
                                                        let v121: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v116.clone());
                                                        let v122 = Documents::method41();
                                                        let v133: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v121.map_err(|x| v122(x));
                                                        let v136: Documents::US8 = match &v133 {
                                                            Err(v133_1_0) => v24(v133_1_0.clone()),
                                                            Ok(v133_0_0) => v23(v133_0_0.clone()),
                                                        };
                                                        let v2539: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v136 {
                                                            Documents::US8::US8_0(v136_0_0) => {
                                                                Ok(v136_0_0.clone())
                                                            }
                                                            Documents::US8::US8_1(v136_1_0) => {
                                                                let v151: string = v136_1_0.clone();
                                                                let v152: string =
                                                                    Documents::method43(
                                                                        v116.clone(),
                                                                    );
                                                                let v153: Option<string> =
                                                                    Documents::method32(
                                                                        v116.clone(),
                                                                    );
                                                                let v167: Documents::US1 =
                                                                    defaultValue(
                                                                        Documents::US1::US1_1,
                                                                        map(
                                                                            Documents::method5(),
                                                                            v153,
                                                                        ),
                                                                    );
                                                                if let Documents::US1::US1_0(
                                                                    v167_0_0,
                                                                ) = &v167
                                                                {
                                                                    let v171: string = match &v167 {
                                                                        Documents::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v116.clone() != string("") {
                                                                        let v176: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v171.clone(),
                                                                        );
                                                                        let v177 =
                                                                            Documents::method41();
                                                                        let v188: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v176
                                                                            .map_err(|x| v177(x));
                                                                        let v191: Documents::US8 =
                                                                            match &v188 {
                                                                                Err(v188_1_0) => {
                                                                                    v24(v188_1_0
                                                                                        .clone())
                                                                                }
                                                                                Ok(v188_0_0) => {
                                                                                    v23(v188_0_0
                                                                                        .clone())
                                                                                }
                                                                            };
                                                                        let v2334:
                                                                                        Result<std::path::PathBuf,
                                                                                               std::io::Error> =
                                                                                    match &v191
                                                                                        {
                                                                                        Documents::US8::US8_0(v191_0_0)
                                                                                        =>
                                                                                        Ok(v191_0_0.clone()),
                                                                                        Documents::US8::US8_1(v191_1_0)
                                                                                        =>
                                                                                        {
                                                                                            let v206:
                                                                                                    string =
                                                                                                v191_1_0.clone();
                                                                                            let v207:
                                                                                                    string =
                                                                                                Documents::method43(v171.clone());
                                                                                            let v208:
                                                                                                    Option<string> =
                                                                                                Documents::method32(v171.clone());
                                                                                            let v222:
                                                                                                    Documents::US1 =
                                                                                                defaultValue(Documents::US1::US1_1,
                                                                                                             map(Documents::method5(),
                                                                                                                 v208));
                                                                                            if let Documents::US1::US1_0(v222_0_0)
                                                                                                   =
                                                                                                   &v222
                                                                                               {
                                                                                                let v226:
                                                                                                        string =
                                                                                                    match &v222
                                                                                                        {
                                                                                                        Documents::US1::US1_0(x)
                                                                                                        =>
                                                                                                        x.clone(),
                                                                                                        _
                                                                                                        =>
                                                                                                        unreachable!(),
                                                                                                    };
                                                                                                if v171.clone()
                                                                                                       !=
                                                                                                       string("")
                                                                                                   {
                                                                                                    let v231:
                                                                                                            Result<std::path::PathBuf,
                                                                                                                   std::io::Error> =
                                                                                                        std::fs::read_link(&*v226.clone());
                                                                                                    let v232 =
                                                                                                        Documents::method41();
                                                                                                    let v243:
                                                                                                            Result<std::path::PathBuf,
                                                                                                                   string> =
                                                                                                        v231.map_err(|x| v232(x));
                                                                                                    let v246:
                                                                                                            Documents::US8 =
                                                                                                        match &v243
                                                                                                            {
                                                                                                            Err(v243_1_0)
                                                                                                            =>
                                                                                                            v24(v243_1_0.clone()),
                                                                                                            Ok(v243_0_0)
                                                                                                            =>
                                                                                                            v23(v243_0_0.clone()),
                                                                                                        };
                                                                                                    let v2129:
                                                                                                            Result<std::path::PathBuf,
                                                                                                                   std::io::Error> =
                                                                                                        match &v246
                                                                                                            {
                                                                                                            Documents::US8::US8_0(v246_0_0)
                                                                                                            =>
                                                                                                            Ok(v246_0_0.clone()),
                                                                                                            Documents::US8::US8_1(v246_1_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v261:
                                                                                                                        string =
                                                                                                                    v246_1_0.clone();
                                                                                                                let v262:
                                                                                                                        string =
                                                                                                                    Documents::method43(v226.clone());
                                                                                                                let v263:
                                                                                                                        Option<string> =
                                                                                                                    Documents::method32(v226.clone());
                                                                                                                let v277:
                                                                                                                        Documents::US1 =
                                                                                                                    defaultValue(Documents::US1::US1_1,
                                                                                                                                 map(Documents::method5(),
                                                                                                                                     v263));
                                                                                                                if let Documents::US1::US1_0(v277_0_0)
                                                                                                                       =
                                                                                                                       &v277
                                                                                                                   {
                                                                                                                    let v281:
                                                                                                                            string =
                                                                                                                        match &v277
                                                                                                                            {
                                                                                                                            Documents::US1::US1_0(x)
                                                                                                                            =>
                                                                                                                            x.clone(),
                                                                                                                            _
                                                                                                                            =>
                                                                                                                            unreachable!(),
                                                                                                                        };
                                                                                                                    if v226.clone()
                                                                                                                           !=
                                                                                                                           string("")
                                                                                                                       {
                                                                                                                        let v286:
                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                       std::io::Error> =
                                                                                                                            std::fs::read_link(&*v281.clone());
                                                                                                                        let v287 =
                                                                                                                            Documents::method41();
                                                                                                                        let v298:
                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                       string> =
                                                                                                                            v286.map_err(|x| v287(x));
                                                                                                                        let v301:
                                                                                                                                Documents::US8 =
                                                                                                                            match &v298
                                                                                                                                {
                                                                                                                                Err(v298_1_0)
                                                                                                                                =>
                                                                                                                                v24(v298_1_0.clone()),
                                                                                                                                Ok(v298_0_0)
                                                                                                                                =>
                                                                                                                                v23(v298_0_0.clone()),
                                                                                                                            };
                                                                                                                        let v1924:
                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                       std::io::Error> =
                                                                                                                            match &v301
                                                                                                                                {
                                                                                                                                Documents::US8::US8_0(v301_0_0)
                                                                                                                                =>
                                                                                                                                Ok(v301_0_0.clone()),
                                                                                                                                Documents::US8::US8_1(v301_1_0)
                                                                                                                                =>
                                                                                                                                {
                                                                                                                                    let v316:
                                                                                                                                            string =
                                                                                                                                        v301_1_0.clone();
                                                                                                                                    let v317:
                                                                                                                                            string =
                                                                                                                                        Documents::method43(v281.clone());
                                                                                                                                    let v318:
                                                                                                                                            Option<string> =
                                                                                                                                        Documents::method32(v281.clone());
                                                                                                                                    let v332:
                                                                                                                                            Documents::US1 =
                                                                                                                                        defaultValue(Documents::US1::US1_1,
                                                                                                                                                     map(Documents::method5(),
                                                                                                                                                         v318));
                                                                                                                                    if let Documents::US1::US1_0(v332_0_0)
                                                                                                                                           =
                                                                                                                                           &v332
                                                                                                                                       {
                                                                                                                                        let v336:
                                                                                                                                                string =
                                                                                                                                            match &v332
                                                                                                                                                {
                                                                                                                                                Documents::US1::US1_0(x)
                                                                                                                                                =>
                                                                                                                                                x.clone(),
                                                                                                                                                _
                                                                                                                                                =>
                                                                                                                                                unreachable!(),
                                                                                                                                            };
                                                                                                                                        if v281.clone()
                                                                                                                                               !=
                                                                                                                                               string("")
                                                                                                                                           {
                                                                                                                                            let v341:
                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                           std::io::Error> =
                                                                                                                                                std::fs::read_link(&*v336.clone());
                                                                                                                                            let v342 =
                                                                                                                                                Documents::method41();
                                                                                                                                            let v353:
                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                           string> =
                                                                                                                                                v341.map_err(|x| v342(x));
                                                                                                                                            let v356:
                                                                                                                                                    Documents::US8 =
                                                                                                                                                match &v353
                                                                                                                                                    {
                                                                                                                                                    Err(v353_1_0)
                                                                                                                                                    =>
                                                                                                                                                    v24(v353_1_0.clone()),
                                                                                                                                                    Ok(v353_0_0)
                                                                                                                                                    =>
                                                                                                                                                    v23(v353_0_0.clone()),
                                                                                                                                                };
                                                                                                                                            let v1719:
                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                           std::io::Error> =
                                                                                                                                                match &v356
                                                                                                                                                    {
                                                                                                                                                    Documents::US8::US8_0(v356_0_0)
                                                                                                                                                    =>
                                                                                                                                                    Ok(v356_0_0.clone()),
                                                                                                                                                    Documents::US8::US8_1(v356_1_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v371:
                                                                                                                                                                string =
                                                                                                                                                            v356_1_0.clone();
                                                                                                                                                        let v372:
                                                                                                                                                                string =
                                                                                                                                                            Documents::method43(v336.clone());
                                                                                                                                                        let v373:
                                                                                                                                                                Option<string> =
                                                                                                                                                            Documents::method32(v336.clone());
                                                                                                                                                        let v387:
                                                                                                                                                                Documents::US1 =
                                                                                                                                                            defaultValue(Documents::US1::US1_1,
                                                                                                                                                                         map(Documents::method5(),
                                                                                                                                                                             v373));
                                                                                                                                                        if let Documents::US1::US1_0(v387_0_0)
                                                                                                                                                               =
                                                                                                                                                               &v387
                                                                                                                                                           {
                                                                                                                                                            let v391:
                                                                                                                                                                    string =
                                                                                                                                                                match &v387
                                                                                                                                                                    {
                                                                                                                                                                    Documents::US1::US1_0(x)
                                                                                                                                                                    =>
                                                                                                                                                                    x.clone(),
                                                                                                                                                                    _
                                                                                                                                                                    =>
                                                                                                                                                                    unreachable!(),
                                                                                                                                                                };
                                                                                                                                                            if v336.clone()
                                                                                                                                                                   !=
                                                                                                                                                                   string("")
                                                                                                                                                               {
                                                                                                                                                                let v396:
                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                    std::fs::read_link(&*v391.clone());
                                                                                                                                                                let v397 =
                                                                                                                                                                    Documents::method41();
                                                                                                                                                                let v408:
                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                               string> =
                                                                                                                                                                    v396.map_err(|x| v397(x));
                                                                                                                                                                let v411:
                                                                                                                                                                        Documents::US8 =
                                                                                                                                                                    match &v408
                                                                                                                                                                        {
                                                                                                                                                                        Err(v408_1_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v24(v408_1_0.clone()),
                                                                                                                                                                        Ok(v408_0_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v23(v408_0_0.clone()),
                                                                                                                                                                    };
                                                                                                                                                                let v1514:
                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                    match &v411
                                                                                                                                                                        {
                                                                                                                                                                        Documents::US8::US8_0(v411_0_0)
                                                                                                                                                                        =>
                                                                                                                                                                        Ok(v411_0_0.clone()),
                                                                                                                                                                        Documents::US8::US8_1(v411_1_0)
                                                                                                                                                                        =>
                                                                                                                                                                        {
                                                                                                                                                                            let v426:
                                                                                                                                                                                    string =
                                                                                                                                                                                v411_1_0.clone();
                                                                                                                                                                            let v427:
                                                                                                                                                                                    string =
                                                                                                                                                                                Documents::method43(v391.clone());
                                                                                                                                                                            let v428:
                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                Documents::method32(v391.clone());
                                                                                                                                                                            let v442:
                                                                                                                                                                                    Documents::US1 =
                                                                                                                                                                                defaultValue(Documents::US1::US1_1,
                                                                                                                                                                                             map(Documents::method5(),
                                                                                                                                                                                                 v428));
                                                                                                                                                                            if let Documents::US1::US1_0(v442_0_0)
                                                                                                                                                                                   =
                                                                                                                                                                                   &v442
                                                                                                                                                                               {
                                                                                                                                                                                let v446:
                                                                                                                                                                                        string =
                                                                                                                                                                                    match &v442
                                                                                                                                                                                        {
                                                                                                                                                                                        Documents::US1::US1_0(x)
                                                                                                                                                                                        =>
                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                        _
                                                                                                                                                                                        =>
                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                    };
                                                                                                                                                                                if v391.clone()
                                                                                                                                                                                       !=
                                                                                                                                                                                       string("")
                                                                                                                                                                                   {
                                                                                                                                                                                    let v451:
                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                        std::fs::read_link(&*v446.clone());
                                                                                                                                                                                    let v452 =
                                                                                                                                                                                        Documents::method41();
                                                                                                                                                                                    let v463:
                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                   string> =
                                                                                                                                                                                        v451.map_err(|x| v452(x));
                                                                                                                                                                                    let v466:
                                                                                                                                                                                            Documents::US8 =
                                                                                                                                                                                        match &v463
                                                                                                                                                                                            {
                                                                                                                                                                                            Err(v463_1_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            v24(v463_1_0.clone()),
                                                                                                                                                                                            Ok(v463_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            v23(v463_0_0.clone()),
                                                                                                                                                                                        };
                                                                                                                                                                                    let v1309:
                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                        match &v466
                                                                                                                                                                                            {
                                                                                                                                                                                            Documents::US8::US8_0(v466_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            Ok(v466_0_0.clone()),
                                                                                                                                                                                            Documents::US8::US8_1(v466_1_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            {
                                                                                                                                                                                                let v481:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    v466_1_0.clone();
                                                                                                                                                                                                let v482:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    Documents::method43(v446.clone());
                                                                                                                                                                                                let v483:
                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                    Documents::method32(v446.clone());
                                                                                                                                                                                                let v497:
                                                                                                                                                                                                        Documents::US1 =
                                                                                                                                                                                                    defaultValue(Documents::US1::US1_1,
                                                                                                                                                                                                                 map(Documents::method5(),
                                                                                                                                                                                                                     v483));
                                                                                                                                                                                                if let Documents::US1::US1_0(v497_0_0)
                                                                                                                                                                                                       =
                                                                                                                                                                                                       &v497
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v501:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        match &v497
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Documents::US1::US1_0(x)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                            _
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    if v446.clone()
                                                                                                                                                                                                           !=
                                                                                                                                                                                                           string("")
                                                                                                                                                                                                       {
                                                                                                                                                                                                        let v506:
                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                            std::fs::read_link(&*v501.clone());
                                                                                                                                                                                                        let v507 =
                                                                                                                                                                                                            Documents::method41();
                                                                                                                                                                                                        let v518:
                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                            v506.map_err(|x| v507(x));
                                                                                                                                                                                                        let v521:
                                                                                                                                                                                                                Documents::US8 =
                                                                                                                                                                                                            match &v518
                                                                                                                                                                                                                {
                                                                                                                                                                                                                Err(v518_1_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v24(v518_1_0.clone()),
                                                                                                                                                                                                                Ok(v518_0_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v23(v518_0_0.clone()),
                                                                                                                                                                                                            };
                                                                                                                                                                                                        let v1104:
                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                            match &v521
                                                                                                                                                                                                                {
                                                                                                                                                                                                                Documents::US8::US8_0(v521_0_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                Ok(v521_0_0.clone()),
                                                                                                                                                                                                                Documents::US8::US8_1(v521_1_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    let v536:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        v521_1_0.clone();
                                                                                                                                                                                                                    let v537:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        Documents::method43(v501.clone());
                                                                                                                                                                                                                    let v538:
                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                        Documents::method32(v501.clone());
                                                                                                                                                                                                                    let v552:
                                                                                                                                                                                                                            Documents::US1 =
                                                                                                                                                                                                                        defaultValue(Documents::US1::US1_1,
                                                                                                                                                                                                                                     map(Documents::method5(),
                                                                                                                                                                                                                                         v538));
                                                                                                                                                                                                                    if let Documents::US1::US1_0(v552_0_0)
                                                                                                                                                                                                                           =
                                                                                                                                                                                                                           &v552
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v556:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            match &v552
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Documents::US1::US1_0(x)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        if v501.clone()
                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                           {
                                                                                                                                                                                                                            let v561:
                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                std::fs::read_link(&*v556.clone());
                                                                                                                                                                                                                            let v562 =
                                                                                                                                                                                                                                Documents::method41();
                                                                                                                                                                                                                            let v573:
                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                v561.map_err(|x| v562(x));
                                                                                                                                                                                                                            let v576:
                                                                                                                                                                                                                                    Documents::US8 =
                                                                                                                                                                                                                                match &v573
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Err(v573_1_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    v24(v573_1_0.clone()),
                                                                                                                                                                                                                                    Ok(v573_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    v23(v573_0_0.clone()),
                                                                                                                                                                                                                                };
                                                                                                                                                                                                                            let v899:
                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                match &v576
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Documents::US8::US8_0(v576_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    Ok(v576_0_0.clone()),
                                                                                                                                                                                                                                    Documents::US8::US8_1(v576_1_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v591:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            v576_1_0.clone();
                                                                                                                                                                                                                                        let v592:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            Documents::method43(v556.clone());
                                                                                                                                                                                                                                        let v593:
                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                            Documents::method32(v556.clone());
                                                                                                                                                                                                                                        let v607:
                                                                                                                                                                                                                                                Documents::US1 =
                                                                                                                                                                                                                                            defaultValue(Documents::US1::US1_1,
                                                                                                                                                                                                                                                         map(Documents::method5(),
                                                                                                                                                                                                                                                             v593));
                                                                                                                                                                                                                                        if let Documents::US1::US1_0(v607_0_0)
                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                               &v607
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v611:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                match &v607
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Documents::US1::US1_0(x)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            if v556.clone()
                                                                                                                                                                                                                                                   !=
                                                                                                                                                                                                                                                   string("")
                                                                                                                                                                                                                                               {
                                                                                                                                                                                                                                                let v616:
                                                                                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                                                                                    std::fs::read_link(&*v611.clone());
                                                                                                                                                                                                                                                let v617 =
                                                                                                                                                                                                                                                    Documents::method41();
                                                                                                                                                                                                                                                let v628:
                                                                                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                                                                                               string> =
                                                                                                                                                                                                                                                    v616.map_err(|x| v617(x));
                                                                                                                                                                                                                                                let v631:
                                                                                                                                                                                                                                                        Documents::US8 =
                                                                                                                                                                                                                                                    match &v628
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                        Err(v628_1_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v24(v628_1_0.clone()),
                                                                                                                                                                                                                                                        Ok(v628_0_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v23(v628_0_0.clone()),
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                let v694:
                                                                                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                                                                                    match &v631
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                        Documents::US8::US8_0(v631_0_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        Ok(v631_0_0.clone()),
                                                                                                                                                                                                                                                        _
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            let v647:
                                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                                Documents::method43(v611.clone());
                                                                                                                                                                                                                                                            let v648:
                                                                                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                                                                                Documents::method32(v611.clone());
                                                                                                                                                                                                                                                            let v662:
                                                                                                                                                                                                                                                                    Documents::US1 =
                                                                                                                                                                                                                                                                defaultValue(Documents::US1::US1_1,
                                                                                                                                                                                                                                                                             map(Documents::method5(),
                                                                                                                                                                                                                                                                                 v648));
                                                                                                                                                                                                                                                            let v666:
                                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                                sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                                         11_u8,
                                                                                                                                                                                                                                                                         v611.clone(),
                                                                                                                                                                                                                                                                         v647);
                                                                                                                                                                                                                                                            let v669:
                                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v666);
                                                                                                                                                                                                                                                            Err(v669)
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                let v695 =
                                                                                                                                                                                                                                                    Documents::method41();
                                                                                                                                                                                                                                                let v706:
                                                                                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                                                                                               string> =
                                                                                                                                                                                                                                                    v694.map_err(|x| v695(x));
                                                                                                                                                                                                                                                let v709:
                                                                                                                                                                                                                                                        Documents::US8 =
                                                                                                                                                                                                                                                    match &v706
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                        Err(v706_1_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v24(v706_1_0.clone()),
                                                                                                                                                                                                                                                        Ok(v706_0_0)
                                                                                                                                                                                                                                                        =>
                                                                                                                                                                                                                                                        v23(v706_0_0.clone()),
                                                                                                                                                                                                                                                    };
                                                                                                                                                                                                                                                match &v709
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Documents::US8::US8_0(v709_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v735:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            Documents::method26(toString(v709_0_0.clone().display()),
                                                                                                                                                                                                                                                                                v592.clone());
                                                                                                                                                                                                                                                        let v738:
                                                                                                                                                                                                                                                                &str =
                                                                                                                                                                                                                                                            &*v735;
                                                                                                                                                                                                                                                        let v759:
                                                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                                                            String::from(v738);
                                                                                                                                                                                                                                                        let v780:
                                                                                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                                                                                            std::path::PathBuf::from(v759);
                                                                                                                                                                                                                                                        Ok(v780)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    Documents::US8::US8_1(v709_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v813:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                     v709_1_0.clone(),
                                                                                                                                                                                                                                                                     v591.clone(),
                                                                                                                                                                                                                                                                     v592.clone());
                                                                                                                                                                                                                                                        let v816:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v813);
                                                                                                                                                                                                                                                        Err(v816)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            } else {
                                                                                                                                                                                                                                                let v842:
                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                                                                             v591.clone(),
                                                                                                                                                                                                                                                             v556.clone(),
                                                                                                                                                                                                                                                             v592.clone());
                                                                                                                                                                                                                                                let v845:
                                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v842);
                                                                                                                                                                                                                                                Err(v845)
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v870:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v591,
                                                                                                                                                                                                                                                         v556.clone(),
                                                                                                                                                                                                                                                         v592.clone());
                                                                                                                                                                                                                                            let v873:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v870);
                                                                                                                                                                                                                                            Err(v873)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                };
                                                                                                                                                                                                                            let v900 =
                                                                                                                                                                                                                                Documents::method41();
                                                                                                                                                                                                                            let v911:
                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                v899.map_err(|x| v900(x));
                                                                                                                                                                                                                            let v914:
                                                                                                                                                                                                                                    Documents::US8 =
                                                                                                                                                                                                                                match &v911
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    Err(v911_1_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    v24(v911_1_0.clone()),
                                                                                                                                                                                                                                    Ok(v911_0_0)
                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                    v23(v911_0_0.clone()),
                                                                                                                                                                                                                                };
                                                                                                                                                                                                                            match &v914
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Documents::US8::US8_0(v914_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v940:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        Documents::method26(toString(v914_0_0.clone().display()),
                                                                                                                                                                                                                                                            v537.clone());
                                                                                                                                                                                                                                    let v943:
                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                        &*v940;
                                                                                                                                                                                                                                    let v964:
                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                        String::from(v943);
                                                                                                                                                                                                                                    let v985:
                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                        std::path::PathBuf::from(v964);
                                                                                                                                                                                                                                    Ok(v985)
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                Documents::US8::US8_1(v914_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v1018:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                 v914_1_0.clone(),
                                                                                                                                                                                                                                                 v536.clone(),
                                                                                                                                                                                                                                                 v537.clone());
                                                                                                                                                                                                                                    let v1021:
                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1018);
                                                                                                                                                                                                                                    Err(v1021)
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                            let v1047:
                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                         v536.clone(),
                                                                                                                                                                                                                                         v501.clone(),
                                                                                                                                                                                                                                         v537.clone());
                                                                                                                                                                                                                            let v1050:
                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1047);
                                                                                                                                                                                                                            Err(v1050)
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v1075:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v536,
                                                                                                                                                                                                                                     v501.clone(),
                                                                                                                                                                                                                                     v537.clone());
                                                                                                                                                                                                                        let v1078:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1075);
                                                                                                                                                                                                                        Err(v1078)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            };
                                                                                                                                                                                                        let v1105 =
                                                                                                                                                                                                            Documents::method41();
                                                                                                                                                                                                        let v1116:
                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                            v1104.map_err(|x| v1105(x));
                                                                                                                                                                                                        let v1119:
                                                                                                                                                                                                                Documents::US8 =
                                                                                                                                                                                                            match &v1116
                                                                                                                                                                                                                {
                                                                                                                                                                                                                Err(v1116_1_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v24(v1116_1_0.clone()),
                                                                                                                                                                                                                Ok(v1116_0_0)
                                                                                                                                                                                                                =>
                                                                                                                                                                                                                v23(v1116_0_0.clone()),
                                                                                                                                                                                                            };
                                                                                                                                                                                                        match &v1119
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Documents::US8::US8_0(v1119_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v1145:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    Documents::method26(toString(v1119_0_0.clone().display()),
                                                                                                                                                                                                                                        v482.clone());
                                                                                                                                                                                                                let v1148:
                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                    &*v1145;
                                                                                                                                                                                                                let v1169:
                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                    String::from(v1148);
                                                                                                                                                                                                                let v1190:
                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                    std::path::PathBuf::from(v1169);
                                                                                                                                                                                                                Ok(v1190)
                                                                                                                                                                                                            }
                                                                                                                                                                                                            Documents::US8::US8_1(v1119_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v1223:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                             v1119_1_0.clone(),
                                                                                                                                                                                                                             v481.clone(),
                                                                                                                                                                                                                             v482.clone());
                                                                                                                                                                                                                let v1226:
                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1223);
                                                                                                                                                                                                                Err(v1226)
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    } else {
                                                                                                                                                                                                        let v1252:
                                                                                                                                                                                                                string =
                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                     v481.clone(),
                                                                                                                                                                                                                     v446.clone(),
                                                                                                                                                                                                                     v482.clone());
                                                                                                                                                                                                        let v1255:
                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1252);
                                                                                                                                                                                                        Err(v1255)
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v1280:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v481,
                                                                                                                                                                                                                 v446.clone(),
                                                                                                                                                                                                                 v482.clone());
                                                                                                                                                                                                    let v1283:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1280);
                                                                                                                                                                                                    Err(v1283)
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        };
                                                                                                                                                                                    let v1310 =
                                                                                                                                                                                        Documents::method41();
                                                                                                                                                                                    let v1321:
                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                   string> =
                                                                                                                                                                                        v1309.map_err(|x| v1310(x));
                                                                                                                                                                                    let v1324:
                                                                                                                                                                                            Documents::US8 =
                                                                                                                                                                                        match &v1321
                                                                                                                                                                                            {
                                                                                                                                                                                            Err(v1321_1_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            v24(v1321_1_0.clone()),
                                                                                                                                                                                            Ok(v1321_0_0)
                                                                                                                                                                                            =>
                                                                                                                                                                                            v23(v1321_0_0.clone()),
                                                                                                                                                                                        };
                                                                                                                                                                                    match &v1324
                                                                                                                                                                                        {
                                                                                                                                                                                        Documents::US8::US8_0(v1324_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v1350:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                Documents::method26(toString(v1324_0_0.clone().display()),
                                                                                                                                                                                                                    v427.clone());
                                                                                                                                                                                            let v1353:
                                                                                                                                                                                                    &str =
                                                                                                                                                                                                &*v1350;
                                                                                                                                                                                            let v1374:
                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                String::from(v1353);
                                                                                                                                                                                            let v1395:
                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                std::path::PathBuf::from(v1374);
                                                                                                                                                                                            Ok(v1395)
                                                                                                                                                                                        }
                                                                                                                                                                                        Documents::US8::US8_1(v1324_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v1428:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                         v1324_1_0.clone(),
                                                                                                                                                                                                         v426.clone(),
                                                                                                                                                                                                         v427.clone());
                                                                                                                                                                                            let v1431:
                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1428);
                                                                                                                                                                                            Err(v1431)
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                } else {
                                                                                                                                                                                    let v1457:
                                                                                                                                                                                            string =
                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                 v426.clone(),
                                                                                                                                                                                                 v391.clone(),
                                                                                                                                                                                                 v427.clone());
                                                                                                                                                                                    let v1460:
                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1457);
                                                                                                                                                                                    Err(v1460)
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v1485:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v426,
                                                                                                                                                                                             v391.clone(),
                                                                                                                                                                                             v427.clone());
                                                                                                                                                                                let v1488:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1485);
                                                                                                                                                                                Err(v1488)
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    };
                                                                                                                                                                let v1515 =
                                                                                                                                                                    Documents::method41();
                                                                                                                                                                let v1526:
                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                               string> =
                                                                                                                                                                    v1514.map_err(|x| v1515(x));
                                                                                                                                                                let v1529:
                                                                                                                                                                        Documents::US8 =
                                                                                                                                                                    match &v1526
                                                                                                                                                                        {
                                                                                                                                                                        Err(v1526_1_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v24(v1526_1_0.clone()),
                                                                                                                                                                        Ok(v1526_0_0)
                                                                                                                                                                        =>
                                                                                                                                                                        v23(v1526_0_0.clone()),
                                                                                                                                                                    };
                                                                                                                                                                match &v1529
                                                                                                                                                                    {
                                                                                                                                                                    Documents::US8::US8_0(v1529_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v1555:
                                                                                                                                                                                string =
                                                                                                                                                                            Documents::method26(toString(v1529_0_0.clone().display()),
                                                                                                                                                                                                v372.clone());
                                                                                                                                                                        let v1558:
                                                                                                                                                                                &str =
                                                                                                                                                                            &*v1555;
                                                                                                                                                                        let v1579:
                                                                                                                                                                                std::string::String =
                                                                                                                                                                            String::from(v1558);
                                                                                                                                                                        let v1600:
                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                            std::path::PathBuf::from(v1579);
                                                                                                                                                                        Ok(v1600)
                                                                                                                                                                    }
                                                                                                                                                                    Documents::US8::US8_1(v1529_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v1633:
                                                                                                                                                                                string =
                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                     v1529_1_0.clone(),
                                                                                                                                                                                     v371.clone(),
                                                                                                                                                                                     v372.clone());
                                                                                                                                                                        let v1636:
                                                                                                                                                                                std::io::Error =
                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1633);
                                                                                                                                                                        Err(v1636)
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            } else {
                                                                                                                                                                let v1662:
                                                                                                                                                                        string =
                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                             v371.clone(),
                                                                                                                                                                             v336.clone(),
                                                                                                                                                                             v372.clone());
                                                                                                                                                                let v1665:
                                                                                                                                                                        std::io::Error =
                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1662);
                                                                                                                                                                Err(v1665)
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v1690:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v371,
                                                                                                                                                                         v336.clone(),
                                                                                                                                                                         v372.clone());
                                                                                                                                                            let v1693:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1690);
                                                                                                                                                            Err(v1693)
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                };
                                                                                                                                            let v1720 =
                                                                                                                                                Documents::method41();
                                                                                                                                            let v1731:
                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                           string> =
                                                                                                                                                v1719.map_err(|x| v1720(x));
                                                                                                                                            let v1734:
                                                                                                                                                    Documents::US8 =
                                                                                                                                                match &v1731
                                                                                                                                                    {
                                                                                                                                                    Err(v1731_1_0)
                                                                                                                                                    =>
                                                                                                                                                    v24(v1731_1_0.clone()),
                                                                                                                                                    Ok(v1731_0_0)
                                                                                                                                                    =>
                                                                                                                                                    v23(v1731_0_0.clone()),
                                                                                                                                                };
                                                                                                                                            match &v1734
                                                                                                                                                {
                                                                                                                                                Documents::US8::US8_0(v1734_0_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v1760:
                                                                                                                                                            string =
                                                                                                                                                        Documents::method26(toString(v1734_0_0.clone().display()),
                                                                                                                                                                            v317.clone());
                                                                                                                                                    let v1763:
                                                                                                                                                            &str =
                                                                                                                                                        &*v1760;
                                                                                                                                                    let v1784:
                                                                                                                                                            std::string::String =
                                                                                                                                                        String::from(v1763);
                                                                                                                                                    let v1805:
                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                        std::path::PathBuf::from(v1784);
                                                                                                                                                    Ok(v1805)
                                                                                                                                                }
                                                                                                                                                Documents::US8::US8_1(v1734_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v1838:
                                                                                                                                                            string =
                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                 v1734_1_0.clone(),
                                                                                                                                                                 v316.clone(),
                                                                                                                                                                 v317.clone());
                                                                                                                                                    let v1841:
                                                                                                                                                            std::io::Error =
                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1838);
                                                                                                                                                    Err(v1841)
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        } else {
                                                                                                                                            let v1867:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                         v0_1.clone(),
                                                                                                                                                         v316.clone(),
                                                                                                                                                         v281.clone(),
                                                                                                                                                         v317.clone());
                                                                                                                                            let v1870:
                                                                                                                                                    std::io::Error =
                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1867);
                                                                                                                                            Err(v1870)
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v1895:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v316,
                                                                                                                                                     v281.clone(),
                                                                                                                                                     v317.clone());
                                                                                                                                        let v1898:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1895);
                                                                                                                                        Err(v1898)
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            };
                                                                                                                        let v1925 =
                                                                                                                            Documents::method41();
                                                                                                                        let v1936:
                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                       string> =
                                                                                                                            v1924.map_err(|x| v1925(x));
                                                                                                                        let v1939:
                                                                                                                                Documents::US8 =
                                                                                                                            match &v1936
                                                                                                                                {
                                                                                                                                Err(v1936_1_0)
                                                                                                                                =>
                                                                                                                                v24(v1936_1_0.clone()),
                                                                                                                                Ok(v1936_0_0)
                                                                                                                                =>
                                                                                                                                v23(v1936_0_0.clone()),
                                                                                                                            };
                                                                                                                        match &v1939
                                                                                                                            {
                                                                                                                            Documents::US8::US8_0(v1939_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v1965:
                                                                                                                                        string =
                                                                                                                                    Documents::method26(toString(v1939_0_0.clone().display()),
                                                                                                                                                        v262.clone());
                                                                                                                                let v1968:
                                                                                                                                        &str =
                                                                                                                                    &*v1965;
                                                                                                                                let v1989:
                                                                                                                                        std::string::String =
                                                                                                                                    String::from(v1968);
                                                                                                                                let v2010:
                                                                                                                                        std::path::PathBuf =
                                                                                                                                    std::path::PathBuf::from(v1989);
                                                                                                                                Ok(v2010)
                                                                                                                            }
                                                                                                                            Documents::US8::US8_1(v1939_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v2043:
                                                                                                                                        string =
                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                             v1939_1_0.clone(),
                                                                                                                                             v261.clone(),
                                                                                                                                             v262.clone());
                                                                                                                                let v2046:
                                                                                                                                        std::io::Error =
                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2043);
                                                                                                                                Err(v2046)
                                                                                                                            }
                                                                                                                        }
                                                                                                                    } else {
                                                                                                                        let v2072:
                                                                                                                                string =
                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                     v0_1.clone(),
                                                                                                                                     v261.clone(),
                                                                                                                                     v226.clone(),
                                                                                                                                     v262.clone());
                                                                                                                        let v2075:
                                                                                                                                std::io::Error =
                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v2072);
                                                                                                                        Err(v2075)
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v2100:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v261,
                                                                                                                                 v226.clone(),
                                                                                                                                 v262.clone());
                                                                                                                    let v2103:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2100);
                                                                                                                    Err(v2103)
                                                                                                                }
                                                                                                            }
                                                                                                        };
                                                                                                    let v2130 =
                                                                                                        Documents::method41();
                                                                                                    let v2141:
                                                                                                            Result<std::path::PathBuf,
                                                                                                                   string> =
                                                                                                        v2129.map_err(|x| v2130(x));
                                                                                                    let v2144:
                                                                                                            Documents::US8 =
                                                                                                        match &v2141
                                                                                                            {
                                                                                                            Err(v2141_1_0)
                                                                                                            =>
                                                                                                            v24(v2141_1_0.clone()),
                                                                                                            Ok(v2141_0_0)
                                                                                                            =>
                                                                                                            v23(v2141_0_0.clone()),
                                                                                                        };
                                                                                                    match &v2144
                                                                                                        {
                                                                                                        Documents::US8::US8_0(v2144_0_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v2170:
                                                                                                                    string =
                                                                                                                Documents::method26(toString(v2144_0_0.clone().display()),
                                                                                                                                    v207.clone());
                                                                                                            let v2173:
                                                                                                                    &str =
                                                                                                                &*v2170;
                                                                                                            let v2194:
                                                                                                                    std::string::String =
                                                                                                                String::from(v2173);
                                                                                                            let v2215:
                                                                                                                    std::path::PathBuf =
                                                                                                                std::path::PathBuf::from(v2194);
                                                                                                            Ok(v2215)
                                                                                                        }
                                                                                                        Documents::US8::US8_1(v2144_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v2248:
                                                                                                                    string =
                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                         v2144_1_0.clone(),
                                                                                                                         v206.clone(),
                                                                                                                         v207.clone());
                                                                                                            let v2251:
                                                                                                                    std::io::Error =
                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v2248);
                                                                                                            Err(v2251)
                                                                                                        }
                                                                                                    }
                                                                                                } else {
                                                                                                    let v2277:
                                                                                                            string =
                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                 v0_1.clone(),
                                                                                                                 v206.clone(),
                                                                                                                 v171.clone(),
                                                                                                                 v207.clone());
                                                                                                    let v2280:
                                                                                                            std::io::Error =
                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2277);
                                                                                                    Err(v2280)
                                                                                                }
                                                                                            } else {
                                                                                                let v2305:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v206,
                                                                                                             v171.clone(),
                                                                                                             v207.clone());
                                                                                                let v2308:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2305);
                                                                                                Err(v2308)
                                                                                            }
                                                                                        }
                                                                                    };
                                                                        let v2335 =
                                                                            Documents::method41();
                                                                        let v2346: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v2334
                                                                            .map_err(|x| v2335(x));
                                                                        let v2349: Documents::US8 =
                                                                            match &v2346 {
                                                                                Err(v2346_1_0) => {
                                                                                    v24(v2346_1_0
                                                                                        .clone())
                                                                                }
                                                                                Ok(v2346_0_0) => {
                                                                                    v23(v2346_0_0
                                                                                        .clone())
                                                                                }
                                                                            };
                                                                        match &v2349
                                                                                    {
                                                                                    Documents::US8::US8_0(v2349_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2375:
                                                                                                string =
                                                                                            Documents::method26(toString(v2349_0_0.clone().display()),
                                                                                                                v152.clone());
                                                                                        let v2378:
                                                                                                &str =
                                                                                            &*v2375;
                                                                                        let v2399:
                                                                                                std::string::String =
                                                                                            String::from(v2378);
                                                                                        let v2420:
                                                                                                std::path::PathBuf =
                                                                                            std::path::PathBuf::from(v2399);
                                                                                        Ok(v2420)
                                                                                    }
                                                                                    Documents::US8::US8_1(v2349_1_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2453:
                                                                                                string =
                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                     v2349_1_0.clone(),
                                                                                                     v151.clone(),
                                                                                                     v152.clone());
                                                                                        let v2456:
                                                                                                std::io::Error =
                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v2453);
                                                                                        Err(v2456)
                                                                                    }
                                                                                }
                                                                    } else {
                                                                        let v2482:
                                                                                        string =
                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                             v0_1.clone(),
                                                                                             v151.clone(),
                                                                                             v116.clone(),
                                                                                             v152.clone());
                                                                        let v2485:
                                                                                        std::io::Error =
                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2482);
                                                                        Err(v2485)
                                                                    }
                                                                } else {
                                                                    let v2510:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v151,
                                                                                         v116.clone(),
                                                                                         v152.clone());
                                                                    let v2513:
                                                                                    std::io::Error =
                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v2510);
                                                                    Err(v2513)
                                                                }
                                                            }
                                                        };
                                                        let v2540 = Documents::method41();
                                                        let v2551: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v2539.map_err(|x| v2540(x));
                                                        let v2554: Documents::US8 = match &v2551 {
                                                            Err(v2551_1_0) => {
                                                                v24(v2551_1_0.clone())
                                                            }
                                                            Ok(v2551_0_0) => v23(v2551_0_0.clone()),
                                                        };
                                                        match &v2554 {
                                                            Documents::US8::US8_0(v2554_0_0) => {
                                                                let v2580: string =
                                                                    Documents::method26(
                                                                        toString(
                                                                            v2554_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v97.clone(),
                                                                    );
                                                                let v2583: &str = &*v2580;
                                                                let v2604: std::string::String =
                                                                    String::from(v2583);
                                                                let v2625: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v2604);
                                                                Ok(v2625)
                                                            }
                                                            Documents::US8::US8_1(v2554_1_0) => {
                                                                let v2658:
                                                                            string =
                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                 v2554_1_0.clone(),
                                                                                 v96.clone(),
                                                                                 v97.clone());
                                                                let v2661: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v2658,
                                                                    );
                                                                Err(v2661)
                                                            }
                                                        }
                                                    } else {
                                                        let v2687:
                                                                    string =
                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                         v0_1.clone(),
                                                                         v96.clone(),
                                                                         v60.clone(),
                                                                         v97.clone());
                                                        let v2690: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v2687,
                                                            );
                                                        Err(v2690)
                                                    }
                                                } else {
                                                    let v2715: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v96,
                                                                     v60.clone(),
                                                                     v97.clone());
                                                    let v2718: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v2715,
                                                    );
                                                    Err(v2718)
                                                }
                                            }
                                        };
                                    let v2745 = Documents::method41();
                                    let v2756: Result<std::path::PathBuf, string> =
                                        v2744.map_err(|x| v2745(x));
                                    let v2759: Documents::US8 = match &v2756 {
                                        Err(v2756_1_0) => v24(v2756_1_0.clone()),
                                        Ok(v2756_0_0) => v23(v2756_0_0.clone()),
                                    };
                                    match &v2759 {
                                        Documents::US8::US8_0(v2759_0_0) => {
                                            let v2785: string = Documents::method26(
                                                toString(v2759_0_0.clone().display()),
                                                v41.clone(),
                                            );
                                            let v2788: &str = &*v2785;
                                            let v2809: std::string::String = String::from(v2788);
                                            let v2830: std::path::PathBuf =
                                                std::path::PathBuf::from(v2809);
                                            Ok(v2830)
                                        }
                                        Documents::US8::US8_1(v2759_1_0) => {
                                            let v2863: string =
                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                             v2759_1_0.clone(),
                                                             v40.clone(),
                                                             v41.clone());
                                            let v2866: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v2863,
                                            );
                                            Err(v2866)
                                        }
                                    }
                                } else {
                                    let v2892: string =
                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                     v0_1.clone(),
                                                     v40.clone(),
                                                     v0_1.clone(),
                                                     v41.clone());
                                    let v2895: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2892);
                                    Err(v2895)
                                }
                            } else {
                                let v2920: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v40,
                                                 v0_1.clone(), v41.clone());
                                let v2923: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2920);
                                Err(v2923)
                            }
                        }
                    }
                };
                let v13137: Option<std::path::PathBuf> = v2950.ok();
                let v13161: Documents::US9 =
                    defaultValue(Documents::US9::US9_1, map(Documents::method44(), v13137));
                let v13193: string = match &v13161 {
                    Documents::US9::US9_0(v13161_0_0) => {
                        let v13187: string = toString(
                            match &v13161 {
                                Documents::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .display(),
                        );
                        if v13187.clone() == string("") {
                            v0_1.clone()
                        } else {
                            v13187
                        }
                    }
                    _ => v0_1.clone(),
                };
                if v13193.clone() == string("") {
                    string("")
                } else {
                    let v13200: Result<regex::Regex, regex::Error> =
                        regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                    let v13203: regex::Regex = v13200.unwrap();
                    let v13214: string = Documents::method45(v13193);
                    let v13216: std::borrow::Cow<str> = v13203.replace_all(&*v13214, &*string(""));
                    let v13218: std::string::String = String::from(v13216);
                    let v13234: string = fable_library_rust::String_::fromString(v13218);
                    replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v13234.clone(), 0_i32))),
                            getSlice(v13234, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method46(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method47(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method48() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method39(v0_1: string) -> string {
            let v4: &str = &*v0_1.clone();
            let v25: std::string::String = String::from(v4);
            let v46: std::path::PathBuf = std::path::PathBuf::from(v25);
            if v46.exists() == false {
                let v68: string = Documents::method38();
                let v72: Array<string> = split(
                    Documents::method40(Documents::method26(v68.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v76: i32 = count_2(v72.clone());
                let v77: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method46(v76, v77.clone()) {
                    let v79: i32 = v77.l0.get().clone();
                    let v82: i32 = v79.wrapping_neg() + v76 - 1_i32;
                    let matchValue: i32 = v77.l1.get().clone();
                    let v84: Array<string> = v77.l2.get().clone();
                    let v83: i32 = matchValue;
                    let v85: string = v72[v82].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == v85.clone() {
                        (v83 + 1_i32, v84.clone())
                    } else {
                        if string(".") == v85.clone() {
                            (v83, v84.clone())
                        } else {
                            if 0_i32 == v83 {
                                if endsWith(v85.clone(), string(":"), false) {
                                    let v93: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v68.clone(), 0_i32)
                                    )]);
                                    let v94: i32 = count_2(v93.clone());
                                    let v96: i32 = v94 + count_2(v84.clone());
                                    let v97: Array<string> = new_init(&string(""), v96);
                                    let v98: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method47(v96, v98.clone()) {
                                        let v100: i32 = v98.l0.get().clone();
                                        let v105: string = if v100 < v94 {
                                            v93[v100].clone()
                                        } else {
                                            let v103: i32 = v100 - v94;
                                            v84[v103].clone()
                                        };
                                        v97.get_mut()[v100 as usize] = v105;
                                        {
                                            let v106: i32 = v100 + 1_i32;
                                            v98.l0.set(v106);
                                            ()
                                        }
                                    }
                                    (0_i32, v97.clone())
                                } else {
                                    let v107: Array<string> = new_array(&[v85]);
                                    let v108: i32 = count_2(v107.clone());
                                    let v110: i32 = v108 + count_2(v84.clone());
                                    let v111: Array<string> = new_init(&string(""), v110);
                                    let v112: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method47(v110, v112.clone()) {
                                        let v114: i32 = v112.l0.get().clone();
                                        let v119: string = if v114 < v108 {
                                            v107[v114].clone()
                                        } else {
                                            let v117: i32 = v114 - v108;
                                            v84[v117].clone()
                                        };
                                        v111.get_mut()[v114 as usize] = v119;
                                        {
                                            let v120: i32 = v114 + 1_i32;
                                            v112.l0.set(v120);
                                            ()
                                        }
                                    }
                                    (0_i32, v111.clone())
                                }
                            } else {
                                (v83 - 1_i32, v84.clone())
                            }
                        }
                    };
                    let v130: i32 = v79 + 1_i32;
                    v77.l0.set(v130);
                    v77.l1.set(patternInput_1.0.clone());
                    v77.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v77.l1.get().clone();
                    let v132: Array<string> = v77.l2.get().clone();
                    let v133: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v132 = v132.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v132 = v132.clone();
                                    move |i: i32| v132[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, count_2(v132.clone()) - 1_i32),
                            )
                        }
                    }));
                    join(ofChar(Documents::method48()), toArray_1(v133))
                }
            } else {
                let v147: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v150: std::path::PathBuf = v147.unwrap();
                let v163: std::path::Display = v150.display();
                let v184: std::string::String = format!("{}", v163);
                fable_library_rust::String_::fromString(v184)
            }
        }
        pub fn method49() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Debug")), 0_i32));
            let v9: &str = inline_colorization::color_bright_blue;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method51(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method50(
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
            let v12: string = Documents::method51(v8, v9, v10, v11);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v12
            ))
        }
        pub fn closure19(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
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
                Documents::method19(Documents::method50(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Documents::method8(v22, v23, v24, v25, v26, v27),
                    Documents::method49(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                ))
            };
        }
        pub fn method52(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method53() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure21((), v))
        }
        pub fn closure22(unitVar: (), v0_1: std::fs::FileType) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn closure23(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn method54(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method55(v0_1: Documents::US11) -> Documents::US11 {
            v0_1
        }
        pub fn method56(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure20(
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
                    let v5: async_walkdir::DirEntry = Documents::method52(v0_1.clone());
                    let v7: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v5));
                    let v9: Result<std::fs::FileType, std::io::Error> = v7.await;
                    let v10 = Documents::method53();
                    let v21: Result<std::fs::FileType, std::string::String> =
                        v9.map_err(|x| v10(x));
                    let v26: Documents::US10 = match &v21 {
                        Err(v21_1_0) => Documents::closure23((), v21_1_0.clone()),
                        Ok(v21_0_0) => Documents::closure22((), v21_0_0.clone()),
                    };
                    let v144: Documents::US11 =
                        Documents::method55(if let Documents::US10::US10_0(v26_0_0) = &v26 {
                            let v28: std::fs::FileType = Documents::method54(match &v26 {
                                Documents::US10::US10_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v28) {
                                Documents::US11::US11_0
                            } else {
                                let v33: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v36: std::path::Display = v33.display();
                                let v57: std::string::String = format!("{}", v36);
                                let v77: string = fable_library_rust::String_::fromString(v57);
                                if if endsWith(v77.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v77, string(".hangul.md"), false)
                                } {
                                    Documents::US11::US11_0
                                } else {
                                    Documents::US11::US11_2
                                }
                            }
                        } else {
                            let v89: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v92: std::path::Display = v89.display();
                            let v113: std::string::String = format!("{}", v92);
                            let v133: string = fable_library_rust::String_::fromString(v113);
                            if if endsWith(v133.clone(), string(".md"), false) == false {
                                true
                            } else {
                                endsWith(v133, string(".hangul.md"), false)
                            } {
                                Documents::US11::US11_0
                            } else {
                                Documents::US11::US11_2
                            }
                        });
                    let v147: string = string("}");
                    let v151: bool = true;
                    let v148 = v144;
                    let v162: string = append(
                        append(
                            append(append(string("true; v148 "), v147), string("); ")),
                            string(""),
                        ),
                        string(" // rust.fix_closure\'"),
                    );
                    let v163: bool = true;
                    v148
                }); // rust.fix_closure';
                let v165 = __future_init;
                let v167: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Documents::US11> + Send>,
                > = v165;
                let v169: Documents::US11 = v167.await;
                let v179: async_walkdir::Filtering = Documents::method56(match &v169 {
                    Documents::US11::US11_0 => async_walkdir::Filtering::Ignore,
                    Documents::US11::US11_1 => async_walkdir::Filtering::IgnoreDir,
                    _ => async_walkdir::Filtering::Continue,
                });
                let v180: string = string("}");
                let v184: bool = true;
                let v181 = v179;
                let v195: string = append(
                    append(
                        append(append(string("true; v181 "), v180), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v196: bool = true;
                v181
            }); // rust.fix_closure';
            let v198 = __future_init;
            v198
        }
        pub fn closure25(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method58() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure25((), v))
        }
        pub fn closure26(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn closure27(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn method59() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method61(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            let v62: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method60(
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
            let v9: string = Documents::method61(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / stream_filter_map"),
                v9
            ))
        }
        pub fn closure28(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
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
                Documents::method19(Documents::method60(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method59(),
                    v0_1,
                ))
            };
        }
        pub fn closure24(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method58();
            let v12: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17: Documents::US12 = match &v12 {
                Err(v12_1_0) => Documents::closure27((), v12_1_0.clone()),
                Ok(v12_0_0) => Documents::closure26((), v12_0_0.clone()),
            };
            let v111: Documents::US1 = match &v17 {
                Documents::US12::US12_0(v17_0_0) => {
                    let v20: std::path::PathBuf = async_walkdir::DirEntry::path(&v17_0_0.clone());
                    let v23: std::path::Display = v20.display();
                    let v44: std::string::String = format!("{}", v23);
                    Documents::US1::US1_0(fable_library_rust::String_::fromString(v44))
                }
                Documents::US12::US12_1(v17_1_0) => {
                    let v69: () = {
                        Documents::closure28(v17_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            match &v111 {
                Documents::US1::US1_0(v111_0_0) => Some(match &v111 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method57(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure24((), v)
                },
            )
        }
        pub fn method63(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            let v62: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
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
            v8: usize,
        ) -> string {
            let v9: string = Documents::method63(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v9
            ))
        }
        pub fn closure29(v0_1: Vec<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
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
                Documents::method19(Documents::method62(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method49(),
                    v0_1.len(),
                ))
            };
        }
        pub fn method64() -> string {
            string("")
        }
        pub fn method65(v0_1: string) -> string {
            Documents::method40(Documents::method39(v0_1))
        }
        pub fn method67(
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
        pub fn closure33(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure32(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure33(v0_1, v)
            })
        }
        pub fn method69() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure32((), v))
        }
        pub fn method70(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method70: loop {
                break '_method70 (match v0_1.get().clone().as_ref() {
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
                            continue '_method70;
                        }
                    }
                });
            }
        }
        pub fn closure31(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US14 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
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
                    while Documents::method47(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method70(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method69())(b0)(b1)
                                }),
                                v27,
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
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn closure34(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US14 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Documents::US14::US14_1(sprintf!(
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
                    while Documents::method47(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method70(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method69())(b0)(b1)
                                }),
                                v27,
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
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method71(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US14 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method71: loop {
                break '_method71 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US14::US14_1(string("choice / no parsers succeeded"))
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
                                continue '_method71;
                            }
                        }
                    }
                });
            }
        }
        pub fn method72(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method72: loop {
                break '_method72 (if v1_1.get().clone() >= 2_i64 {
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
                        continue '_method72;
                    }
                });
            }
        }
        pub fn method73(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method73: loop {
                break '_method73 ({
                    let v70: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        if Documents::method72(v19, 0_i64) == false {
                            let v31: string = ofChar(v19);
                            let v34: i32 = length(v31.clone());
                            let v35: Array<char> = new_init(&'\u{0000}', v34);
                            let v36: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method47(v34, v36.clone()) {
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
                                    Documents::method70(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method69())(b0)(b1)
                                                },
                                            ),
                                            v41,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v19,
                                    v26,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v19,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v82: Documents::US14 = match &v70 {
                        Documents::US14::US14_0(v70_0_0, v70_0_1, v70_0_2, v70_0_3, v70_0_4) => {
                            let v71: char = v70_0_0.clone();
                            Documents::US14::US14_0(
                                if '\\' == v71 { '/' } else { v71 },
                                v70_0_1.clone(),
                                v70_0_2.clone(),
                                v70_0_3.clone(),
                                v70_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v70_1_0) => {
                            Documents::US14::US14_1(v70_1_0.clone())
                        }
                    };
                    match &v82 {
                        Documents::US14::US14_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
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
                            continue '_method73;
                        }
                        _ => Documents::US15::US15_0(
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
        pub fn method74(
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
            '_method74: loop {
                break '_method74 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US14::US14_1(string("choice / no parsers succeeded"))
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
                                continue '_method74;
                            }
                        }
                    }
                });
            }
        }
        pub fn method75(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method75: loop {
                break '_method75 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method75;
                    }
                });
            }
        }
        pub fn method76(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method76: loop {
                break '_method76 ({
                    let v76: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        if Documents::method75(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method47(v37, v39.clone()) {
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
                                    Documents::method70(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method69())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v88: Documents::US14 = match &v76 {
                        Documents::US14::US14_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                            let v77: char = v76_0_0.clone();
                            Documents::US14::US14_0(
                                if '\\' == v77 { '/' } else { v77 },
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v76_1_0) => {
                            Documents::US14::US14_1(v76_1_0.clone())
                        }
                    };
                    match &v88 {
                        Documents::US14::US14_0(v88_0_0, v88_0_1, v88_0_2, v88_0_3, v88_0_4) => {
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
                            continue '_method76;
                        }
                        _ => Documents::US15::US15_0(
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
        pub fn method77(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method77: loop {
                break '_method77 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method77;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method78(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method78: loop {
                break '_method78 ({
                    let v42: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        while Documents::method47(v20, v22.clone()) {
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
                                Documents::method70(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method69())(b0)(b1)
                                        }),
                                        v27,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US14::US14_0(
                                v8,
                                v15,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    };
                    match &v42 {
                        Documents::US14::US14_0(v42_0_0, v42_0_1, v42_0_2, v42_0_3, v42_0_4) => {
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
                            continue '_method78;
                        }
                        _ => Documents::US15::US15_0(
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
        pub fn method68(v0_1: string) -> Documents::US13 {
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
                fn v12(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US14 {
                    Documents::closure31((), arg10_0040)
                }
                fn v13(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US14 {
                    Documents::closure34((), arg10_0040_1)
                }
                let v17: Documents::US14 = Documents::method71(
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
                let v153: Documents::US15 = match &v17 {
                    Documents::US14::US14_0(v17_0_0, v17_0_1, v17_0_2, v17_0_3, v17_0_4) => {
                        let v22: i32 = v17_0_4.clone();
                        let v21: i32 = v17_0_3.clone();
                        let v20: LrcPtr<StringBuilder> = v17_0_2.clone();
                        let v19: string = v17_0_1.clone();
                        let v88: Documents::US14 = if string("") == v19.clone() {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v20.clone(), v21, v22)
                            ))
                        } else {
                            let v37: char = getCharAt(v19.clone(), 0_i32);
                            let v44: string =
                                getSlice(v19.clone(), Some(1_i32), Some(length(v19.clone())));
                            if Documents::method72(v37, 0_i64) == false {
                                let v49: string = ofChar(v37);
                                let v52: i32 = length(v49.clone());
                                let v53: Array<char> = new_init(&'\u{0000}', v52);
                                let v54: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method47(v52, v54.clone()) {
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
                                        Documents::method70(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method69())(b0)(b1)
                                                    },
                                                ),
                                                v59,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v20.clone(),
                                            v21,
                                            v22,
                                        );
                                    Documents::US14::US14_0(
                                        v37,
                                        v44,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US14::US14_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v37,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v20.clone(),
                                                                          v21,
                                                                          v22)))
                            }
                        };
                        let v100: Documents::US14 = match &v88 {
                            Documents::US14::US14_0(
                                v88_0_0,
                                v88_0_1,
                                v88_0_2,
                                v88_0_3,
                                v88_0_4,
                            ) => {
                                let v89: char = v88_0_0.clone();
                                Documents::US14::US14_0(
                                    if '\\' == v89 { '/' } else { v89 },
                                    v88_0_1.clone(),
                                    v88_0_2.clone(),
                                    v88_0_3.clone(),
                                    v88_0_4.clone(),
                                )
                            }
                            Documents::US14::US14_1(v88_1_0) => {
                                Documents::US14::US14_1(v88_1_0.clone())
                            }
                        };
                        let v114: Documents::US15 = match &v100 {
                            Documents::US14::US14_0(
                                v100_0_0,
                                v100_0_1,
                                v100_0_2,
                                v100_0_3,
                                v100_0_4,
                            ) => Documents::method73(
                                ofChar(v100_0_0.clone()),
                                v100_0_1.clone(),
                                v100_0_2.clone(),
                                v100_0_3.clone(),
                                v100_0_4.clone(),
                            ),
                            Documents::US14::US14_1(v100_1_0) => {
                                Documents::US15::US15_1(v100_1_0.clone())
                            }
                        };
                        let v124: Documents::US15 = match &v114 {
                            Documents::US15::US15_0(
                                v114_0_0,
                                v114_0_1,
                                v114_0_2,
                                v114_0_3,
                                v114_0_4,
                            ) => Documents::US15::US15_0(
                                v114_0_0.clone(),
                                v114_0_1.clone(),
                                v114_0_2.clone(),
                                v114_0_3.clone(),
                                v114_0_4.clone(),
                            ),
                            _ => Documents::US15::US15_0(
                                string(""),
                                v19.clone(),
                                v20.clone(),
                                v21,
                                v22,
                            ),
                        };
                        match &v124 {
                            Documents::US15::US15_0(
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
                                let v133: Documents::US14 = Documents::method74(
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
                                        Documents::US14::US14_0(v133_0_0,
                                                                v133_0_1,
                                                                v133_0_2,
                                                                v133_0_3,
                                                                v133_0_4) =>
                                        Documents::US15::US15_0(v124_0_0.clone(),
                                                                v133_0_1.clone(),
                                                                v133_0_2.clone(),
                                                                v133_0_3.clone(),
                                                                v133_0_4.clone()),
                                        Documents::US14::US14_1(v133_1_0) =>
                                        Documents::US15::US15_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
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
                            _ => Documents::US15::US15_1(string("between / expected content")),
                        }
                    }
                    Documents::US14::US14_1(v17_1_0) => Documents::US15::US15_1(v17_1_0.clone()),
                };
                let v303: Documents::US15 = match &v153 {
                    Documents::US15::US15_0(v153_0_0, v153_0_1, v153_0_2, v153_0_3, v153_0_4) => {
                        v153.clone()
                    }
                    _ => {
                        let v233: Documents::US14 = if string("") == v7.clone() {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v11.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v177: char = getCharAt(v7.clone(), 0_i32);
                            let v184: string =
                                getSlice(v7.clone(), Some(1_i32), Some(length(v7.clone())));
                            if Documents::method75(v177, 0_i64) == false {
                                let v189: string = ofChar(v177);
                                let v192: i32 = length(v189.clone());
                                let v193: Array<char> = new_init(&'\u{0000}', v192);
                                let v194: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method47(v192, v194.clone()) {
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
                                        Documents::method70(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method69())(b0)(b1)
                                                    },
                                                ),
                                                v199,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v11.clone(),
                                            1_i32,
                                            1_i32,
                                        );
                                    Documents::US14::US14_0(
                                        v177,
                                        v184,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                Documents::US14::US14_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v177,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v11.clone(),
                                                                          1_i32,
                                                                          1_i32)))
                            }
                        };
                        let v245: Documents::US14 = match &v233 {
                            Documents::US14::US14_0(
                                v233_0_0,
                                v233_0_1,
                                v233_0_2,
                                v233_0_3,
                                v233_0_4,
                            ) => {
                                let v234: char = v233_0_0.clone();
                                Documents::US14::US14_0(
                                    if '\\' == v234 { '/' } else { v234 },
                                    v233_0_1.clone(),
                                    v233_0_2.clone(),
                                    v233_0_3.clone(),
                                    v233_0_4.clone(),
                                )
                            }
                            Documents::US14::US14_1(v233_1_0) => {
                                Documents::US14::US14_1(v233_1_0.clone())
                            }
                        };
                        let v259: Documents::US15 = match &v245 {
                            Documents::US14::US14_0(
                                v245_0_0,
                                v245_0_1,
                                v245_0_2,
                                v245_0_3,
                                v245_0_4,
                            ) => Documents::method76(
                                ofChar(v245_0_0.clone()),
                                v245_0_1.clone(),
                                v245_0_2.clone(),
                                v245_0_3.clone(),
                                v245_0_4.clone(),
                            ),
                            Documents::US14::US14_1(v245_1_0) => {
                                Documents::US15::US15_1(v245_1_0.clone())
                            }
                        };
                        match &v259 {
                            Documents::US15::US15_0(
                                v259_0_0,
                                v259_0_1,
                                v259_0_2,
                                v259_0_3,
                                v259_0_4,
                            ) => v259.clone(),
                            _ => {
                                let v271: Documents::US17 = if length(v7.clone()) == 0_i32 {
                                    Documents::US17::US17_0(v7.clone(), v11.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US17::US17_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v7.clone()
                                    ))
                                };
                                let v280: Documents::US15 = match &v271 {
                                    Documents::US17::US17_0(
                                        v271_0_0,
                                        v271_0_1,
                                        v271_0_2,
                                        v271_0_3,
                                    ) => Documents::US15::US15_0(
                                        string(""),
                                        v271_0_0.clone(),
                                        v271_0_1.clone(),
                                        v271_0_2.clone(),
                                        v271_0_3.clone(),
                                    ),
                                    Documents::US17::US17_1(v271_1_0) => {
                                        Documents::US15::US15_1(v271_1_0.clone())
                                    }
                                };
                                match &v280 {
                                    Documents::US15::US15_0(
                                        v280_0_0,
                                        v280_0_1,
                                        v280_0_2,
                                        v280_0_3,
                                        v280_0_4,
                                    ) => {
                                        let v282: string = v280_0_1.clone();
                                        Documents::US15::US15_0(
                                            v280_0_0.clone(),
                                            getSlice(
                                                v282.clone(),
                                                Some(Documents::method77(v282.clone(), 0_i32)),
                                                Some(length(v282)),
                                            ),
                                            v280_0_2.clone(),
                                            v280_0_3.clone(),
                                            v280_0_4.clone(),
                                        )
                                    }
                                    Documents::US15::US15_1(v280_1_0) => {
                                        Documents::US15::US15_1(v280_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v471: Documents::US18 = match &v303 {
                    Documents::US15::US15_0(v303_0_0, v303_0_1, v303_0_2, v303_0_3, v303_0_4) => {
                        let v308: i32 = v303_0_4.clone();
                        let v307: i32 = v303_0_3.clone();
                        let v306: LrcPtr<StringBuilder> = v303_0_2.clone();
                        let v305: string = v303_0_1.clone();
                        let v372: Documents::US14 = if string("") == v305.clone() {
                            Documents::US14::US14_1(sprintf!(
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
                                while Documents::method47(v325, v327.clone()) {
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
                                        Documents::method70(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method69())(b0)(b1)
                                                    },
                                                ),
                                                v332,
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            ),
                                            v306.clone(),
                                            v307,
                                            v308,
                                        );
                                    Documents::US14::US14_0(
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
                                Documents::US14::US14_1(sprintf!("{}\n{}\n",
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
                        let v384: Documents::US19 = match &v372 {
                            Documents::US14::US14_0(
                                v372_0_0,
                                v372_0_1,
                                v372_0_2,
                                v372_0_3,
                                v372_0_4,
                            ) => Documents::US19::US19_0(
                                Documents::US16::US16_0(v372_0_0.clone()),
                                v372_0_1.clone(),
                                v372_0_2.clone(),
                                v372_0_3.clone(),
                                v372_0_4.clone(),
                            ),
                            _ => Documents::US19::US19_0(
                                Documents::US16::US16_1,
                                v305.clone(),
                                v306.clone(),
                                v307,
                                v308,
                            ),
                        };
                        let v445: Documents::US15 = match &v384 {
                            Documents::US19::US19_0(
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
                                let v427: Documents::US14 = if string("") == v386.clone() {
                                    Documents::US14::US14_1(sprintf!(
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
                                    while Documents::method47(v405, v407.clone()) {
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
                                                        Documents::method70(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method69())(b0)(b1)),
                                                                                     v412,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v387,
                                                                            v388,
                                                                            v389);
                                        Documents::US14::US14_0(
                                            v393,
                                            v400,
                                            patternInput_3.0.clone(),
                                            patternInput_3.1.clone(),
                                            patternInput_3.2.clone(),
                                        )
                                    }
                                };
                                match &v427 {
                                    Documents::US14::US14_0(
                                        v427_0_0,
                                        v427_0_1,
                                        v427_0_2,
                                        v427_0_3,
                                        v427_0_4,
                                    ) => Documents::method78(
                                        ofChar(v427_0_0.clone()),
                                        v427_0_1.clone(),
                                        v427_0_2.clone(),
                                        v427_0_3.clone(),
                                        v427_0_4.clone(),
                                    ),
                                    Documents::US14::US14_1(v427_1_0) => {
                                        Documents::US15::US15_1(v427_1_0.clone())
                                    }
                                }
                            }
                            Documents::US19::US19_1(v384_1_0) => {
                                Documents::US15::US15_1(v384_1_0.clone())
                            }
                        };
                        let v457: Documents::US20 = match &v445 {
                            Documents::US15::US15_0(
                                v445_0_0,
                                v445_0_1,
                                v445_0_2,
                                v445_0_3,
                                v445_0_4,
                            ) => Documents::US20::US20_0(
                                Documents::US1::US1_0(v445_0_0.clone()),
                                v445_0_1.clone(),
                                v445_0_2.clone(),
                                v445_0_3.clone(),
                                v445_0_4.clone(),
                            ),
                            _ => Documents::US20::US20_0(
                                Documents::US1::US1_1,
                                v305,
                                v306,
                                v307,
                                v308,
                            ),
                        };
                        match &v457 {
                            Documents::US20::US20_0(
                                v457_0_0,
                                v457_0_1,
                                v457_0_2,
                                v457_0_3,
                                v457_0_4,
                            ) => Documents::US18::US18_0(
                                v303_0_0.clone(),
                                v457_0_0.clone(),
                                v457_0_1.clone(),
                                v457_0_2.clone(),
                                v457_0_3.clone(),
                                v457_0_4.clone(),
                            ),
                            Documents::US20::US20_1(v457_1_0) => {
                                Documents::US18::US18_1(v457_1_0.clone())
                            }
                        }
                    }
                    Documents::US15::US15_1(v303_1_0) => Documents::US18::US18_1(v303_1_0.clone()),
                };
                match &v471 {
                    Documents::US18::US18_0(
                        v471_0_0,
                        v471_0_1,
                        v471_0_2,
                        v471_0_3,
                        v471_0_4,
                        v471_0_5,
                    ) => Documents::US13::US13_0(v471_0_0.clone(), v471_0_1.clone()),
                    Documents::US18::US18_1(v471_1_0) => Documents::US13::US13_1(v471_1_0.clone()),
                }
            }
        }
        pub fn method81(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method81: loop {
                break '_method81 (if v1_1.get().clone() >= 4_i64 {
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
                        continue '_method81;
                    }
                });
            }
        }
        pub fn method82(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method82: loop {
                break '_method82 ({
                    let v82: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        if Documents::method81(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method47(v40, v42.clone()) {
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
                                    Documents::method70(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method69())(b0)(b1)
                                                },
                                            ),
                                            v47,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v25,
                                    v32,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v82 {
                        Documents::US14::US14_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
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
                            continue '_method82;
                        }
                        _ => Documents::US15::US15_0(
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
        pub fn method84(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method84: loop {
                break '_method84 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method84;
                    }
                });
            }
        }
        pub fn closure35(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v67: Documents::US14 = if string("") == v0_1.clone() {
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
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method47(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method70(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method69())(b0)(b1)
                                }),
                                v27,
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
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v114: Documents::US14 = match &v67 {
                Documents::US14::US14_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                    let v72: i32 = v67_0_4.clone();
                    let v71: i32 = v67_0_3.clone();
                    let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                    let v69: string = v67_0_1.clone();
                    if string("") == v69.clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        while Documents::method47(v88, v90.clone()) {
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
                                Documents::method70(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method69())(b0)(b1)
                                        }),
                                        v95,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v70,
                                    v71,
                                    v72,
                                );
                            Documents::US14::US14_0(
                                v76,
                                v83,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v67_1_0) => Documents::US14::US14_1(v67_1_0.clone()),
            };
            match &v114 {
                Documents::US14::US14_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                    Documents::US15::US15_0(
                        sprintf!("{}{}", '\\', v114_0_0.clone()),
                        v114_0_1.clone(),
                        v114_0_2.clone(),
                        v114_0_3.clone(),
                        v114_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v114_1_0) => Documents::US15::US15_1(v114_1_0.clone()),
            }
        }
        pub fn closure36(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v67: Documents::US14 = if string("") == v0_1.clone() {
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
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method47(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method70(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method69())(b0)(b1)
                                }),
                                v27,
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
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
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
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v114: Documents::US14 = match &v67 {
                Documents::US14::US14_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                    let v72: i32 = v67_0_4.clone();
                    let v71: i32 = v67_0_3.clone();
                    let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                    let v69: string = v67_0_1.clone();
                    if string("") == v69.clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        while Documents::method47(v88, v90.clone()) {
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
                                Documents::method70(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method69())(b0)(b1)
                                        }),
                                        v95,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v70,
                                    v71,
                                    v72,
                                );
                            Documents::US14::US14_0(
                                v76,
                                v83,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v67_1_0) => Documents::US14::US14_1(v67_1_0.clone()),
            };
            match &v114 {
                Documents::US14::US14_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                    Documents::US15::US15_0(
                        sprintf!("{}{}", '`', v114_0_0.clone()),
                        v114_0_1.clone(),
                        v114_0_2.clone(),
                        v114_0_3.clone(),
                        v114_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v114_1_0) => Documents::US15::US15_1(v114_1_0.clone()),
            }
        }
        pub fn method85(
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
            '_method85: loop {
                break '_method85 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US15::US15_1(string("choice / no parsers succeeded"))
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
                                continue '_method85;
                            }
                        }
                    }
                });
            }
        }
        pub fn method86(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method86: loop {
                break '_method86 (match v0_1.get().clone().as_ref() {
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
                        continue '_method86;
                    }
                });
            }
        }
        pub fn method83(
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
            '_method83: loop {
                break '_method83 ({
                    let v76: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        if Documents::method84(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method47(v37, v39.clone()) {
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
                                    Documents::method70(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method69())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v90: Documents::US15 = match &v76 {
                        Documents::US14::US14_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                            Documents::US15::US15_0(
                                ofChar(v76_0_0.clone()),
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v76_1_0) => {
                            Documents::US15::US15_1(v76_1_0.clone())
                        }
                    };
                    let v104: Documents::US15 = match &v90 {
                        Documents::US15::US15_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => {
                            v90.clone()
                        }
                        _ => Documents::method85(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure35((), arg10_0040)
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
                                            Documents::closure36((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v104 {
                        Documents::US15::US15_0(
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
                            continue '_method83;
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method86(
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
        pub fn method87(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method87(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method88(
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
            '_method88: loop {
                break '_method88 ({
                    let v76: Documents::US14 = if string("") == v1_1.get().clone() {
                        Documents::US14::US14_1(sprintf!(
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
                        if Documents::method84(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method47(v37, v39.clone()) {
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
                                    Documents::method70(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method69())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v90: Documents::US15 = match &v76 {
                        Documents::US14::US14_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                            Documents::US15::US15_0(
                                ofChar(v76_0_0.clone()),
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v76_1_0) => {
                            Documents::US15::US15_1(v76_1_0.clone())
                        }
                    };
                    match &v90 {
                        Documents::US15::US15_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => {
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
                            continue '_method88;
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method86(
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
        pub fn method89(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method89: loop {
                break '_method89 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method89;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method80(
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
            '_method80: loop {
                break '_method80 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v82: Documents::US14 = if v5 {
                        Documents::US14::US14_1(sprintf!(
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
                        if Documents::method81(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method47(v40, v42.clone()) {
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
                                    Documents::method70(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method69())(b0)(b1)
                                                },
                                            ),
                                            v47,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Documents::US14::US14_0(
                                    v25,
                                    v32,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v96: Documents::US15 = match &v82 {
                        Documents::US14::US14_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                            Documents::method82(
                                ofChar(v82_0_0.clone()),
                                v82_0_1.clone(),
                                v82_0_2.clone(),
                                v82_0_3.clone(),
                                v82_0_4.clone(),
                            )
                        }
                        Documents::US14::US14_1(v82_1_0) => {
                            Documents::US15::US15_1(v82_1_0.clone())
                        }
                    };
                    let v341: Documents::US15 = match &v96 {
                        Documents::US15::US15_0(v96_0_0, v96_0_1, v96_0_2, v96_0_3, v96_0_4) => {
                            v96.clone()
                        }
                        _ => {
                            let v165: Documents::US14 = if v5 {
                                Documents::US14::US14_1(sprintf!(
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
                                    while Documents::method47(v118, v120.clone()) {
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
                                                             Documents::method70(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method69())(b0)(b1)),
                                                                                          v125,
                                                                                          LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                 v2.get().clone(),
                                                                                 v3.get().clone(),
                                                                                 v4.get().clone());
                                        Documents::US14::US14_0(
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
                            let v282: Documents::US15 = match &v165 {
                                Documents::US14::US14_0(
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
                                    let v172: Documents::US22 = Documents::method83(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v167.clone(),
                                        v168.clone(),
                                        v169,
                                        v170,
                                    );
                                    let v193: Documents::US15 = match &v172 {
                                        Documents::US22::US22_0(
                                            v172_0_0,
                                            v172_0_1,
                                            v172_0_2,
                                            v172_0_3,
                                            v172_0_4,
                                        ) => {
                                            let v179: List<string> = Documents::method87(
                                                v172_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US15::US15_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v179 = v179.clone();
                                                        move || {
                                                            map_1(
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
                                        Documents::US22::US22_1(v172_1_0) => {
                                            Documents::US15::US15_1(v172_1_0.clone())
                                        }
                                    };
                                    match &v193 {
                                        Documents::US15::US15_0(
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
                                            let v262: Documents::US14 = if string("")
                                                == v195.clone()
                                            {
                                                Documents::US14::US14_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                    while Documents::method47(v215, v217.clone()) {
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
                                                                                 Documents::method70(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method69())(b0)(b1)),
                                                                                                              v222,
                                                                                                              LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                     v196.clone(),
                                                                                                     v197,
                                                                                                     v198);
                                                        Documents::US14::US14_0(
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
                                                    Documents::US14::US14_1(sprintf!("{}\n{}\n",
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
                                                                 Documents::US14::US14_0(v262_0_0,
                                                                                         v262_0_1,
                                                                                         v262_0_2,
                                                                                         v262_0_3,
                                                                                         v262_0_4)
                                                                 =>
                                                                 Documents::US15::US15_0(v193_0_0.clone(),
                                                                                         v262_0_1.clone(),
                                                                                         v262_0_2.clone(),
                                                                                         v262_0_3.clone(),
                                                                                         v262_0_4.clone()),
                                                                 Documents::US14::US14_1(v262_1_0)
                                                                 =>
                                                                 Documents::US15::US15_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
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
                                        _ => Documents::US15::US15_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Documents::US14::US14_1(v165_1_0) => {
                                    Documents::US15::US15_1(v165_1_0.clone())
                                }
                            };
                            match &v282 {
                                Documents::US15::US15_0(
                                    v282_0_0,
                                    v282_0_1,
                                    v282_0_2,
                                    v282_0_3,
                                    v282_0_4,
                                ) => v282.clone(),
                                _ => {
                                    let v294: Documents::US15 =
                                                     Documents::method85(v1_1.get().clone(),
                                                                         v2.get().clone(),
                                                                         v3.get().clone(),
                                                                         v4.get().clone(),
                                                                         LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                          |arg10_0040:
                                                                                                                               (string,
                                                                                                                                LrcPtr<StringBuilder>,
                                                                                                                                i32,
                                                                                                                                i32)|
                                                                                                                          Documents::closure35((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure36((),
                                                                                                                                                                                 arg10_0040_1)),
                                                                                                                                             LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v305: Documents::US15 = match &v294 {
                                        Documents::US15::US15_0(
                                            v294_0_0,
                                            v294_0_1,
                                            v294_0_2,
                                            v294_0_3,
                                            v294_0_4,
                                        ) => Documents::US15::US15_0(
                                            string(""),
                                            v294_0_1.clone(),
                                            v294_0_2.clone(),
                                            v294_0_3.clone(),
                                            v294_0_4.clone(),
                                        ),
                                        Documents::US15::US15_1(v294_1_0) => {
                                            Documents::US15::US15_1(v294_1_0.clone())
                                        }
                                    };
                                    let v316: Documents::US22 = match &v305 {
                                        Documents::US15::US15_0(
                                            v305_0_0,
                                            v305_0_1,
                                            v305_0_2,
                                            v305_0_3,
                                            v305_0_4,
                                        ) => Documents::method88(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v305_0_1.clone(),
                                            v305_0_2.clone(),
                                            v305_0_3.clone(),
                                            v305_0_4.clone(),
                                        ),
                                        Documents::US15::US15_1(v305_1_0) => {
                                            Documents::US22::US22_1(v305_1_0.clone())
                                        }
                                    };
                                    match &v316 {
                                        Documents::US22::US22_0(
                                            v316_0_0,
                                            v316_0_1,
                                            v316_0_2,
                                            v316_0_3,
                                            v316_0_4,
                                        ) => {
                                            let v323: List<string> = Documents::method87(
                                                v316_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US15::US15_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v323 = v323.clone();
                                                        move || {
                                                            map_1(
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
                                        Documents::US22::US22_1(v316_1_0) => {
                                            Documents::US15::US15_1(v316_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v341 {
                        Documents::US15::US15_0(
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
                            let v352: i32 = Documents::method89(v347.clone(), 0_i32);
                            let v364: Documents::US17 = if 0_i32 == v352 {
                                Documents::US17::US17_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US17::US17_0(
                                    getSlice(v347.clone(), Some(v352), Some(length(v347.clone()))),
                                    v348.clone(),
                                    v349,
                                    v350,
                                )
                            };
                            match &v364 {
                                Documents::US17::US17_0(v364_0_0, v364_0_1, v364_0_2, v364_0_3) => {
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
                                    continue '_method80;
                                }
                                _ => Documents::US22::US22_0(
                                    Documents::method86(
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
                        _ => Documents::US22::US22_0(
                            Documents::method86(
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
        pub fn method79(v0_1: string) -> Documents::US21 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v15: Documents::US22 = Documents::method80(
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
                    Documents::US22::US22_0(v15_0_0, v15_0_1, v15_0_2, v15_0_3, v15_0_4) => {
                        Documents::US21::US21_0(toArray(Documents::method87(
                            v15_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US22::US22_1(v15_1_0) => Documents::US21::US21_1(v15_1_0.clone()),
                }
            }
        }
        pub fn method91(
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
                l0: MutCell::new(Documents::method14()),
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
            let v195: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v165)),
                    (),
                );
                ()
            };
            let v203: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v212: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v220: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v231: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
                ()
            };
            let v239: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v248: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v256: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v261: std::string::String = format!("{:#?}", v5);
            let v291: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v261)),
                    (),
                );
                ()
            };
            let v299: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v308: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v316: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v321: std::string::String = format!("{:#?}", v6);
            let v351: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v321)),
                    (),
                );
                ()
            };
            let v359: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v368: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v376: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v387: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v395: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v404: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("working_directory")), ());
                ()
            };
            let v412: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v417: std::string::String = format!("{:#?}", v8);
            let v447: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v417)),
                    (),
                );
                ()
            };
            let v456: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v464: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method90(
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
            let v17: string = Documents::method91(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options"),
                v17
            ))
        }
        pub fn closure37(
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
            if Documents::method7(Documents::US0::US0_1) {
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
                Documents::method19(Documents::method90(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method49(),
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
        pub fn closure38(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method92() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure38((), v))
        }
        pub fn closure39(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method93(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US23>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure39((), v)
                },
            )
        }
        pub fn closure40(unitVar: (), v0_1: std::string::String) -> Documents::US23 {
            Documents::US23::US23_1(v0_1)
        }
        pub fn method94() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure40((), v))
        }
        pub fn method95(
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
            let v9: string = Documents::method61(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v9
            ))
        }
        pub fn closure41(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
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
                Documents::method19(Documents::method95(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method59(),
                    v0_1,
                ))
            };
        }
        pub fn method96(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure42(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method97(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method98() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure43((), v)
            })
        }
        pub fn method99() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure43((), v)
            })
        }
        pub fn closure44(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method100() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure44((), v)
                },
            )
        }
        pub fn closure45(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_0(v0_1)
        }
        pub fn method101() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure45((), v))
        }
        pub fn closure46(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_1(v0_1)
        }
        pub fn method102() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure46((), v))
        }
        pub fn method104(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string("e")), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v62: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method103(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: std::string::String,
        ) -> string {
            let v10: string = Documents::method104(v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v10
            ))
        }
        pub fn closure47(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
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
                Documents::method19(Documents::method103(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method59(),
                    string("runtime.stdio_line"),
                    v0_1,
                ))
            };
        }
        pub fn method105() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v32: &str = inline_colorization::color_reset;
            let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
            fable_library_rust::String_::fromString(v34)
        }
        pub fn method107() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            v1_1.l0.get().clone()
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
        ) -> string {
            let v9: string = Documents::method107();
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure48(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
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
                Documents::method19(if v0_1.clone() == string("") {
                    string("")
                } else {
                    Documents::method106(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Documents::method8(v19, v20, v21, v22, v23, v24),
                        Documents::method105(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure49(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method108(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure49((), v)
            })
        }
        pub fn method109(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure50(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn method110() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US26,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure50((), v)
                },
            )
        }
        pub fn method111(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure51(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method112(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US27>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure51((), v)
                },
            )
        }
        pub fn method113(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method114(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure52(unitVar: (), v0_1: std::process::Output) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn closure53(unitVar: (), v0_1: std::string::String) -> Documents::US28 {
            Documents::US28::US28_1(v0_1)
        }
        pub fn method115(
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
            let v9: string = Documents::method61(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v9
            ))
        }
        pub fn closure54(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
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
                Documents::method19(Documents::method115(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method59(),
                    v0_1,
                ))
            };
        }
        pub fn closure55(unitVar: (), v0_1: i32) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method116() -> Func1<i32, Documents::US29> {
            Func1::new(move |v: i32| Documents::closure55((), v))
        }
        pub fn method118(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method117(
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
            let v10: string = Documents::method118(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure56(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
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
                Documents::method19(Documents::method117(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method8(v20, v21, v22, v23, v24, v25),
                    Documents::method105(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method121(
            v0_1: string,
            v1_1: Documents::US1,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            let v198: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v168)),
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
            let v294: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v264)),
                    (),
                );
                ()
            };
            let v302: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v311: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v319: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v324: std::string::String = format!("{:#?}", v6);
            let v354: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v324)),
                    (),
                );
                ()
            };
            let v362: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v379: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v390: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v398: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v407: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string("working_directory")), ());
                ()
            };
            let v415: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v420: std::string::String = format!("{:#?}", v8);
            let v450: () = {
                Documents::closure8(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v420)),
                    (),
                );
                ()
            };
            let v459: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v467: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method120(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: Documents::US1,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method121(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
            ))
        }
        pub fn closure57(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: Documents::US1,
            v8: string,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
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
                Documents::method19(Documents::method120(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method49(),
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
        pub fn closure59(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method122() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US30> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure59((), v)
            })
        }
        pub fn closure60(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
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
                Documents::method19(if v0_1.clone() == string("") {
                    string("")
                } else {
                    Documents::method106(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Documents::method8(v19, v20, v21, v22, v23, v24),
                        Documents::method105(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure58(
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
        pub fn closure62(unitVar: (), v0_1: CancellationToken) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method123() -> Func1<CancellationToken, Documents::US31> {
            Func1::new(move |v: CancellationToken| Documents::closure62((), v))
        }
        pub fn closure63(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn method125(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            let v62: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method124(
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
            let v9: string = Documents::method125(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure64(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
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
                Documents::method19(Documents::method124(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method35(),
                    v0_1,
                ))
            };
        }
        pub fn method127(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method126(
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
            let v10: string = Documents::method127(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v10
            ))
        }
        pub fn closure65(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
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
                Documents::method19(Documents::method126(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method8(v20, v21, v22, v23, v24, v25),
                    Documents::method49(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method119(
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
        pub fn method66(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Documents::US13 = Documents::method68(Documents::method67(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US1) = match &v9 {
                Documents::US13::US13_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Documents::US13::US13_1(v9_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v9_1_0.clone()),
                ),
            };
            let v19: Documents::US1 = patternInput.1.clone();
            let v18: string = patternInput.0.clone();
            let v24: Documents::US21 = Documents::method79(match &v19 {
                Documents::US1::US1_0(v19_0_0) => match &v19 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            });
            let v30: Array<string> = match &v24 {
                Documents::US21::US21_0(v24_0_0) => v24_0_0.clone(),
                Documents::US21::US21_1(v24_1_0) => panic!(
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
                    let v39: &str = &*v36;
                    let v60: std::string::String = String::from(v39);
                    let v80: bool = true;
                    v60
                })
                .collect::<Vec<_>>();
            let v82: Vec<std::string::String> = _vec_map;
            let v85: () = {
                Documents::closure37(
                    v0_1,
                    v1_1,
                    v2.clone(),
                    v3,
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v18.clone(),
                    v82.clone(),
                    (),
                );
                ()
            };
            let _v128: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_3: LrcPtr<(i32, string)> = (Func0::new({
                    let v18 = v18.clone();
                    let v2 = v2.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v82 = v82.clone();
                    move || {
                        let v130: std::process::Command = std::process::Command::new(&*v18.clone());
                        let v132: bool = true;
                        let mut v130 = v130;
                        let v134: &mut std::process::Command =
                            std::process::Command::args(&mut v130, &*v82.clone());
                        let v136: std::process::Stdio = std::process::Stdio::piped();
                        let v138: &mut std::process::Command =
                            std::process::Command::stdout(v134, std::process::Stdio::piped());
                        let v140: std::process::Stdio = std::process::Stdio::piped();
                        let v142: &mut std::process::Command =
                            std::process::Command::stderr(v138, std::process::Stdio::piped());
                        let v144: std::process::Stdio = std::process::Stdio::piped();
                        let v146: &mut std::process::Command =
                            std::process::Command::stdin(v142, std::process::Stdio::piped());
                        let v160: Documents::US1 = defaultValue(
                            Documents::US1::US1_1,
                            map(Documents::method5(), v6.clone()),
                        );
                        let v168: &mut std::process::Command = match &v160 {
                            Documents::US1::US1_0(v160_0_0) => std::process::Command::current_dir(
                                v146,
                                &*match &v160 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            ),
                            _ => v146,
                        };
                        let v186: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v168
                        } else {
                            let v172: Vec<(string, string)> = v2.clone().to_vec();
                            let v174: bool = true;
                            let _vec_fold_ = v172.into_iter().fold(v168, |acc, x| {
                                //;
                                let v176: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v181: &mut std::process::Command = std::process::Command::env(
                                    v176,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v183: bool = true;
                                v181
                            });
                            _vec_fold_
                        };
                        let v188: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v186);
                        let v189 = Documents::method53();
                        let v192: Result<std::process::Child, std::string::String> =
                            v188.map_err(|x| v189(x));
                        let v203 = Documents::method92();
                        let v205: bool = true;
                        let _result_map_ = v192.map(|x| {
                            //;
                            let v211: Option<std::process::Child> = v203(Some(x));
                            let v213: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v211);
                            let v215: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v213);
                            let v217: bool = true;
                            v215
                        });
                        let v219: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v220 = Documents::method93();
                        let v221 = Documents::method94();
                        let v223: Documents::US23 = match v219 {
                            Ok(x) => v220(x),
                            Err(e) => v221(e),
                        };
                        let patternInput_3: (i32, Documents::US4, Documents::US24) = match &v223 {
                            Documents::US23::US23_0(v223_0_0) => {
                                let v224: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v223_0_0.clone();
                                let v226: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v228: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v224.clone();
                                    let v230: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v228.lock();
                                    let v244: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method96(v230.unwrap());
                                    let v246: bool = true;
                                    let mut v244 = v244;
                                    let v248: &mut Option<std::process::Child> = &mut v244;
                                    let v250: Option<&mut std::process::Child> = v248.as_mut();
                                    let v252: &mut std::process::Child = v250.unwrap();
                                    let v254: &mut Option<std::process::ChildStdout> =
                                        &mut v252.stdout;
                                    let v256: Option<std::process::ChildStdout> =
                                        Option::take(v254);
                                    let v258: std::process::ChildStdout = v256.unwrap();
                                    let v260: bool = true;
                                    v258
                                })();
                                let v262: std::process::ChildStdout = _capture;
                                let v264: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v266: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v224.clone();
                                    let v268: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v266.lock();
                                    let v282: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method96(v268.unwrap());
                                    let v284: bool = true;
                                    let mut v282 = v282;
                                    let v286: &mut Option<std::process::Child> = &mut v282;
                                    let v288: Option<&mut std::process::Child> = v286.as_mut();
                                    let v290: &mut std::process::Child = v288.unwrap();
                                    let v292: &mut Option<std::process::ChildStderr> =
                                        &mut v290.stderr;
                                    let v294: Option<std::process::ChildStderr> =
                                        Option::take(v292);
                                    let v296: std::process::ChildStderr = v294.unwrap();
                                    let v298: bool = true;
                                    v296
                                })();
                                let v300: std::process::ChildStderr = _capture;
                                let v302: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v304: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v224.clone();
                                    let v306: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v304.lock();
                                    let v320: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method96(v306.unwrap());
                                    let v322: bool = true;
                                    let mut v320 = v320;
                                    let v324: &mut Option<std::process::Child> = &mut v320;
                                    let v326: Option<&mut std::process::Child> = v324.as_mut();
                                    let v328: &mut std::process::Child = v326.unwrap();
                                    let v330: &mut Option<std::process::ChildStdin> =
                                        &mut v328.stdin;
                                    let v332: Option<std::process::ChildStdin> = Option::take(v330);
                                    let v334: std::process::ChildStdin = v332.unwrap();
                                    let v339: Option<std::process::ChildStdin> =
                                        (Documents::method97())(Some(v334));
                                    let v341: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v339);
                                    let v343: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v341);
                                    let v345: bool = true;
                                    v343
                                })();
                                let v347: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v349: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v352: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method98())(v349.clone());
                                let v354: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v352);
                                let v356: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v354);
                                let v358: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method99())(v349);
                                let v360: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v358);
                                let v362: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v360);
                                let v364: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method100())(patternInput_2.1.clone());
                                let v366: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v364);
                                let v368: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v366);
                                let v370: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v372: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v262);
                                    let v374: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v372);
                                    let v376: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v374);
                                    let v378: bool = true;
                                    let mut v376 = v376;
                                    let _iter_try_for_each = v376.try_for_each(|x| {
                                        //;
                                        let v380: Result<std::string::String, std::io::Error> = x;
                                        let v382: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v356.clone();
                                        let v383 = Documents::method53();
                                        let v386: Result<std::string::String, std::string::String> =
                                            v380.map_err(|x| v383(x));
                                        let v397 = Documents::method101();
                                        let v398 = Documents::method102();
                                        let v400: Documents::US25 = match v386 {
                                            Ok(x) => v397(x),
                                            Err(e) => v398(e),
                                        };
                                        let v589: std::string::String = match &v400 {
                                            Documents::US25::US25_0(v400_0_0) => {
                                                let v403: string =
                                                    fable_library_rust::String_::fromString(
                                                        v400_0_0.clone(),
                                                    );
                                                let v405: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v407: std::borrow::Cow<[u8]> =
                                                    v405.encode(&*v403).0;
                                                let v409: &[u8] = v407.as_ref();
                                                let v411: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v409);
                                                let v414: &str = v411.unwrap();
                                                let v441: std::string::String = String::from(v414);
                                                let v448: string = sprintf!(
                                                    "> {}",
                                                    fable_library_rust::String_::fromString(
                                                        v441.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v451: () = {
                                                        Documents::closure48(v448.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v496: () = {
                                                        Documents::closure11(v448, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v441
                                            }
                                            Documents::US25::US25_1(v400_1_0) => {
                                                let v498: std::string::String = v400_1_0.clone();
                                                let v501: () = {
                                                    Documents::closure47(v498.clone(), ());
                                                    ()
                                                };
                                                let v545: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v498);
                                                let v548: &str = &*v545;
                                                String::from(v548)
                                            }
                                        };
                                        let v591: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v382;
                                        let v593: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v591.lock();
                                        let v596: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v593.unwrap();
                                        let v608: &std::sync::mpsc::Sender<std::string::String> =
                                            &v596;
                                        let v610: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v608.send(v589);
                                        let v611 = Documents::method108();
                                        let v614: Result<(), std::string::String> =
                                            v610.map_err(|x| v611(x));
                                        let v626: _ = v614;
                                        let v628: bool = true;
                                        v626
                                    }); //;
                                    let v631: Result<(), string> = Documents::method109(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v634: string = string("}");
                                    let v638: bool = true;
                                    let v635 = v631;
                                    let v649: string = append(
                                        append(
                                            append(
                                                append(string("true; v635 "), v634),
                                                string("); "),
                                            ),
                                            string(""),
                                        ),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v650: bool = true;
                                    v635
                                }); // rust.fix_closure';
                                let v652: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v654: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v656: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v300);
                                    let v658: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v656);
                                    let v660: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v658);
                                    let v662: bool = true;
                                    let mut v660 = v660;
                                    let _iter_try_for_each = v660.try_for_each(|x| {
                                        //;
                                        let v664: Result<std::string::String, std::io::Error> = x;
                                        let v666: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v362.clone();
                                        let v667 = Documents::method53();
                                        let v670: Result<std::string::String, std::string::String> =
                                            v664.map_err(|x| v667(x));
                                        let v681 = Documents::method101();
                                        let v682 = Documents::method102();
                                        let v684: Documents::US25 = match v670 {
                                            Ok(x) => v681(x),
                                            Err(e) => v682(e),
                                        };
                                        let v914: std::string::String = match &v684 {
                                            Documents::US25::US25_0(v684_0_0) => {
                                                let v687: string =
                                                    fable_library_rust::String_::fromString(
                                                        v684_0_0.clone(),
                                                    );
                                                let v689: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v691: std::borrow::Cow<[u8]> =
                                                    v689.encode(&*v687).0;
                                                let v693: &[u8] = v691.as_ref();
                                                let v695: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v693);
                                                let v698: &str = v695.unwrap();
                                                let v725: std::string::String = String::from(v698);
                                                let v732: string = sprintf!(
                                                    "! {}",
                                                    fable_library_rust::String_::fromString(
                                                        v725.clone()
                                                    )
                                                );
                                                if v5 {
                                                    let v735: () = {
                                                        Documents::closure48(v732.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v779: () = {
                                                        Documents::closure11(v732, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v781: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v725
                                                    );
                                                    let v784: &str = &*v781;
                                                    String::from(v784)
                                                }
                                            }
                                            Documents::US25::US25_1(v684_1_0) => {
                                                let v824: std::string::String = v684_1_0.clone();
                                                let v827: () = {
                                                    Documents::closure47(v824.clone(), ());
                                                    ()
                                                };
                                                let v870: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v824);
                                                let v873: &str = &*v870;
                                                String::from(v873)
                                            }
                                        };
                                        let v916: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v666;
                                        let v918: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v916.lock();
                                        let v921: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v918.unwrap();
                                        let v933: &std::sync::mpsc::Sender<std::string::String> =
                                            &v921;
                                        let v935: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v933.send(v914);
                                        let v936 = Documents::method108();
                                        let v939: Result<(), std::string::String> =
                                            v935.map_err(|x| v936(x));
                                        let v951: _ = v939;
                                        let v953: bool = true;
                                        v951
                                    }); //;
                                    let v956: Result<(), string> = Documents::method109(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v957: string = string("}");
                                    let v961: bool = true;
                                    let v958 = v956;
                                    let v972: string = append(
                                        append(
                                            append(
                                                append(string("true; v958 "), v957),
                                                string("); "),
                                            ),
                                            string(""),
                                        ),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v973: bool = true;
                                    v958
                                }); // rust.fix_closure';
                                let v975: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v989: Documents::US26 = defaultValue(
                                    Documents::US26::US26_1,
                                    map(Documents::method110(), v4.clone()),
                                );
                                match &v989 {
                                    Documents::US26::US26_0(v989_0_0) => {
                                        let v995: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v347;
                                        let v997: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v995.lock();
                                        let v1011: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method111(v997.unwrap());
                                        let v1013: bool = true;
                                        let mut v1011 = v1011;
                                        let v1015: &mut Option<std::process::ChildStdin> =
                                            &mut v1011;
                                        let v1017: Option<std::process::ChildStdin> =
                                            Option::take(v1015);
                                        let v1019: bool = true;
                                        let _optionm_map_ = v1017.map(|x| {
                                            //;
                                            let v1021: std::process::ChildStdin = x;
                                            let v1023: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v1021);
                                            let v1025: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v1023);
                                            let v1027: bool = true;
                                            v1025
                                        });
                                        let v1029: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v1043: Documents::US27 = defaultValue(
                                            Documents::US27::US27_1,
                                            map(Documents::method112(), v1029),
                                        );
                                        match &v1043 {
                                            Documents::US27::US27_0(v1043_0_0) => {
                                                let v1047: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v1043 {
                                                    Documents::US27::US27_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                (match &v989 {
                                                    Documents::US26::US26_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v1047.clone()
                                                );
                                                {
                                                    let v1049: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v1047;
                                                    let v1051: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v1049.lock();
                                                    let v1065: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method113(v1051.unwrap());
                                                    let v1067: bool = true;
                                                    let mut v1065 = v1065;
                                                    let v1069: bool = true;
                                                    std::io::Write::flush(&mut *v1065).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v1071: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v224;
                                    let v1073: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1071.lock();
                                    let v1087: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method96(v1073.unwrap());
                                    let v1089: bool = true;
                                    let mut v1087 = v1087;
                                    let v1091: &mut Option<std::process::Child> = &mut v1087;
                                    let v1093: Option<std::process::Child> = Option::take(v1091);
                                    let v1095: std::process::Child = v1093.unwrap();
                                    let v1097: Result<std::process::Output, std::io::Error> =
                                        v1095.wait_with_output();
                                    let v1098 = Documents::method53();
                                    let v1109: Result<std::process::Output, std::string::String> =
                                        v1097.map_err(|x| v1098(x));
                                    let v1112: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method114(v975);
                                    let v1115: string = string("v1112");
                                    let v1116: std::thread::JoinHandle<Result<(), string>> =
                                        Documents::method114(v652);
                                    let v1121: string = append(
                                        append(string("vec!["), append(string("v1116, "), v1115)),
                                        string("]"),
                                    );
                                    let v1122: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v1116, v1112];
                                    let v1124: bool = true;
                                    v1122.into_iter().for_each(|x| {
                                        //;
                                        let v1126: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v1128: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v1126);
                                        let v1131: Result<(), string> = v1128.unwrap();
                                        v1131.unwrap();
                                        ();
                                        {
                                            let v1147: bool = true;
                                            let v1149: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v1152: Documents::US28 = match &v1109 {
                                            Err(v1109_1_0) => {
                                                Documents::closure53((), v1109_1_0.clone())
                                            }
                                            Ok(v1109_0_0) => {
                                                Documents::closure52((), v1109_0_0.clone())
                                            }
                                        };
                                        match &v1152 {
                                            Documents::US28::US28_0(v1152_0_0) => {
                                                let v1155: std::process::ExitStatus =
                                                    v1152_0_0.clone().status;
                                                let v1157: Option<i32> = v1155.code();
                                                let v1171: Documents::US29 = defaultValue(
                                                    Documents::US29::US29_1,
                                                    map(Documents::method116(), v1157),
                                                );
                                                match &v1171 {
                                                    Documents::US29::US29_0(v1171_0_0) => (
                                                        match &v1171 {
                                                            Documents::US29::US29_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US4::US4_1,
                                                        Documents::US24::US24_0(v368.clone()),
                                                    ),
                                                    _ => {
                                                        let v1181:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US4::US4_0(String::from(
                                                                v1181,
                                                            )),
                                                            Documents::US24::US24_0(v368.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US28::US28_1(v1152_1_0) => {
                                                let v1229: std::string::String = v1152_1_0.clone();
                                                let v1232: () = {
                                                    Documents::closure54(v1229.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US4::US4_0(v1229),
                                                    Documents::US24::US24_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US23::US23_1(v223_1_0) => {
                                let v1280: std::string::String = v223_1_0.clone();
                                let v1283: () = {
                                    Documents::closure41(v1280.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US4::US4_0(v1280),
                                    Documents::US24::US24_1,
                                )
                            }
                        };
                        let v1330: Documents::US24 = patternInput_3.2.clone();
                        let v1329: Documents::US4 = patternInput_3.1.clone();
                        let v1328: i32 = patternInput_3.0.clone();
                        let v1337: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1330 {
                            Documents::US24::US24_0(v1330_0_0) => Some(match &v1330 {
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
                        let v1339: bool = true;
                        let _optionm_map_ = v1337.map(|x| {
                            //;
                            let v1341: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1343: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1341;
                            let v1345: Result<
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
                            > = v1343.lock();
                            let v1348: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1345.unwrap();
                            let v1360 = v1348.iter();
                            let v1362: Vec<std::string::String> = v1360.collect::<Vec<_>>();
                            let v1364: bool = true;
                            let _vec_map: Vec<_> = v1362
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1366: std::string::String = x;
                                    let v1368: string =
                                        fable_library_rust::String_::fromString(v1366);
                                    let v1370: bool = true;
                                    v1368
                                })
                                .collect::<Vec<_>>();
                            let v1372: Vec<string> = _vec_map;
                            let v1381: string = join(
                                string("\n"),
                                toArray_1(ofArray_1(fable_library_rust::NativeArray_::array_from(
                                    v1372,
                                ))),
                            );
                            let v1385: bool = true;
                            v1381
                        });
                        let v1387: Option<string> = _optionm_map_;
                        let v1394: Documents::US1 = match &v1329 {
                            Documents::US4::US4_0(v1329_0_0) => Documents::US1::US1_0(
                                fable_library_rust::String_::fromString(match &v1329 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Documents::US1::US1_1,
                        };
                        let v1399: string = defaultValue(
                            match &v1394 {
                                Documents::US1::US1_0(v1394_0_0) => match &v1394 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v1387,
                        );
                        let v1404: () = {
                            Documents::closure56(v1328, v1399.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1328, v1399))
                    }
                }))();
                _v128.set(Some(x_3))
            }
            {
                let v1446: LrcPtr<(i32, string)> = match &_v128.get().clone() {
                    None => panic!("{}", string("base.capture / _v128=None"),),
                    Some(_v128_0_0) => _v128_0_0.clone(),
                };
                let _v7: (i32, string) = (v1446.0.clone(), v1446.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method128(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method26(v2, Documents::method43(v1_1.clone()));
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
        pub fn method129() -> string {
            string("")
        }
        pub fn closure66(unitVar: (), v0_1: string) -> Documents::US33 {
            Documents::US33::US33_0(v0_1)
        }
        pub fn method130() -> Func1<string, Documents::US33> {
            Func1::new(move |v: string| Documents::closure66((), v))
        }
        pub fn closure67(unitVar: (), v0_1: std::string::String) -> Documents::US33 {
            Documents::US33::US33_1(v0_1)
        }
        pub fn method131() -> Func1<std::string::String, Documents::US33> {
            Func1::new(move |v: std::string::String| Documents::closure67((), v))
        }
        pub fn method132(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v25: std::string::String = String::from(v4);
            let v60: std::path::PathBuf = std::path::PathBuf::from(v25);
            if v60.clone().exists() {
                v60.is_file()
            } else {
                false
            }
        }
        pub fn method134(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: i32,
            v6: string,
            v7: string,
            v8: Documents::US1,
            v9: string,
            v10: string,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method133(
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
            v17: Documents::US1,
            v18: string,
            v19: string,
        ) -> string {
            let v20: string =
                Documents::method134(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v20
            ))
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
            if Documents::method7(Documents::US0::US0_2) {
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
                Documents::method19(if v53.clone() == string("") {
                    string("")
                } else {
                    Documents::method133(
                        v29.clone(),
                        v30.clone(),
                        v31.clone(),
                        v32.clone(),
                        v33.clone(),
                        v34.clone(),
                        Documents::method8(v29, v30, v31, v32, v33, v34),
                        Documents::method12(),
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
        pub fn method136(v0_1: string) -> string {
            v0_1
        }
        pub fn closure69(unitVar: (), v0_1: u64) -> Documents::US34 {
            Documents::US34::US34_0(v0_1)
        }
        pub fn closure70(unitVar: (), v0_1: std::string::String) -> Documents::US34 {
            Documents::US34::US34_1(v0_1)
        }
        pub fn method138(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            let v131: () = {
                Documents::closure8(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v101)),
                    (),
                );
                ()
            };
            let v140: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method137(
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
            let v11: string = Documents::method138(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure71(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
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
                Documents::method19(Documents::method137(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method35(),
                    v0_1,
                    v1_1,
                    v2,
                ))
            };
        }
        pub fn method140(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            v9: string,
            v10: u64,
        ) -> string {
            let v11: string = Documents::method140(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure72(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
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
                Documents::method19(Documents::method139(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method49(),
                    v0_1,
                    v1_1,
                    v2,
                ))
            };
        }
        pub fn method135(v0_1: string, v1_1: string) {
            let v3: string = Documents::method136(v0_1);
            let v5: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v3);
            let v6 = Documents::method53();
            let v17: Result<u64, std::string::String> = v5.map_err(|x| v6(x));
            let v22: Documents::US34 = match &v17 {
                Err(v17_1_0) => Documents::closure70((), v17_1_0.clone()),
                Ok(v17_0_0) => Documents::closure69((), v17_0_0.clone()),
            };
            match &v22 {
                Documents::US34::US34_0(v22_0_0) => {
                    let v26: () = {
                        Documents::closure72(v1_1.clone(), v3.clone(), v22_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US34::US34_1(v22_1_0) => {
                    let v69: () = {
                        Documents::closure71(v1_1.clone(), v3.clone(), v22_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ();
            ()
        }
        pub fn method142(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method143(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method144(v0_1: string) -> string {
            v0_1
        }
        pub fn method145(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure75(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v8: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v19: string = Documents::method144(v0_1);
            let v21: &[u8] = v19.as_bytes();
            let v22: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method145(v8);
            let v24: bool = true;
            let mut v22 = v22;
            let v26: bool = true;
            std::io::Write::write_all(&mut *v22, v21).unwrap();
            ()
        }
        pub fn method146(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method147(v0_1: string) -> string {
            v0_1
        }
        pub fn method149(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method148(
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
            let v11: string = Documents::method149(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.hangul"),
                v11
            ))
        }
        pub fn closure76(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
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
                Documents::method19(Documents::method148(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method12(),
                    v1_1,
                    length(v2),
                    v0_1,
                ))
            };
        }
        pub fn method141(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US35 {
            let v7: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v41: Vec<u8> = Documents::method142(v7.unwrap());
            let v43: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v41);
            let v46: std::string::String = v43.unwrap();
            let v78: Array<string> = split(
                fable_library_rust::String_::fromString(v46),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v81: i32 = count_2(v78.clone());
            let v82: Array<string> = new_init(&string(""), v81);
            let v83: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method47(v81, v83.clone()) {
                let v85: i32 = v83.l0.get().clone();
                let v88: string = trim(v78[v85].clone());
                v82.get_mut()[v85 as usize] = v88;
                {
                    let v89: i32 = v85 + 1_i32;
                    v83.l0.set(v89);
                    ()
                }
            }
            {
                let v90: i32 = count_2(v82.clone());
                let v91: Array<string> = new_init(&string(""), v90);
                let v92: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method143(v90, v92.clone()) {
                    let v94: i32 = v92.l0.get().clone();
                    let v95: i32 = v92.l1.get().clone();
                    let v96: string = v82[v94].clone();
                    let v102: i32 = if string("") != v96.clone() {
                        v91.get_mut()[v95 as usize] = v96;
                        v95 + 1_i32
                    } else {
                        v95
                    };
                    let v103: i32 = v94 + 1_i32;
                    v92.l0.set(v103);
                    v92.l1.set(v102);
                    ()
                }
                {
                    let v104: i32 = v92.l1.get().clone();
                    let v105: Array<string> = new_init(&string(""), v104);
                    let v106: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method47(v104, v106.clone()) {
                        let v108: i32 = v106.l0.get().clone();
                        let v109: string = v91[v108].clone();
                        v105.get_mut()[v108 as usize] = v109;
                        {
                            let v110: i32 = v108 + 1_i32;
                            v106.l0.set(v110);
                            ()
                        }
                    }
                    {
                        let v119: string = sprintf!(
                            "{}\n\n",
                            join(
                                string("\n"),
                                toArray_1(delay(Func0::new({
                                    let v105 = v105.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v105 = v105.clone();
                                                move |i: i32| v105[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                count_2(v105.clone()) - 1_i32,
                                            ),
                                        )
                                    }
                                })))
                            )
                        );
                        let patternInput: (i32, string) = Documents::method66(
                            sprintf!(
                                "{} {}",
                                Documents::method26(
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
                                let v119 = v119.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure75(v119.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v160: i32 = patternInput.0.clone();
                        let v162: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v165: i32 = count_2(v162.clone());
                        let v167: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method146(v90, v167.clone()) {
                            let v169: i32 = v167.l0.get().clone();
                            let matchValue: string = v167.l1.get().clone();
                            let matchValue_1: i32 = v167.l2.get().clone();
                            let v172: i32 = v167.l3.get().clone();
                            let v171: i32 = matchValue_1;
                            let v170: string = matchValue;
                            let patternInput_2: (string, i32, i32) =
                                if v82[v169].clone() == string("") {
                                    (sprintf!("{}\n", v170.clone()), v171 + 1_i32, v172 + 1_i32)
                                } else {
                                    let v178: i32 = v171 - v172;
                                    (
                                        if v178 >= v165 {
                                            v170.clone()
                                        } else {
                                            let v180: string = v162[v178].clone();
                                            if v178 == v165 - 1_i32 {
                                                sprintf!("{}{}", v170.clone(), v180.clone())
                                            } else {
                                                sprintf!("{}{}\n", v170, v180)
                                            }
                                        },
                                        v171 + 1_i32,
                                        v172,
                                    )
                                };
                            let v193: i32 = v169 + 1_i32;
                            v167.l0.set(v193);
                            v167.l1.set(patternInput_2.0.clone());
                            v167.l2.set(patternInput_2.1.clone());
                            v167.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v167.l1.get().clone();
                            let matchValue_4: i32 = v167.l2.get().clone();
                            let matchValue_5: i32 = v167.l3.get().clone();
                            let v194: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v194.clone()).unwrap();
                            ();
                            {
                                let v202: () = {
                                    Documents::closure76(v2, v160, v194.clone(), ());
                                    ()
                                };
                                Documents::US35::US35_0(v160, v194)
                            }
                        }
                    }
                }
            }
        }
        pub fn method151(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method150(
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
            let v10: string = Documents::method151(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.files_fn / error"),
                v10
            ))
        }
        pub fn closure77(v0_1: string, v1_1: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
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
                Documents::method19(Documents::method150(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method8(v20, v21, v22, v23, v24, v25),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure74(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US32 {
            let patternInput: (string, string) = Documents::method128(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if Documents::method132(v6.clone()) == false {
                true
            } else {
                Documents::method132(v7.clone()) == false
            } {
                false
            } else {
                let v13: string = Documents::method40(v6.clone());
                let v15: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v13);
                let v18: std::fs::File = v15.unwrap();
                let v30: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
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
                        let v61: usize = v50.unwrap();
                        if v61 == v40 {
                            let v68: bool = true;
                            break;
                            ()
                        }
                        {
                            let v70: usize = v44.len();
                            let v71: u8 = v70 as u8;
                            let v74: usize = v61;
                            let v87: &_ = if v74 == v70 {
                                &v44[v40..]
                            } else {
                                &v44[v40..v74]
                            };
                            sha2::Digest::update(&mut v37, v87);
                            {
                                let v90: bool = true;
                            } // rust.loop;
                            let v92: bool = true;
                        } // rust.loop;
                        let v94: bool = true;
                    } // rust.loop;
                    let v96: bool = true;
                    {
                        // rust.loop;
                        let v98: bool = true;
                        {
                            // rust.loop;
                            let v100: &[u8] = &sha2::Digest::finalize(v37);
                            let v102: Vec<u8> = v100.iter().map(|x| *x).collect::<Vec<_>>();
                            let v104: bool = true;
                            let _vec_map: Vec<_> = v102
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v106: u8 = x;
                                    let v108: std::string::String = format!("{:02x}", v106);
                                    let v110: string =
                                        fable_library_rust::String_::fromString(v108);
                                    let v112: bool = true;
                                    v110
                                })
                                .collect::<Vec<_>>();
                            let v114: Vec<string> = _vec_map;
                            let v116: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v114);
                            let v117: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v116 = v116.clone();
                                move || {
                                    map_1(
                                        Func1::new({
                                            let v116 = v116.clone();
                                            move |i: i32| v116[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v116.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v123: string = join(Documents::method129(), toArray_1(v117));
                            let v127 = Documents::method53();
                            let v130: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v123).map_err(|x| v127(x));
                            let v141 = Documents::method130();
                            let v142 = Documents::method131();
                            let v144: Documents::US33 = match v130 {
                                Ok(x) => v141(x),
                                Err(e) => v142(e),
                            };
                            let v150: string = match &v144 {
                                Documents::US33::US33_0(v144_0_0) => v144_0_0.clone(),
                                Documents::US33::US33_1(v144_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v144_1_0.clone()
                                    ),
                                ),
                            };
                            let v151: string = Documents::method40(v7.clone());
                            let v153: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v151);
                            let v156: std::fs::File = v153.unwrap();
                            let v168: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v156);
                            let v170: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v168);
                            let v172: bool = true;
                            let mut v170 = v170;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v175: sha2::Sha256 = result;
                                let v177: bool = true;
                                let mut v175 = v175;
                                let v178: usize = 0_i32 as usize;
                                let v182: _ = [0_u8; 1024];
                                let v184: bool = true;
                                loop {
                                    // rust.loop;
                                    let v186: bool = true;
                                    let mut v182 = v182;
                                    let v188: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v170, &mut v182);
                                    let v199: usize = v188.unwrap();
                                    if v199 == v178 {
                                        let v206: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v208: usize = v182.len();
                                        let v209: u8 = v208 as u8;
                                        let v212: usize = v199;
                                        let v225: &_ = if v212 == v208 {
                                            &v182[v178..]
                                        } else {
                                            &v182[v178..v212]
                                        };
                                        sha2::Digest::update(&mut v175, v225);
                                        {
                                            let v228: bool = true;
                                        } // rust.loop;
                                        let v230: bool = true;
                                    } // rust.loop;
                                    let v232: bool = true;
                                } // rust.loop;
                                let v234: bool = true;
                                {
                                    // rust.loop;
                                    let v236: bool = true;
                                    {
                                        // rust.loop;
                                        let v238: &[u8] = &sha2::Digest::finalize(v175);
                                        let v240: Vec<u8> =
                                            v238.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v242: bool = true;
                                        let _vec_map: Vec<_> = v240
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v244: u8 = x;
                                                let v246: std::string::String =
                                                    format!("{:02x}", v244);
                                                let v248: string =
                                                    fable_library_rust::String_::fromString(v246);
                                                let v250: bool = true;
                                                v248
                                            })
                                            .collect::<Vec<_>>();
                                        let v252: Vec<string> = _vec_map;
                                        let v254: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v252);
                                        let v255: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v254 = v254.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v254 = v254.clone();
                                                            move |i_1: i32| v254[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v254.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v261: string =
                                            join(Documents::method129(), toArray_1(v255));
                                        let v265 = Documents::method53();
                                        let v268: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v261).map_err(|x| v265(x));
                                        let v279 = Documents::method130();
                                        let v280 = Documents::method131();
                                        let v282: Documents::US33 = match v268 {
                                            Ok(x) => v279(x),
                                            Err(e) => v280(e),
                                        };
                                        v150 == match &v282 {
                                            Documents::US33::US33_0(v282_0_0) => v282_0_0.clone(),
                                            Documents::US33::US33_1(v282_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v282_1_0.clone()
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
                let v292: Documents::US35 = Documents::method141(v2, v3, v6.clone(), v4);
                match &v292 {
                    Documents::US35::US35_0(v292_0_0, v292_0_1) => {
                        let v294: string = v292_0_1.clone();
                        let v293: i32 = v292_0_0.clone();
                        if v293 != 0_i32 {
                            let v300: () = {
                                Documents::closure77(v294.clone(), v293, ());
                                ()
                            };
                            Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v294)),
                            ))
                        } else {
                            if Documents::method132(v6.clone()) {
                                Documents::method135(v7, v6.clone())
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
                    Documents::US35::US35_1(v292_1_0, v292_1_1) => {
                        Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v292_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure73(
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
                    Documents::closure74(
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
        pub fn method154(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method153(
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
            let v11: string = Documents::method154(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.crowbook / result contains ERROR"),
                v11
            ))
        }
        pub fn closure80(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
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
                Documents::method19(Documents::method153(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method35(),
                    v2,
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method152(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US35 {
            let patternInput: (i32, string) = Documents::method66(
                append(
                    sprintf!("crowbook --verbose --to {}", v4.clone()),
                    sprintf!(
                        " --single \"{}\" --output \"{}\" {}",
                        v2,
                        v1_1.clone(),
                        if string("html") == v4.clone() {
                            string("--set html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  pre { background-color: #1b1b1b; padding: 10px; }   \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
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
                    Documents::closure80(v1_1, v75.clone(), v74, ());
                    ()
                };
                Documents::US35::US35_1(v74, v75)
            }
        }
        pub fn closure79(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (string, string) = Documents::method128(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if Documents::method132(v5.clone()) == false {
                true
            } else {
                Documents::method132(v6.clone()) == false
            } {
                false
            } else {
                let v12: string = Documents::method40(v5.clone());
                let v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
                let v17: std::fs::File = v14.unwrap();
                let v29: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v17);
                let v31: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v29);
                let v33: bool = true;
                let mut v31 = v31;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v36: sha2::Sha256 = result;
                    let v38: bool = true;
                    let mut v36 = v36;
                    let v39: usize = 0_i32 as usize;
                    let v43: _ = [0_u8; 1024];
                    let v45: bool = true;
                    loop {
                        // rust.loop;
                        let v47: bool = true;
                        let mut v43 = v43;
                        let v49: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v31, &mut v43);
                        let v60: usize = v49.unwrap();
                        if v60 == v39 {
                            let v67: bool = true;
                            break;
                            ()
                        }
                        {
                            let v69: usize = v43.len();
                            let v70: u8 = v69 as u8;
                            let v73: usize = v60;
                            let v86: &_ = if v73 == v69 {
                                &v43[v39..]
                            } else {
                                &v43[v39..v73]
                            };
                            sha2::Digest::update(&mut v36, v86);
                            {
                                let v89: bool = true;
                            } // rust.loop;
                            let v91: bool = true;
                        } // rust.loop;
                        let v93: bool = true;
                    } // rust.loop;
                    let v95: bool = true;
                    {
                        // rust.loop;
                        let v97: bool = true;
                        {
                            // rust.loop;
                            let v99: &[u8] = &sha2::Digest::finalize(v36);
                            let v101: Vec<u8> = v99.iter().map(|x| *x).collect::<Vec<_>>();
                            let v103: bool = true;
                            let _vec_map: Vec<_> = v101
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v105: u8 = x;
                                    let v107: std::string::String = format!("{:02x}", v105);
                                    let v109: string =
                                        fable_library_rust::String_::fromString(v107);
                                    let v111: bool = true;
                                    v109
                                })
                                .collect::<Vec<_>>();
                            let v113: Vec<string> = _vec_map;
                            let v115: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v113);
                            let v116: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
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
                            let v122: string = join(Documents::method129(), toArray_1(v116));
                            let v126 = Documents::method53();
                            let v129: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v122).map_err(|x| v126(x));
                            let v140 = Documents::method130();
                            let v141 = Documents::method131();
                            let v143: Documents::US33 = match v129 {
                                Ok(x) => v140(x),
                                Err(e) => v141(e),
                            };
                            let v149: string = match &v143 {
                                Documents::US33::US33_0(v143_0_0) => v143_0_0.clone(),
                                Documents::US33::US33_1(v143_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v143_1_0.clone()
                                    ),
                                ),
                            };
                            let v150: string = Documents::method40(v6.clone());
                            let v152: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v150);
                            let v155: std::fs::File = v152.unwrap();
                            let v167: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v155);
                            let v169: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v167);
                            let v171: bool = true;
                            let mut v169 = v169;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v174: sha2::Sha256 = result;
                                let v176: bool = true;
                                let mut v174 = v174;
                                let v177: usize = 0_i32 as usize;
                                let v181: _ = [0_u8; 1024];
                                let v183: bool = true;
                                loop {
                                    // rust.loop;
                                    let v185: bool = true;
                                    let mut v181 = v181;
                                    let v187: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v169, &mut v181);
                                    let v198: usize = v187.unwrap();
                                    if v198 == v177 {
                                        let v205: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v207: usize = v181.len();
                                        let v208: u8 = v207 as u8;
                                        let v211: usize = v198;
                                        let v224: &_ = if v211 == v207 {
                                            &v181[v177..]
                                        } else {
                                            &v181[v177..v211]
                                        };
                                        sha2::Digest::update(&mut v174, v224);
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
                                        let v237: &[u8] = &sha2::Digest::finalize(v174);
                                        let v239: Vec<u8> =
                                            v237.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v241: bool = true;
                                        let _vec_map: Vec<_> = v239
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v243: u8 = x;
                                                let v245: std::string::String =
                                                    format!("{:02x}", v243);
                                                let v247: string =
                                                    fable_library_rust::String_::fromString(v245);
                                                let v249: bool = true;
                                                v247
                                            })
                                            .collect::<Vec<_>>();
                                        let v251: Vec<string> = _vec_map;
                                        let v253: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(v251);
                                        let v254: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v253 = v253.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v253 = v253.clone();
                                                            move |i_1: i32| v253[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count_2(v253.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v260: string =
                                            join(Documents::method129(), toArray_1(v254));
                                        let v264 = Documents::method53();
                                        let v267: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v260).map_err(|x| v264(x));
                                        let v278 = Documents::method130();
                                        let v279 = Documents::method131();
                                        let v281: Documents::US33 = match v267 {
                                            Ok(x) => v278(x),
                                            Err(e) => v279(e),
                                        };
                                        v149 == match &v281 {
                                            Documents::US33::US33_0(v281_0_0) => v281_0_0.clone(),
                                            Documents::US33::US33_1(v281_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v281_1_0.clone()
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
                let v291: Documents::US35 = Documents::method152(v2, v5.clone(), v3, v1_1, v4);
                match &v291 {
                    Documents::US35::US35_0(v291_0_0, v291_0_1) => {
                        let v293: string = v291_0_1.clone();
                        let v292: i32 = v291_0_0.clone();
                        if v292 != 0_i32 {
                            let v299: () = {
                                Documents::closure77(v293.clone(), v292, ());
                                ()
                            };
                            Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v293)),
                            ))
                        } else {
                            if Documents::method132(v5.clone()) {
                                Documents::method135(v6, v5.clone())
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
                    Documents::US35::US35_1(v291_1_0, v291_1_1) => {
                        Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v291_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure78(
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
                move |v: string| Documents::closure79(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method156(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
        pub fn method155(
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
            let v10: string = Documents::method156(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / par_map / files\' = [] / listm.iter"),
                v10
            ))
        }
        pub fn closure81(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
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
                Documents::method19(Documents::method155(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method8(v20, v21, v22, v23, v24, v25),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method157(
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
                    Documents::method157(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method158(v0_1: i32, v1_1: LrcPtr<Documents::Mut9>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method159(
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
                    Documents::method159(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure82(
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
        pub fn method160(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method161(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn closure30(
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
            let v6: string = Documents::method39(v5);
            let v9: &str = &*v6.clone();
            let v30: std::string::String = String::from(v9);
            let v51: std::path::PathBuf = std::path::PathBuf::from(v30);
            let v72: std::path::Display = v51.display();
            let v93: std::string::String = format!("{}", v72);
            let v119: string = sprintf!(
                ".{}",
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v93),
                        v3.clone(),
                        Documents::method64()
                    ),
                    string("\\"),
                    string("/")
                )
            );
            let v120: string = Documents::method40(v6);
            let v122: string = Documents::method65(Documents::method26(v2.clone(), v119.clone()));
            let patternInput: (i32, string) = Documents::method66(
                sprintf!(
                    "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                    v122.clone()
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v134: string = patternInput.1.clone();
            let v133: i32 = patternInput.0.clone();
            let v136: string = Documents::method65(Documents::method26(v3.clone(), v119.clone()));
            let patternInput_1: (i32, string) = Documents::method66(
                sprintf!("git hash-object \"{}\"", v136.clone()),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v148: string = patternInput_1.1.clone();
            let v147: i32 = patternInput_1.0.clone();
            let v150: string = Documents::method65(Documents::method26(v4.clone(), v119.clone()));
            let v152: string =
                (Documents::method128(string("hangul.md"), v136.clone(), v4.clone()))
                    .0
                    .clone();
            let v593: LrcPtr<Documents::UH4> = if contains(v134.clone(), v148.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v164: string = Documents::method40(v136.clone());
                let v166: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v164);
                let v169: std::fs::File = v166.unwrap();
                let v181: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v169);
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
                        let v212: usize = v201.unwrap();
                        if v212 == v191 {
                            let v219: bool = true;
                            break;
                            ()
                        }
                        {
                            let v221: usize = v195.len();
                            let v222: u8 = v221 as u8;
                            let v225: usize = v212;
                            let v238: &_ = if v225 == v221 {
                                &v195[v191..]
                            } else {
                                &v195[v191..v225]
                            };
                            sha2::Digest::update(&mut v188, v238);
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
                            let v251: &[u8] = &sha2::Digest::finalize(v188);
                            let v253: Vec<u8> = v251.iter().map(|x| *x).collect::<Vec<_>>();
                            let v255: bool = true;
                            let _vec_map: Vec<_> = v253
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v257: u8 = x;
                                    let v259: std::string::String = format!("{:02x}", v257);
                                    let v261: string =
                                        fable_library_rust::String_::fromString(v259);
                                    let v263: bool = true;
                                    v261
                                })
                                .collect::<Vec<_>>();
                            let v265: Vec<string> = _vec_map;
                            let v267: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v265);
                            let v268: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v267 = v267.clone();
                                move || {
                                    map_1(
                                        Func1::new({
                                            let v267 = v267.clone();
                                            move |i: i32| v267[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v267.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let v274: string = join(Documents::method129(), toArray_1(v268));
                            let v278 = Documents::method53();
                            let v281: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v274).map_err(|x| v278(x));
                            let v292 = Documents::method130();
                            let v293 = Documents::method131();
                            let v295: Documents::US33 = match v281 {
                                Ok(x) => v292(x),
                                Err(e) => v293(e),
                            };
                            let v301: string = match &v295 {
                                Documents::US33::US33_0(v295_0_0) => v295_0_0.clone(),
                                Documents::US33::US33_1(v295_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v295_1_0.clone()
                                    ),
                                ),
                            };
                            let v443: Documents::US1 = if Documents::method132(v150.clone())
                                == false
                            {
                                Documents::US1::US1_1
                            } else {
                                let v305: string = Documents::method40(v150.clone());
                                let v307: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v305);
                                let v310: std::fs::File = v307.unwrap();
                                let v322: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v310);
                                let v324: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v322);
                                let v326: bool = true;
                                let mut v324 = v324;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v329: sha2::Sha256 = result;
                                    let v331: bool = true;
                                    let mut v329 = v329;
                                    let v332: usize = 0_i32 as usize;
                                    let v336: _ = [0_u8; 1024];
                                    let v338: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v340: bool = true;
                                        let mut v336 = v336;
                                        let v342: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v324, &mut v336);
                                        let v353: usize = v342.unwrap();
                                        if v353 == v332 {
                                            let v360: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v362: usize = v336.len();
                                            let v363: u8 = v362 as u8;
                                            let v366: usize = v353;
                                            let v379: &_ = if v366 == v362 {
                                                &v336[v332..]
                                            } else {
                                                &v336[v332..v366]
                                            };
                                            sha2::Digest::update(&mut v329, v379);
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
                                            let v392: &[u8] = &sha2::Digest::finalize(v329);
                                            let v394: Vec<u8> =
                                                v392.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v396: bool = true;
                                            let _vec_map: Vec<_> = v394
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
                                            let v406: Vec<string> = _vec_map;
                                            let v408: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(v406);
                                            let v409: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v408 = v408.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v408 = v408.clone();
                                                                move |i_1: i32| v408[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count_2(v408.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v415: string =
                                                join(Documents::method129(), toArray_1(v409));
                                            let v419 = Documents::method53();
                                            let v422: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v415)
                                                    .map_err(|x| v419(x));
                                            let v433 = Documents::method130();
                                            let v434 = Documents::method131();
                                            let v436: Documents::US33 = match v422 {
                                                Ok(x) => v433(x),
                                                Err(e) => v434(e),
                                            };
                                            match &v436 {
                                                Documents::US33::US33_0(v436_0_0) => {
                                                    Documents::US1::US1_0(v436_0_0.clone())
                                                }
                                                _ => Documents::US1::US1_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US1::US1_0(v443_0_0) = &v443 {
                                if v301.clone()
                                    == match &v443 {
                                        Documents::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v449: () = {
                                        Documents::closure68(
                                            v119.clone(),
                                            v120.clone(),
                                            v122.clone(),
                                            v134.clone(),
                                            v133,
                                            v136.clone(),
                                            v148.clone(),
                                            v147,
                                            v150.clone(),
                                            v301.clone(),
                                            v443.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method135(v150.clone(), v136.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v136.clone(),
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
                                                            Documents::closure73(
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
                                                v136.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure78(
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
                                                    v136.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure78(
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
                                                        v136.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure78(
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
                                                            v152.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure78(
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
                                                                v152.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure78(
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
                                                                    v152.clone(),
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
                                                                                                                                                                                                                                                                                                                                                               Documents::closure78(v4.clone(),
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
                                let v522: () = {
                                    Documents::closure68(
                                        v119,
                                        v120.clone(),
                                        v122,
                                        v134,
                                        v133,
                                        v136.clone(),
                                        v148,
                                        v147,
                                        v150.clone(),
                                        v301,
                                        v443,
                                        (),
                                    );
                                    ()
                                };
                                Documents::method135(v150, v136.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v136.clone(),
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
                                                        Documents::closure73(
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
                                            v136.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_8: string| {
                                                            Documents::closure78(
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
                                                v136.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_9: string| {
                                                                Documents::closure78(
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
                                                    v136.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_10: string| {
                                                                    Documents::closure78(
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
                                                        v152.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_11: string| {
                                                                        Documents::closure78(
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
                                                            v152.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_12: string| {
                                                                            Documents::closure78(
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
                                                                v152.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_13: string| {
                                                                                Documents::closure78(
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
            let v974: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method157(
                if (if let Documents::UH4::UH4_0 = v593.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v593
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method128(string("epub"), v152.clone(), v4.clone());
                    let v598: string = patternInput_3.1.clone();
                    let v597: string = patternInput_3.0.clone();
                    let v650: LrcPtr<Documents::UH5> = if if Documents::method132(v597.clone()) {
                        true
                    } else {
                        if Documents::method132(v598.clone()) == false {
                            true
                        } else {
                            let v604: () = {
                                Documents::closure81(v598.clone(), v597.clone(), ());
                                ()
                            };
                            Documents::method135(v597, v598);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v152.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_14: string| {
                                            Documents::closure78(v4.clone(), v3.clone(), true, v_14)
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
                        Documents::method128(string("pdf"), v152.clone(), v4.clone());
                    let v653: string = patternInput_4.1.clone();
                    let v652: string = patternInput_4.0.clone();
                    let v703: LrcPtr<Documents::UH5> = if if Documents::method132(v652.clone()) {
                        true
                    } else {
                        if Documents::method132(v653.clone()) == false {
                            true
                        } else {
                            let v659: () = {
                                Documents::closure81(v653.clone(), v652.clone(), ());
                                ()
                            };
                            Documents::method135(v652, v653);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v152.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_15: string| {
                                            Documents::closure78(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v650.clone(),
                        ))
                    } else {
                        v650
                    };
                    let patternInput_5: (string, string) =
                        Documents::method128(string("html"), v152.clone(), v4.clone());
                    let v706: string = patternInput_5.1.clone();
                    let v705: string = patternInput_5.0.clone();
                    let v756: LrcPtr<Documents::UH5> = if if Documents::method132(v705.clone()) {
                        true
                    } else {
                        if Documents::method132(v706.clone()) == false {
                            true
                        } else {
                            let v712: () = {
                                Documents::closure81(v706.clone(), v705.clone(), ());
                                ()
                            };
                            Documents::method135(v705, v706);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v152,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_16: string| {
                                            Documents::closure78(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v703.clone(),
                        ))
                    } else {
                        v703
                    };
                    let patternInput_6: (string, string) =
                        Documents::method128(string("epub"), v136.clone(), v4.clone());
                    let v758: string = patternInput_6.1.clone();
                    let v757: string = patternInput_6.0.clone();
                    let v808: LrcPtr<Documents::UH5> = if if Documents::method132(v757.clone()) {
                        true
                    } else {
                        if Documents::method132(v758.clone()) == false {
                            true
                        } else {
                            let v764: () = {
                                Documents::closure81(v758.clone(), v757.clone(), ());
                                ()
                            };
                            Documents::method135(v757, v758);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v136.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_17: string| {
                                            Documents::closure78(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v756.clone(),
                        ))
                    } else {
                        v756
                    };
                    let patternInput_7: (string, string) =
                        Documents::method128(string("pdf"), v136.clone(), v4.clone());
                    let v810: string = patternInput_7.1.clone();
                    let v809: string = patternInput_7.0.clone();
                    let v860: LrcPtr<Documents::UH5> = if if Documents::method132(v809.clone()) {
                        true
                    } else {
                        if Documents::method132(v810.clone()) == false {
                            true
                        } else {
                            let v816: () = {
                                Documents::closure81(v810.clone(), v809.clone(), ());
                                ()
                            };
                            Documents::method135(v809, v810);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v136.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_18: string| {
                                            Documents::closure78(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v808.clone(),
                        ))
                    } else {
                        v808
                    };
                    let patternInput_8: (string, string) =
                        Documents::method128(string("html"), v136.clone(), v4.clone());
                    let v862: string = patternInput_8.1.clone();
                    let v861: string = patternInput_8.0.clone();
                    let v912: LrcPtr<Documents::UH5> = if if Documents::method132(v861.clone()) {
                        true
                    } else {
                        if Documents::method132(v862.clone()) == false {
                            true
                        } else {
                            let v868: () = {
                                Documents::closure81(v862.clone(), v861.clone(), ());
                                ()
                            };
                            Documents::method135(v861, v862);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v136.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_19: string| {
                                            Documents::closure78(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v860.clone(),
                        ))
                    } else {
                        v860
                    };
                    let patternInput_9: (string, string) =
                        Documents::method128(string("hangul.md"), v136.clone(), v4.clone());
                    let v914: string = patternInput_9.1.clone();
                    let v913: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method132(v913.clone()) {
                            true
                        } else {
                            if Documents::method132(v914.clone()) == false {
                                true
                            } else {
                                let v920: () = {
                                    Documents::closure81(v914.clone(), v913.clone(), ());
                                    ()
                                };
                                Documents::method135(v913, v914);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v136,
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
                                                Documents::closure73(
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
                            v912,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v978: Vec<LrcPtr<Documents::UH5>> = v974.to_vec();
            let v981: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v983: Array<LrcPtr<Documents::UH5>> =
                fable_library_rust::NativeArray_::array_from(v978);
            let v984: i32 = count_2(v983.clone());
            let v985: LrcPtr<Documents::Mut9> = LrcPtr::new(Documents::Mut9 {
                l0: MutCell::new(0_i32),
                l1: MutCell::new(v981),
            });
            while Documents::method158(v984, v985.clone()) {
                let v987: i32 = v985.l0.get().clone();
                let v988: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    v985.l1.get().clone();
                let v993 = toArray(Documents::method159(
                    v983[v987].clone(),
                    empty::<(
                        string,
                        string,
                        Func1<string, Func1<string, Documents::US32>>,
                    )>(),
                ));
                let v997 = v993.to_vec();
                let v999 = rayon::iter::IntoParallelIterator::into_par_iter(v997);
                let v1002 = rayon::iter::ParallelIterator::map(v999, |x| {
                    Func1::new(
                        move |arg10_0040_9: (
                            string,
                            string,
                            Func1<string, Func1<string, Documents::US32>>,
                        )| Documents::closure82((), arg10_0040_9),
                    )(x)
                });
                let v1005: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method160(rayon::iter::ParallelIterator::collect(v1002));
                let v1006: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                    Documents::method161(v988);
                let v1008: bool = true;
                let mut v1006 = v1006;
                let v1010: bool = true;
                v1006.extend(v1005);
                let v1012: Vec<Option<Result<string, LrcPtr<(string, string)>>>> = v1006;
                let v1013: i32 = v987 + 1_i32;
                v985.l0.set(v1013);
                v985.l1.set(v1012);
                ()
            }
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((v120, v985.l1.get().clone())))
        }
        pub fn method162(
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
        pub fn method25(
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
            let v8: Documents::US7 = Documents::method29(
                Documents::method26(string("polyglot"), string(".devcontainer")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v56: Documents::US1 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US1::US1_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure14(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US1::US1_1
                }
            };
            let v111: Documents::US1 = match &v56 {
                Documents::US1::US1_0(v56_0_0) => Documents::US1::US1_0(match &v56 {
                    Documents::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v59: string = Documents::method38();
                    let v61: Documents::US7 = Documents::method29(
                        Documents::method26(string("polyglot"), string(".devcontainer")),
                        v59,
                    );
                    match &v61 {
                        Documents::US7::US7_0(v61_0_0) => Documents::US1::US1_0(v61_0_0.clone()),
                        Documents::US7::US7_1(v61_1_0) => {
                            let v67: () = {
                                Documents::closure14(v61_1_0.clone(), ());
                                ()
                            };
                            Documents::US1::US1_1
                        }
                    }
                }
            };
            let v116: string = Documents::method26(
                match &v111 {
                    Documents::US1::US1_0(v111_0_0) => match &v111 {
                        Documents::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v117: string = Documents::method39(v3);
            let v118: string = Documents::method39(v2);
            let v119: string = Documents::method39(v1_1);
            let v122: () = {
                Documents::closure19(v0_1.clone(), v117.clone(), v118.clone(), v119.clone(), ());
                ()
            };
            let v163: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v165: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v118.clone());
                let v168: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v165, |x| {
                    Func1::new(move |v: async_walkdir::DirEntry| Documents::closure20((), v))(x)
                });
                let v169 = Documents::method57();
                let v171 = tokio_stream::StreamExt::filter_map(v168, |x| v169(x));
                let v173: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                    Box::pin(tokio_stream::StreamExt::collect(v171));
                let v175: Vec<string> = v173.await;
                let v178: () = {
                    Documents::closure29(v175.clone(), ());
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
                                Documents::closure30(
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
                > = Documents::method162(Ok::<
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
                let v246: string = append(
                    append(
                        append(append(string("true; v232 "), v231), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v247: bool = true;
                v232
            }); // rust.fix_closure';
            let v249 = __future_init;
            v249
        }
        pub fn closure83(
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
        pub fn closure84(unitVar: (), v0_1: std::string::String) -> Documents::US36 {
            Documents::US36::US36_1(v0_1)
        }
        pub fn method163(
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
            let v9: string = Documents::method61(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure85(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
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
                Documents::method19(Documents::method163(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method59(),
                    v0_1,
                ))
            };
        }
        pub fn method165(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
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
            let v62: () = {
                Documents::closure8(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method164(
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
            let v9: string = Documents::method165(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure86(
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
            if Documents::method7(Documents::US0::US0_2) {
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
                Documents::method19(Documents::method164(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method12(),
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
            let v62: string = Documents::method20();
            let v65: &str = &*v62;
            let v85: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v65).cloned();
            let v99: Documents::US4 =
                defaultValue(Documents::US4::US4_1, map(Documents::method21(), v85));
            let v106: std::string::String = match &v99 {
                Documents::US4::US4_0(v99_0_0) => match &v99 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v108: string = fable_library_rust::String_::fromString(v106);
            let v109: string = Documents::method22();
            let v112: &str = &*v109;
            let v132: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v112).cloned();
            let v146: Documents::US4 =
                defaultValue(Documents::US4::US4_1, map(Documents::method21(), v132));
            let v153: std::string::String = match &v146 {
                Documents::US4::US4_0(v146_0_0) => match &v146 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v155: string = fable_library_rust::String_::fromString(v153);
            let v156: string = Documents::method23();
            let v159: &str = &*v156;
            let v179: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v159).cloned();
            let v193: Documents::US4 =
                defaultValue(Documents::US4::US4_1, map(Documents::method21(), v179));
            let v200: std::string::String = match &v193 {
                Documents::US4::US4_0(v193_0_0) => match &v193 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v202: string = fable_library_rust::String_::fromString(v200);
            let v203: string = Documents::method24();
            let v206: &str = &*v203;
            let v226: Option<std::string::String> = clap::ArgMatches::get_one(&v61, v206).cloned();
            let v240: Documents::US4 =
                defaultValue(Documents::US4::US4_1, map(Documents::method21(), v226));
            let v247: std::string::String = match &v240 {
                Documents::US4::US4_0(v240_0_0) => match &v240 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v250: std::pin::Pin<
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
            > = Documents::method25(
                fable_library_rust::String_::fromString(v247),
                v202,
                v155,
                v108,
            );
            let v252 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v254: Result<
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
            > = v252.handle().block_on(v250);
            let v257: Documents::US36 = match &v254 {
                Err(v254_1_0) => Documents::closure84((), v254_1_0.clone()),
                Ok(v254_0_0) => Documents::closure83((), v254_0_0.clone()),
            };
            match &v257 {
                Documents::US36::US36_0(v257_0_0) => {
                    let v261: () = {
                        Documents::closure86(v257_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US36::US36_1(v257_1_0) => {
                    let v306: () = {
                        Documents::closure85(v257_1_0.clone(), ());
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
