using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(PrimeNumberReturn.PrimeNumberRet.IsPrimeNumber(7));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(PrimeNumberReturn.PrimeNumberRet.IsPrimeNumber(12));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(PrimeNumberReturn.PrimeNumberRet.IsPrimeNumber(7));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(PrimeNumberReturn.PrimeNumberRet.IsPrimeNumber(12));
        }
    }
}
