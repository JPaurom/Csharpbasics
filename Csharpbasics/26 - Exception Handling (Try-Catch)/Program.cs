using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Exception_Handling__Try_Catch_
{
    class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            try
            {
                return (double)numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed. Returning default value of 0.0");
                return 0.0;
            }
        }
        public int ParseInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric value. Returning default value of -1.");
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Welcome to the Calculator Program!");

            Console.Write("Enter the numerator: ");
            string numeratorInput = Console.ReadLine();
            int numerator = calculator.ParseInput(numeratorInput);

            Console.Write("Enter the denominator: ");
            string denominatorInput = Console.ReadLine();
            int denominator = calculator.ParseInput(denominatorInput);

            if (numerator != -1 && denominator != -1)
            {
                double result = calculator.Divide(numerator, denominator);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Cannot perform divison due to invalid input. ");
            }
            { 
                Console.WriteLine("Program has ended. Press any key to exit. ");
                Console.ReadKey();
            }
        }
    }
}
