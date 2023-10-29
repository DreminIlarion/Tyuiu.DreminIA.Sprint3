using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIA.Task4.V16.Lib;


namespace Tyuiu.DreminIA.Task4.V16.Test
{
    [Theory]
    [InlineData(-5, 0.1924605032)]
    [InlineData(-4.5, 0.2045706144)]
    [InlineData(-4, 0.2184157585)]
    // Другие тестовые значения

    public void CalculateFunctionValue_ShouldReturnExpectedResult(double x, double expected)
    {
        double result = MyMath.CalculateFunctionValue(x);
        Assert.Equal(expected, result, 10); // 10 - количество знаков после запятой
    }
}
