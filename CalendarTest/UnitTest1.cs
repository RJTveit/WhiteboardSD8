using CalendarLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalendarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime testDate1 = new DateTime(2020, 08, 04);
            Assert.AreEqual(217, Class1.GetJulianDate(testDate1));
        }
    }
}
