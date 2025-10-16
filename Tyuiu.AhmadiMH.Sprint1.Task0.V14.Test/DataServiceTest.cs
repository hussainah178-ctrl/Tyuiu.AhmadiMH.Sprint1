using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AhmadiMH.Sprint1.Task0.V14.Lib;

namespace Tyuiu.AhmadiMH.Sprint1.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var result = ds.Calculate();
            Assert.AreEqual(25, result);
        }
    }
}
