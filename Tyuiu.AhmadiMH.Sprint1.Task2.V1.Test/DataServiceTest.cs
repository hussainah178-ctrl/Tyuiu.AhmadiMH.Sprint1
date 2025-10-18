using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.AhmadiMH.Sprint1.Task2.V1.Lib;

namespace Tyuiu.AhmadiMH.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertKmToMiles()
        {
            DataService ds = new DataService();
            int value = 100;
            double wait = 62.150;
            double res = ds.ConvertKmToMiles(value);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidConvertKmToMilesWithZero()
        {
            DataService ds = new DataService();
            int value = 0;
            double wait = 0;
            double res = ds.ConvertKmToMiles(value);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertKmToMilesWithFifty()
        {
            DataService ds = new DataService();
            int value = 50;
            double wait = 31.075;
            double res = ds.ConvertKmToMiles(value);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}