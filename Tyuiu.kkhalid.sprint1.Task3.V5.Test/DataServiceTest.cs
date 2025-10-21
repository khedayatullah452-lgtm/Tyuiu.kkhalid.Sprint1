using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.kkhalid.sprint1.Task3.V5.Lib;

namespace Tyuiu.kkhalid.sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 120;
            double y = 3.5;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(420.000, res);

        }
    }
}
