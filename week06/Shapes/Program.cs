using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

        List<Shapes> shapesList = new List<Shapes>();
        shapesList.Add(new Square(3.4));
        shapesList.Add(new Rectangle(2.5, 6.0));
        shapesList.Add(new Circle(3.2));

        foreach (Shapes shapes in shapesList)
        {
            Console.WriteLine(shapes.GetColor());
            Console.WriteLine(shapes.GetArea());
        }


        /*Square square = new Square(3.4);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(2.5, 6.0);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(3.2);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());*/
    }
}