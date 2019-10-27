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
    public class AngryAnimalsTests
    {
        [TestMethod()]
        public void AngryAnimalsTestCase1()
        {
            int animalsCount = 4;
            var herbivorus = Array.ConvertAll("1 2".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("3 4".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 7;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase2()
        {
            int animalsCount = 5;
            var herbivorus = Array.ConvertAll("1 2".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("3 5".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 11;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase3()
        {
            int animalsCount = 8;
            var herbivorus = Array.ConvertAll("2 3 4 3".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("8 5 6 4".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 18;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase4()
        {
            int animalsCount = 4;
            var herbivorus = Array.ConvertAll("3 4".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("1 2".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 7;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase5()
        {
            int animalsCount = 5;
            var herbivorus = Array.ConvertAll("3 5".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("1 2".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 11;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase6()
        {
            int animalsCount = 8;
            var herbivorus = Array.ConvertAll("8 5 6 4".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("2 3 4 3".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 18;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase7()
        {
            int animalsCount = 8;
            var herbivorus = Array.ConvertAll("8 5 4 4".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("2 3 6 3".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 18;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase8()
        {
            int animalsCount = 8;
            var herbivorus = Array.ConvertAll("5 4 4 8".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("3 6 3 2".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 18;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void AngryAnimalsTestCase9()
        {
            int animalsCount = 8;
            var herbivorus = Array.ConvertAll("5 4 4 8 1".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var carnivorous = Array.ConvertAll("3 6 3 2 8".Split(' '), aTemp => Convert.ToInt32(aTemp)).ToList();
            var expectedOutput = 18;


            var actualOutput = AngryAnimals.Solve(animalsCount, herbivorus, carnivorous);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}