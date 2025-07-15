using System.Reflection.Metadata.Ecma335;

public class Square : Shapes
{
    private double _side;

    public Square(double side) : base("Yellow")
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}