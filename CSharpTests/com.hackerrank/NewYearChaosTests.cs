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
    public class NewYearChaosTests
    {
        private const string ImpossibleMessage = "Too chaotic";
        [TestMethod()]
        public void NewYearChaosTestCase1()
        {
            int[] input = Array.ConvertAll("2 1 5 3 4".Split(' '), qTemp => Convert.ToInt32(qTemp));
            var expectedOutput = "3";

            var actualOutput = NewYearChaos.Solve(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void NewYearChaosTestCase2()
        {
            int[] input = Array.ConvertAll("2 5 1 3 4".Split(' '), qTemp => Convert.ToInt32(qTemp));
            var expectedOutput = ImpossibleMessage;

            var actualOutput = NewYearChaos.Solve(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void NewYearChaosTestCase3()
        {
            int[] input = Array.ConvertAll("1 2 5 3 7 8 6 4".Split(' '), qTemp => Convert.ToInt32(qTemp));
            var expectedOutput = "7";

            var actualOutput = NewYearChaos.Solve(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}