using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;

            //int i = 0;

            //while (i < 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}
            
            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberAInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            Console.WriteLine();
            //While Example
            //while will check the condition first and then execute the statement
            /*
            while(answer != actualAnswer)
            {
                Console.Write("Enter your answer");
                string answerInput= Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong");
                }
            }
            */
            // Do While Example
            //Do while will execute the statement at least once and then check
            do
            {
                Console.Write("Enter your answer");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);
                if(answer != actualAnswer) 
                {
                    Console.WriteLine("Close but it was wrong");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");
            Console.ReadLine();
        }
    }
}
