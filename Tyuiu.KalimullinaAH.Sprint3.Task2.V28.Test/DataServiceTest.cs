﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIA.Sprint3.Task2.V28.Lib;
namespace Tyuiu.DreminIA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue =9 ;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = -15.642;
            Assert.AreEqual(wait, res);
        }
    }
}
