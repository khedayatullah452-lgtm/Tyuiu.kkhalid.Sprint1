using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.sprint1.Task4.V25.Lib;

namespace Tyuiu.kkhalid.sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);

        }
    }
}
