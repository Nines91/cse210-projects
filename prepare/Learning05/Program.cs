using System;


class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        //Console.WriteLine("Hello Learning05 World!");
        Square shape1 = new Square("Yellow", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Green", 3, 6);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Blue", 3.5);
        shapes.Add(shape3);

        foreach (Shape shape in shapes) 
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

        
    }
}