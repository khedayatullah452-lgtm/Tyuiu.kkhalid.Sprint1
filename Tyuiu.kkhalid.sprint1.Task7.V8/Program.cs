
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint1.Task7.V8.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.
//  формула
//                   y      
//( Z = x*lnx + --------------- )
//                cosx - x / 3

namespace Tyuiu.kkhalid.sprint1.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                 y        ");                                             
            Console.WriteLine("z = x * lnx + ----------- ");
            Console.WriteLine("              cosx - x/3 ");
            



           double x, y;
            Console.WriteLine("Введите Значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                y                 ");
            Console.WriteLine("z = x*lnx + ---------- =" + ds.Calculate(x,y));
            Console.WriteLine("            cosx - x/3                                ");
            Console.ReadKey();


        }

    }

}

