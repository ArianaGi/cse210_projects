using System.Net.NetworkInformation;

public class Circle : Shapes
{
    private double _radius;
    private double _pi = 3.14159;

    public Circle(double radius) : base("pink")
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.Pow(_pi * _radius, 2);
        return area;
    }
}