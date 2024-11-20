using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times should the loop run?");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat the message ?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            if (loopCounter <= 0)
            {
                Console.WriteLine("Enter a value above 0");
            }
            else
            {
                Console.WriteLine("Enter a start value");
                int startValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a end value");
                int endValue = Convert.ToInt32(Console.ReadLine());
                for (int i = startValue; i <= endValue; i++)
                {
                    Console.WriteLine("The loop has finished");
                }
            }
            Console.ReadLine();
                    
        }
    }
}
