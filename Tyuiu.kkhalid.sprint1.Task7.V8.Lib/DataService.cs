using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.kkhalid.sprint1.Task7.V8.Lib

{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double res = 2 * Math.Log(2) + 4 / (Math.Cos(2) - 4 / 3);
           
            return res;
        }
    }
}
