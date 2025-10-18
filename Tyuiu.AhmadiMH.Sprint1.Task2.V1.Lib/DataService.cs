
namespace Tyuiu.AhmadiMH.Sprint1.Task2.V1.Lib

{
    public class DataService:
    {
        public double ConvertKmToMiles(int value)
        {
            double result = value / 1.609;
            return Math.Round(result, 3);
        }
    }
}