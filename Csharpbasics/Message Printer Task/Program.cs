using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Printer_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the message: C# is fun I am going to code C# tomorrow ");
            var message = Console.ReadLine();

            Console.WriteLine("\nOriginal Order:");
            Console.WriteLine(message);

            Console.WriteLine("\nReverse Order:");
            char[] messageArray = message.ToCharArray();    
            Array.Reverse(messageArray);
            Console.WriteLine(new string(messageArray));
            
            Console.WriteLine("\nLetter by Letter: ");
            foreach (char c in message)
            {
                Console.WriteLine(c);   
            }

            Console.WriteLine("\nReversed Letter by Letter: ");
            Array.Reverse(messageArray);
            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
    }
}
