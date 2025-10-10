using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.Sprint1.Task2.V22.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
//Расчеты:Заданы три числа. Вычислить среднее значение из них.
// Первое число (a), Второе число (b), Третье число (c)
//Среднее значение (целое число)


namespace Tyuiu.kkhalid.Sprint1.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 22 — Вычисление среднего значения трёх чисел");
            Console.WriteLine("***********************************************");

            int a, b, c;

            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            c = int.Parse(Console.ReadLine());

            DataService ds = new DataService();
            int average = ds.CalculateAVGValue(a, b, c);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Среднее значение (целое число): " + average);

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();





        }
    }
}
