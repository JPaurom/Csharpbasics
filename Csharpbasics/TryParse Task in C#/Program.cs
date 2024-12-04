using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Task_in_C_
{
    internal class Program
    {
        static bool TryParse(string input, out int result)
        {
            try
            {
                result = Convert.ToInt32(input); 
                return true; 
            }
            catch (FormatException)
            {
                result = 0;
                return false; 
            }
        }

        static void Main(string[] args)
        {
            string mainInput = "123"; 

            if (TryParse(mainInput, out int mainResult))
            {
                Console.WriteLine($"Conversion succeeded: {mainResult}");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
            Console.ReadLine();
        }
    }
}
