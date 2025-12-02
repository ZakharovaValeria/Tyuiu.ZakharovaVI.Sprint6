using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaVI.Sprint6.Task0.V2.Lib;

namespace Tyuiu.ZakharovaVI.Sprint6.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 6.425;
            Assert.AreEqual(wait, res);
        }
    }
}
