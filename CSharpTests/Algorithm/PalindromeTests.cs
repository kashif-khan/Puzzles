using CSharp.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Algorithm.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void TrueCaseSensitivePalindromeEvenLengthString()
        {
            var input = "hannah";
            var expectedOutput = true;
            var sut = new Palindrome();

            var actualOutput = sut.IsPalindrome(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void TrueCaseSensitivePalindromeOddLengthString()
        {
            var input = "civic";
            var expectedOutput = true;
            var sut = new Palindrome();

            var actualOutput = sut.IsPalindrome(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void FalseCaseSensitivePalindromeEvenLengthString()
        {
            var input = "abcd";
            var expectedOutput = false;
            var sut = new Palindrome();

            var actualOutput = sut.IsPalindrome(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void FalseCaseSensitivePalindromeOddLengthString()
        {
            var input = "abcde";
            var expectedOutput = false;
            var sut = new Palindrome();

            var actualOutput = sut.IsPalindrome(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}