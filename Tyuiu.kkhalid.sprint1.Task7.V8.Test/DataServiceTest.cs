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
            double wait = -2.307;
           var  res = ds.Calculate(x, y);
            Assert.AreEqual(-2.307 ,res );
            
        }
    }
}
