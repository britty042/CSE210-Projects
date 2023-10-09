using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapelist = new List<Shape>();

        Square square1 = new Square("Red", 4);
        shapelist.Add(square1);

        Rectangle rectangle1 = new Rectangle("Blue", 4, 5);
        shapelist.Add(rectangle1);

        Circle circle1 = new Circle("Orange", 3);
        shapelist.Add(circle1);

        foreach (Shape shape in shapelist)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());

        }
    }    
}