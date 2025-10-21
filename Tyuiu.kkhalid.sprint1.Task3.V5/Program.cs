using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint1.Task3.V5.Lib;

namespace Tyuiu.kkhalid.sprint1.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            double x, y;

            Console.WriteLine("Введите Значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между населенными пунктами( distanceBetweenPoints * mapScale = " + ds.DistanceLength(x, y));



            Console.ReadKey();

        }
    }
}
