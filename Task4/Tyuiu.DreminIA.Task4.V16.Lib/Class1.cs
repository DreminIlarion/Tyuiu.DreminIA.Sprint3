using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;

namespace Tyuiu.DreminIA.Task4.V16.Lib
{
    public class Class1 : : ISprint3Task4V16
    {
        public static double CalculateFunctionValue(double x)
        {
            if (x == 0)
            {
                return double.NaN; // Пропускаем значение при x = 0
            }

            return ((Math.Cos(x) + x) / x) + 0.25;
        }
    }
}
