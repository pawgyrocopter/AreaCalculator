using System.Diagnostics;
using AreaCalculator.Exceptions;

namespace AreaCalculator.Figures;

public class Triangle : Shape
{
    private decimal _firstSide = 0m;
    private decimal _secondSide = 0m;
    private decimal _thirdSide = 0m;

    public readonly bool IsRight = false;

    public Triangle(decimal firstSide, decimal secondSide, decimal thirdSide)
    {
        CheckExistance(firstSide, secondSide, thirdSide);
        IsRight = CheckRight(firstSide, secondSide, thirdSide);
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    public override decimal CalculateArea()
    {
        var p = (_firstSide + _secondSide + _thirdSide) / 2;
        return (decimal) Math.Sqrt((double) (p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide)));
    }

    private bool CheckExistance(in decimal firstSide,in decimal secondSide,in decimal thirdSide)
    {
        if (firstSide + secondSide < thirdSide ||
            secondSide + thirdSide < firstSide ||
            thirdSide + firstSide < secondSide)
        {
            throw new FigureException("This triangle can't exist");
        }
        return true;
    }

    private bool CheckRight(in decimal firstSide, in decimal secondSide, in decimal thirdSide)
    {
        var maxSide = Math.Max(Math.Max(firstSide, secondSide), thirdSide);
        var right = maxSide switch
        {
            var value when value == firstSide => secondSide * secondSide * secondSide + thirdSide * thirdSide == firstSide * firstSide ,
            var value when value == secondSide => firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide ,
            var value when value == thirdSide => secondSide * secondSide + firstSide * firstSide == thirdSide * thirdSide ,
            _ => false
        };

        return right;
    }
}