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
            double cosx = Math.Cos(x);
            double denominator = cosx - (x / 3);
            double term1 = x * Math.Log(x);
            double term2 = y / cosx - (x / 3);

            return term1 + term2;
        }
    }
}
