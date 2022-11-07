namespace AreaCalculator.Figures;

public abstract class Shape
{
    protected const decimal PI = 3.14m;
    
    public virtual decimal CalculateArea()
    {
        return 0m;
    }
}