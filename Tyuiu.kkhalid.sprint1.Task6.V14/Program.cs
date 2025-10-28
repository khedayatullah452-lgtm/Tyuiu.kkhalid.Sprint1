using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ЗАДАНИЕ
//Написать программу: пользователь вводит текст.
//Проверить, что строка составлена только из строчных русских букв.

using Tyuiu.kkhalid.sprint1.Task6.V14.Lib;
namespace Tyuiu.kkhalid.sprint1.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" пользователь вводит текст: ");
            string str = Console.ReadLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckLowerCaseRusLetters(str));
            Console.ReadLine();
        }
    }
}