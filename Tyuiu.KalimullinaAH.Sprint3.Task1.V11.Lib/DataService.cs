﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DreminIA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            while (startValue <= stopValue)

            {
                    res = res * (Math.Pow(value, startValue) + 1.0/2);
                    startValue++;
            }
         return Math.Round(res,3);
              
               
           
        }
    }
}
