
using Xunit;

public class testCalculator{
    [Fact]
    public void Sum5and25return30(){
        Calculator calc = new Calculator();

        int expectedNumber = 30;
        int resNumber = calc.Sum(5, 25);

        Assert.Equal(expectedNumber, resNumber);
    }

    [Fact]
    public void Multiply5and25return125(){
        Calculator calc = new Calculator();

        int expectedNumber = 125;
        int resNumber = calc.Multipy(5, 25);

        Assert.Equal(expectedNumber, resNumber);
    }
}