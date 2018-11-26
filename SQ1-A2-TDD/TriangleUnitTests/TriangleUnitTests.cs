using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ1_A2_TDD;

namespace TriangleUnitTests
{
    [TestClass]
    public class TriangleTests
    {
        Triangle testTriangle = new Triangle();

        [TestMethod]
        public void HypotenuseTestNormal()
        {
            Assert.AreEqual(testTriangle.CalculateHyp(3, 4), 5);
        }

        [TestMethod]
        public void HypotenuseTestException()
        {
            Assert.AreEqual(testTriangle.CalculateHyp(-3, -4), 0);
        }
    }
}
