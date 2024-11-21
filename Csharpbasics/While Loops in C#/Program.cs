using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 1;
            while (Counter <= 5)
            {
                Console.WriteLine($"Counter value: {Counter}");
                Counter++;
            }
            Console.WriteLine("The loop has finished.");
            Console.ReadLine();
        }
    }
}
