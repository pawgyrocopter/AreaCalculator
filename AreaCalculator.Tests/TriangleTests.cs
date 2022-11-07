using System;
using System.Runtime.CompilerServices;
using AreaCalculator.Exceptions;
using AreaCalculator.Figures;
using Xunit;

namespace AreaCalculator.Tests;

public class TriangleTests
{

    [Theory]
    [InlineData(2,2,3, 1.98431348329844)]
    [InlineData(4,5,3, 6)]
    [InlineData(10,5,11, 24.9799919935936)]
    public void AreaTriangleTest(decimal a, decimal b, decimal c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);
        var result = (double)triangle.CalculateArea();
        Assert.Equal(expectedArea, result);
    }
    
    [Theory]
    [InlineData(2,2,3,false)]
    [InlineData(4,5,3, true)]
    [InlineData(10,5,11, false)]
    public void IsRightTriangleTest(decimal a, decimal b, decimal c, bool isRight)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(isRight, triangle.IsRight);
    }

    [Theory]
    [InlineData(1,1,1, true)]
    [InlineData(1,2,3, true)]
    [InlineData(4, 5, 3, true)]
    [InlineData(10, 5, 6, true)]
    [InlineData(0 , 0 ,0, false)]
    public void IsExistTriangleTest(decimal a, decimal b, decimal c, bool expectedIsExist)
    {
        bool isExist = true;
        try
        {
            var triangle = new Triangle(a, b, c);
        }
        catch (FigureException figureException)
        {
            isExist = false;
        }
        
        Assert.Equal(isExist, expectedIsExist);
    }
}