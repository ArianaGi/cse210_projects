using System.ComponentModel.DataAnnotations;

public class Rectangle : Shapes
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width) : base("Green")
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}