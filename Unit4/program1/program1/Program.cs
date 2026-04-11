using System;

class Rectangle
{
    // Instance variables
    double length;
    double width;

    // Default Constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized Constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    // Method to calculate area
    public double Area()
    {
        return length * width;
    }

  
    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area());
    }
}

class Program
{
    static void Main()
    {
        
        Rectangle r1 = new Rectangle();
        Console.WriteLine("Rectangle 1 (Default Constructor):");
        r1.Display();

        Console.WriteLine();

        
        Rectangle r2 = new Rectangle(10, 5);
        Console.WriteLine("Rectangle 2 (Parameterized Constructor):");
        r2.Display();
    }
}