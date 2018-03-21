using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.com.hackerrank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank.Tests
{
    [TestClass()]
    public class ColleenBirthdayCakeCandlesTests
    {
        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase1()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = 2;
            var age = 4;
            var candleHeights = new int[] { 3, 2, 1, 3 };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase2()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = 4;
            var age = 4;
            var candleHeights = new int[] { 3, 3, 3, 3 };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase3()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = 1;
            var age = 4;
            var candleHeights = new int[] { 2, 2, 1, 3 };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase4()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = 1;
            var age = 4;
            var candleHeights = new int[] { 3, 2, 1, 1 };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase5()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = 1;
            var age = 1;
            var candleHeights = new int[] { 3 };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase6()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = -1;
            var age = 0;
            var candleHeights = new int[] { 3 };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ColleenBirthdayCakeCandlesSolveTestCase7()
        {
            var instance = new ColleenBirthdayCakeCandles();
            var expectedOutput = -1;
            var age = 1;
            var candleHeights = new int[] { };
            var actualOutput = instance.Solve(age, candleHeights);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}