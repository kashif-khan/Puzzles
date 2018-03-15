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
    public class HolePuzzleTests
    {
        [TestMethod()]
        public void HolePuzzleSolveTestCase1()
        {
            var puzzleInstance = new HolePuzzle();
            int TotalHoles = puzzleInstance.Solve(8888);
            Assert.AreEqual(8, TotalHoles);
        }

        [TestMethod()]
        public void HolePuzzleSolveTestCase2()
        {
            var puzzleInstance = new HolePuzzle();
            int TotalHoles = puzzleInstance.Solve(123);
            Assert.AreEqual(0, TotalHoles);
        }

        [TestMethod()]
        public void HolePuzzleSolveTestCase3()
        {
            var puzzleInstance = new HolePuzzle();
            int TotalHoles = puzzleInstance.Solve(101);
            Assert.AreEqual(1, TotalHoles);
        }

        [TestMethod()]
        public void HolePuzzleSolveTestCase4()
        {
            var puzzleInstance = new HolePuzzle();
            int TotalHoles = puzzleInstance.Solve(181);
            Assert.AreEqual(2, TotalHoles);
        }
    }
}