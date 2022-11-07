using AreaCalculator.Figures;
using Xunit;

namespace AreaCalculator.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 3.14159265358979)]
    [InlineData(2, 12.56637061435916)]
    [InlineData(3, 28.27433388230811)]
    [InlineData(4, 50.26548245743664)]
    [InlineData(5,78.53981633974475)]
    [InlineData(5.5, 95.0331777710911475)]
    [InlineData(6.6, 136.8477759903712524)]
    [InlineData(10.1, 320.4738665926944779)]
    public void AreaCircleTest(decimal radius, double areaExpected)
    {
        var circle = new Circle(radius);
        var result = (double) circle.CalculateArea();
        Assert.Equal(areaExpected, result);
    }
}