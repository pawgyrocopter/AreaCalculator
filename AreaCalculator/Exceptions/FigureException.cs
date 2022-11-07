namespace AreaCalculator.Exceptions;

public class FigureException : Exception
{
    public FigureException(){}
    
    public FigureException(string message)
        : base(message) { }

    public FigureException(string message, Exception inner)
        : base(message, inner) { }
}