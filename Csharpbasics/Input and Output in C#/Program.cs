using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_Output_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Greetings " + userName + "!");

        }
    }
}
