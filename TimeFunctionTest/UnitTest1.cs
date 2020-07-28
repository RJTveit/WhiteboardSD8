using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeFunction;

namespace TimeFunctionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(15, Program.TimeBetween(10, 55, 11, 10));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(45, Program.TimeBetween(12, 20, 1, 5));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(6, Program.TimeBetween(3, 2, 3, 8));
            Assert.AreEqual(60, Program.TimeBetween(1, 0, 2, 0));
            Assert.AreEqual(30, Program.TimeBetween(1, 0, 1, 30));
            Assert.AreEqual(10, Program.TimeBetween(2, 5, 2, 15));
        }
    }
}
