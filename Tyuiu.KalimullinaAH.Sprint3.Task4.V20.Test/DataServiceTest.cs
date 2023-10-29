using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIA.Sprint3.Task4.V20.Lib;
namespace Tyuiu.DreminIA.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2.239;
            Assert.AreEqual(wait, res);
        }
    }
}
