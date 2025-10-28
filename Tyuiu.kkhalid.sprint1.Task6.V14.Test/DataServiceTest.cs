using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using Tyuiu.kkhalid.sprint1.Task6.V14.Lib;
namespace Tyuiu.kkhalid.sprint1.Task6.V14.Test


{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string input  = ("я люблю путешествовать на природе");
            
            DataService ds = new DataService();

            bool result = ds.CheckLowerCaseRusLetters(input);
            Assert.IsTrue(result);

        }
    }
}
