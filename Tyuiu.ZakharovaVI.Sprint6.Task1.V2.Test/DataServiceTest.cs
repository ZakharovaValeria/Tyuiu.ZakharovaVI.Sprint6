using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaVI.Sprint6.Task1.V2.Lib;
namespace Tyuiu.ZakharovaVI.Sprint6.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -15.6;
            valueWaitArray[1] = -12.35;
            valueWaitArray[2] = -10.72;
            valueWaitArray[3] = -8.88;
            valueWaitArray[4] = -2.16;
            valueWaitArray[5] = 3.25;
            valueWaitArray[6] = 6.64;
            valueWaitArray[7] = 10.3;
            valueWaitArray[8] = 16.17;
            valueWaitArray[9] = 28.1;
            valueWaitArray[10] = 38.41;

            double[] res;
            
            res = ds.GetMassFunction(startValue, stopValue);
            

            Console.WriteLine("Expected: " + string.Join(",", valueWaitArray));
            Console.WriteLine("Actual: " + string.Join(", ", res));


            CollectionAssert.AreEqual(valueWaitArray, res);

          

        }
    }
}
