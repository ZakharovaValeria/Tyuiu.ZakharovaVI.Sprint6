using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaVI.Sprint6.Task6.V5.Lib;

namespace Tyuiu.ZakharovaVI.Sprint6.Task6.V5.Test 
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
