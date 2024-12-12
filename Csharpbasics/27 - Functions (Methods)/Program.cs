using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___Functions__Methods_
{
    class MathOperations
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        { 
            return a - b; 
        }
        public int Multiplication(int a, int b)
        { 
            return a * b; 
        }
        public double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divid by zero. ");
                return 0.0;
            }
            return (double)a / b;
        }
        public double Power(int baseNum, int exponent)
        {
            return Math.Pow(baseNum, exponent);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine("Welcome to the Math Operations Program!");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {mathOperations.Addition(num1, num2)}");
            Console.WriteLine($"Subtraction: {mathOperations.Subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication: {mathOperations.Multiplication(num1, num2)}");
            Console.WriteLine($"Division: {mathOperations.Division(num1, num2)}");
            Console.WriteLine($"Power: {mathOperations.Power(num1, num2)}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
