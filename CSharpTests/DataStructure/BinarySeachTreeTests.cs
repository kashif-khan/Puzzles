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
    public class BinarySeachTreeTests
    {
        [TestMethod()]
        public void BinarySeachTreeTestCase1()
        {
            var rnd = new Random();

            var set = new HashSet<int>();

            do
            {
                var value = rnd.Next(100, 1000);
                set.Add(value);
                Console.WriteLine($"Choosing value: {value}");
            } while (set.Count < 10);

            BinarySeachTree<int> searchTree = null;

            foreach (var item in set)
            {
                searchTree = BinarySeachTree<int>.Insert(searchTree, item);
            }

            var expectedOutput = set.Skip(4).First();

            var actualOutput = BinarySeachTree<int>.Search(searchTree, expectedOutput);

            Assert.AreEqual(expectedOutput, actualOutput.Value, "Value does not match");
        }
    }
}