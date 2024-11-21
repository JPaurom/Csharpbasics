using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Verification_and_Control_Flow_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string userInput = Console.ReadLine();
            int age = Convert.ToInt32(userInput);
            const int LegalAge = 18;
            if (age >= LegalAge)
            {
                Console.WriteLine("You are a adult. ");
            }
            else
            {
                Console.WriteLine("You are under the legal age. ");
            }
            int Counter = 1;
            while (Counter <= 5)
            {
                Console.WriteLine($"Counter value: {Counter}");
                Counter++;
            }
            switch (Counter)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Thre");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break ;
            }
            var name = "John";
            Console.WriteLine($"Welcome {name}! The loop and the switch statement have completed");
            Console.ReadLine();
        }
    }
}
