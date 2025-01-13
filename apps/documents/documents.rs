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
#![allow(unused_assignments)]
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
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::getZero;
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
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith3;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::indexOf;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
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
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Text::StringBuilder;
        use fable_library_rust::System::Threading::CancellationToken;
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
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        pub trait IPathJoin: core::fmt::Debug + core::fmt::Display {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + core::fmt::Debug + core::fmt::Display> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync: core::fmt::Debug + core::fmt::Display {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + core::fmt::Debug + core::fmt::Display> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname: core::fmt::Debug + core::fmt::Display {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + core::fmt::Debug + core::fmt::Display> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Documents::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Documents::US0),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(Documents::US3),
            US4_1(Documents::US3),
            US4_2(Documents::US3),
            US4_3(Documents::US3),
            US4_4(Documents::US3),
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0(string),
            US7_1(string),
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(std::path::PathBuf),
            US8_1(string),
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::path::PathBuf),
            US9_1,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(std::fs::FileType),
            US10_1(std::string::String),
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US11 {
            US11_0,
            US11_1,
            US11_2,
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(async_walkdir::DirEntry),
            US12_1(std::string::String),
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US13 {
            US13_0(string, Documents::US5),
            US13_1(string),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US14_1(string),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Documents::UH0>),
        }
        impl core::fmt::Display for UH0 {
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
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US16 {
            US16_0(char),
            US16_1,
        }
        impl core::fmt::Display for US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
        }
        impl core::fmt::Display for US17 {
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
        impl core::fmt::Display for US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(Documents::US16, string, LrcPtr<StringBuilder>, i32, i32),
            US19_1(string),
        }
        impl core::fmt::Display for US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(Documents::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US20_1(string),
        }
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US21 {
            US21_0(Array<string>),
            US21_1(string),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Documents::UH2>),
        }
        impl core::fmt::Display for UH2 {
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
        impl core::fmt::Display for US22 {
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
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US23_1(std::string::String),
        }
        impl core::fmt::Display for US23 {
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
        impl core::fmt::Display for US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(std::string::String),
            US25_1(std::string::String),
        }
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US26_1,
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US27_1,
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::process::Output),
            US28_1(std::string::String),
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US29 {
            US29_0(i32),
            US29_1,
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US30_1,
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US31 {
            US31_0(CancellationToken),
            US31_1,
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US32 {
            US32_0(Result<string, LrcPtr<(string, string)>>),
            US32_1,
        }
        impl core::fmt::Display for US32 {
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
        impl core::fmt::Display for UH5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(LrcPtr<Documents::UH5>, LrcPtr<Documents::UH4>),
        }
        impl core::fmt::Display for UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0(string),
            US33_1(std::string::String),
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(u64),
            US34_1(std::string::String),
        }
        impl core::fmt::Display for US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US35 {
            US35_0(i32, string),
            US35_1(i32, string),
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut8 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<i32>,
            pub l3: MutCell<i32>,
        }
        impl core::fmt::Display for Mut8 {
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
        impl core::fmt::Display for US36 {
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
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Documents::US5> {
            Func1::new(move |v: string| Documents::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
            let v2: string = Documents::method4(v0_1);
            let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v2);
            let v6: bool = true;
            let _result_map_ = v4.map(|x| {
                //;
                let v8: std::string::String = x;
                let v10: string = fable_library_rust::String_::fromString(v8);
                let v12: bool = true;
                v10
            });
            let v14: Result<string, std::env::VarError> = _result_map_;
            let v15: string = Documents::method5();
            v14.unwrap_or(v15)
        }
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v6 {
                    Documents::US1::US1_0(v6_0_0) => Documents::US1::US1_0(
                        match &v6 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v13 {
                            Documents::US1::US1_0(v13_0_0) => Documents::US1::US1_0(
                                match &v13 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v20 {
                                    Documents::US1::US1_0(v20_0_0) => Documents::US1::US1_0(
                                        match &v20 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v27: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v27 {
                                            Documents::US1::US1_0(v27_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v27 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v34: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Documents::US1::US1_0(v34_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v34 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
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
                if (Documents::method3(string("AUTOMATION"))) != string("True") {
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
            let _run_target_args__v1: (Documents::US1, Documents::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v132: Documents::US2 = _run_target_args__v1.1.clone();
            let v131: Documents::US1 = _run_target_args__v1.0.clone();
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
                        }
                        .clone(),
                        _ => v0_1.clone(),
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
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v35: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method9() -> Func1<i64, Documents::US2> {
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
            let v20: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method9(), v5));
            let v117: DateTime = match &v20 {
                Documents::US2::US2_0(v20_0_0) => {
                    let v77: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v20 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v77.hours(),
                        v77.minutes(),
                        v77.seconds(),
                        v77.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v118: string = Documents::method10();
            let provider: string = if (v118.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v118
            };
            v117.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1_1));
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
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), string("args"), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v47: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
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
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v37: () = {
                Documents::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
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
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn method21() -> Func1<std::string::String, Documents::US6> {
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
        pub fn method26(v0_1: string, v1_1: string) -> string {
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
        pub fn method28(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_dir()
            } else {
                false
            }
        }
        pub fn method29(v0_1: string) -> Option<string> {
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
        pub fn method30(v0_1: string, v1_1: string, v2: string) -> Documents::US7 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method30: loop {
                break '_method30 (if Documents::method28(Documents::method26(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Documents::US7::US7_0(v2.get().clone())
                } else {
                    let v6: Option<string> = Documents::method29(v2.get().clone());
                    let v20: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
                    match &v20 {
                        Documents::US5::US5_0(v20_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v20 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method30;
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
        pub fn method27(v0_1: string, v1_1: string) -> Documents::US7 {
            if Documents::method28(Documents::method26(v1_1.clone(), v0_1.clone())) {
                Documents::US7::US7_0(v1_1.clone())
            } else {
                let v5: Option<string> = Documents::method29(v1_1.clone());
                let v19: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
                match &v19 {
                    Documents::US5::US5_0(v19_0_0) => Documents::method30(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v19 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
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
        pub fn method31() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method33(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), string("error"), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            let v44: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method32(
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
            let v9: string = Documents::method33(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v9
            ))
        }
        pub fn closure13(v0_1: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method32(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method31(),
                    v0_1,
                ))
            };
        }
        pub fn method34() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v5: std::path::PathBuf = v2.unwrap();
            let v19: std::path::Display = v5.display();
            let v43: std::string::String = format!("{}", v19);
            fable_library_rust::String_::fromString(v43)
        }
        pub fn method40(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v5: std::string::String = format!("{:#?}", v0_1);
            let v38: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v5), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure14(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method40(v0_1)
        }
        pub fn method39() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure14((), v))
        }
        pub fn closure15(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US8 {
            Documents::US8::US8_0(v0_1)
        }
        pub fn method41() -> Func1<std::path::PathBuf, Documents::US8> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: string) -> Documents::US8 {
            Documents::US8::US8_1(v0_1)
        }
        pub fn method42() -> Func1<string, Documents::US8> {
            Func1::new(move |v: string| Documents::closure16((), v))
        }
        pub fn method45(v0_1: string) -> string {
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
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v115));
            match &v129 {
                Documents::US5::US5_0(v129_0_0) => match &v129 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method46(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v8: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method44(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method45(v4.clone());
            let v6: Option<string> = Documents::method29(v4.clone());
            let v20: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v24: string = Documents::method46(v3);
            if (v2) >= 11_u8 {
                let v28: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v31: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v28);
                Err(v31)
            } else {
                if let Documents::US5::US5_0(v20_0_0) = &v20 {
                    if (v4.clone()) != string("") {
                        let v74: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v20_0_0.clone());
                        let v75 = Documents::method39();
                        let v87: Result<std::path::PathBuf, string> = v74.map_err(|x| v75(x));
                        let v90 = Documents::method41();
                        let v91 = Documents::method42();
                        let v92: Documents::US8 = match &v87 {
                            Err(v87_1_0) => v91(v87_1_0.clone()),
                            Ok(v87_0_0) => v90(v87_0_0.clone()),
                        };
                        match &v92 {
                            Documents::US8::US8_0(v92_0_0) => {
                                let v121: string = Documents::method26(
                                    toString(v92_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v124: &str = &*v121;
                                let v148: std::string::String = String::from(v124);
                                let v172: std::path::PathBuf = std::path::PathBuf::from(v148);
                                Ok(v172)
                            }
                            Documents::US8::US8_1(v92_1_0) => {
                                let v211: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v92_1_0.clone(),
                                        v24.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v214: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v211);
                                Err(v214)
                            }
                        }
                    } else {
                        let v254: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v24.clone(),
                                            v4.clone(), v5.clone()));
                        let v257: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v254);
                        Err(v257)
                    }
                } else {
                    let v296: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1, v24.clone(), v4, v5.clone()));
                    let v299: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v296);
                    Err(v299)
                }
            }
        }
        pub fn method43(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v6 = Documents::method39();
            let v18: Result<std::path::PathBuf, string> = v5.map_err(|x| v6(x));
            let v21 = Documents::method41();
            let v22 = Documents::method42();
            let v23: Documents::US8 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v23 {
                Documents::US8::US8_0(v23_0_0) => Ok(v23_0_0.clone()),
                Documents::US8::US8_1(v23_1_0) => Documents::method44(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure17(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v23_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure18(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method43(v0_1, v1_1, v2)
        }
        pub fn closure17(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure18(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method47(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method45(v0_1.clone());
            let v5: Option<string> = Documents::method29(v0_1.clone());
            let v19: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v23: string = Documents::method46(v3);
            if (v2) >= 11_u8 {
                let v27: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v30: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v27);
                Err(v30)
            } else {
                if let Documents::US5::US5_0(v19_0_0) = &v19 {
                    if (v0_1.clone()) != string("") {
                        let v73: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v19_0_0.clone());
                        let v74 = Documents::method39();
                        let v86: Result<std::path::PathBuf, string> = v73.map_err(|x| v74(x));
                        let v89 = Documents::method41();
                        let v90 = Documents::method42();
                        let v91: Documents::US8 = match &v86 {
                            Err(v86_1_0) => v90(v86_1_0.clone()),
                            Ok(v86_0_0) => v89(v86_0_0.clone()),
                        };
                        match &v91 {
                            Documents::US8::US8_0(v91_0_0) => {
                                let v120: string = Documents::method26(
                                    toString(v91_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v123: &str = &*v120;
                                let v147: std::string::String = String::from(v123);
                                let v171: std::path::PathBuf = std::path::PathBuf::from(v147);
                                Ok(v171)
                            }
                            Documents::US8::US8_1(v91_1_0) => {
                                let v210: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v91_1_0.clone(),
                                        v23.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v213: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v210);
                                Err(v213)
                            }
                        }
                    } else {
                        let v253: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v23.clone(),
                                            v0_1.clone(), v4.clone()));
                        let v256: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v253);
                        Err(v256)
                    }
                } else {
                    let v295: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v23.clone(), v0_1,
                                        v4.clone()));
                    let v298: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v295);
                    Err(v298)
                }
            }
        }
        pub fn method38(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v5 = Documents::method39();
            let v17: Result<std::path::PathBuf, string> = v4.map_err(|x| v5(x));
            let v20 = Documents::method41();
            let v21 = Documents::method42();
            let v22: Documents::US8 = match &v17 {
                Err(v17_1_0) => v21(v17_1_0.clone()),
                Ok(v17_0_0) => v20(v17_0_0.clone()),
            };
            match &v22 {
                Documents::US8::US8_0(v22_0_0) => Ok(v22_0_0.clone()),
                Documents::US8::US8_1(v22_1_0) => Documents::method47(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure17(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v22_1_0.clone(),
                ),
            }
        }
        pub fn method49(v0_1: bool) -> i32 {
            unbox::<i32>(&getZero())
        }
        pub fn method50() -> i32 {
            unbox::<i32>(&getZero())
        }
        pub fn method51(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(&getZero())
        }
        pub fn method53(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method45(v4.clone());
            let v6: Option<string> = Documents::method29(v4.clone());
            let v20: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v24: string = Documents::method40(v3);
            if (v2) >= 11_u8 {
                let v28: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v31: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v28);
                Err(v31)
            } else {
                if let Documents::US5::US5_0(v20_0_0) = &v20 {
                    if (v4.clone()) != string("") {
                        let v74: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v20_0_0.clone());
                        let v75 = Documents::method39();
                        let v87: Result<std::path::PathBuf, string> = v74.map_err(|x| v75(x));
                        let v90 = Documents::method41();
                        let v91 = Documents::method42();
                        let v92: Documents::US8 = match &v87 {
                            Err(v87_1_0) => v91(v87_1_0.clone()),
                            Ok(v87_0_0) => v90(v87_0_0.clone()),
                        };
                        match &v92 {
                            Documents::US8::US8_0(v92_0_0) => {
                                let v121: string = Documents::method26(
                                    toString(v92_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v124: &str = &*v121;
                                let v148: std::string::String = String::from(v124);
                                let v172: std::path::PathBuf = std::path::PathBuf::from(v148);
                                Ok(v172)
                            }
                            Documents::US8::US8_1(v92_1_0) => {
                                let v211: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v92_1_0.clone(),
                                        v24.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v214: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v211);
                                Err(v214)
                            }
                        }
                    } else {
                        let v254: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v24.clone(),
                                            v4.clone(), v5.clone()));
                        let v257: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v254);
                        Err(v257)
                    }
                } else {
                    let v296: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1, v24.clone(), v4, v5.clone()));
                    let v299: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v296);
                    Err(v299)
                }
            }
        }
        pub fn method52(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v30: i32 = Documents::method49(unbox::<bool>(&getZero()));
            let v32: bool = Documents::method51(Documents::method50(), v30);
            if v32 {
                let v34: bool = unbox::<bool>(&getZero());
                let v86: std::path::PathBuf = getZero();
                Ok(v86)
            } else {
                let v107: string =
                    append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                    v0_1.clone(), v32, v2.clone(), v1_1));
                Documents::method53(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v107),
                    v2,
                )
            }
        }
        pub fn closure20(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method52(v0_1, v1_1, v2)
        }
        pub fn closure19(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure20(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method54(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method45(v0_1.clone());
            let v5: Option<string> = Documents::method29(v0_1.clone());
            let v19: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v23: string = Documents::method40(v3);
            if (v2) >= 11_u8 {
                let v27: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v30: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v27);
                Err(v30)
            } else {
                if let Documents::US5::US5_0(v19_0_0) = &v19 {
                    if (v0_1.clone()) != string("") {
                        let v73: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v19_0_0.clone());
                        let v74 = Documents::method39();
                        let v86: Result<std::path::PathBuf, string> = v73.map_err(|x| v74(x));
                        let v89 = Documents::method41();
                        let v90 = Documents::method42();
                        let v91: Documents::US8 = match &v86 {
                            Err(v86_1_0) => v90(v86_1_0.clone()),
                            Ok(v86_0_0) => v89(v86_0_0.clone()),
                        };
                        match &v91 {
                            Documents::US8::US8_0(v91_0_0) => {
                                let v120: string = Documents::method26(
                                    toString(v91_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v123: &str = &*v120;
                                let v147: std::string::String = String::from(v123);
                                let v171: std::path::PathBuf = std::path::PathBuf::from(v147);
                                Ok(v171)
                            }
                            Documents::US8::US8_1(v91_1_0) => {
                                let v210: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v91_1_0.clone(),
                                        v23.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v213: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v210);
                                Err(v213)
                            }
                        }
                    } else {
                        let v253: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v23.clone(),
                                            v0_1.clone(), v4.clone()));
                        let v256: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v253);
                        Err(v256)
                    }
                } else {
                    let v295: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v23.clone(), v0_1,
                                        v4.clone()));
                    let v298: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v295);
                    Err(v298)
                }
            }
        }
        pub fn method48(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v29: i32 = Documents::method49(unbox::<bool>(&getZero()));
            let v31: bool = Documents::method51(Documents::method50(), v29);
            if v31 {
                let v33: bool = unbox::<bool>(&getZero());
                let v85: std::path::PathBuf = getZero();
                Ok(v85)
            } else {
                let v106: string =
                    append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                    v0_1.clone(), v31, v0_1.clone(), v1_1));
                Documents::method54(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v106),
                )
            }
        }
        pub fn method37(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method28(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method38(v0_1, 0_u8)
            }
        }
        pub fn closure21(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method55() -> Func1<std::path::PathBuf, Documents::US9> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure21((), v))
        }
        pub fn method57(v0_1: string) -> string {
            v0_1
        }
        pub fn method56(v0_1: string, v1_1: string, v2: string) -> string {
            let v5: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v8: regex::Regex = v5.unwrap();
            let v20: string = Documents::method57(v2);
            let v22: std::borrow::Cow<str> = v8.replace_all(&*v20, &*v1_1);
            let v24: std::string::String = String::from(v22);
            fable_library_rust::String_::fromString(v24)
        }
        pub fn method36(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method37(v0_1.clone());
                let v6: Option<std::path::PathBuf> = v3.ok();
                let v31: Documents::US9 =
                    defaultValue(Documents::US9::US9_1, map(Documents::method55(), v6));
                let v66: string = match &v31 {
                    Documents::US9::US9_0(v31_0_0) => {
                        let v60: string = toString(
                            match &v31 {
                                Documents::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone()
                            .display(),
                        );
                        if (v60.clone()) == string("") {
                            v0_1.clone()
                        } else {
                            v60
                        }
                    }
                    _ => v0_1.clone(),
                };
                if (v66.clone()) == string("") {
                    string("")
                } else {
                    let v71: string =
                        Documents::method56(string("^\\\\\\\\\\?\\\\"), string(""), v66);
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v71.clone(), 0_i32))),
                            getSlice(v71, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method58(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method59(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method60() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method61(v0_1: string) -> string {
            v0_1
        }
        pub fn method35(v0_1: string) -> string {
            let v4: &str = &*v0_1.clone();
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            if (v52.exists()) == false {
                let v77: string = Documents::method34();
                let v81: Array<string> = split(
                    Documents::method36(Documents::method26(v77.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v85: i32 = get_Count(v81.clone());
                let v86: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method58(v85, v86.clone()) {
                    let v88: i32 = v86.l0.get().clone();
                    let v91: i32 = ((v88.wrapping_neg()) + (v85)) - 1_i32;
                    let matchValue: i32 = v86.l1.get().clone();
                    let v93: Array<string> = v86.l2.get().clone();
                    let v92: i32 = matchValue;
                    let v94: string = v81[v91].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v94.clone()) {
                        ((v92) + 1_i32, v93.clone())
                    } else {
                        if string(".") == (v94.clone()) {
                            (v92, v93.clone())
                        } else {
                            if 0_i32 == (v92) {
                                if endsWith3(v94.clone(), string(":"), false) {
                                    let v104: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v77.clone(), 0_i32)
                                    )]);
                                    let v105: i32 = get_Count(v104.clone());
                                    let v107: i32 = (v105) + (get_Count(v93.clone()));
                                    let v108: Array<string> = new_init(&string(""), v107);
                                    let v109: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method59(v107, v109.clone()) {
                                        let v111: i32 = v109.l0.get().clone();
                                        let v116: string = if (v111) < (v105) {
                                            v104[v111].clone()
                                        } else {
                                            let v114: i32 = (v111) - (v105);
                                            v93[v114].clone()
                                        };
                                        v108.get_mut()[v111 as usize] = v116;
                                        {
                                            let v117: i32 = (v111) + 1_i32;
                                            v109.l0.set(v117);
                                            ()
                                        }
                                    }
                                    (0_i32, v108.clone())
                                } else {
                                    let v118: Array<string> = new_array(&[v94]);
                                    let v119: i32 = get_Count(v118.clone());
                                    let v121: i32 = (v119) + (get_Count(v93.clone()));
                                    let v122: Array<string> = new_init(&string(""), v121);
                                    let v123: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method59(v121, v123.clone()) {
                                        let v125: i32 = v123.l0.get().clone();
                                        let v130: string = if (v125) < (v119) {
                                            v118[v125].clone()
                                        } else {
                                            let v128: i32 = (v125) - (v119);
                                            v93[v128].clone()
                                        };
                                        v122.get_mut()[v125 as usize] = v130;
                                        {
                                            let v131: i32 = (v125) + 1_i32;
                                            v123.l0.set(v131);
                                            ()
                                        }
                                    }
                                    (0_i32, v122.clone())
                                }
                            } else {
                                ((v92) - 1_i32, v93.clone())
                            }
                        }
                    };
                    let v141: i32 = (v88) + 1_i32;
                    v86.l0.set(v141);
                    v86.l1.set(patternInput_1.0.clone());
                    v86.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v86.l1.get().clone();
                    let v143: Array<string> = v86.l2.get().clone();
                    let _let__v144: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v143 = v143.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v143 = v143.clone();
                                    move |i: i32| v143[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v143.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v155: string = ofChar(Documents::method60());
                    join(
                        if (v155.clone()) == string("\n") {
                            Documents::method61(v155.clone())
                        } else {
                            v155
                        },
                        toArray_1(_let__v144),
                    )
                }
            } else {
                let v167: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v170: std::path::PathBuf = v167.unwrap();
                let v184: std::path::Display = v170.display();
                let v208: std::string::String = format!("{}", v184);
                fable_library_rust::String_::fromString(v208)
            }
        }
        pub fn method62() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Debug")), 0_i32));
            let v9: &str = inline_colorization::color_bright_blue;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method64(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Documents::closure8(v5.clone(), string("source_dir"), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v5.clone(), v0_1, ());
                ()
            };
            let v47: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v5.clone(), string("dist_dir"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v5.clone(), v1_1, ());
                ()
            };
            let v80: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Documents::closure8(v5.clone(), string("cache_dir"), ());
                ()
            };
            let v97: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Documents::closure8(v5.clone(), v2, ());
                ()
            };
            let v113: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v5.clone(), string("hangul_spec"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v5.clone(), v3, ());
                ()
            };
            let v147: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method63(
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
            let v12: string = Documents::method64(v8, v9, v10, v11);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v12
            ))
        }
        pub fn closure22(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method63(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Documents::method8(v22, v23, v24, v25, v26, v27),
                    Documents::method62(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                ))
            };
        }
        pub fn closure24(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method65() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure24((), v))
        }
        pub fn closure25(unitVar: (), v0_1: std::fs::FileType) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method66() -> Func1<std::fs::FileType, Documents::US10> {
            Func1::new(move |v: std::fs::FileType| Documents::closure25((), v))
        }
        pub fn closure26(unitVar: (), v0_1: std::string::String) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn method67() -> Func1<std::string::String, Documents::US10> {
            Func1::new(move |v: std::string::String| Documents::closure26((), v))
        }
        pub fn closure23(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(
                /*;
                let v4: bool = */
                async {
                    /*;
                    let v6: bool = */
 //;
                    let v8: bool = true;
                    let __future_init = Box::pin(
                        /*;
                        let v10: bool = */
                        async move {
                            /*;
                            let v12: bool = */
 //;
                            let v14: async_walkdir::DirEntry = v0_1.clone();
                            let v16: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                            Output = Result<std::fs::FileType, std::io::Error>,
                                        > + Send,
                                >,
                            > = Box::pin(async_walkdir::DirEntry::file_type(&v14));
                            let v18: Result<std::fs::FileType, std::io::Error> = v16.await;
                            let v19 = Documents::method65();
                            let v31: Result<std::fs::FileType, std::string::String> =
                                v18.map_err(|x| v19(x));
                            let v34 = Documents::method66();
                            let v35 = Documents::method67();
                            let v36: Documents::US10 = match &v31 {
                                Err(v31_1_0) => v35(v31_1_0.clone()),
                                Ok(v31_0_0) => v34(v31_0_0.clone()),
                            };
                            let v172: Documents::US11 = if let Documents::US10::US10_0(v36_0_0) =
                                &v36
                            {
                                if std::fs::FileType::is_dir(&v36_0_0.clone()) {
                                    Documents::US11::US11_0
                                } else {
                                    let v42: std::path::PathBuf =
                                        async_walkdir::DirEntry::path(&v0_1.clone());
                                    let v45: std::path::Display = v42.display();
                                    let v69: std::string::String = format!("{}", v45);
                                    let v92: string = fable_library_rust::String_::fromString(v69);
                                    if if (endsWith3(v92.clone(), string(".md"), false)) == false {
                                        true
                                    } else {
                                        endsWith3(v92, string(".hangul.md"), false)
                                    } {
                                        Documents::US11::US11_0
                                    } else {
                                        Documents::US11::US11_2
                                    }
                                }
                            } else {
                                let v108: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                                let v111: std::path::Display = v108.display();
                                let v135: std::string::String = format!("{}", v111);
                                let v158: string = fable_library_rust::String_::fromString(v135);
                                if if (endsWith3(v158.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    endsWith3(v158, string(".hangul.md"), false)
                                } {
                                    Documents::US11::US11_0
                                } else {
                                    Documents::US11::US11_2
                                }
                            };
                            let v175: string = string("}");
                            let v180: bool = true;
                            let _fix_closure_v177 = v172;
                            let v187: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v177 "), (v175))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v188: bool = true;
                            _fix_closure_v177
                        },
                    ); // rust.fix_closure';
                    let v190 = __future_init;
                    let v192: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US11> + Send>,
                    > = v190;
                    let v194: Documents::US11 = v192.await;
                    let v203: async_walkdir::Filtering = match &v194 {
                        Documents::US11::US11_0 => async_walkdir::Filtering::Ignore,
                        Documents::US11::US11_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v204: string = string("}");
                    let v209: bool = true;
                    let _fix_closure_v206 = v203;
                    let v216: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v206 "), (v204))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v217: bool = true;
                    _fix_closure_v206
                },
            ); // rust.fix_closure';
            let v219 = __future_init;
            v219
        }
        pub fn closure28(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method69() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure28((), v))
        }
        pub fn closure29(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn method70() -> Func1<async_walkdir::DirEntry, Documents::US12> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure29((), v))
        }
        pub fn closure30(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn method71() -> Func1<std::string::String, Documents::US12> {
            Func1::new(move |v: std::string::String| Documents::closure30((), v))
        }
        pub fn method72() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method74(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), string("error"), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method73(
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
            let v9: string = Documents::method74(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / stream_filter_map"),
                v9
            ))
        }
        pub fn closure31(v0_1: std::string::String, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method73(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method72(),
                    v0_1,
                ))
            };
        }
        pub fn closure27(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method69();
            let v13: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v16 = Documents::method70();
            let v17 = Documents::method71();
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
                        Documents::closure31(v18_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v118 {
                Documents::US5::US5_0(v118_0_0) => Some(
                    match &v118 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method68(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure27((), v)
                },
            )
        }
        pub fn method76(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), string("files_len"), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method75(
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
            let v9: string = Documents::method76(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v9
            ))
        }
        pub fn closure32(v0_1: Vec<string>, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method75(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method62(),
                    v0_1.len(),
                ))
            };
        }
        pub fn method77() -> string {
            string("")
        }
        pub fn method78(v0_1: string) -> string {
            Documents::method36(Documents::method35(v0_1))
        }
        pub fn method80(
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
        pub fn method82() -> string {
            string("")
        }
        pub fn closure36(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure35(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure36(v0_1, v)
            })
        }
        pub fn method83() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure35((), v))
        }
        pub fn method84(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method84: loop {
                break '_method84 (match v0_1.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Documents::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == (v4);
                        let patternInput: (i32, i32) = if v6 {
                            ((v2.get().clone()) + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), (v3.get().clone()) + 1_i32)
                        };
                        {
                            let v0_1_temp: LrcPtr<Documents::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
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
                            continue '_method84;
                        }
                    }
                });
            }
        }
        pub fn closure37(v0_1: i32, v1_1: i32, v2: string) -> string {
            if (v1_1) >= (v0_1) {
                v2.clone()
            } else {
                (Documents::method85(v0_1, (v1_1) + 1_i32))(append((v2), string(" ")))
            }
        }
        pub fn method85(v0_1: i32, v1_1: i32) -> Func1<string, string> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure37(v0_1, v1_1, v)
            })
        }
        pub fn closure34(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US14 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '\"' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method59(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method84(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method83())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US14::US14_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method85((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
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
            if string("") == (v0_1.clone()) {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '\'' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method59(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method84(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method83())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US14::US14_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method85((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn method86(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US14 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method86: loop {
                break '_method86 (match v2.get().clone().as_ref() {
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
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method86;
                            }
                        }
                    }
                });
            }
        }
        pub fn method87(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method87: loop {
                break '_method87 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US16 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US16::US16_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US16::US16_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US16::US16_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US16::US16_0(v11_0_0) => match &v11 {
                                Documents::US16::US16_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method87;
                    }
                });
            }
        }
        pub fn method88(
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
            '_method88: loop {
                break '_method88 ({
                    let v109: Documents::US14 = if string("") == (v1_1.get().clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v21: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method87(v21, 0_i64)) == false {
                            let v44: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v49: string = ofChar(v21);
                            let v52: i32 = length(v49.clone());
                            let v53: Array<char> = new_init(&'\u{0000}', v52);
                            let v54: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method59(v52, v54.clone()) {
                                let v56: i32 = v54.l0.get().clone();
                                let v57: char = getCharAt(v49.clone(), v56);
                                v53.get_mut()[v56 as usize] = v57;
                                {
                                    let v58: i32 = (v56) + 1_i32;
                                    v54.l0.set(v58);
                                    ()
                                }
                            }
                            {
                                let v59: List<char> = ofArray(v53.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method84(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method83())(b0)(b1)
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
                                if '\\' == (v110) { '/' } else { v110 },
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
                                append((v0_1.get().clone()), (ofChar(v121_0_0.clone())));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method88;
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
        pub fn method89(
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
            '_method89: loop {
                break '_method89 (match v4.get().clone().as_ref() {
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
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method89;
                            }
                        }
                    }
                });
            }
        }
        pub fn method90(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method90: loop {
                break '_method90 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US16 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US16::US16_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US16::US16_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US16::US16_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US16::US16_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US16::US16_0(v15_0_0) => match &v15 {
                                Documents::US16::US16_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method90;
                    }
                });
            }
        }
        pub fn method91(
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
            '_method91: loop {
                break '_method91 ({
                    let v115: Documents::US14 = if string("") == (v1_1.get().clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method90(v24, 0_i64)) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method59(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = (v59) + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method84(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method83())(b0)(b1)
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
                                if '\\' == (v116) { '/' } else { v116 },
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
                                append((v0_1.get().clone()), (ofChar(v127_0_0.clone())));
                            let v1_1_temp: string = v127_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v127_0_2.clone();
                            let v3_temp: i32 = v127_0_3.clone();
                            let v4_temp: i32 = v127_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method91;
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
        pub fn method92(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method92: loop {
                break '_method92 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method92;
                    } else {
                        v1_1.get().clone()
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
                    let v79: Documents::US14 = if string("") == (v1_1.get().clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v10: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v30: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v35: string = ofChar(v10);
                        let v38: i32 = length(v35.clone());
                        let v39: Array<char> = new_init(&'\u{0000}', v38);
                        let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method59(v38, v40.clone()) {
                            let v42: i32 = v40.l0.get().clone();
                            let v43: char = getCharAt(v35.clone(), v42);
                            v39.get_mut()[v42 as usize] = v43;
                            {
                                let v44: i32 = (v42) + 1_i32;
                                v40.l0.set(v44);
                                ()
                            }
                        }
                        {
                            let v45: List<char> = ofArray(v39.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method84(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method83())(b0)(b1)
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
                                append((v0_1.get().clone()), (ofChar(v79_0_0.clone())));
                            let v1_1_temp: string = v79_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v79_0_2.clone();
                            let v3_temp: i32 = v79_0_3.clone();
                            let v4_temp: i32 = v79_0_4.clone();
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
        pub fn method81(v0_1: string) -> Documents::US13 {
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
                    StringBuilder::_ctor__Z721C83C5(Documents::method82());
                fn v15(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US14 {
                    Documents::closure34((), arg10_0040)
                }
                fn v16(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US14 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v20: Documents::US14 = Documents::method86(
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
                        let v130: Documents::US14 = if string("") == (v22.clone()) {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v23.clone(), v24, v25)
                            ))
                        } else {
                            let v42: char = getCharAt(v22.clone(), 0_i32);
                            if (Documents::method87(v42, 0_i64)) == false {
                                let v65: string = getSlice(
                                    v22.clone(),
                                    Some(1_i32),
                                    Some((length(v22.clone())) - 1_i32),
                                );
                                let v70: string = ofChar(v42);
                                let v73: i32 = length(v70.clone());
                                let v74: Array<char> = new_init(&'\u{0000}', v73);
                                let v75: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method59(v73, v75.clone()) {
                                    let v77: i32 = v75.l0.get().clone();
                                    let v78: char = getCharAt(v70.clone(), v77);
                                    v74.get_mut()[v77 as usize] = v78;
                                    {
                                        let v79: i32 = (v77) + 1_i32;
                                        v75.l0.set(v79);
                                        ()
                                    }
                                }
                                {
                                    let v80: List<char> = ofArray(v74.clone());
                                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method84(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method83())(b0)(b1)
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
                                    if '\\' == (v131) { '/' } else { v131 },
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
                                ) = Documents::method88(
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
                                let v180: Documents::US14 = Documents::method89(
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
                                                                         (v22.clone(),
                                                                          v23.clone(),
                                                                          v24,
                                                                          v25),
                                                                         (v173.clone(),
                                                                          v174.clone(),
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
                        let v321: Documents::US14 = if string("") == (v7.clone()) {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v12.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v228: char = getCharAt(v7.clone(), 0_i32);
                            if (Documents::method90(v228, 0_i64)) == false {
                                let v251: string = getSlice(
                                    v7.clone(),
                                    Some(1_i32),
                                    Some((length(v7.clone())) - 1_i32),
                                );
                                let v256: string = ofChar(v228);
                                let v259: i32 = length(v256.clone());
                                let v260: Array<char> = new_init(&'\u{0000}', v259);
                                let v261: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method59(v259, v261.clone()) {
                                    let v263: i32 = v261.l0.get().clone();
                                    let v264: char = getCharAt(v256.clone(), v263);
                                    v260.get_mut()[v263 as usize] = v264;
                                    {
                                        let v265: i32 = (v263) + 1_i32;
                                        v261.l0.set(v265);
                                        ()
                                    }
                                }
                                {
                                    let v266: List<char> = ofArray(v260.clone());
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method84(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method83())(b0)(b1)
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
                                    if '\\' == (v322) { '/' } else { v322 },
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
                                ) = Documents::method91(
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
                                let v366: Documents::US17 = if (length(v7.clone())) == 0_i32 {
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
                                                Some(Documents::method92(v377.clone(), 0_i32)),
                                                Some((length(v377)) - 1_i32),
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
                let v682: Documents::US18 = match &v414 {
                    Documents::US15::US15_0(v414_0_0, v414_0_1, v414_0_2, v414_0_3, v414_0_4) => {
                        let v419: i32 = v414_0_4.clone();
                        let v418: i32 = v414_0_3.clone();
                        let v417: LrcPtr<StringBuilder> = v414_0_2.clone();
                        let v416: string = v414_0_1.clone();
                        let v541: Documents::US14 = if string("") == (v416.clone()) {
                            Documents::US14::US14_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v417.clone(), v418, v419)
                            ))
                        } else {
                            let v425: char = getCharAt(v416.clone(), 0_i32);
                            if (v425) == ' ' {
                                let v446: string = getSlice(
                                    v416.clone(),
                                    Some(1_i32),
                                    Some((length(v416.clone())) - 1_i32),
                                );
                                let v451: string = ofChar(v425);
                                let v454: i32 = length(v451.clone());
                                let v455: Array<char> = new_init(&'\u{0000}', v454);
                                let v456: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method59(v454, v456.clone()) {
                                    let v458: i32 = v456.l0.get().clone();
                                    let v459: char = getCharAt(v451.clone(), v458);
                                    v455.get_mut()[v458 as usize] = v459;
                                    {
                                        let v460: i32 = (v458) + 1_i32;
                                        v456.l0.set(v460);
                                        ()
                                    }
                                }
                                {
                                    let v461: List<char> = ofArray(v455.clone());
                                    let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method84(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                        (Documents::method83())(b0)(b1)
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
                                let v499: i32 = (indexOf(v416.clone(), string("\n"))) - 1_i32;
                                Documents::US14::US14_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                            ' ',
                                                                                            v418,
                                                                                            v419,
                                                                                            v417.clone(),
                                                                                            getSlice(v416.clone(),
                                                                                                     Some(0_i32),
                                                                                                     Some((if -2_i32
                                                                                                                  ==
                                                                                                                  (v499)
                                                                                                              {
                                                                                                               (length(v416.clone()))
                                                                                                                   +
                                                                                                                   1_i32
                                                                                                           } else {
                                                                                                               (v499)
                                                                                                                   +
                                                                                                                   1_i32
                                                                                                           })
                                                                                                              -
                                                                                                              1_i32))),
                                                                                   string("\n"),
                                                                                   append(((Documents::method85((v419)
                                                                                                                    -
                                                                                                                    1_i32,
                                                                                                                0_i32))(string(""))),
                                                                                          string("^")),
                                                                                   string("\n")])))
                            }
                        };
                        let v553: Documents::US19 = match &v541 {
                            Documents::US14::US14_0(
                                v541_0_0,
                                v541_0_1,
                                v541_0_2,
                                v541_0_3,
                                v541_0_4,
                            ) => Documents::US19::US19_0(
                                Documents::US16::US16_0(v541_0_0.clone()),
                                v541_0_1.clone(),
                                v541_0_2.clone(),
                                v541_0_3.clone(),
                                v541_0_4.clone(),
                            ),
                            _ => Documents::US19::US19_0(
                                Documents::US16::US16_1,
                                v416.clone(),
                                v417.clone(),
                                v418,
                                v419,
                            ),
                        };
                        let v656: Documents::US15 = match &v553 {
                            Documents::US19::US19_0(
                                v553_0_0,
                                v553_0_1,
                                v553_0_2,
                                v553_0_3,
                                v553_0_4,
                            ) => {
                                let v558: i32 = v553_0_4.clone();
                                let v557: i32 = v553_0_3.clone();
                                let v556: LrcPtr<StringBuilder> = v553_0_2.clone();
                                let v555: string = v553_0_1.clone();
                                let v633: Documents::US14 = if string("") == (v555.clone()) {
                                    Documents::US14::US14_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v556.clone(), v557, v558)
                                    ))
                                } else {
                                    let v564: char = getCharAt(v555.clone(), 0_i32);
                                    let v584: string = getSlice(
                                        v555.clone(),
                                        Some(1_i32),
                                        Some((length(v555)) - 1_i32),
                                    );
                                    let v589: string = ofChar(v564);
                                    let v592: i32 = length(v589.clone());
                                    let v593: Array<char> = new_init(&'\u{0000}', v592);
                                    let v594: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method59(v592, v594.clone()) {
                                        let v596: i32 = v594.l0.get().clone();
                                        let v597: char = getCharAt(v589.clone(), v596);
                                        v593.get_mut()[v596 as usize] = v597;
                                        {
                                            let v598: i32 = (v596) + 1_i32;
                                            v594.l0.set(v598);
                                            ()
                                        }
                                    }
                                    {
                                        let v599: List<char> = ofArray(v593.clone());
                                        let patternInput_5:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Documents::method84(foldBack(Func2::new(move
                                                                                                    |b0:
                                                                                                         char,
                                                                                                     b1:
                                                                                                         LrcPtr<Documents::UH0>|
                                                                                                    (Documents::method83())(b0)(b1)),
                                                                                     v599,
                                                                                     LrcPtr::new(Documents::UH0::UH0_0)),
                                                                            v556,
                                                                            v557,
                                                                            v558);
                                        Documents::US14::US14_0(
                                            v564,
                                            v584,
                                            patternInput_5.0.clone(),
                                            patternInput_5.1.clone(),
                                            patternInput_5.2.clone(),
                                        )
                                    }
                                };
                                match &v633 {
                                    Documents::US14::US14_0(
                                        v633_0_0,
                                        v633_0_1,
                                        v633_0_2,
                                        v633_0_3,
                                        v633_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Documents::method93(
                                            ofChar(v633_0_0.clone()),
                                            v633_0_1.clone(),
                                            v633_0_2.clone(),
                                            v633_0_3.clone(),
                                            v633_0_4.clone(),
                                        );
                                        Documents::US15::US15_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Documents::US14::US14_1(v633_1_0) => {
                                        Documents::US15::US15_1(v633_1_0.clone())
                                    }
                                }
                            }
                            Documents::US19::US19_1(v553_1_0) => {
                                Documents::US15::US15_1(v553_1_0.clone())
                            }
                        };
                        let v668: Documents::US20 = match &v656 {
                            Documents::US15::US15_0(
                                v656_0_0,
                                v656_0_1,
                                v656_0_2,
                                v656_0_3,
                                v656_0_4,
                            ) => Documents::US20::US20_0(
                                Documents::US5::US5_0(v656_0_0.clone()),
                                v656_0_1.clone(),
                                v656_0_2.clone(),
                                v656_0_3.clone(),
                                v656_0_4.clone(),
                            ),
                            _ => Documents::US20::US20_0(
                                Documents::US5::US5_1,
                                v416.clone(),
                                v417.clone(),
                                v418,
                                v419,
                            ),
                        };
                        match &v668 {
                            Documents::US20::US20_0(
                                v668_0_0,
                                v668_0_1,
                                v668_0_2,
                                v668_0_3,
                                v668_0_4,
                            ) => Documents::US18::US18_0(
                                v414_0_0.clone(),
                                v668_0_0.clone(),
                                v668_0_1.clone(),
                                v668_0_2.clone(),
                                v668_0_3.clone(),
                                v668_0_4.clone(),
                            ),
                            Documents::US20::US20_1(v668_1_0) => {
                                Documents::US18::US18_1(v668_1_0.clone())
                            }
                        }
                    }
                    Documents::US15::US15_1(v414_1_0) => Documents::US18::US18_1(v414_1_0.clone()),
                };
                match &v682 {
                    Documents::US18::US18_0(
                        v682_0_0,
                        v682_0_1,
                        v682_0_2,
                        v682_0_3,
                        v682_0_4,
                        v682_0_5,
                    ) => Documents::US13::US13_0(v682_0_0.clone(), v682_0_1.clone()),
                    Documents::US18::US18_1(v682_1_0) => Documents::US13::US13_1(v682_1_0.clone()),
                }
            }
        }
        pub fn method96(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method96: loop {
                break '_method96 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US16 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US16::US16_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US16::US16_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US16::US16_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US16::US16_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US16::US16_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US16::US16_0(v19_0_0) => match &v19 {
                                Documents::US16::US16_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method96;
                    }
                });
            }
        }
        pub fn method97(
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
            '_method97: loop {
                break '_method97 ({
                    let v121: Documents::US14 = if string("") == (v1_1.get().clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method96(v27, 0_i64)) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method59(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = (v62) + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method84(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method83())(b0)(b1)
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
                                append((v0_1.get().clone()), (ofChar(v121_0_0.clone())));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method97;
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
        pub fn method99(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method99: loop {
                break '_method99 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US16 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US16::US16_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US16::US16_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US16::US16_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US16::US16_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US16::US16_0(v15_0_0) => match &v15 {
                                Documents::US16::US16_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method99;
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
            let v126: Documents::US14 = if string("") == (v0_1.clone()) {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '\\' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method59(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method84(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method83())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US14::US14_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method85((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v210: Documents::US14 = match &v126 {
                Documents::US14::US14_0(v126_0_0, v126_0_1, v126_0_2, v126_0_3, v126_0_4) => {
                    let v131: i32 = v126_0_4.clone();
                    let v130: i32 = v126_0_3.clone();
                    let v129: LrcPtr<StringBuilder> = v126_0_2.clone();
                    let v128: string = v126_0_1.clone();
                    if string("") == (v128.clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v129.clone(), v130, v131)
                        ))
                    } else {
                        let v137: char = getCharAt(v128.clone(), 0_i32);
                        let v157: string =
                            getSlice(v128.clone(), Some(1_i32), Some((length(v128)) - 1_i32));
                        let v162: string = ofChar(v137);
                        let v165: i32 = length(v162.clone());
                        let v166: Array<char> = new_init(&'\u{0000}', v165);
                        let v167: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method59(v165, v167.clone()) {
                            let v169: i32 = v167.l0.get().clone();
                            let v170: char = getCharAt(v162.clone(), v169);
                            v166.get_mut()[v169 as usize] = v170;
                            {
                                let v171: i32 = (v169) + 1_i32;
                                v167.l0.set(v171);
                                ()
                            }
                        }
                        {
                            let v172: List<char> = ofArray(v166.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method84(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method83())(b0)(b1)
                                        }),
                                        v172,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v129,
                                    v130,
                                    v131,
                                );
                            Documents::US14::US14_0(
                                v137,
                                v157,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v126_1_0) => Documents::US14::US14_1(v126_1_0.clone()),
            };
            match &v210 {
                Documents::US14::US14_0(v210_0_0, v210_0_1, v210_0_2, v210_0_3, v210_0_4) => {
                    Documents::US15::US15_0(
                        append((ofChar('\\')), (ofChar(v210_0_0.clone()))),
                        v210_0_1.clone(),
                        v210_0_2.clone(),
                        v210_0_3.clone(),
                        v210_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v210_1_0) => Documents::US15::US15_1(v210_1_0.clone()),
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
            let v126: Documents::US14 = if string("") == (v0_1.clone()) {
                Documents::US14::US14_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '`' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method59(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method84(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                    (Documents::method83())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US14::US14_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method85((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v210: Documents::US14 = match &v126 {
                Documents::US14::US14_0(v126_0_0, v126_0_1, v126_0_2, v126_0_3, v126_0_4) => {
                    let v131: i32 = v126_0_4.clone();
                    let v130: i32 = v126_0_3.clone();
                    let v129: LrcPtr<StringBuilder> = v126_0_2.clone();
                    let v128: string = v126_0_1.clone();
                    if string("") == (v128.clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v129.clone(), v130, v131)
                        ))
                    } else {
                        let v137: char = getCharAt(v128.clone(), 0_i32);
                        let v157: string =
                            getSlice(v128.clone(), Some(1_i32), Some((length(v128)) - 1_i32));
                        let v162: string = ofChar(v137);
                        let v165: i32 = length(v162.clone());
                        let v166: Array<char> = new_init(&'\u{0000}', v165);
                        let v167: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                            l0: MutCell::new(0_i32),
                        });
                        while Documents::method59(v165, v167.clone()) {
                            let v169: i32 = v167.l0.get().clone();
                            let v170: char = getCharAt(v162.clone(), v169);
                            v166.get_mut()[v169 as usize] = v170;
                            {
                                let v171: i32 = (v169) + 1_i32;
                                v167.l0.set(v171);
                                ()
                            }
                        }
                        {
                            let v172: List<char> = ofArray(v166.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method84(
                                    foldBack(
                                        Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                            (Documents::method83())(b0)(b1)
                                        }),
                                        v172,
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    ),
                                    v129,
                                    v130,
                                    v131,
                                );
                            Documents::US14::US14_0(
                                v137,
                                v157,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Documents::US14::US14_1(v126_1_0) => Documents::US14::US14_1(v126_1_0.clone()),
            };
            match &v210 {
                Documents::US14::US14_0(v210_0_0, v210_0_1, v210_0_2, v210_0_3, v210_0_4) => {
                    Documents::US15::US15_0(
                        append((ofChar('`')), (ofChar(v210_0_0.clone()))),
                        v210_0_1.clone(),
                        v210_0_2.clone(),
                        v210_0_3.clone(),
                        v210_0_4.clone(),
                    )
                }
                Documents::US14::US14_1(v210_1_0) => Documents::US15::US15_1(v210_1_0.clone()),
            }
        }
        pub fn method100(
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
            '_method100: loop {
                break '_method100 (match v4.get().clone().as_ref() {
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
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method100;
                            }
                        }
                    }
                });
            }
        }
        pub fn method101(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method101: loop {
                break '_method101 (match v0_1.get().clone().as_ref() {
                    Documents::UH2::UH2_0 => v1_1.get().clone(),
                    Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Documents::UH2> = match v0_1.get().clone().as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(Documents::UH2::UH2_1(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method101;
                    }
                });
            }
        }
        pub fn method98(
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
            '_method98: loop {
                break '_method98 ({
                    let v115: Documents::US14 = if string("") == (v1_1.get().clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method99(v24, 0_i64)) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method59(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = (v59) + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method84(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method83())(b0)(b1)
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
                        _ => Documents::method100(
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
                            continue '_method98;
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method101(
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
        pub fn method102(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method102(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method103(
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
            '_method103: loop {
                break '_method103 ({
                    let v115: Documents::US14 = if string("") == (v1_1.get().clone()) {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method99(v24, 0_i64)) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method59(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = (v59) + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method84(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method83())(b0)(b1)
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
                            continue '_method103;
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method101(
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
        pub fn method95(
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
            '_method95: loop {
                break '_method95 ({
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v121: Documents::US14 = if v5 {
                        Documents::US14::US14_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method96(v27, 0_i64)) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                                l0: MutCell::new(0_i32),
                            });
                            while Documents::method59(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = (v62) + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method84(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method83())(b0)(b1)
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
                                Documents::method97(
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
                            let v268: Documents::US14 = if v5 {
                                Documents::US14::US14_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                  '\"',
                                                                                  (v2.get().clone(),
                                                                                   v3.get().clone(),
                                                                                   v4.get().clone())))
                            } else {
                                let v151: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if (v151) == '\"' {
                                    let v172: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some((length(v1_1.get().clone())) - 1_i32),
                                    );
                                    let v177: string = ofChar(v151);
                                    let v180: i32 = length(v177.clone());
                                    let v181: Array<char> = new_init(&'\u{0000}', v180);
                                    let v182: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method59(v180, v182.clone()) {
                                        let v184: i32 = v182.l0.get().clone();
                                        let v185: char = getCharAt(v177.clone(), v184);
                                        v181.get_mut()[v184 as usize] = v185;
                                        {
                                            let v186: i32 = (v184) + 1_i32;
                                            v182.l0.set(v186);
                                            ()
                                        }
                                    }
                                    {
                                        let v187: List<char> = ofArray(v181.clone());
                                        let patternInput_2:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Documents::method84(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Documents::UH0>|
                                                                                                         (Documents::method83())(b0)(b1)),
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
                                    let v225: i32 =
                                        (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                    Documents::US14::US14_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                         '\"',
                                                                                                         v3.get().clone(),
                                                                                                         v4.get().clone(),
                                                                                                         v2.get().clone(),
                                                                                                         getSlice(v1_1.get().clone(),
                                                                                                                  Some(0_i32),
                                                                                                                  Some((if -2_i32
                                                                                                                               ==
                                                                                                                               (v225)
                                                                                                                           {
                                                                                                                            (length(v1_1.get().clone()))
                                                                                                                                +
                                                                                                                                1_i32
                                                                                                                        } else {
                                                                                                                            (v225)
                                                                                                                                +
                                                                                                                                1_i32
                                                                                                                        })
                                                                                                                           -
                                                                                                                           1_i32))),
                                                                                                string("\n"),
                                                                                                append(((Documents::method85((v4.get().clone())
                                                                                                                                 -
                                                                                                                                 1_i32,
                                                                                                                             0_i32))(string(""))),
                                                                                                       string("^")),
                                                                                                string("\n")])))
                                }
                            };
                            let v452: Documents::US15 = match &v268 {
                                Documents::US14::US14_0(
                                    v268_0_0,
                                    v268_0_1,
                                    v268_0_2,
                                    v268_0_3,
                                    v268_0_4,
                                ) => {
                                    let v273: i32 = v268_0_4.clone();
                                    let v272: i32 = v268_0_3.clone();
                                    let v271: LrcPtr<StringBuilder> = v268_0_2.clone();
                                    let v270: string = v268_0_1.clone();
                                    let v275: Documents::US22 = Documents::method98(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v270.clone(),
                                        v271.clone(),
                                        v272,
                                        v273,
                                    );
                                    let v302: Documents::US15 = match &v275 {
                                        Documents::US22::US22_0(
                                            v275_0_0,
                                            v275_0_1,
                                            v275_0_2,
                                            v275_0_3,
                                            v275_0_4,
                                        ) => {
                                            let v282: List<string> = Documents::method102(
                                                v275_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US15::US15_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v282 = v282.clone();
                                                        move || ofList(v282.clone()).clone()
                                                    }))),
                                                ),
                                                v275_0_1.clone(),
                                                v275_0_2.clone(),
                                                v275_0_3.clone(),
                                                v275_0_4.clone(),
                                            )
                                        }
                                        Documents::US22::US22_1(v275_1_0) => {
                                            Documents::US15::US15_1(v275_1_0.clone())
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
                                            let v430: Documents::US14 = if string("")
                                                == (v304.clone())
                                            {
                                                Documents::US14::US14_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                                      '\"',
                                                                                                      (v305.clone(),
                                                                                                       v306,
                                                                                                       v307)))
                                            } else {
                                                let v313: char = getCharAt(v304.clone(), 0_i32);
                                                if (v313) == '\"' {
                                                    let v334: string = getSlice(
                                                        v304.clone(),
                                                        Some(1_i32),
                                                        Some((length(v304.clone())) - 1_i32),
                                                    );
                                                    let v339: string = ofChar(v313);
                                                    let v342: i32 = length(v339.clone());
                                                    let v343: Array<char> =
                                                        new_init(&'\u{0000}', v342);
                                                    let v344: LrcPtr<Documents::Mut6> =
                                                        LrcPtr::new(Documents::Mut6 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Documents::method59(v342, v344.clone()) {
                                                        let v346: i32 = v344.l0.get().clone();
                                                        let v347: char =
                                                            getCharAt(v339.clone(), v346);
                                                        v343.get_mut()[v346 as usize] = v347;
                                                        {
                                                            let v348: i32 = (v346) + 1_i32;
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
                                                                                 Documents::method84(foldBack(Func2::new(move
                                                                                                                             |b0:
                                                                                                                                  char,
                                                                                                                              b1:
                                                                                                                                  LrcPtr<Documents::UH0>|
                                                                                                                             (Documents::method83())(b0)(b1)),
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
                                                    let v387: i32 =
                                                        (indexOf(v304.clone(), string("\n")))
                                                            - 1_i32;
                                                    Documents::US14::US14_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                             '\"',
                                                                                                                             v306,
                                                                                                                             v307,
                                                                                                                             v305.clone(),
                                                                                                                             getSlice(v304.clone(),
                                                                                                                                      Some(0_i32),
                                                                                                                                      Some((if -2_i32
                                                                                                                                                   ==
                                                                                                                                                   (v387)
                                                                                                                                               {
                                                                                                                                                (length(v304.clone()))
                                                                                                                                                    +
                                                                                                                                                    1_i32
                                                                                                                                            } else {
                                                                                                                                                (v387)
                                                                                                                                                    +
                                                                                                                                                    1_i32
                                                                                                                                            })
                                                                                                                                               -
                                                                                                                                               1_i32))),
                                                                                                                    string("\n"),
                                                                                                                    append(((Documents::method85((v307)
                                                                                                                                                     -
                                                                                                                                                     1_i32,
                                                                                                                                                 0_i32))(string(""))),
                                                                                                                           string("^")),
                                                                                                                    string("\n")])))
                                                }
                                            };
                                            match &v430 {
                                                                 Documents::US14::US14_0(v430_0_0,
                                                                                         v430_0_1,
                                                                                         v430_0_2,
                                                                                         v430_0_3,
                                                                                         v430_0_4)
                                                                 =>
                                                                 Documents::US15::US15_0(v302_0_0.clone(),
                                                                                         v430_0_1.clone(),
                                                                                         v430_0_2.clone(),
                                                                                         v430_0_3.clone(),
                                                                                         v430_0_4.clone()),
                                                                 Documents::US14::US14_1(v430_1_0)
                                                                 =>
                                                                 Documents::US15::US15_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v430_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v270.clone(),
                                                                                                   v271.clone(),
                                                                                                   v272,
                                                                                                   v273),
                                                                                                  (v304.clone(),
                                                                                                   v305.clone(),
                                                                                                   v306,
                                                                                                   v307))),
                                                             }
                                        }
                                        _ => Documents::US15::US15_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Documents::US14::US14_1(v268_1_0) => {
                                    Documents::US15::US15_1(v268_1_0.clone())
                                }
                            };
                            match &v452 {
                                Documents::US15::US15_0(
                                    v452_0_0,
                                    v452_0_1,
                                    v452_0_2,
                                    v452_0_3,
                                    v452_0_4,
                                ) => v452.clone(),
                                _ => {
                                    let v464: Documents::US15 =
                                                     Documents::method100(v1_1.get().clone(),
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
                                    let v475: Documents::US15 = match &v464 {
                                        Documents::US15::US15_0(
                                            v464_0_0,
                                            v464_0_1,
                                            v464_0_2,
                                            v464_0_3,
                                            v464_0_4,
                                        ) => Documents::US15::US15_0(
                                            string(""),
                                            v464_0_1.clone(),
                                            v464_0_2.clone(),
                                            v464_0_3.clone(),
                                            v464_0_4.clone(),
                                        ),
                                        Documents::US15::US15_1(v464_1_0) => {
                                            Documents::US15::US15_1(v464_1_0.clone())
                                        }
                                    };
                                    let v486: Documents::US22 = match &v475 {
                                        Documents::US15::US15_0(
                                            v475_0_0,
                                            v475_0_1,
                                            v475_0_2,
                                            v475_0_3,
                                            v475_0_4,
                                        ) => Documents::method103(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v475_0_1.clone(),
                                            v475_0_2.clone(),
                                            v475_0_3.clone(),
                                            v475_0_4.clone(),
                                        ),
                                        Documents::US15::US15_1(v475_1_0) => {
                                            Documents::US22::US22_1(v475_1_0.clone())
                                        }
                                    };
                                    match &v486 {
                                        Documents::US22::US22_0(
                                            v486_0_0,
                                            v486_0_1,
                                            v486_0_2,
                                            v486_0_3,
                                            v486_0_4,
                                        ) => {
                                            let v493: List<string> = Documents::method102(
                                                v486_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US15::US15_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v493 = v493.clone();
                                                        move || ofList(v493.clone()).clone()
                                                    }))),
                                                ),
                                                v486_0_1.clone(),
                                                v486_0_2.clone(),
                                                v486_0_3.clone(),
                                                v486_0_4.clone(),
                                            )
                                        }
                                        Documents::US22::US22_1(v486_1_0) => {
                                            Documents::US15::US15_1(v486_1_0.clone())
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
                            let v524: i32 = Documents::method92(v519.clone(), 0_i32);
                            let v552: Documents::US17 = if 0_i32 == (v524) {
                                Documents::US17::US17_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US17::US17_0(
                                    getSlice(
                                        v519.clone(),
                                        Some(v524),
                                        Some((length(v519.clone())) - 1_i32),
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
                                    continue '_method95;
                                }
                                _ => Documents::US22::US22_0(
                                    Documents::method101(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v518.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v519.clone(),
                                    v520.clone(),
                                    v521,
                                    v522,
                                ),
                            }
                        }
                        _ => Documents::US22::US22_0(
                            Documents::method101(
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
        pub fn method94(v0_1: string) -> Documents::US21 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v18: Documents::US22 = Documents::method95(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method82()),
                    1_i32,
                    1_i32,
                );
                match &v18 {
                    Documents::US22::US22_0(v18_0_0, v18_0_1, v18_0_2, v18_0_3, v18_0_4) => {
                        Documents::US21::US21_0(toArray(Documents::method102(
                            v18_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US22::US22_1(v18_1_0) => Documents::US21::US21_1(v18_1_0.clone()),
                }
            }
        }
        pub fn method105(
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
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v26: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v52: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v77: () = {
                Documents::closure8(v10.clone(), v1_1, ());
                ()
            };
            let v85: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v102: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v127: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v135: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v143: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v160: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v165: std::string::String = format!("{:#?}", v3);
            let v198: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v165),
                    (),
                );
                ()
            };
            let v206: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v215: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v223: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v234: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v242: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v251: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v259: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v264: std::string::String = format!("{:#?}", v5);
            let v297: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v264),
                    (),
                );
                ()
            };
            let v305: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v314: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v322: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v327: std::string::String = format!("{:#?}", v6);
            let v360: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v327),
                    (),
                );
                ()
            };
            let v368: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v377: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v385: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v396: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v404: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v413: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v421: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v426: std::string::String = format!("{:#?}", v8);
            let v459: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v426),
                    (),
                );
                ()
            };
            let v468: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v476: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method104(
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
            let v17: string = Documents::method105(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method104(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method62(),
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
        pub fn method106() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn method107(
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
        pub fn method108() -> Func1<std::string::String, Documents::US23> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn method109(
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
            let v9: string = Documents::method74(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v9
            ))
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method109(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method72(),
                    v0_1,
                ))
            };
        }
        pub fn method110(
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
        pub fn method111(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure46((), v))
        }
        pub fn closure47(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method112() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn method113() -> Func1<
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
        pub fn method114() -> Func1<
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
        pub fn method115() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure49((), v))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_1(v0_1)
        }
        pub fn method116() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure50((), v))
        }
        pub fn method118(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), string("trace\'"), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v39: () = {
                Documents::closure8(
                    v3.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v48: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v3.clone(), string("e"), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v70: std::string::String = format!("{:#?}", v1_1);
            let v103: () = {
                Documents::closure8(v3.clone(), fable_library_rust::String_::fromString(v70), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
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
            v8: bool,
            v9: std::string::String,
        ) -> string {
            let v10: string = Documents::method118(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.stdio_line"),
                v10
            ))
        }
        pub fn closure51(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
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
                    Documents::method72(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method119() -> string {
            let v6: string = Documents::method13(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method121() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            v1_1.l0.get().clone()
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
        ) -> string {
            let v9: string = Documents::method121();
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure52(v0_1: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method120(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Documents::method8(v19, v20, v21, v22, v23, v24),
                        Documents::method119(),
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
        pub fn method122(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method123(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn method124() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US26,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure54((), v)
                },
            )
        }
        pub fn method125(
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
        pub fn method126(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US27>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure55((), v)
                },
            )
        }
        pub fn method127(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure56(unitVar: (), v0_1: std::process::Output) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method128() -> Func1<std::process::Output, Documents::US28> {
            Func1::new(move |v: std::process::Output| Documents::closure56((), v))
        }
        pub fn closure57(unitVar: (), v0_1: std::string::String) -> Documents::US28 {
            Documents::US28::US28_1(v0_1)
        }
        pub fn method129() -> Func1<std::string::String, Documents::US28> {
            Func1::new(move |v: std::string::String| Documents::closure57((), v))
        }
        pub fn method130(
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
            let v9: string = Documents::method74(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v9
            ))
        }
        pub fn closure58(v0_1: std::string::String, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method130(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method72(),
                    v0_1,
                ))
            };
        }
        pub fn closure59(unitVar: (), v0_1: i32) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method131() -> Func1<i32, Documents::US29> {
            Func1::new(move |v: i32| Documents::closure59((), v))
        }
        pub fn method132() -> string {
            string("\n")
        }
        pub fn method134(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("std_trace_length"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
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
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Documents::method134(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method133(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method8(v20, v21, v22, v23, v24, v25),
                    Documents::method119(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method138(
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
                l0: MutCell::new(Documents::method14()),
            });
            let v17: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v26: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v52: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v69: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v97: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v105: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v146: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v155: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v163: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v168: std::string::String = format!("{:#?}", v3);
            let v201: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v168),
                    (),
                );
                ()
            };
            let v209: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v218: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v237: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v245: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v262: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v267: std::string::String = format!("{:#?}", v5);
            let v300: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v267),
                    (),
                );
                ()
            };
            let v308: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v317: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v325: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v330: std::string::String = format!("{:#?}", v6);
            let v363: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v330),
                    (),
                );
                ()
            };
            let v371: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v380: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v388: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v399: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v407: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v416: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v424: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v429: std::string::String = format!("{:#?}", v8);
            let v462: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v429),
                    (),
                );
                ()
            };
            let v471: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v479: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
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
            v9: Documents::US5,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method138(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method137(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method62(),
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
        pub fn method139(
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
        pub fn method142(v0_1: bool) -> string {
            unbox::<string>(&getZero())
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method143() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US30> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure63((), v)
            })
        }
        pub fn method144(v0_1: bool) -> i32 {
            unbox::<i32>(&getZero())
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method120(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Documents::method8(v19, v20, v21, v22, v23, v24),
                        Documents::method119(),
                        v0_1,
                    )
                })
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
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            getZero()
        }
        pub fn method140(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            Documents::method141(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
        }
        pub fn closure62(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) {
            let v11: Arc<Async<()>> =
                Documents::method140(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
            getZero::<()>();
            ()
        }
        pub fn closure65(unitVar: (), v0_1: CancellationToken) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method145() -> Func1<CancellationToken, Documents::US31> {
            Func1::new(move |v: CancellationToken| Documents::closure65((), v))
        }
        pub fn method146(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            getZero()
        }
        pub fn method147(v0_1: bool) -> bool {
            unbox::<bool>(&getZero())
        }
        pub fn method148(v0_1: bool) {
            ();
        }
        pub fn closure66(v0_1: bool, unitVar: ()) {
            if (Documents::method147(v0_1)) == false {
                Documents::method148(v0_1);
            };
        }
        pub fn method151(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), string("ex"), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
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
            v8: LrcPtr<TaskCanceledException>,
        ) -> string {
            let v9: string = Documents::method151(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure67(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method150(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method31(),
                    v0_1,
                ))
            };
        }
        pub fn method149(
            v0_1: bool,
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            getZero()
        }
        pub fn method153(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("output_length"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method152(
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
            let v10: string = Documents::method153(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v10
            ))
        }
        pub fn closure68(v0_1: i32, v1_1: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method152(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Documents::method8(v20, v21, v22, v23, v24, v25),
                    Documents::method62(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method136(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            getZero()
        }
        pub fn method135(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            Documents::method136(v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method79(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Documents::US13 = Documents::method81(Documents::method80(
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
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v9_1_0.clone()
                    ])),
                ),
            };
            let v21: Documents::US5 = patternInput.1.clone();
            let v20: string = patternInput.0.clone();
            let v26: Documents::US21 = Documents::method94(match &v21 {
                Documents::US5::US5_0(v21_0_0) => match &v21 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v34: Array<string> = match &v26 {
                Documents::US21::US21_0(v26_0_0) => v26_0_0.clone(),
                Documents::US21::US21_1(v26_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v26_1_0.clone()
                    ])),
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
            let _capture_v138: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
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
                        let v144: bool = true;
                        std::process::Command::args(&mut v140, &*v92.clone());
                        let v146: std::process::Command = v140;
                        let v148: std::process::Stdio = std::process::Stdio::piped();
                        let v150: bool = true;
                        let mut v146 = v146;
                        let v152: bool = true;
                        std::process::Command::stdout(&mut v146, std::process::Stdio::piped());
                        let v154: std::process::Command = v146;
                        let v156: std::process::Stdio = std::process::Stdio::piped();
                        let v158: bool = true;
                        let mut v154 = v154;
                        let v160: bool = true;
                        std::process::Command::stderr(&mut v154, std::process::Stdio::piped());
                        let v162: std::process::Command = v154;
                        let v164: std::process::Stdio = std::process::Stdio::piped();
                        let v166: bool = true;
                        let mut v162 = v162;
                        let v168: bool = true;
                        std::process::Command::stdin(&mut v162, std::process::Stdio::piped());
                        let v170: std::process::Command = v162;
                        let v184: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v198: std::process::Command = match &v184 {
                            Documents::US5::US5_0(v184_0_0) => {
                                let v190: bool = true;
                                let mut v170 = v170;
                                let v192: bool = true;
                                std::process::Command::current_dir(
                                    &mut v170,
                                    &*match &v184 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v170
                            }
                            _ => v170,
                        };
                        let v220: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v198
                        } else {
                            let v202: Vec<(string, string)> = v2.clone().to_vec();
                            let v204: bool = true;
                            let _vec_fold_ = v202.into_iter().fold(v198, |acc, x| {
                                //;
                                let v206: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v211: bool = true;
                                let mut v206 = v206;
                                let v213: bool = true;
                                std::process::Command::env(
                                    &mut v206,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v215: std::process::Command = v206;
                                let v217: bool = true;
                                v215
                            });
                            _vec_fold_
                        };
                        let v222: bool = true;
                        let mut v220 = v220;
                        let v224: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v220);
                        let v225 = Documents::method65();
                        let v228: Result<std::process::Child, std::string::String> =
                            v224.map_err(|x| v225(x));
                        let v240 = Documents::method106();
                        let v242: bool = true;
                        let _result_map_ = v228.map(|x| {
                            //;
                            let v248: Option<std::process::Child> = v240(Some(x));
                            let v250: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v248);
                            let v252: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v250);
                            let v254: bool = true;
                            v252
                        });
                        let v256: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v257 = Documents::method107();
                        let v258 = Documents::method108();
                        let v260: Documents::US23 = match v256 {
                            Ok(x) => v257(x),
                            Err(e) => v258(e),
                        };
                        let patternInput_3: (i32, Documents::US6, Documents::US24) = match &v260 {
                            Documents::US23::US23_0(v260_0_0) => {
                                let v261: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v260_0_0.clone();
                                let v263: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v265: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v261.clone();
                                    let v267: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v265.lock();
                                    let v282: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method110(v267.unwrap());
                                    let v284: bool = true;
                                    let mut v282 = v282;
                                    let v286: &mut Option<std::process::Child> = &mut v282;
                                    let v288: Option<&mut std::process::Child> = v286.as_mut();
                                    let v290: &mut std::process::Child = v288.unwrap();
                                    let v292: &mut Option<std::process::ChildStdout> =
                                        &mut v290.stdout;
                                    let v294: Option<std::process::ChildStdout> =
                                        Option::take(v292);
                                    let v296: std::process::ChildStdout = v294.unwrap();
                                    let v298: bool = true;
                                    v296
                                })();
                                let v300: std::process::ChildStdout = _capture;
                                let v302: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v304: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v261.clone();
                                    let v306: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v304.lock();
                                    let v321: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method110(v306.unwrap());
                                    let v323: bool = true;
                                    let mut v321 = v321;
                                    let v325: &mut Option<std::process::Child> = &mut v321;
                                    let v327: Option<&mut std::process::Child> = v325.as_mut();
                                    let v329: &mut std::process::Child = v327.unwrap();
                                    let v331: &mut Option<std::process::ChildStderr> =
                                        &mut v329.stderr;
                                    let v333: Option<std::process::ChildStderr> =
                                        Option::take(v331);
                                    let v335: std::process::ChildStderr = v333.unwrap();
                                    let v337: bool = true;
                                    v335
                                })();
                                let v339: std::process::ChildStderr = _capture;
                                let v341: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v343: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v261.clone();
                                    let v345: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v343.lock();
                                    let v360: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method110(v345.unwrap());
                                    let v362: bool = true;
                                    let mut v360 = v360;
                                    let v364: &mut Option<std::process::Child> = &mut v360;
                                    let v366: Option<&mut std::process::Child> = v364.as_mut();
                                    let v368: &mut std::process::Child = v366.unwrap();
                                    let v370: &mut Option<std::process::ChildStdin> =
                                        &mut v368.stdin;
                                    let v372: Option<std::process::ChildStdin> = Option::take(v370);
                                    let v374: std::process::ChildStdin = v372.unwrap();
                                    let v379: Option<std::process::ChildStdin> =
                                        (Documents::method111())(Some(v374));
                                    let v381: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v379);
                                    let v383: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v381);
                                    let v385: bool = true;
                                    v383
                                })();
                                let v387: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v389: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v392: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method112())(v389.clone());
                                let v394: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v392);
                                let v396: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v394);
                                let v398: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method113())(v389);
                                let v400: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v398);
                                let v402: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v400);
                                let v404: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method114())(patternInput_2.1.clone());
                                let v406: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v404);
                                let v408: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v406);
                                let v410: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v412: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v300);
                                    let v414: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v412);
                                    let v416: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v414);
                                    let v418: bool = true;
                                    let mut v416 = v416;
                                    let _iter_try_for_each = v416.try_for_each(|x| {
                                        //;
                                        let v420: Result<std::string::String, std::io::Error> = x;
                                        let v422: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v396.clone();
                                        let v423 = Documents::method65();
                                        let v426: Result<std::string::String, std::string::String> =
                                            v420.map_err(|x| v423(x));
                                        let v438 = Documents::method115();
                                        let v439 = Documents::method116();
                                        let v441: Documents::US25 = match v426 {
                                            Ok(x) => v438(x),
                                            Err(e) => v439(e),
                                        };
                                        let v636: std::string::String = match &v441 {
                                            Documents::US25::US25_0(v441_0_0) => {
                                                let v444: string =
                                                    fable_library_rust::String_::fromString(
                                                        v441_0_0.clone(),
                                                    );
                                                let v446: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v448: std::borrow::Cow<[u8]> =
                                                    v446.encode(&*v444).0;
                                                let v450: &[u8] = v448.as_ref();
                                                let v452: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v450);
                                                let v455: &str = v452.unwrap();
                                                let v486: std::string::String = String::from(v455);
                                                let v493: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v486.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v496: () = {
                                                        Documents::closure52(v493.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v541: () = {
                                                        Documents::closure11(v493, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v486
                                            }
                                            Documents::US25::US25_1(v441_1_0) => {
                                                let v543: std::string::String = v441_1_0.clone();
                                                let v546: () = {
                                                    Documents::closure51(v5, v543.clone(), ());
                                                    ()
                                                };
                                                let v586: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v543);
                                                let v589: &str = &*v586;
                                                String::from(v589)
                                            }
                                        };
                                        let v638: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v422;
                                        let v640: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v638.lock();
                                        let v643: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v640.unwrap();
                                        let v656: &std::sync::mpsc::Sender<std::string::String> =
                                            &v643;
                                        let v658: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v656.send(v636);
                                        let v659 = Documents::method122();
                                        let v662: Result<(), std::string::String> =
                                            v658.map_err(|x| v659(x));
                                        let v675: _ = v662;
                                        let v677: bool = true;
                                        v675
                                    }); //;
                                    let v680: Result<(), string> = Documents::method123(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v683: string = string("}");
                                    let v688: bool = true;
                                    let _fix_closure_v685 = v680;
                                    let v695: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v685 "),
                                                    (v683),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v696: bool = true;
                                    _fix_closure_v685
                                }); // rust.fix_closure';
                                let v698: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v700: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v702: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v339);
                                    let v704: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v702);
                                    let v706: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v704);
                                    let v708: bool = true;
                                    let mut v706 = v706;
                                    let _iter_try_for_each = v706.try_for_each(|x| {
                                        //;
                                        let v710: Result<std::string::String, std::io::Error> = x;
                                        let v712: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v402.clone();
                                        let v713 = Documents::method65();
                                        let v716: Result<std::string::String, std::string::String> =
                                            v710.map_err(|x| v713(x));
                                        let v728 = Documents::method115();
                                        let v729 = Documents::method116();
                                        let v731: Documents::US25 = match v716 {
                                            Ok(x) => v728(x),
                                            Err(e) => v729(e),
                                        };
                                        let v974: std::string::String = match &v731 {
                                            Documents::US25::US25_0(v731_0_0) => {
                                                let v734: string =
                                                    fable_library_rust::String_::fromString(
                                                        v731_0_0.clone(),
                                                    );
                                                let v736: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v738: std::borrow::Cow<[u8]> =
                                                    v736.encode(&*v734).0;
                                                let v740: &[u8] = v738.as_ref();
                                                let v742: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v740);
                                                let v745: &str = v742.unwrap();
                                                let v776: std::string::String = String::from(v745);
                                                let v783: string = concat(new_array(&[
                                                    string("! "),
                                                    fable_library_rust::String_::fromString(
                                                        v776.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v786: () = {
                                                        Documents::closure52(v783.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v830: () = {
                                                        Documents::closure11(v783, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v832: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v776
                                                    );
                                                    let v835: &str = &*v832;
                                                    String::from(v835)
                                                }
                                            }
                                            Documents::US25::US25_1(v731_1_0) => {
                                                let v881: std::string::String = v731_1_0.clone();
                                                let v884: () = {
                                                    Documents::closure51(v5, v881.clone(), ());
                                                    ()
                                                };
                                                let v924: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v881);
                                                let v927: &str = &*v924;
                                                String::from(v927)
                                            }
                                        };
                                        let v976: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v712;
                                        let v978: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v976.lock();
                                        let v981: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v978.unwrap();
                                        let v994: &std::sync::mpsc::Sender<std::string::String> =
                                            &v981;
                                        let v996: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v994.send(v974);
                                        let v997 = Documents::method122();
                                        let v1000: Result<(), std::string::String> =
                                            v996.map_err(|x| v997(x));
                                        let v1013: _ = v1000;
                                        let v1015: bool = true;
                                        v1013
                                    }); //;
                                    let v1018: Result<(), string> = Documents::method123(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v1019: string = string("}");
                                    let v1024: bool = true;
                                    let _fix_closure_v1021 = v1018;
                                    let v1031: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v1021 "),
                                                    (v1019),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v1032: bool = true;
                                    _fix_closure_v1021
                                }); // rust.fix_closure';
                                let v1034: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v1048: Documents::US26 = defaultValue(
                                    Documents::US26::US26_1,
                                    map(Documents::method124(), v4.clone()),
                                );
                                match &v1048 {
                                    Documents::US26::US26_0(v1048_0_0) => {
                                        let v1054: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v387.clone();
                                        let v1056: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v1054.lock();
                                        let v1071: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method125(v1056.unwrap());
                                        let v1073: bool = true;
                                        let mut v1071 = v1071;
                                        let v1075: &mut Option<std::process::ChildStdin> =
                                            &mut v1071;
                                        let v1077: Option<std::process::ChildStdin> =
                                            Option::take(v1075);
                                        let v1079: bool = true;
                                        let _optionm_map_ = v1077.map(|x| {
                                            //;
                                            let v1081: std::process::ChildStdin = x;
                                            let v1083: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v1081);
                                            let v1085: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v1083);
                                            let v1087: bool = true;
                                            v1085
                                        });
                                        let v1089: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v1103: Documents::US27 = defaultValue(
                                            Documents::US27::US27_1,
                                            map(Documents::method126(), v1089),
                                        );
                                        match &v1103 {
                                            Documents::US27::US27_0(v1103_0_0) => {
                                                let v1107: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v1103 {
                                                    Documents::US27::US27_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v1048 {
                                                    Documents::US26::US26_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v1107.clone()
                                                );
                                                {
                                                    let v1109: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v1107;
                                                    let v1111: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v1109.lock();
                                                    let v1126: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method127(v1111.unwrap());
                                                    let v1128: bool = true;
                                                    let mut v1126 = v1126;
                                                    let v1130: bool = true;
                                                    std::io::Write::flush(&mut *v1126).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v1132: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v261;
                                    let v1134: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1132.lock();
                                    let v1149: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method110(v1134.unwrap());
                                    let v1151: bool = true;
                                    let mut v1149 = v1149;
                                    let v1153: &mut Option<std::process::Child> = &mut v1149;
                                    let v1155: Option<std::process::Child> = Option::take(v1153);
                                    let v1157: std::process::Child = v1155.unwrap();
                                    let v1159: Result<std::process::Output, std::io::Error> =
                                        v1157.wait_with_output();
                                    let v1160 = Documents::method65();
                                    let v1172: Result<std::process::Output, std::string::String> =
                                        v1159.map_err(|x| v1160(x));
                                    let v1182: string = string("vec![v698, v1034]");
                                    let v1183: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v698, v1034];
                                    let v1185: bool = true;
                                    v1183.into_iter().for_each(|x| {
                                        //;
                                        let v1187: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v1189: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v1187);
                                        let v1192: Result<(), string> = v1189.unwrap();
                                        v1192.unwrap();
                                        {
                                            let v1209: bool = true;
                                            let v1211: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v1212 = Documents::method128();
                                        let v1213 = Documents::method129();
                                        let v1214: Documents::US28 = match &v1172 {
                                            Err(v1172_1_0) => v1213(v1172_1_0.clone()),
                                            Ok(v1172_0_0) => v1212(v1172_0_0.clone()),
                                        };
                                        match &v1214 {
                                            Documents::US28::US28_0(v1214_0_0) => {
                                                let v1217: std::process::ExitStatus =
                                                    v1214_0_0.clone().status;
                                                let v1219: Option<i32> = v1217.code();
                                                let v1233: Documents::US29 = defaultValue(
                                                    Documents::US29::US29_1,
                                                    map(Documents::method131(), v1219),
                                                );
                                                match &v1233 {
                                                    Documents::US29::US29_0(v1233_0_0) => (
                                                        match &v1233 {
                                                            Documents::US29::US29_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US6::US6_1,
                                                        Documents::US24::US24_0(v408.clone()),
                                                    ),
                                                    _ => {
                                                        let v1243:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US6::US6_0(String::from(
                                                                v1243,
                                                            )),
                                                            Documents::US24::US24_0(v408.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US28::US28_1(v1214_1_0) => {
                                                let v1297: std::string::String = v1214_1_0.clone();
                                                let v1300: () = {
                                                    Documents::closure58(v1297.clone(), ());
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US6::US6_0(v1297),
                                                    Documents::US24::US24_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US23::US23_1(v260_1_0) => {
                                let v1348: std::string::String = v260_1_0.clone();
                                let v1351: () = {
                                    Documents::closure45(v1348.clone(), ());
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US6::US6_0(v1348),
                                    Documents::US24::US24_1,
                                )
                            }
                        };
                        let v1398: Documents::US24 = patternInput_3.2.clone();
                        let v1397: Documents::US6 = patternInput_3.1.clone();
                        let v1396: i32 = patternInput_3.0.clone();
                        let v1405: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1398 {
                            Documents::US24::US24_0(v1398_0_0) => Some(
                                match &v1398 {
                                    Documents::US24::US24_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
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
                        let v1407: bool = true;
                        let _optionm_map_ = v1405.map(|x| {
                            //;
                            let v1409: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1411: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1409;
                            let v1413: Result<
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
                            > = v1411.lock();
                            let v1416: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1413.unwrap();
                            let v1429 = v1416.iter();
                            let v1431: Vec<std::string::String> = v1429.collect::<Vec<_>>();
                            let v1433: bool = true;
                            let _vec_map: Vec<_> = v1431
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1435: std::string::String = x;
                                    let v1437: string =
                                        fable_library_rust::String_::fromString(v1435);
                                    let v1439: bool = true;
                                    v1437
                                })
                                .collect::<Vec<_>>();
                            let v1441: Vec<string> = _vec_map;
                            let v1444: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v1441.clone()),
                            );
                            let v1450: string = join(Documents::method132(), toArray_1(v1444));
                            let v1455: bool = true;
                            v1450
                        });
                        let v1457: Option<string> = _optionm_map_;
                        let v1464: Documents::US5 = match &v1397 {
                            Documents::US6::US6_0(v1397_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v1397 {
                                        Documents::US6::US6_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v1469: string = defaultValue(
                            match &v1464 {
                                Documents::US5::US5_0(v1464_0_0) => match &v1464 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v1457,
                        );
                        let v1474: () = {
                            Documents::closure60(v1396, v1469.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1396, v1469))
                    }
                }))();
                _capture_v138.set(Some(x_5))
            }
            {
                let v1516: LrcPtr<(i32, string)> = match &_capture_v138.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v138=None"),),
                    Some(_capture_v138_0_0) => _capture_v138_0_0.clone(),
                };
                let _run_target_args__v7: (i32, string) = (v1516.0.clone(), v1516.1.clone());
                (
                    _run_target_args__v7.0.clone(),
                    _run_target_args__v7.1.clone(),
                )
            }
        }
        pub fn method154(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method26(v2, Documents::method45(v1_1.clone()));
            let v8: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some((lastIndexOf(v1_1.clone(), string("."))) - 1_i32),
            );
            let v14: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some((lastIndexOf(v4.clone(), string("."))) - 1_i32),
            );
            let v22: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v22 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v8, string("."), v0_1.clone()]))
                },
                if v22 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v14, string("."), v0_1]))
                },
            )
        }
        pub fn method155() -> string {
            string("")
        }
        pub fn closure69(unitVar: (), v0_1: string) -> Documents::US33 {
            Documents::US33::US33_0(v0_1)
        }
        pub fn method156() -> Func1<string, Documents::US33> {
            Func1::new(move |v: string| Documents::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: std::string::String) -> Documents::US33 {
            Documents::US33::US33_1(v0_1)
        }
        pub fn method157() -> Func1<std::string::String, Documents::US33> {
            Func1::new(move |v: std::string::String| Documents::closure70((), v))
        }
        pub fn method158(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_file()
            } else {
                false
            }
        }
        pub fn method160(
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
                l0: MutCell::new(Documents::method14()),
            });
            let v19: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v12.clone(), string("file"), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), v0_1, ());
                ()
            };
            let v54: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v12.clone(), string("real_path"), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v12.clone(), v1_1, ());
                ()
            };
            let v87: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v12.clone(), string("relative_path"), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v12.clone(), v2, ());
                ()
            };
            let v120: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v129: () = {
                Documents::closure8(v12.clone(), string("origin_hash_exit_code"), ());
                ()
            };
            let v137: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v153: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v162: () = {
                Documents::closure8(v12.clone(), string("origin_hash"), ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v178: () = {
                Documents::closure8(v12.clone(), v4, ());
                ()
            };
            let v186: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v195: () = {
                Documents::closure8(v12.clone(), string("local_git_hash_exit_code"), ());
                ()
            };
            let v203: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v211: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v219: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v228: () = {
                Documents::closure8(v12.clone(), string("local_git_hash"), ());
                ()
            };
            let v236: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v244: () = {
                Documents::closure8(v12.clone(), v6, ());
                ()
            };
            let v252: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v261: () = {
                Documents::closure8(v12.clone(), string("hash1"), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v277: () = {
                Documents::closure8(v12.clone(), v7, ());
                ()
            };
            let v285: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v294: () = {
                Documents::closure8(v12.clone(), string("hash2"), ());
                ()
            };
            let v302: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v313: () = {
                Documents::closure8(v12.clone(), sprintf!("{:?}", v8), ());
                ()
            };
            let v321: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v330: () = {
                Documents::closure8(v12.clone(), string("dist_path"), ());
                ()
            };
            let v338: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v346: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v354: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v363: () = {
                Documents::closure8(v12.clone(), string("cache_path"), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v379: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v388: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            v12.l0.get().clone()
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
                Documents::method160(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v20
            ))
        }
        pub fn closure71(
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                let v53: string =
                    string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2");
                Documents::method19(if (v53.clone()) == string("") {
                    string("")
                } else {
                    Documents::method159(
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
        pub fn closure72(unitVar: (), v0_1: u64) -> Documents::US34 {
            Documents::US34::US34_0(v0_1)
        }
        pub fn method162() -> Func1<u64, Documents::US34> {
            Func1::new(move |v: u64| Documents::closure72((), v))
        }
        pub fn closure73(unitVar: (), v0_1: std::string::String) -> Documents::US34 {
            Documents::US34::US34_1(v0_1)
        }
        pub fn method163() -> Func1<std::string::String, Documents::US34> {
            Func1::new(move |v: std::string::String| Documents::closure73((), v))
        }
        pub fn method165(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("error"), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v101: std::string::String = format!("{:#?}", v2);
            let v134: () = {
                Documents::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v101),
                    (),
                );
                ()
            };
            let v143: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
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
            v8: string,
            v9: string,
            v10: std::string::String,
        ) -> string {
            let v11: string = Documents::method165(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure74(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method164(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method31(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method167(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method166(
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
            let v11: string = Documents::method167(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure75(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method166(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method62(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method161(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method65();
            let v17: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v20 = Documents::method162();
            let v21 = Documents::method163();
            let v22: Documents::US34 = match &v17 {
                Err(v17_1_0) => v21(v17_1_0.clone()),
                Ok(v17_0_0) => v20(v17_0_0.clone()),
            };
            match &v22 {
                Documents::US34::US34_0(v22_0_0) => {
                    let v26: () = {
                        Documents::closure75(v0_1.clone(), v1_1.clone(), v22_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US34::US34_1(v22_1_0) => {
                    let v69: () = {
                        Documents::closure74(v0_1.clone(), v1_1.clone(), v22_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method169(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method170(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method171(v0_1: string) -> string {
            v0_1
        }
        pub fn method172(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure78(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v8: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v20: string = Documents::method171(v0_1);
            let v22: &[u8] = v20.as_bytes();
            let v23: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method172(v8);
            let v25: bool = true;
            let mut v23 = v23;
            let v27: bool = true;
            std::io::Write::write_all(&mut *v23, v22).unwrap();
            ()
        }
        pub fn method173(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method175(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("result_len"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method174(
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
            let v11: string = Documents::method175(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.hangul"),
                v11
            ))
        }
        pub fn closure79(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method174(
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
        pub fn method168(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US35 {
            let v7: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v45: Vec<u8> = Documents::method169(v7.unwrap());
            let v47: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v45);
            let v50: std::string::String = v47.unwrap();
            let v86: Array<string> = split(
                fable_library_rust::String_::fromString(v50),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v89: i32 = get_Count(v86.clone());
            let v90: Array<string> = new_init(&string(""), v89);
            let v91: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method59(v89, v91.clone()) {
                let v93: i32 = v91.l0.get().clone();
                let v96: string = trim(v86[v93].clone());
                v90.get_mut()[v93 as usize] = v96;
                {
                    let v99: i32 = (v93) + 1_i32;
                    v91.l0.set(v99);
                    ()
                }
            }
            {
                let v100: i32 = get_Count(v90.clone());
                let v101: Array<string> = new_init(&string(""), v100);
                let v102: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method170(v100, v102.clone()) {
                    let v104: i32 = v102.l0.get().clone();
                    let v105: i32 = v102.l1.get().clone();
                    let v106: string = v90[v104].clone();
                    let v112: i32 = if string("") != (v106.clone()) {
                        v101.get_mut()[v105 as usize] = v106;
                        (v105) + 1_i32
                    } else {
                        v105
                    };
                    let v113: i32 = (v104) + 1_i32;
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
                    while Documents::method59(v114, v116.clone()) {
                        let v118: i32 = v116.l0.get().clone();
                        let v119: string = v101[v118].clone();
                        v115.get_mut()[v118 as usize] = v119;
                        {
                            let v120: i32 = (v118) + 1_i32;
                            v116.l0.set(v120);
                            ()
                        }
                    }
                    {
                        let _let__v121: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v115 = v115.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v115 = v115.clone();
                                        move |i: i32| v115[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v115.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v136: string = concat(new_array(&[
                            join(Documents::method132(), toArray_1(_let__v121)),
                            string("\n\n"),
                        ]));
                        let patternInput: (i32, string) = Documents::method79(
                            concat(new_array(&[
                                Documents::method26(
                                    v0_1,
                                    concat(new_array(&[
                                        string("../vault/deps/hangulize/cmd/hangulize/hangulize"),
                                        if cfg!(windows) {
                                            string(".exe")
                                        } else {
                                            string("")
                                        },
                                    ])),
                                ),
                                string(" "),
                                v1_1,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v136 = v136.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure78(v136.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v180: i32 = patternInput.0.clone();
                        let v182: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v185: i32 = get_Count(v182.clone());
                        let v187: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method173(v100, v187.clone()) {
                            let v189: i32 = v187.l0.get().clone();
                            let matchValue: string = v187.l1.get().clone();
                            let matchValue_1: i32 = v187.l2.get().clone();
                            let v192: i32 = v187.l3.get().clone();
                            let v191: i32 = matchValue_1;
                            let v190: string = matchValue;
                            let patternInput_2: (string, i32, i32) =
                                if (v90[v189].clone()) == string("") {
                                    (
                                        concat(new_array(&[v190.clone(), string("\n")])),
                                        (v191) + 1_i32,
                                        (v192) + 1_i32,
                                    )
                                } else {
                                    let v198: i32 = (v191) - (v192);
                                    (
                                        if (v198) >= (v185) {
                                            v190.clone()
                                        } else {
                                            let v200: string = v182[v198].clone();
                                            if (v198) == ((v185) - 1_i32) {
                                                concat(new_array(&[v190.clone(), v200.clone()]))
                                            } else {
                                                concat(new_array(&[v190, v200, string("\n")]))
                                            }
                                        },
                                        (v191) + 1_i32,
                                        v192,
                                    )
                                };
                            let v213: i32 = (v189) + 1_i32;
                            v187.l0.set(v213);
                            v187.l1.set(patternInput_2.0.clone());
                            v187.l2.set(patternInput_2.1.clone());
                            v187.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v187.l1.get().clone();
                            let matchValue_4: i32 = v187.l2.get().clone();
                            let matchValue_5: i32 = v187.l3.get().clone();
                            let v214: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v214.clone()).unwrap();
                            {
                                let v221: () = {
                                    Documents::closure79(v2, v180, v214.clone(), ());
                                    ()
                                };
                                Documents::US35::US35_0(v180, v214)
                            }
                        }
                    }
                }
            }
        }
        pub fn method177(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("result"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method176(
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
            let v10: string = Documents::method177(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.files_fn / error"),
                v10
            ))
        }
        pub fn closure80(v0_1: string, v1_1: i32, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method176(
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
        pub fn closure77(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US32 {
            let patternInput: (string, string) = Documents::method154(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if (Documents::method158(v6.clone())) == false {
                true
            } else {
                (Documents::method158(v7.clone())) == false
            } {
                false
            } else {
                let v13: string = Documents::method36(v6.clone());
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
                        if (v63) == (v41) {
                            let v70: bool = true;
                            break;
                            ()
                        }
                        {
                            let v71: usize = v63;
                            let v86: &_ = if (v71) == (v45.len()) {
                                &v45[v41..]
                            } else {
                                &v45[v41..v71]
                            };
                            sha2::Digest::update(&mut v38, v86);
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
                            let v99: &[u8] = &sha2::Digest::finalize(v38);
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
                                fable_library_rust::NativeArray_::array_from(v113.clone());
                            let _let__v116: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v115 = v115.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v115 = v115.clone();
                                                move |i: i32| v115[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v115.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v125: string = Documents::method155();
                            let v131: string = join(
                                if (v125.clone()) == string("\n") {
                                    Documents::method61(v125.clone())
                                } else {
                                    v125
                                },
                                toArray_1(_let__v116),
                            );
                            let v135 = Documents::method65();
                            let v138: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v131).map_err(|x| v135(x));
                            let v150 = Documents::method156();
                            let v151 = Documents::method157();
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
                            let v162: string = Documents::method36(v7.clone());
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
                                    if (v212) == (v190) {
                                        let v219: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v220: usize = v212;
                                        let v235: &_ = if (v220) == (v194.len()) {
                                            &v194[v190..]
                                        } else {
                                            &v194[v190..v220]
                                        };
                                        sha2::Digest::update(&mut v187, v235);
                                        {
                                            let v238: bool = true;
                                        } // rust.loop;
                                        let v240: bool = true;
                                    } // rust.loop;
                                    let v242: bool = true;
                                } // rust.loop;
                                let v244: bool = true;
                                {
                                    // rust.loop;
                                    let v246: bool = true;
                                    {
                                        // rust.loop;
                                        let v248: &[u8] = &sha2::Digest::finalize(v187);
                                        let v250: Vec<u8> =
                                            v248.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v252: bool = true;
                                        let _vec_map: Vec<_> = v250
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v254: u8 = x;
                                                let v256: std::string::String =
                                                    format!("{:02x}", v254);
                                                let v258: string =
                                                    fable_library_rust::String_::fromString(v256);
                                                let v260: bool = true;
                                                v258
                                            })
                                            .collect::<Vec<_>>();
                                        let v262: Vec<string> = _vec_map;
                                        let v264: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v262.clone(),
                                            );
                                        let _let__v265: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v264 = v264.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v264 = v264.clone();
                                                            move |i_1: i32| v264[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v264.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v274: string = Documents::method155();
                                        let v280: string = join(
                                            if (v274.clone()) == string("\n") {
                                                Documents::method61(v274.clone())
                                            } else {
                                                v274
                                            },
                                            toArray_1(_let__v265),
                                        );
                                        let v284 = Documents::method65();
                                        let v287: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v280).map_err(|x| v284(x));
                                        let v299 = Documents::method156();
                                        let v300 = Documents::method157();
                                        let v302: Documents::US33 = match v287 {
                                            Ok(x) => v299(x),
                                            Err(e) => v300(e),
                                        };
                                        (v161)
                                            == (match &v302 {
                                                Documents::US33::US33_0(v302_0_0) => {
                                                    v302_0_0.clone()
                                                }
                                                Documents::US33::US33_1(v302_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v302_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US32::US32_1
            } else {
                let v314: Documents::US35 = Documents::method168(v2, v3, v6.clone(), v4);
                match &v314 {
                    Documents::US35::US35_0(v314_0_0, v314_0_1) => {
                        let v316: string = v314_0_1.clone();
                        let v315: i32 = v314_0_0.clone();
                        if (v315) != 0_i32 {
                            let v322: () = {
                                Documents::closure80(v316.clone(), v315, ());
                                ()
                            };
                            Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v316)),
                            ))
                        } else {
                            if Documents::method158(v6.clone()) {
                                Documents::method161(v7.clone(), v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v6.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US32::US32_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US35::US35_1(v314_1_0, v314_1_1) => {
                        Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v314_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure76(
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
        pub fn method180(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v29: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v96: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method179(
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
            let v11: string = Documents::method180(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.crowbook / result contains ERROR"),
                v11
            ))
        }
        pub fn closure83(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v26: Option<i64> = patternInput.5.clone();
                let v25: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v24: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v23: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v22: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v21: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method179(
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    Documents::method8(v21, v22, v23, v24, v25, v26),
                    Documents::method31(),
                    v2,
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method178(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US35 {
            let v61: string = if string("html") == (v4.clone()) {
                string("--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
            } else {
                if string("pdf") == (v4.clone()) {
                    append((append(string("--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\""),
                                       (if (v0_1) == false {
                                            string("")
                                        } else {
                                            string(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13")
                                        }))),
                               string(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""))
                } else {
                    if string("epub") == (v4.clone()) {
                        string("--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
                    } else {
                        string("")
                    }
                }
            };
            let patternInput: (i32, string) = Documents::method79(
                append(
                    (concat(new_array(&[string("crowbook --verbose --to "), v4]))),
                    sprintf!(" --single \"{}\" --output \"{}\" {}", v2, v1_1.clone(), v61),
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
            if (contains(v75.clone(), string("ERROR"))) == false {
                Documents::US35::US35_0(v74, v75.clone())
            } else {
                let v84: () = {
                    Documents::closure83(v1_1, v75.clone(), v74, ());
                    ()
                };
                Documents::US35::US35_1(v74, v75)
            }
        }
        pub fn closure82(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US32 {
            let patternInput: (string, string) = Documents::method154(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method158(v5.clone())) == false {
                true
            } else {
                (Documents::method158(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method36(v5.clone());
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
                        if (v62) == (v40) {
                            let v69: bool = true;
                            break;
                            ()
                        }
                        {
                            let v70: usize = v62;
                            let v85: &_ = if (v70) == (v44.len()) {
                                &v44[v40..]
                            } else {
                                &v44[v40..v70]
                            };
                            sha2::Digest::update(&mut v37, v85);
                            {
                                let v88: bool = true;
                            } // rust.loop;
                            let v90: bool = true;
                        } // rust.loop;
                        let v92: bool = true;
                    } // rust.loop;
                    let v94: bool = true;
                    {
                        // rust.loop;
                        let v96: bool = true;
                        {
                            // rust.loop;
                            let v98: &[u8] = &sha2::Digest::finalize(v37);
                            let v100: Vec<u8> = v98.iter().map(|x| *x).collect::<Vec<_>>();
                            let v102: bool = true;
                            let _vec_map: Vec<_> = v100
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v104: u8 = x;
                                    let v106: std::string::String = format!("{:02x}", v104);
                                    let v108: string =
                                        fable_library_rust::String_::fromString(v106);
                                    let v110: bool = true;
                                    v108
                                })
                                .collect::<Vec<_>>();
                            let v112: Vec<string> = _vec_map;
                            let v114: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v112.clone());
                            let _let__v115: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v114 = v114.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v114 = v114.clone();
                                                move |i: i32| v114[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v114.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v124: string = Documents::method155();
                            let v130: string = join(
                                if (v124.clone()) == string("\n") {
                                    Documents::method61(v124.clone())
                                } else {
                                    v124
                                },
                                toArray_1(_let__v115),
                            );
                            let v134 = Documents::method65();
                            let v137: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v130).map_err(|x| v134(x));
                            let v149 = Documents::method156();
                            let v150 = Documents::method157();
                            let v152: Documents::US33 = match v137 {
                                Ok(x) => v149(x),
                                Err(e) => v150(e),
                            };
                            let v160: string = match &v152 {
                                Documents::US33::US33_0(v152_0_0) => v152_0_0.clone(),
                                Documents::US33::US33_1(v152_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v152_1_0.clone()
                                    ),
                                ),
                            };
                            let v161: string = Documents::method36(v6.clone());
                            let v163: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v161);
                            let v166: std::fs::File = v163.unwrap();
                            let v179: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v166);
                            let v181: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v179);
                            let v183: bool = true;
                            let mut v181 = v181;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v186: sha2::Sha256 = result;
                                let v188: bool = true;
                                let mut v186 = v186;
                                let v189: usize = 0_i32 as usize;
                                let v193: _ = [0_u8; 1024];
                                let v195: bool = true;
                                loop {
                                    // rust.loop;
                                    let v197: bool = true;
                                    let mut v193 = v193;
                                    let v199: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v181, &mut v193);
                                    let v211: usize = v199.unwrap();
                                    if (v211) == (v189) {
                                        let v218: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v219: usize = v211;
                                        let v234: &_ = if (v219) == (v193.len()) {
                                            &v193[v189..]
                                        } else {
                                            &v193[v189..v219]
                                        };
                                        sha2::Digest::update(&mut v186, v234);
                                        {
                                            let v237: bool = true;
                                        } // rust.loop;
                                        let v239: bool = true;
                                    } // rust.loop;
                                    let v241: bool = true;
                                } // rust.loop;
                                let v243: bool = true;
                                {
                                    // rust.loop;
                                    let v245: bool = true;
                                    {
                                        // rust.loop;
                                        let v247: &[u8] = &sha2::Digest::finalize(v186);
                                        let v249: Vec<u8> =
                                            v247.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v251: bool = true;
                                        let _vec_map: Vec<_> = v249
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v253: u8 = x;
                                                let v255: std::string::String =
                                                    format!("{:02x}", v253);
                                                let v257: string =
                                                    fable_library_rust::String_::fromString(v255);
                                                let v259: bool = true;
                                                v257
                                            })
                                            .collect::<Vec<_>>();
                                        let v261: Vec<string> = _vec_map;
                                        let v263: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v261.clone(),
                                            );
                                        let _let__v264: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v263 = v263.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v263 = v263.clone();
                                                            move |i_1: i32| v263[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v263.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v273: string = Documents::method155();
                                        let v279: string = join(
                                            if (v273.clone()) == string("\n") {
                                                Documents::method61(v273.clone())
                                            } else {
                                                v273
                                            },
                                            toArray_1(_let__v264),
                                        );
                                        let v283 = Documents::method65();
                                        let v286: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v279).map_err(|x| v283(x));
                                        let v298 = Documents::method156();
                                        let v299 = Documents::method157();
                                        let v301: Documents::US33 = match v286 {
                                            Ok(x) => v298(x),
                                            Err(e) => v299(e),
                                        };
                                        (v160)
                                            == (match &v301 {
                                                Documents::US33::US33_0(v301_0_0) => {
                                                    v301_0_0.clone()
                                                }
                                                Documents::US33::US33_1(v301_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v301_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US32::US32_1
            } else {
                let v313: Documents::US35 = Documents::method178(v2, v5.clone(), v3, v1_1, v4);
                match &v313 {
                    Documents::US35::US35_0(v313_0_0, v313_0_1) => {
                        let v315: string = v313_0_1.clone();
                        let v314: i32 = v313_0_0.clone();
                        if (v314) != 0_i32 {
                            let v321: () = {
                                Documents::closure80(v315.clone(), v314, ());
                                ()
                            };
                            Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v315)),
                            ))
                        } else {
                            if Documents::method158(v5.clone()) {
                                Documents::method161(v6.clone(), v5.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v5.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US32::US32_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US35::US35_1(v313_1_0, v313_1_1) => {
                        Documents::US32::US32_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v313_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure81(
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
                move |v: string| Documents::closure82(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method182(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v10: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Documents::closure8(v3.clone(), string("output_path"), ());
                ()
            };
            let v28: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v45: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("output_cache_path"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method181(
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
            let v10: string = Documents::method182(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / par_map / files\' = [] / listm.iter"),
                v10
            ))
        }
        pub fn closure84(v0_1: string, v1_1: string, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method181(
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
        pub fn method183(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<LrcPtr<Documents::UH5>>,
        ) -> List<LrcPtr<Documents::UH5>> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH4::UH4_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method183(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure86(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: LrcPtr<Documents::UH4>,
        ) -> LrcPtr<Documents::UH4> {
            LrcPtr::new(Documents::UH4::UH4_1(v0_1, v1_1))
        }
        pub fn closure85(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH5>,
        ) -> Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH4>| Documents::closure86(v0_1.clone(), v)
            })
        }
        pub fn method184(
        ) -> Func1<LrcPtr<Documents::UH5>, Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH5>| Documents::closure85((), v))
        }
        pub fn method186(
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
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, x, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
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
                    Documents::method186(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure87(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US32>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US32 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US32::US32_0(v4_0_0) => Some(
                    match &v4 {
                        Documents::US32::US32_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method187(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method188(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method185(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH4>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method185: loop {
                break '_method185 (match v0_1.get().clone().as_ref() {
                    Documents::UH4::UH4_0 => v1_1.get().clone(),
                    Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => {
                        let v7 = toArray(Documents::method186(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH4::UH4_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US32>>,
                            )>(),
                        ));
                        let v11 = v7.to_vec();
                        let v13 = rayon::iter::IntoParallelIterator::into_par_iter(v11);
                        let v16 = rayon::iter::ParallelIterator::map(v13, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US32>>,
                                )| {
                                    Documents::closure87((), arg10_0040)
                                },
                            )(x)
                        });
                        let v19: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method187(rayon::iter::ParallelIterator::collect(v16));
                        let v20: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method188(v1_1.get().clone());
                        let v22: bool = true;
                        let mut v20 = v20;
                        let v24: bool = true;
                        v20.extend(v19);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH4::UH4_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v20;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method185;
                        }
                    }
                });
            }
        }
        pub fn closure33(
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
            let v6: string = Documents::method35(v5);
            let v9: &str = &*v6.clone();
            let v33: std::string::String = String::from(v9);
            let v57: std::path::PathBuf = std::path::PathBuf::from(v33);
            let v81: std::path::Display = v57.display();
            let v105: std::string::String = format!("{}", v81);
            let v134: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v105),
                        v3.clone(),
                        Documents::method77(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v135: string = Documents::method36(v6);
            let v137: string = Documents::method78(Documents::method26(v2.clone(), v134.clone()));
            let patternInput: (i32, string) = Documents::method79(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v137.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v149: string = patternInput.1.clone();
            let v148: i32 = patternInput.0.clone();
            let v151: string = Documents::method78(Documents::method26(v3.clone(), v134.clone()));
            let patternInput_1: (i32, string) = Documents::method79(
                concat(new_array(&[
                    string("git hash-object \""),
                    v151.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v163: string = patternInput_1.1.clone();
            let v162: i32 = patternInput_1.0.clone();
            let v165: string = Documents::method78(Documents::method26(v4.clone(), v134.clone()));
            let v167: string =
                (Documents::method154(string("hangul.md"), v151.clone(), v4.clone()))
                    .0
                    .clone();
            let v628: LrcPtr<Documents::UH4> = if contains(v149.clone(), v163.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v179: string = Documents::method36(v151.clone());
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
                        if (v229) == (v207) {
                            let v236: bool = true;
                            break;
                            ()
                        }
                        {
                            let v237: usize = v229;
                            let v252: &_ = if (v237) == (v211.len()) {
                                &v211[v207..]
                            } else {
                                &v211[v207..v237]
                            };
                            sha2::Digest::update(&mut v204, v252);
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
                            let v265: &[u8] = &sha2::Digest::finalize(v204);
                            let v267: Vec<u8> = v265.iter().map(|x| *x).collect::<Vec<_>>();
                            let v269: bool = true;
                            let _vec_map: Vec<_> = v267
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v271: u8 = x;
                                    let v273: std::string::String = format!("{:02x}", v271);
                                    let v275: string =
                                        fable_library_rust::String_::fromString(v273);
                                    let v277: bool = true;
                                    v275
                                })
                                .collect::<Vec<_>>();
                            let v279: Vec<string> = _vec_map;
                            let v281: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v279.clone());
                            let _let__v282: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v281 = v281.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v281 = v281.clone();
                                                move |i: i32| v281[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v281.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v291: string = Documents::method155();
                            let v297: string = join(
                                if (v291.clone()) == string("\n") {
                                    Documents::method61(v291.clone())
                                } else {
                                    v291
                                },
                                toArray_1(_let__v282),
                            );
                            let v301 = Documents::method65();
                            let v304: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v297).map_err(|x| v301(x));
                            let v316 = Documents::method156();
                            let v317 = Documents::method157();
                            let v319: Documents::US33 = match v304 {
                                Ok(x) => v316(x),
                                Err(e) => v317(e),
                            };
                            let v327: string = match &v319 {
                                Documents::US33::US33_0(v319_0_0) => v319_0_0.clone(),
                                Documents::US33::US33_1(v319_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v319_1_0.clone()
                                    ),
                                ),
                            };
                            let v478: Documents::US5 = if (Documents::method158(v165.clone()))
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v331: string = Documents::method36(v165.clone());
                                let v333: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v331);
                                let v336: std::fs::File = v333.unwrap();
                                let v349: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v336);
                                let v351: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v349);
                                let v353: bool = true;
                                let mut v351 = v351;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v356: sha2::Sha256 = result;
                                    let v358: bool = true;
                                    let mut v356 = v356;
                                    let v359: usize = 0_i32 as usize;
                                    let v363: _ = [0_u8; 1024];
                                    let v365: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v367: bool = true;
                                        let mut v363 = v363;
                                        let v369: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v351, &mut v363);
                                        let v381: usize = v369.unwrap();
                                        if (v381) == (v359) {
                                            let v388: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v389: usize = v381;
                                            let v404: &_ = if (v389) == (v363.len()) {
                                                &v363[v359..]
                                            } else {
                                                &v363[v359..v389]
                                            };
                                            sha2::Digest::update(&mut v356, v404);
                                            {
                                                let v407: bool = true;
                                            } // rust.loop;
                                            let v409: bool = true;
                                        } // rust.loop;
                                        let v411: bool = true;
                                    } // rust.loop;
                                    let v413: bool = true;
                                    {
                                        // rust.loop;
                                        let v415: bool = true;
                                        {
                                            // rust.loop;
                                            let v417: &[u8] = &sha2::Digest::finalize(v356);
                                            let v419: Vec<u8> =
                                                v417.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v421: bool = true;
                                            let _vec_map: Vec<_> = v419
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v423: u8 = x;
                                                    let v425: std::string::String =
                                                        format!("{:02x}", v423);
                                                    let v427: string =
                                                        fable_library_rust::String_::fromString(
                                                            v425,
                                                        );
                                                    let v429: bool = true;
                                                    v427
                                                })
                                                .collect::<Vec<_>>();
                                            let v431: Vec<string> = _vec_map;
                                            let v433: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(
                                                    v431.clone(),
                                                );
                                            let _let__v434: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v433 = v433.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v433 = v433.clone();
                                                                move |i_1: i32| v433[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                (get_Count(v433.clone())) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v443: string = Documents::method155();
                                            let v449: string = join(
                                                if (v443.clone()) == string("\n") {
                                                    Documents::method61(v443.clone())
                                                } else {
                                                    v443
                                                },
                                                toArray_1(_let__v434),
                                            );
                                            let v453 = Documents::method65();
                                            let v456: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v449)
                                                    .map_err(|x| v453(x));
                                            let v468 = Documents::method156();
                                            let v469 = Documents::method157();
                                            let v471: Documents::US33 = match v456 {
                                                Ok(x) => v468(x),
                                                Err(e) => v469(e),
                                            };
                                            match &v471 {
                                                Documents::US33::US33_0(v471_0_0) => {
                                                    Documents::US5::US5_0(v471_0_0.clone())
                                                }
                                                _ => Documents::US5::US5_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US5::US5_0(v478_0_0) = &v478 {
                                if (v327.clone()) == (v478_0_0.clone()) {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v484: () = {
                                        Documents::closure71(
                                            v134.clone(),
                                            v135.clone(),
                                            v137.clone(),
                                            v149.clone(),
                                            v148,
                                            v151.clone(),
                                            v163.clone(),
                                            v162,
                                            v165.clone(),
                                            v327.clone(),
                                            v478.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method161(v165.clone(), v151.clone());
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
                                                v151.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure81(
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
                                                                    Documents::closure81(
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
                                                                        Documents::closure81(
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
                                                                            Documents::closure81(
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
                                                                                Documents::closure81(
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
                                                                                                                                                                                                                                                                                                                                                               Documents::closure81(v4.clone(),
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
                                let v557: () = {
                                    Documents::closure71(
                                        v134,
                                        v135.clone(),
                                        v137,
                                        v149,
                                        v148,
                                        v151.clone(),
                                        v163,
                                        v162,
                                        v165.clone(),
                                        v327,
                                        v478.clone(),
                                        (),
                                    );
                                    ()
                                };
                                Documents::method161(v165, v151.clone());
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
                                                        Documents::closure76(
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
                                                            Documents::closure81(
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
                                                                Documents::closure81(
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
                                                                    Documents::closure81(
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
                                                                        Documents::closure81(
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
                                                                            Documents::closure81(
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
                                                                                Documents::closure81(
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
            let v1009: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method183(
                if (if let Documents::UH4::UH4_0 = v628.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v628
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method154(string("epub"), v167.clone(), v4.clone());
                    let v633: string = patternInput_3.1.clone();
                    let v632: string = patternInput_3.0.clone();
                    let v685: LrcPtr<Documents::UH5> = if if Documents::method158(v632.clone()) {
                        true
                    } else {
                        if (Documents::method158(v633.clone())) == false {
                            true
                        } else {
                            let v639: () = {
                                Documents::closure84(v633.clone(), v632.clone(), ());
                                ()
                            };
                            Documents::method161(v632, v633);
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
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_14)
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
                        Documents::method154(string("pdf"), v167.clone(), v4.clone());
                    let v688: string = patternInput_4.1.clone();
                    let v687: string = patternInput_4.0.clone();
                    let v738: LrcPtr<Documents::UH5> = if if Documents::method158(v687.clone()) {
                        true
                    } else {
                        if (Documents::method158(v688.clone())) == false {
                            true
                        } else {
                            let v694: () = {
                                Documents::closure84(v688.clone(), v687.clone(), ());
                                ()
                            };
                            Documents::method161(v687, v688);
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
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v685.clone(),
                        ))
                    } else {
                        v685
                    };
                    let patternInput_5: (string, string) =
                        Documents::method154(string("html"), v167.clone(), v4.clone());
                    let v741: string = patternInput_5.1.clone();
                    let v740: string = patternInput_5.0.clone();
                    let v791: LrcPtr<Documents::UH5> = if if Documents::method158(v740.clone()) {
                        true
                    } else {
                        if (Documents::method158(v741.clone())) == false {
                            true
                        } else {
                            let v747: () = {
                                Documents::closure84(v741.clone(), v740.clone(), ());
                                ()
                            };
                            Documents::method161(v740, v741);
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
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v738.clone(),
                        ))
                    } else {
                        v738
                    };
                    let patternInput_6: (string, string) =
                        Documents::method154(string("epub"), v151.clone(), v4.clone());
                    let v793: string = patternInput_6.1.clone();
                    let v792: string = patternInput_6.0.clone();
                    let v843: LrcPtr<Documents::UH5> = if if Documents::method158(v792.clone()) {
                        true
                    } else {
                        if (Documents::method158(v793.clone())) == false {
                            true
                        } else {
                            let v799: () = {
                                Documents::closure84(v793.clone(), v792.clone(), ());
                                ()
                            };
                            Documents::method161(v792, v793);
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
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v791.clone(),
                        ))
                    } else {
                        v791
                    };
                    let patternInput_7: (string, string) =
                        Documents::method154(string("pdf"), v151.clone(), v4.clone());
                    let v845: string = patternInput_7.1.clone();
                    let v844: string = patternInput_7.0.clone();
                    let v895: LrcPtr<Documents::UH5> = if if Documents::method158(v844.clone()) {
                        true
                    } else {
                        if (Documents::method158(v845.clone())) == false {
                            true
                        } else {
                            let v851: () = {
                                Documents::closure84(v845.clone(), v844.clone(), ());
                                ()
                            };
                            Documents::method161(v844, v845);
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
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v843.clone(),
                        ))
                    } else {
                        v843
                    };
                    let patternInput_8: (string, string) =
                        Documents::method154(string("html"), v151.clone(), v4.clone());
                    let v897: string = patternInput_8.1.clone();
                    let v896: string = patternInput_8.0.clone();
                    let v947: LrcPtr<Documents::UH5> = if if Documents::method158(v896.clone()) {
                        true
                    } else {
                        if (Documents::method158(v897.clone())) == false {
                            true
                        } else {
                            let v903: () = {
                                Documents::closure84(v897.clone(), v896.clone(), ());
                                ()
                            };
                            Documents::method161(v896, v897);
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
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v895.clone(),
                        ))
                    } else {
                        v895
                    };
                    let patternInput_9: (string, string) =
                        Documents::method154(string("hangul.md"), v151.clone(), v4.clone());
                    let v949: string = patternInput_9.1.clone();
                    let v948: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method158(v948.clone()) {
                            true
                        } else {
                            if (Documents::method158(v949.clone())) == false {
                                true
                            } else {
                                let v955: () = {
                                    Documents::closure84(v949.clone(), v948.clone(), ());
                                    ()
                                };
                                Documents::method161(v948, v949);
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
                                                Documents::closure76(
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
                            v947,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v1013: Vec<LrcPtr<Documents::UH5>> = v1009.to_vec();
            let v1016: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v1019: List<LrcPtr<Documents::UH5>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v1013.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v135,
                Documents::method185(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH5>, b1: LrcPtr<Documents::UH4>| {
                                (Documents::method184())(b0)(b1)
                            },
                        ),
                        v1019,
                        LrcPtr::new(Documents::UH4::UH4_0),
                    ),
                    v1016,
                ),
            )))
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
            let v8: Documents::US7 = Documents::method27(
                Documents::method26(string("polyglot"), string("workspace")),
                string("C:\\home\\git\\polyglot\\target\\Builder\\documents"),
            );
            let v56: Documents::US5 = match &v8 {
                Documents::US7::US7_0(v8_0_0) => Documents::US5::US5_0(v8_0_0.clone()),
                Documents::US7::US7_1(v8_1_0) => {
                    let v14: () = {
                        Documents::closure13(v8_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            let v111: Documents::US5 = match &v56 {
                Documents::US5::US5_0(v56_0_0) => Documents::US5::US5_0(
                    match &v56 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => {
                    let v59: string = Documents::method34();
                    let v61: Documents::US7 = Documents::method27(
                        Documents::method26(string("polyglot"), string("workspace")),
                        v59,
                    );
                    match &v61 {
                        Documents::US7::US7_0(v61_0_0) => Documents::US5::US5_0(v61_0_0.clone()),
                        Documents::US7::US7_1(v61_1_0) => {
                            let v67: () = {
                                Documents::closure13(v61_1_0.clone(), ());
                                ()
                            };
                            Documents::US5::US5_1
                        }
                    }
                }
            };
            let v116: string = Documents::method26(
                match &v111 {
                    Documents::US5::US5_0(v111_0_0) => match &v111 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => panic!("{}", string("Option does not have a value."),),
                },
                string("polyglot"),
            );
            let v117: string = Documents::method35(v3);
            let v118: string = Documents::method35(v2);
            let v119: string = Documents::method35(v1_1);
            let v122: () = {
                Documents::closure22(v0_1.clone(), v117.clone(), v118.clone(), v119.clone(), ());
                ()
            };
            let v163: bool = true;
            let __future_init = Box::pin(
                /*;
                let v165: bool = */
                async move {
                    /*;
                    let v167: bool = */
 //;
                    let v169: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v118.clone());
                    let v172: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v169, move |x| {
                            Func1::new(move |v: async_walkdir::DirEntry| {
                                Documents::closure23((), v)
                            })(x)
                        });
                    let v173 = Documents::method68();
                    let v175 = futures::stream::StreamExt::filter_map(v172, |x| async { v173(x) });
                    let v177: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v175));
                    let v179: Vec<string> = v177.await;
                    let v182: () = {
                        Documents::closure32(v179.clone(), ());
                        ()
                    };
                    let v225: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v179);
                    let v228: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v225, |x| {
                            Func1::new({
                                let v0_1 = v0_1.clone();
                                let v116 = v116.clone();
                                let v117 = v117.clone();
                                let v118 = v118.clone();
                                let v119 = v119.clone();
                                move |v_1: string| {
                                    Documents::closure33(
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
                    let v230: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v228);
                    let v234: string = string("}");
                    let v239: bool = true;
                    let _fix_closure_v236 = Ok::<
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
                    >(v230);
                    let v246: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v236 "), (v234))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v247: bool = true;
                    _fix_closure_v236
                },
            ); // rust.fix_closure';
            let v249 = __future_init;
            v249
        }
        pub fn closure88(
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
        pub fn method189() -> Func1<
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
                >| Documents::closure88((), v),
            )
        }
        pub fn closure89(unitVar: (), v0_1: std::string::String) -> Documents::US36 {
            Documents::US36::US36_1(v0_1)
        }
        pub fn method190() -> Func1<std::string::String, Documents::US36> {
            Func1::new(move |v: std::string::String| Documents::closure89((), v))
        }
        pub fn method191(
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
            let v9: string = Documents::method74(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure90(v0_1: std::string::String, unitVar: ()) {
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method191(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Documents::method8(v19, v20, v21, v22, v23, v24),
                    Documents::method72(),
                    v0_1,
                ))
            };
        }
        pub fn method193(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Documents::closure8(v2.clone(), string("result_len"), ());
                ()
            };
            let v27: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v32), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method192(
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
            let v9: string = Documents::method193(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure91(
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
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method192(
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
            let v88: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v65).cloned();
            let v102: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v88));
            let v109: std::string::String = match &v102 {
                Documents::US6::US6_0(v102_0_0) => match &v102 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v111: string = fable_library_rust::String_::fromString(v109);
            let v112: string = Documents::method22();
            let v115: &str = &*v112;
            let v138: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v115).cloned();
            let v152: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v138));
            let v159: std::string::String = match &v152 {
                Documents::US6::US6_0(v152_0_0) => match &v152 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v161: string = fable_library_rust::String_::fromString(v159);
            let v162: string = Documents::method23();
            let v165: &str = &*v162;
            let v188: Option<std::string::String> =
                clap::ArgMatches::get_one(&v61.clone(), v165).cloned();
            let v202: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v188));
            let v209: std::string::String = match &v202 {
                Documents::US6::US6_0(v202_0_0) => match &v202 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v211: string = fable_library_rust::String_::fromString(v209);
            let v212: string = Documents::method24();
            let v215: &str = &*v212;
            let v238: Option<std::string::String> = clap::ArgMatches::get_one(&v61, v215).cloned();
            let v252: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v238));
            let v259: std::string::String = match &v252 {
                Documents::US6::US6_0(v252_0_0) => match &v252 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
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
            > = Documents::method25(
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
            let v265 = Documents::method189();
            let v266 = Documents::method190();
            let v267: Documents::US36 = match &v264 {
                Err(v264_1_0) => v266(v264_1_0.clone()),
                Ok(v264_0_0) => v265(v264_0_0.clone()),
            };
            match &v267 {
                Documents::US36::US36_0(v267_0_0) => {
                    let v271: () = {
                        Documents::closure91(v267_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US36::US36_1(v267_1_0) => {
                    let v316: () = {
                        Documents::closure90(v267_1_0.clone(), ());
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
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/async_.rs"]
mod module_2335f2f5;
pub use module_2335f2f5::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/common.rs"]
mod module_652e6d81;
pub use module_652e6d81::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/crypto.rs"]
mod module_dd5f95ef;
pub use module_dd5f95ef::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/date_time.rs"]
mod module_ca5e6cb2;
pub use module_ca5e6cb2::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/file_system.rs"]
mod module_5ab1faf0;
pub use module_5ab1faf0::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/lib.rs"]
mod module_b386774b;
pub use module_b386774b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/networking.rs"]
mod module_ce497f72;
pub use module_ce497f72::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/platform.rs"]
mod module_9a61edd3;
pub use module_9a61edd3::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/runtime.rs"]
mod module_502d7e30;
pub use module_502d7e30::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/sm.rs"]
mod module_34f67952;
pub use module_34f67952::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/threading.rs"]
mod module_11c0c5c2;
pub use module_11c0c5c2::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/trace.rs"]
mod module_28ecba0d;
pub use module_28ecba0d::*;
#[path = "../../deps/polyglot/lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Documents::main(array_from(args));
}
