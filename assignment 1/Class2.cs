using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    internal class Class2
    {
        static void Main(string[]args)
        {
            double num1, num2, result = 0;
            char operation;

            Console.WriteLine("=== Simple Calculator ===");
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("+ for Addition");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("* for Multiplication");
            Console.WriteLine("/ for Division");
            Console.Write("Enter your choice: ");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Result = {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Result = {result}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation! Please choose +, -, * or /.");
                    break;
            }
          
        }
    }
}


           
        