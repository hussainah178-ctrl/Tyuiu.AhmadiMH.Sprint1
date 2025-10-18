using System;
using Tyuiu.AhmadiMH.Sprint1.Task2.V1.Lib;

//Задани
//Формулировка задания: Известно расстояние в километрах. Вычислить расстояние в милях.
// При условии, что 1 миля = 1,609 км. Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.AhmadiMH.Sprint1.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите расстояние в километрах (целое число): ");
            int kilometers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double miles = kilometers / 1.609;
            Console.WriteLine($"Расстояние в милях: {miles:F3}                                            ");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}