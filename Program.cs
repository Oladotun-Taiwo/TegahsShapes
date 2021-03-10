using System;
using System.Collections.Generic;

public abstract class Shape
{
    protected double width;
    protected double height;


    public Shape(double Width)
    {
        width = height = Width;
    }
    public Shape(double Width, double Height)
    {
        width = Width;
        height = Height;
    }
    public abstract double CalculateSurface();
}

public class Rectangle : Shape
{
    public Rectangle(double Width, double Height) : base(Width, Height)
    {


    }
    public override double CalculateSurface()
    {
        return height * width;
    }
}

public class Triangle : Shape
{
    public Triangle(double Width, double Height) : base(Width, Height)
    {


    }
    public override double CalculateSurface()
    {
        return height * width / 2;
    }
}

public class Circle : Shape
{
    public Circle(double Radius) : base(Radius)
        {


    }
    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(width, 2);
    }
}

public class TestShape
{
    static void Main()
    {
        var list = new List<Shape>();

        list.Add(new Rectangle(6, 12));
        list.Add(new Circle(8));
        list.Add(new Triangle(11, 13));

        Console.WriteLine($"Area of Rectangle: {list[0].CalculateSurface()}");
        Console.WriteLine($"Area of Circle: {list[1].CalculateSurface()}");
        Console.WriteLine($"Area of Triangle: {list[2].CalculateSurface()}");




        Console.ReadKey();
    }
}
