using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }
        }
    }
}
    

