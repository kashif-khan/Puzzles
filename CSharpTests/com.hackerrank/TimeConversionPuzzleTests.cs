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
    public class TimeConversionPuzzleTests
    {
        [TestMethod()]
        public void TimeConversionPuzzleSolveTestCase1()
        {
            var instance = new TimeConversionPuzzle();
            var expectedvalue = "19:05:45";
            var testValue = "07:05:45PM";
            var actualvalue = instance.Solve(testValue);
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        public void TimeConversionPuzzleSolveTestCase2()
        {
            var instance = new TimeConversionPuzzle();
            var expectedvalue = "00:00:00";
            var testValue = "12:00:00AM";
            var actualvalue = instance.Solve(testValue);
            Assert.AreEqual(expectedvalue, actualvalue);
        }

        [TestMethod()]
        public void TimeConversionPuzzleSolveTestCase3()
        {
            var instance = new TimeConversionPuzzle();
            var expectedvalue = "12:00:00";
            var testValue = "12:00:00PM";
            var actualvalue = instance.Solve(testValue);
            Assert.AreEqual(expectedvalue, actualvalue);
        }
    }
}