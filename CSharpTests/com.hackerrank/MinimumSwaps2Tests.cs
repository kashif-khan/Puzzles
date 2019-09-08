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
    public class MinimumSwaps2Tests
    {
        [TestMethod()]
        public void MinimumSwaps2TestCase1()
        {
            int[] inputArray = Array.ConvertAll("2 3 4 1 5".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int expectedOutput = 3;

            int actualOutput = MinimumSwaps2.Solve(inputArray);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void MinimumSwaps2TestCase2()
        {
            int[] inputArray = Array.ConvertAll("1 3 5 2 4 6 7".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int expectedOutput = 3;

            int actualOutput = MinimumSwaps2.Solve(inputArray);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void MinimumSwaps2TestCase3()
        {
            int[] inputArray = Array.ConvertAll("4 3 1 2".Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int expectedOutput = 3;

            int actualOutput = MinimumSwaps2.Solve(inputArray);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}