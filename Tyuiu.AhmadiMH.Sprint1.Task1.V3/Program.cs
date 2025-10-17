using System;
using Tyuiu.AhmadiMH.Sprint1.Task1.V3.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные
//ычисляет результат по формуле (x-y)/(x+3)+3 и печатает его на экране

namespace Tyuiu.AhmadiMH.Sprint1.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спинт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задани 0#                                                               *");
            Console.WriteLine("* Вариант 3#                                                              *");
            Console.WriteLine(" * Выполнил: Спирин Игорь Сергеевич | АСОи                                *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Формула: (x - y) / (x + 3) + 3                                          *");
            Console.WriteLine("* Введите значение X:                                                     *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите значение Y:                                                     *");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine("* " + result + "                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}