using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DreminIA.Sprint3.Task5.V28.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, k;
            for ( i= startValue1; i<= stopValue1;i++)
            {
                for( k= startValue2;k<=stopValue2;k++)
                {
                    res += Math.Pow((x) /( Math.Sin(x)),k);
                }
            }return Math.Round(res,3);
        }   
    }
}
