using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Reverse_Remove_and_Find_in_C_
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 45, 12, 78, 34, 89, 23 };
            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            Array.Sort(numbers);
            Console.WriteLine("\nSorted Array (Ascending Order):");
            PrintArray(numbers);

            Array.Reverse(numbers);
            Console.WriteLine("\nReversed Array:");
            PrintArray(numbers);

            numbers = numbers.Where(num => num != 78).ToArray();
            Console.WriteLine("\nArray after removing 78:");
            PrintArray(numbers);

            int index = Array.IndexOf(numbers, 34);
            if (index == -1)
            {
                Console.WriteLine("\nNumber 34 does not exist in the array.");
            }
            else
            {
                Console.WriteLine($"\nIndex of number 34: {index}");
            }
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
