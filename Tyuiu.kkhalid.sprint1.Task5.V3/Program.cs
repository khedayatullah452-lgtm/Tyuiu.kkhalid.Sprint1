using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ЗАДАНИЕ
//Написать программу, которая решает следующую задачу:
//Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k (например, если k=130985, то h=9).



using Tyuiu.kkhalid.sprint1.Task5.V3.Lib;
namespace Tyuiu.kkhalid.sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

             int k ;
            Console.WriteLine("Введите Значение k:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" k=130985, то h=9 ="+ ds.Calculate(k));
            Console.ReadKey();
        }
    }
}
