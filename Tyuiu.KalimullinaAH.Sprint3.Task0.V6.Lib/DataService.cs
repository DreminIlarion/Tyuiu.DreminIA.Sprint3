using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DreminIA.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                res *= 1 / Math.Pow((Math.Cos(5) + 1), 2);
            }

            return Math.Round(res, 3);
        }

      
    }
}
