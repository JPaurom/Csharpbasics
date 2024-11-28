using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number: ");
            number=int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
}
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
        }
    }
}
