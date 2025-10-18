using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AhmadiMH.Sprint1.Task1.V3.Lib;

namespace Tyuiu.AhmadiMH.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertKmToMiles()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            var result = ds.Calculate(x, y);
            Assert.AreEqual((10 - 5) / (10 + 3) + 3, result);
        }
    }
}