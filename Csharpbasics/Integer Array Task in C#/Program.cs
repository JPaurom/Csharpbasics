using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Array_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            int sum = SumOfNumbers(numbers);

            Console.WriteLine("Array Length:" + numbers.Length);

            if (sum > -1)
            {
                Console.WriteLine($"The total is:{sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            if (sum < 0)
            {
                Console.WriteLine("Canot add up an empty array");
            }
        }

        static int SumOfNumbers(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}
