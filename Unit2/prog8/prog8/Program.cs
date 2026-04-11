using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            long factorial = 1;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial = " + factorial);
        }
    }
}
    

