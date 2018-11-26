/*
 * 
 * Author:      Kyle Horsley
 * Date:        Nov 25, 2018
 * Project:     SQ1-A2- Test Driven Development
 * File:        TriangleUnitTests.cs
 * Description: This is the test project for my triangle class. It was developed using Test
 *              driven development and serves as a unit tester to ensure all functions of my
 *              test class are adequately working.
 * 
*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ1_A2_TDD;

namespace TriangleUnitTests
{
    [TestClass]
    public class TriangleTests
    {
        Triangle testTriangle = new Triangle();

        /*
        * Name:    HypoteneuseTestNormal
        * Purpose: To ensure the CalculateHyp function could handle basic 
        *          functional inputs.
        */
        [TestMethod]
        public void HypotenuseTestNormal()
        {
            Assert.AreEqual(testTriangle.CalculateHyp(3, 4), 5);
        }

        /*
        * Name:    HypoteneuseTestException
        * Purpose: To ensure that an error number (-1) would be returned
        *          as no negative numbers should be inputted.
        */
        [TestMethod]
        public void HypotenuseTestException()
        {
            Assert.AreEqual(testTriangle.CalculateHyp(-3, 4), -1);
        }

        /*
        * Name:    AreaTestNormal
        * Purpose: To ensure the area formula is correct and can take
        *          regular non boundary or exception inputs.
        */
        [TestMethod]
        public void AreaTestNormal()
        {
            Assert.AreEqual(testTriangle.CalculateArea(8, 9), 36);
        }

        /*
        * Name:     AreaTestException
        * Purpose:  To ensure that the error number (-1) is returned
        *           as both inputs entered are invalid and negative.
        */
        [TestMethod]
        public void AreaTestException()
        {
            Assert.AreEqual(testTriangle.CalculateArea(-9, -8), -1);
        }

        /*
        * Name:    AngleTestNormal
        * Purpose: Ensures normal inputs can be entered to find the 
        *           correct third angle
        */
        [TestMethod]
        public void AngleTestNormal()
        {
            Assert.AreEqual(testTriangle.CalculateAngle (30,120),30);
        }

        /*
        * Name:    AngleTestException
        * Purpose: Ensures the user cannot enter in faulty information
        */
        [TestMethod]
        public void AngleTestException()
        {
            Assert.AreEqual(testTriangle.CalculateAngle(100, 120), -1);
        }
    }
}