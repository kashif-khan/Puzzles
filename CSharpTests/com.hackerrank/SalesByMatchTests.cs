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
    public class SalesByMatchTests
    {
        [TestMethod()]
        public void SockMerchantTest()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = ar.Length;

            int result = SalesByMatch.SockMerchant(n, ar);

            Assert.AreEqual(3, result);
        }
    }
}