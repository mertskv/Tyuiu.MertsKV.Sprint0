using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Tyuiu.MertsKV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.MertsKV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServise.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5};
            var res = DataServise.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);

        }
        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5};
            var res = DataServise.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }

    }
}
