using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CircleTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.PI, Circles.Circle.Area(1.0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(100*Math.PI, Circles.Circle.Area(10.0));
        }
    }
}
