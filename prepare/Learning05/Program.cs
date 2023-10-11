using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
                List<Shape> Shapes = new();

        Square s1 = new Square("Red", 3);
        Shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 3, 4);
        Shapes.Add(r1);

        Circle c1 = new Circle("Yellow", 2);
        Shapes.Add(c1);


        foreach(Shape s in Shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}