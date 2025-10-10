using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.kkhalid.Sprint1.Task2.V22.Lib
{
    public class DataService : ISprint1Task2V22
    {
        public int CalculateAVGValue(int a , int b, int c)
        {
            int result = (a + b + c) / 3;
            return result;
        }
    }
}
