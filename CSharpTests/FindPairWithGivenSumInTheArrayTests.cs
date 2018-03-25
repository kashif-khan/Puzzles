using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tests
{
    [TestClass()]
    public class FindPairWithGivenSumInTheArrayTests
    {
        [TestMethod()]
        public void FindPairWithGivenSumInTheArraySolveTestCase1()
        {
            var instance = new FindPairWithGivenSumInTheArray();
            var inputArray = new int[] { 8, 7, 2, 5, 3, 1 };
            var sum = 10;
            var expectedOutput = new List<string>() { "0:2", "1:4" };
            var actualOutput = instance.Solve(inputArray, sum);
            Assert.IsTrue(expectedOutput.SequenceEqual(actualOutput));
        }
        
        //TODO: Duplicates cannot be added in the dictionary
        //[TestMethod()]
        //public void FindPairWithGivenSumInTheArraySolveTestCase2()
        //{
        //    var instance = new FindPairWithGivenSumInTheArray();
        //    var inputArray = new int[] { 8, 2, 7, 3, 3, 2 };
        //    var sum = 10;
        //    var expectedOutput = new List<string>() { "0:1", "2:3", "2:4", "0:5" };
        //    var actualOutput = instance.Solve(inputArray, sum);
        //    Assert.IsTrue(expectedOutput.SequenceEqual(actualOutput));
        //}
    }
}