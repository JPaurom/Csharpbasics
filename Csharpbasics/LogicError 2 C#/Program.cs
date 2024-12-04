using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicError_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            int age;
            if (int.TryParse(input, out age))
            {

                if (age > 50) 
                {
                    Console.WriteLine("Over 50");
                }
                else if (age > 30)
                {
                    Console.WriteLine("Over 30");
                }
                else if (age > 18)
                {
                    Console.WriteLine("Over 18");
                }
                else
                {
                    Console.WriteLine("18 or younger");
                }
            }
            Console.ReadLine();
        }
    }
}
