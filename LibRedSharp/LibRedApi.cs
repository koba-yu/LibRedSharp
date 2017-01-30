using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LibRedSharp
{
    public static class LibRedApi
    {
        private const string LibRedName = "libRed.dll";

        [DllImport(LibRedName)]
        public static extern void redOpen();

        [DllImport(LibRedName)]
        public static extern IntPtr redDo(string source);

        [DllImport(LibRedName)]
        public static extern IntPtr redDoFile(string source);

        [DllImport(LibRedName)]
        public static extern IntPtr redDoBlock(IntPtr code);

        [DllImport(LibRedName)]
        public static extern IntPtr redRoutine(IntPtr name, string desc, IntPtr ptr);

        [DllImport(LibRedName)]
        public static extern IntPtr redSymbol(string word);

        [DllImport(LibRedName)]
        public static extern IntPtr redUnset();

        [DllImport(LibRedName)]
        public static extern IntPtr redNone();

        [DllImport(LibRedName)]
        public static extern IntPtr redLogic(IntPtr @bool);

        [DllImport(LibRedName)]
        public static extern IntPtr redDatatype(IntPtr dtype);

        [DllImport(LibRedName)]
        public static extern IntPtr redInteger(IntPtr number);

        [DllImport(LibRedName)]
        public static extern IntPtr redFloat(double number);

        [DllImport(LibRedName)]
        public static extern IntPtr redPair(IntPtr x, IntPtr y);

        [DllImport(LibRedName)]
        public static extern IntPtr redTuple(IntPtr r, IntPtr g, IntPtr b);

        [DllImport(LibRedName)]
        public static extern IntPtr redTuple4(IntPtr r, IntPtr g, IntPtr b, IntPtr a);

        [DllImport(LibRedName)]
        public static extern IntPtr redString(string str);

        [DllImport(LibRedName)]
        public static extern IntPtr redWord(string word);

        [DllImport(LibRedName)]
        public static extern IntPtr redMakeSeries(IntPtr t, IntPtr size);

        [DllImport(LibRedName)]
        public static extern int redCInt32(IntPtr value);

        [DllImport(LibRedName)]
        public static extern double redCDouble(IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redTypeOf(IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redCString(IntPtr @string);

        [DllImport(LibRedName)]
        public static extern IntPtr redAppend(IntPtr series, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redClear(IntPtr series);

        [DllImport(LibRedName)]
        public static extern IntPtr redCopy(IntPtr series);

        [DllImport(LibRedName)]
        public static extern IntPtr redFind(IntPtr series, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redIndex(IntPtr series);

        [DllImport(LibRedName)]
        public static extern IntPtr redLength(IntPtr series);

        [DllImport(LibRedName)]
        public static extern IntPtr redMake(IntPtr proto, IntPtr spec);

        [DllImport(LibRedName)]
        public static extern IntPtr redMold(IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redPick(IntPtr series, IntPtr index);

        [DllImport(LibRedName)]
        public static extern IntPtr redPoke(IntPtr series, IntPtr index, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redPut(IntPtr series, IntPtr index, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redRemove(IntPtr series);

        [DllImport(LibRedName)]
        public static extern IntPtr redSelect(IntPtr series, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redSkip(IntPtr series, IntPtr offset);

        [DllImport(LibRedName)]
        public static extern IntPtr redTo(IntPtr proto, IntPtr spec);

        [DllImport(LibRedName)]
        public static extern IntPtr redSet(IntPtr id, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redGet(IntPtr id);

        [DllImport(LibRedName)]
        public static extern IntPtr redSetPath(IntPtr path, IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redGetPath(IntPtr path);

        [DllImport(LibRedName)]
        public static extern void redSetEncoding(RedEncoding encIn, RedEncoding encOut);

        [DllImport(LibRedName)]
        public static extern void redPrint(IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redProbe(IntPtr value);

        [DllImport(LibRedName)]
        public static extern IntPtr redHasError();

        [DllImport(LibRedName)]
        public static extern string redFormError();

        [DllImport(LibRedName)]
        public static extern IntPtr redOpenLogWindow();

        [DllImport(LibRedName)]
        public static extern IntPtr redCloseLogWindow();

        [DllImport(LibRedName)]
        public static extern IntPtr redOpenLogFile(string name);

        [DllImport(LibRedName)]
        public static extern void redCloseLogFile();

        [DllImport(LibRedName)]
        public static extern void redClose();
    }
}
