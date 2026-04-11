using System;


abstract class Shape
{
    
    public abstract double Area();

  
    public void Display()
    {
        Console.WriteLine("Calculating Area...");
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

class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle(10, 5);

        r.Display(); 
        Console.WriteLine("Area: " + r.Area());
    }
}