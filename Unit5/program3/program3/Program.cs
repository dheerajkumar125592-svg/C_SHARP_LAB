using System;


abstract class Shape
{
   
    public abstract double Area();
}


class Triangle : Shape
{
    double baseVal, height;

    public Triangle(double b, double h)
    {
        baseVal = b;
        height = h;
    }

    public override double Area()
    {
        return 0.5 * baseVal * height;
    }
}


class Rectangle : Shape
{
    double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double Area()
    {
        return length * width;
    }
}


class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        Shape t = new Triangle(10, 5);
        Shape r = new Rectangle(8, 4);
        Shape c = new Circle(3);

        Console.WriteLine("Area of Triangle: " + t.Area());
        Console.WriteLine("Area of Rectangle: " + r.Area());
        Console.WriteLine("Area of Circle: " + c.Area());
    }
}