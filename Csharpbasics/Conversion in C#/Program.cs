using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "123";
            int number = Convert.ToInt32(numberAsString);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
