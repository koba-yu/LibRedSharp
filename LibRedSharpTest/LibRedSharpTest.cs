using LibRedSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace LibRedSharpTest
{
    [TestClass]
    public class LibRedSharpTest
    {
        [ClassInitialize]
        public static void LibRedOpen(TestContext testContext)
        {
            LibRedApi.redOpen();
        }

        [ClassCleanup]
        public static void LibRedClose()
        {
            LibRedApi.redClose();
        }

        [TestMethod]
        public void AddIntegerTest()
        {
            var temp = LibRedApi.redDo("1 + 2");
            var ret = LibRedApi.redCInt32(temp);
            Assert.AreEqual(3, ret);
        }

        [TestMethod]
        public void StringTest()
        {
            LibRedApi.redOpen();
            LibRedApi.redSetEncoding(RedEncoding.UTF8, RedEncoding.UTF16);
            var redString = LibRedApi.redDo(@"{ABC}");
            var cString = LibRedApi.redCString(redString);
            var text = Marshal.PtrToStringUni(cString);
            Assert.AreEqual("ABC", text);
        }
    }
}
