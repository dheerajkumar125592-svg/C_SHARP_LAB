using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double principal, rate, time, simpleInterest;

            Console.Write("Enter Principal Amount: ");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest (%): ");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            time = Convert.ToDouble(Console.ReadLine());

            simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("Simple Interest = " + simpleInterest);
        }
    }
}
   

