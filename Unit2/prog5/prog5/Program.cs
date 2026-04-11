using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.Write("Enter radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;

            Console.WriteLine("Area of the circle = " + area);
        }
    }
}
    

