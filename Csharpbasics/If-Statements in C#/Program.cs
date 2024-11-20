using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down your age to check if you are eligible to vote");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else 
            {
                Console.WriteLine("You are not eligible to vote. ");
            }
            Console.ReadLine();
              
        }
    }
}
