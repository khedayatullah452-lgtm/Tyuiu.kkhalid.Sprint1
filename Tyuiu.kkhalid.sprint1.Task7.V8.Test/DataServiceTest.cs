using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.sprint1.Task7.V8.Lib;

namespace Tyuiu.kkhalid.sprint1.Task7.V8.Test



{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double expected = 10 * Math.Log(10) + 20 / (Math.Cos(10) - 10 / 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(expected ,res,30 );
            
        }
    }
}
