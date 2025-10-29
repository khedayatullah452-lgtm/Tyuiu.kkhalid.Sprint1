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
            double x = 2;
            double y = 4;
            double expected = 2* Math.Log(2) + 4 / (Math.Cos(2) - 4 / 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(expected ,res,30 );
            
        }
    }
}
