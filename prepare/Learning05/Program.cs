using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("White", 15);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Black", 15,24);
        shapes.Add(rectangle);

        Circle circle = new Circle("Brown", 55);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color {color} has an area of {area}.");
        }






    }
}