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
    public class JumpingOnTheCloudsTests
    {
        [TestMethod()]
        public void JumpingOnTheCloudsTestCase1()
        {
            var clouds = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            var expectedJumps = 4;

            var actualJumps = JumpingOnTheClouds.Solve(clouds);

            Assert.AreEqual(expectedJumps, actualJumps);
        }

        [TestMethod()]
        public void JumpingOnTheCloudsTestCase2()
        {
            var clouds = new int[] { 0, 0, 0, 0, 1, 0 };
            var expectedJumps = 3;

            var actualJumps = JumpingOnTheClouds.Solve(clouds);

            Assert.AreEqual(expectedJumps, actualJumps);
        }

        [TestMethod()]
        public void JumpingOnTheCloudsTestCase3()
        {
            var clouds = new int[] { 0, 0, 0, 1, 0, 0 };
            var expectedJumps = 3;

            var actualJumps = JumpingOnTheClouds.Solve(clouds);

            Assert.AreEqual(expectedJumps, actualJumps);
        }
    }
}