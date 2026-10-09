using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(5, "Red");
        shapes.Add(square);
        //shapes.Add(new Square(5, "Red")); A quick way to do the above
        
        Rectangle rectangle = new Rectangle(5, 3, "Green");
        shapes.Add(rectangle);
        //shapes.Add(new Rectangle(5, 3, "Green"));

        Circle circle = new Circle(6, "Yellow");
        shapes.Add(circle);
        //shapes.Add(new Circle(7, "Yellow"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}