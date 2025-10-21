using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.kkhalid.sprint1.Task2.V22.Lib;

namespace Tyuiu.kkhalid.sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 2;
            int z = 4;
            var res = ds.CalculateAVGValue(x, y, z);
            Assert.AreEqual(3, res);

        }
    }
}
