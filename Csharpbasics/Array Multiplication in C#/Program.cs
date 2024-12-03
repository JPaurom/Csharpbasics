using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Multiplication_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] multiplicationArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiplicationArray[i] = num * (i + 1); 
            }
            Console.WriteLine($"Multiplication Table for {num}:");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{multiplicationArray[i]}");
            }
            Console.ReadLine();

        }
    }
}
