using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security;
using Tyuiu.kkhalid.Sprint1.Task1.V25.Lib;
namespace Tyuiu.kkhalid.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpreission()
        {
          DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.calculate(x, y);
            Assert .AreEqual(2, res);
            
        }
    }
}
