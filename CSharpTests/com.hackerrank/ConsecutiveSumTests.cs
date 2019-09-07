using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.com.hackerrank;

namespace CSharpTests.com.hackerrank
{
    /// <summary>
    /// Summary description for ConsecutiveSumTests
    /// </summary>
    [TestClass]
    public class ConsecutiveSumTests
    {
        public ConsecutiveSumTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Single digit input number
        /// </summary>
        [TestMethod]
        public void ConsecutiveSumTestCase0()
        {
            var input = 1L;
            var expectedOutput = 0;
            var actualOutput = ConsecutiveSum.Solve(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        /// <summary>
        /// Odd input number
        /// </summary>
        [TestMethod]
        public void ConsecutiveSumTestCase1()
        {
            var input = 15L;
            var expectedOutput = 3;
            var actualOutput = ConsecutiveSum.Solve(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        /// <summary>
        /// Even input number
        /// </summary>
        [TestMethod]
        public void ConsecutiveSumTestCase2()
        {
            var input = 10L;
            var expectedOutput = 1;
            var actualOutput = ConsecutiveSum.Solve(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ConsecutiveSumTestCase3()
        {
            var input = (long)Math.Pow(10, 12); // 1000000000000
            var expectedOutput = 12;
            var actualOutput = ConsecutiveSum.Solve(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
