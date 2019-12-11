using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure.Tests
{
    [TestClass()]
    public class IntervalTreeTests
    {
        [TestMethod()]
        public void IntervalTreeTestCase1()
        {
            var intervals = new List<IntervalTree<int>>
            {
                new IntervalTree<int>(15,20),
                new IntervalTree<int>(10,30),
                new IntervalTree<int>(17,19),
                new IntervalTree<int>(5, 20),
                new IntervalTree<int>(12,15),
                new IntervalTree<int>(30,40)
            };
            var expectedOutput = new IntervalTree<int>(5, 20);

            IntervalTree<int> parentNode = null;

            for (int iterator = 0; iterator < intervals.Count; iterator++)
            {
                parentNode = IntervalTree<int>.Insert(parentNode, intervals[iterator]);
            }

            var searchOperand = new IntervalTree<int>(6, 7);

            var actualOutput = IntervalTree<int>.Search(parentNode, searchOperand);

            Assert.IsTrue(expectedOutput == actualOutput, "Expected and actual output differs");
        }

        [TestMethod()]
        public void IntervalTreeTestCase2()
        {
            var intervals = new List<IntervalTree<DateTime>>()
            {
                new IntervalTree<DateTime>( new DateTime(2019,01,01),new DateTime(2019,01,03)),
                new IntervalTree<DateTime>( new DateTime(2019,01,04),new DateTime(2019,01,06)),
                new IntervalTree<DateTime>( new DateTime(2019,01,07),new DateTime(2019,01,07)),
                new IntervalTree<DateTime>( new DateTime(2019,01,08),new DateTime(2019,01,08)),
                new IntervalTree<DateTime>( new DateTime(2019,01,09),new DateTime(2019,01,11)),
                new IntervalTree<DateTime>( new DateTime(2019,01,12),new DateTime(2019,01,13))
            };
            var expectedOutput = new IntervalTree<DateTime>(new DateTime(2019, 01, 01), new DateTime(2019, 01, 03));

            IntervalTree<DateTime> parentNode = null;

            for (int iterator = 0; iterator < intervals.Count; iterator++)
            {
                parentNode = IntervalTree<DateTime>.Insert(parentNode, intervals[iterator]);
            }

            var searchOperand = new IntervalTree<DateTime>(new DateTime(2019, 01, 02), new DateTime(2019, 01, 02));

            var actualOutput = IntervalTree<DateTime>.Search(parentNode, searchOperand);

            Assert.IsTrue(expectedOutput == actualOutput, "Expected and actual output differs");
        }
    }
}