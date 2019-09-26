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
    public class ImageEditingTests
    {
        [TestMethod()]
        public void ImageEditingTestCase1()
        {
            var dimension = 3;
            var image = new string[]
            {
                "1 1 1",
                "1 1 0",
                "1 0 1"
            };
            var expectedOutput = 2;
            var inputData = PrepareData(dimension, dimension, image);

            var actualOutput = ImageEditing.Solve(inputData);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void ImageEditingTestCase2()
        {
            var dimension = 5;
            var image = new string[]
            {
                "1 1 1 1 1",
                "1 1 1 0 0",
                "1 1 1 0 0",
                "1 1 1 0 0",
                "1 1 1 1 1"
            };
            var expectedOutput = 3;
            var inputData = PrepareData(dimension, dimension, image);

            var actualOutput = ImageEditing.Solve(inputData);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        private List<List<int>> PrepareData(int arrRows, int arrColumns, params string[] values)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < arrRows; i++)
            {
                arr.Add(values[i].TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            return arr;
        }
    }
}