using CSharp.com.hackerrank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests.com.hackerrank
{
    [TestClass()]
    public class SlantedCipherTests
    {
        /// <summary>
        /// Even number of rows
        /// </summary>
        [TestMethod()]
        public void SlantedCipherTestCase1()
        {
            var numberOfRows = 2;
            var encodedString = "hlowrd_el_ol";
            var expectedOutput = "hello world";
            var actualOutput = SlantedCipher.Solve(numberOfRows, encodedString);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        /// <summary>
        /// Odd number of rows
        /// </summary>
        [TestMethod()]
        public void SlantedCipherTestCase2()
        {
            var numberOfRows = 3;
            var encodedString = "mnes__ya_____mi";
            var expectedOutput = "my name is";
            var actualOutput = SlantedCipher.Solve(numberOfRows, encodedString);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
