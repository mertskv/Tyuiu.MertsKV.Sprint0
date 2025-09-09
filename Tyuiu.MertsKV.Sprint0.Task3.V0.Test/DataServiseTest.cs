using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MertsKV.Sprint0.Task3.V0.Lib;

namespace Tyuiu.MertsKV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataServise.Sum(5, 5));
        }
    }
}
