using System;
using System.Collections.Generic;

interface IDrawable
{
    void draw();
}

abstract class Shape : IDrawable
{
    public abstract double calculate_area();
    public abstract void draw();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double calculate_area()
    {
        return Math.PI * Radius * Radius;
    }

    public override void draw()
    {
        Console.WriteLine("Малюємо коло");
    }
}

class Square : Shape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public override double calculate_area()
    {
        return Side * Side;
    }

    public override void draw()
    {
        Console.WriteLine("Малюємо квадрат");
    }
}

class Triangle : Shape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override double calculate_area()
    {
        return 0.5 * BaseLength * Height;
    }

    public override void draw()
    {
        Console.WriteLine("Малюємо трикутник");
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Square(4),
            new Triangle(6, 3)
        };

        foreach (Shape shape in shapes)
        {
            shape.draw();
            Console.WriteLine($"Площа: {shape.calculate_area():F2}");
            Console.WriteLine();
        }
    }
}
