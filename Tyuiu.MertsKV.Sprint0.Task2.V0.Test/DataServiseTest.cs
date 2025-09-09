using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MertsKV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MertsKV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest 
    {
        [TestMethod]
        public void CheckGetMessangeValid() 
        {
            // Область создания методов тестирования из библиотеки 
            var name = "Кристина";
            var res = DataServise.GetMessange(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Кристина", res);
        }
    }
}
