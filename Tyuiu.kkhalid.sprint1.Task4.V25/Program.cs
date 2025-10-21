using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.
//  формула
// 
// ( 1/ 1+cos alpha )

using Tyuiu.kkhalid.sprint1.Task4.V25.Lib;

namespace Tyuiu.kkhalid.sprint1.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine("Введите Значение X:");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("1/ 1+cos alpha =" + ds.Calculate(x));
            Console.ReadKey();

        }
    }
}
