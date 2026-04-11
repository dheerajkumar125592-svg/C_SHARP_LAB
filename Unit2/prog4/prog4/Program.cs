using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double principal, rate, time, amount, compoundInterest;

            Console.Write("Enter Principal Amount: ");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest (%): ");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            time = Convert.ToDouble(Console.ReadLine());

            
            amount = principal * Math.Pow((1 + rate / 100), time);

            compoundInterest = amount - principal;

            Console.WriteLine("Compound Interest = " + compoundInterest);
            Console.WriteLine("Total Amount = " + amount);
        }
    }
}
   

