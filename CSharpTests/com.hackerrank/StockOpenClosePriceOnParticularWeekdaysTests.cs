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
    public class StockOpenClosePriceOnParticularWeekdaysTests
    {
        [TestMethod()]
        public void StockOpenClosePriceOnParticularWeekdaysTestCase1()
        {
            var fromDate = "1-January-2000";
            var toDate = "22-February-2000";
            var weekDay = "Monday";
            var expectedOutput = new string[]
            {
                "17-January-2000 5617.7 5404.07",
                "31-January-2000 5338.67 5205.29",
                "7-February-2000 5431.55 5474",
                "14-February-2000 6130.23 5924.31",
                "21-February-2000 5874.25 5876.89"
            };

            var actualOutput = StockOpenClosePriceOnParticularWeekdays.Solve(fromDate, toDate, weekDay);

            Assert.IsTrue(actualOutput.Count() == expectedOutput.Count(), "Expected output count does not match with actual output count");

            foreach (var item in expectedOutput)
            {
                Assert.IsTrue(actualOutput.Contains(item), $"{item} does not exist in the output");
            }
        }
    }
}