using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank.Tests
{
    [TestClass()]
    public class TrimPuzzleTests
    {
        [TestMethod()]
        public void TrimPuzzleSolveTestCase1()
        {
            var Input = "kincenvizh";
            var puzzle = new TrimPuzzle();
            var Output = puzzle.Solve(Input);
            Assert.IsTrue(Output.Count == 53);
        }

        [TestMethod()]
        public void TrimPuzzleSolveTestCase2()
        {
            var Input = "ii";
            var puzzle = new TrimPuzzle();
            var Output = puzzle.Solve(Input);
            Assert.IsTrue(Output.Count == 2);
        }

        [TestMethod()]
        public void TrimPuzzleSolveTestCase3()
        {
            var Input = "iki";
            var puzzle = new TrimPuzzle();
            var Output = puzzle.Solve(Input);
            Assert.IsTrue(Output.Count == 5);
        }
    }
}