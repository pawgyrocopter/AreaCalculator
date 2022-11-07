using AreaCalculator.Exceptions;

namespace AreaCalculator.Figures;

public class Triangle : Shape
{
    private decimal _firstSide;
    private decimal _secondSide;
    private decimal _thirdSide;

    public Triangle(decimal firstSide, decimal secondSide, decimal thirdSide)
    {
        if (firstSide + secondSide < thirdSide ||
            secondSide + thirdSide < firstSide ||
            thirdSide + firstSide < secondSide)
        {
            throw new FigureException("This triangle can't exist");
        }

        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    public override decimal CalculateArea()
    {
        var p = (_firstSide + _secondSide + _thirdSide) / 2;
        return (decimal)Math.Sqrt((double) (p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide)));
    }
}