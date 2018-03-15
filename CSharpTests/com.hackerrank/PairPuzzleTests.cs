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
    public class PairPuzzleTests
    {
        /// <summary>
        /// The unique value being in the middle
        /// </summary>
        [TestMethod()]
        public void PairPuzzleSolveTestCase1()
        {
            var values = new int[] { 1, 1, 2, 1, 1 };
            int UniqueValue = PairPuzzle.Solve(values);
            Assert.AreEqual(2, UniqueValue);
        }

        /// <summary>
        /// The unique value being in the last
        /// </summary>
        [TestMethod()]
        public void PairPuzzleSolveTestCase2()
        {
            var values = new int[] { 1, 1, 1, 1, 2 };
            int UniqueValue = PairPuzzle.Solve(values);
            Assert.AreEqual(2, UniqueValue);
        }

        /// <summary>
        /// The unique value being in the beginning
        /// </summary>
        [TestMethod()]
        public void PairPuzzleSolveTestCase3()
        {
            var values = new int[] { 2, 1, 1, 1, 1 };
            int UniqueValue = PairPuzzle.Solve(values);
            Assert.AreEqual(2, UniqueValue);
        }

        /// <summary>
        /// The unique value is absent in the list
        /// </summary>
        [TestMethod()]
        public void PairPuzzleSolveTestCase4()
        {
            var values = new int[] { 1, 1, 1, 1 };
            int UniqueValue = PairPuzzle.Solve(values);
            Assert.AreEqual(-1, UniqueValue);
        }

        /// <summary>
        /// The unique value being in the last
        /// </summary>
        [TestMethod()]
        public void PairPuzzleSolveTestCase5()
        {
            var values = new int[] { 1, 1, 2 };
            int UniqueValue = PairPuzzle.Solve(values);
            Assert.AreEqual(2, UniqueValue);
        }
    }
}