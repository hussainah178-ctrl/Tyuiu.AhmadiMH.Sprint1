using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AhmadiMH.Sprint1.Task0.V14.Lib;
//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение 2*3*3+7 и печатает результат на экране

namespace Tyuiu.AhmadiMH.Sprint1.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* Спинт #1                                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                                        *");
            Console.WriteLine("* Задани 0#                                                                               *");
            Console.WriteLine("* Вариант 14#                                                                             *");
            Console.WriteLine(" * Выполнил: Спирин Игорь Сергеевич | АСОиУб-25-1                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
            Console.WriteLine(" * Написать программу, которая вычисляет выражение 2*3*3+7 и печатает результат на экране *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* 2 * 3 * 3 + 7                                                                           *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                              *");
            Console.WriteLine("*******************************************************************************************");
            //Метод Calculate находится в библиотеке Tyulu.SpirinIS.Sprint1.Task0.V0.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadKey();
        }
    }
}