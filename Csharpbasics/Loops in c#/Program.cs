using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times should the loop run?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Enter a value above 0");
            }
            else
            {
                for (int i = 1; i <= loopCounter; i++)
                {
                    Console.WriteLine("Current loop counter value:" + i);
                }
                Console.WriteLine("The loop has finished.");
            }

            Console.ReadLine();
        }
    }
}
