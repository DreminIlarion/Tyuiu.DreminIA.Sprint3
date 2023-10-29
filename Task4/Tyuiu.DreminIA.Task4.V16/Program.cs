using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DreminIA.Task4.V16.Lib;

namespace Tyuiu.DreminIA.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            double product = 1.0;

            for (double x = -5; x <= 5; x += 0.5)
            {
                double y = MathLibrary.MyMath.CalculateFunctionValue(x);
                if (!double.IsNaN(y)) // Пропускаем значение при x = 0
                {
                    product *= y;
                    Console.WriteLine($"x = {x}, y = {y}");
                }
            }

            Console.WriteLine($"Product of non-skipped values: {product}");
        }
    }
}
