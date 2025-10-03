using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            // Ask user for a number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if number is even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even.");
            }
            else
            {
                Console.WriteLine(number + " is Odd.");
            }

            // Wait so console doesn’t close immediately
            Console.ReadKey();
        }

    }
}
