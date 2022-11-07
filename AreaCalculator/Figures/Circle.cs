namespace AreaCalculator.Figures;

public class Circle : Shape
{
    private decimal _radius;

    public Circle(decimal radius)
    {
        _radius = radius;
    }
    
    public override decimal CalculateArea()
    {
        return PI * _radius * _radius;
    }
}