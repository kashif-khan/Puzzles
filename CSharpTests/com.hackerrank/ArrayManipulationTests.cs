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
    public class ArrayManipulationTests
    {
        [TestMethod()]
        public void ArrayManipulationTestCase1()
        {
            uint specimenArrayLength = 5;

            int[][] queries = new int[3][];

            queries[0] = Array.ConvertAll("1 2 100".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            queries[1] = Array.ConvertAll("2 5 100".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            queries[2] = Array.ConvertAll("3 4 100".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));

            var expectedOutput = 200;

            long actualOutput = ArrayManipulation.Solve(specimenArrayLength, queries);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ArrayManipulationTestCase2()
        {
            uint specimenArrayLength = 10;

            int[][] queries = new int[3][];

            queries[0] = Array.ConvertAll("1 5 3".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            queries[1] = Array.ConvertAll("4 8 7".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            queries[2] = Array.ConvertAll("6 9 1".Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));

            var expectedOutput = 10;

            long actualOutput = ArrayManipulation.Solve(specimenArrayLength, queries);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}