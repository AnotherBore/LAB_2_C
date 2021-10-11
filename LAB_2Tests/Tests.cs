using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LAB_2.Tests
{
    [TestClass()]
    public class Logic1
    {
        [TestMethod()]
        public void RealSquare()
        {
            UInt16 a = 10;
            UInt16 b = 10;
            UInt16 count = LogicTask1.CuttingSquares(a, b);
            Assert.AreEqual(1, count);
        }
        [TestMethod()]
        public void DefaultRectangle()
        {
            UInt16 a = 10;
            UInt16 b = 7;
            UInt16 count = LogicTask1.CuttingSquares(a, b);
            Assert.AreEqual(6, count);
        }
    }

    [TestClass()]
    public class Logic2
    {
        [TestMethod()]
        public void AllIsLetters()
        {
            string input = "ahdshasjhdajnscxn";
            int dol = Task2.LogicTask2.ProportionOfLetters(input);
            Assert.AreEqual(100, dol);
        }

        [TestMethod()]
        public void TwentyPercent()
        {
            string input = "ah  9341 .";
            int dol = Task2.LogicTask2.ProportionOfLetters(input);
            Assert.AreEqual(20, dol);
        }

        [TestMethod()]
        public void NoLetters()
        {
            string input = "123612893182   ,.,";
            int dol = Task2.LogicTask2.ProportionOfLetters(input);
            Assert.AreEqual(0, dol);
        }
    }
}