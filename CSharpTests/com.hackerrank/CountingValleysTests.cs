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
    public class CountingValleysTests
    {
        [TestMethod()]
        public void CountingValleysTestCase1()
        {
            int stepCount = 8;
            string steps = "UDDDUDUU";
            int expectedOutput = 1;

            int actualOutput = CountingValleys.Solve(stepCount, steps);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}