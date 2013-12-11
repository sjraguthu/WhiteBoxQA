using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteBoxQA.Models;

namespace WhiteBoxQA.Tests
{
    [TestClass]
    public class UtilityTests
    {
        // example unit test
        [TestMethod]
        public void AddTenTest()
        {
            int actualResult = Utility.AddTen(4);
            Assert.AreEqual(14, actualResult);
        }
    }
}