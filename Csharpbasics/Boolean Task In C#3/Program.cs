using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Task_In_C_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;

            bool isTrue = true;

            bool resultAnd = isTrue && (num1 > num3 && num2 < num4);
            bool resultOr = isTrue || (num1 < num3 || num2 > num4);
            bool resultNot = !isTrue;

            Console.WriteLine(resultAnd);
            Console.WriteLine(resultOr);
            Console.WriteLine(resultNot);

            Console.WriteLine(num1 > num3); 
            Console.WriteLine(num2 < num4); 
            Console.WriteLine(num1 == num4); 
            Console.WriteLine(num2 != num3);

            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) || (num2 > num4);

            Console.WriteLine(expression1); 
            Console.WriteLine(expression2);

            Console.ReadLine();
        }
    }
}
