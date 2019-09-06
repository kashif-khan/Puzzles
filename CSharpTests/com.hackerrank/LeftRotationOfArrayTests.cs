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
    public class LeftRotationOfArrayTests
    {
        [TestMethod()]
        public void LeftRotationOfArrayTestCase1()
        {
            int numbersToShift = 4;

            int[] inputArray = Array.ConvertAll("1 2 3 4 5".Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] expectedOutput = Array.ConvertAll("5 1 2 3 4".Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] actualOutput = LeftRotationOfArray.Solve(inputArray, numbersToShift);

            Assert.AreEqual(String.Join(" ", expectedOutput), string.Join(" ", actualOutput));
        }


    }
}