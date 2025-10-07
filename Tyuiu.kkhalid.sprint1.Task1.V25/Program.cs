using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные
//вычисляет результат по формуле (x*y)/(1+x) и печатает его на экране.

using Tyuiu.kkhalid.Sprint1.Task1.V25.Lib;

namespace Tyuiu.kkhalid.Sprint1.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Халид Х. Х.    | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Халид Хедаятулла         | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение                         *");
            Console.WriteLine("* (x * y)/(1 + x)              и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
             
            double x, y;

            Console.WriteLine("Введите Значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            //Метод Calculate находится в бибилиотеке Tyuiu.kkhalid.sprint1.Task1.V25.lib
            //в классе DataSrevice
            Console.WriteLine(ds.Calculate(x,y));

            Console.ReadLine();

        }   

    }         

}
