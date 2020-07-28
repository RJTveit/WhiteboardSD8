using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberCompare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_compareIntegers()
        {
            Assert.AreEqual("5 > 2", Program.NumberCompare(5, 2));
        }
        [TestMethod]
        public void TestMethod_compareDoubles()
        {
            Assert.AreEqual("5.2 > 2.1", Program.NumberCompare(5.2, 2.1));
        }
    }
}
