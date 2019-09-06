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
    public class HourGlassTests
    {
        /// <summary>
        /// The unique value being in the middle
        /// </summary>
        [TestMethod()]
        public void HourGlassSolveTestCase1()
        {
            var inputArray = new int[6][];

            inputArray[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            inputArray[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            inputArray[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            inputArray[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            inputArray[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            inputArray[5] = new int[] { 0, 0, 1, 2, 4, 0 };
            var outputArray = 19;
            int UniqueValue = HourGlass.Solve(inputArray);
            Assert.AreEqual(outputArray, UniqueValue);
        }
    }
}