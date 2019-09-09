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
    public class RepeatedStringTests
    {
        [TestMethod()]
        public void RepeatedStringTestCase1()
        {
            string inputString = "aba";

            long repeatCount = 10;

            long expectedOutput = 7;

            long actualOutput = RepeatedString.Solve(inputString, repeatCount);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void RepeatedStringTestCase2()
        {
            string inputString = "a";

            long repeatCount = 1000000000000;

            long expectedOutput = 1000000000000;

            long actualOutput = RepeatedString.Solve(inputString, repeatCount);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void RepeatedStringTestCase3()
        {
            string inputString = "abcac";

            long repeatCount = 10;

            long expectedOutput = 4;

            long actualOutput = RepeatedString.Solve(inputString, repeatCount);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}