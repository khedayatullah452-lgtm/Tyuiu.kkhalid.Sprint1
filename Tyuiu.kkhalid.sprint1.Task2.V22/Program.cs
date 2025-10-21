using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Заданы три числа. Вычислить среднее значение из них.
//Первое число (целое число), Второе число (целое число), Третье число (целое число)
//Среднее значение (целое число)


using Tyuiu.kkhalid.sprint1.Task2.V22.Lib;

namespace Tyuiu.kkhalid.sprint1.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");


            int x, y, z;

            Console.WriteLine("Введите Значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Значение z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Среднее значение (целое число) = " + ds.CalculateAVGValue(x, y, z));

            Console.ReadKey();

        }
    }
}
