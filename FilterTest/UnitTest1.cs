using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayFilter;
using System;

namespace ArrayFilterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFilterDistinct()
        {
            int[] testArray = { 8, 6, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 9 };
            Assert.AreEqual(7, DistinctArrayFilter.DistinctInteger(testArray));
        }

        [TestMethod]
        public void TestFilterDistinct2()
        {
            int[] testArray = { 8, 4, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 1 };
            Assert.AreNotEqual(7, DistinctArrayFilter.DistinctInteger(testArray));
        }

        [TestMethod]
        public void TestFilterDistinct3()
        {
            int[] testArray = { 8, 4, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 1 };
            Assert.AreEqual(9, DistinctArrayFilter.DistinctInteger(testArray));
        }

        [TestMethod]
        public void TestFilterDistinct4()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 9, 2, 3 };
            Assert.AreEqual(6, DistinctArrayFilter.DistinctInteger(testArray));
        }

        [TestMethod]
        public void TestFilterDistinct5()
        {
            int[] testArray = { 1, 2, 3 };
            Assert.AreEqual(3, DistinctArrayFilter.DistinctInteger(testArray));
        }


    }
}
