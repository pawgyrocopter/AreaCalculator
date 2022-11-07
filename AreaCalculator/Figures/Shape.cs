namespace AreaCalculator.Figures;

public abstract class Shape
{
    protected const decimal PI = (decimal) Math.PI;
    
    public virtual decimal CalculateArea()
    {
        return 0m;
    }
}