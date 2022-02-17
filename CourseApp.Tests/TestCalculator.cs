using System;
using Xunit;
using Calculator;

namespace TestCalculator
{
    public class TestCalculator
    {
        [Fact]
        public void Multiply_5and5_25return()
        {
            Calc calc = new Calc();

            int x = 5;
            int y = 5;

            Assert.Equal(25, calc.Multiply(x,y));
        }

        [Fact]
        public void Sum_5and5_10return()
        {
            Calc calc = new Calc();

            int x = 5;
            int y = 5;

            Assert.Equal(10, calc.Sum(x, y));
        }
    }
}
