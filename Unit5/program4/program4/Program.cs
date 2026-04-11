using System;

class Demo
{
   
    static int count;

 
    static Demo()
    {
        count = 100;
        Console.WriteLine("Static Constructor Called");
    }

 
    public Demo()
    {
        Console.WriteLine("Instance Constructor Called");
    }


    public void Show()
    {
        Console.WriteLine("Count = " + count);
    }
}

class Program
{
    static void Main()
    {
      
        Demo d1 = new Demo();
        d1.Show();

        Console.WriteLine();

        Demo d2 = new Demo();
        d2.Show();
    }
}