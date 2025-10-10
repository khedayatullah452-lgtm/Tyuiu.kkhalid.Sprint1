using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.Sprint1.Task2.V22.Lib;

namespace Tyuiu.kkhalid.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 4;
            int c = 6;
            var res = ds.CalculateAVGValue(a, b, c);
            Assert.AreEqual(4, res);
        }
    }
}
