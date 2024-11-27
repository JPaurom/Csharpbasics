using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            int num3 = 4;
            int num4 = 6;
            int num5 = 20;
            int num6 = 7;

            int sum = num1 + num2;
            int product = num3 * num4;
            int remainder = num5 % num6;

            Console.WriteLine("sum of num1 and num2 : " + sum);
            Console.WriteLine("product of num3 and num4: " + product);
            Console.WriteLine("remainder of num5 divided by num6: " + remainder);

            Console.WriteLine("Postfix Increment on num6: " + num6++); 
            Console.WriteLine("Prefix Increment on num6: " + ++num6); 
            Console.WriteLine("Postfix Decrement on num6: " + num6--); 
            Console.WriteLine("Prefix Decrement on num6: " + --num6);

            num5 += 5;
            Console.WriteLine("After num5 += 5: " + num5); 

            num5 -= 3;
            Console.WriteLine("After num5 -= 3: " + num5); 

            num5 *= 2;
            Console.WriteLine("After num5 *= 2: " + num5); 

            num5 /= 4;
            Console.WriteLine("After num5 /= 4: " + num5); 

            num5 %= 3;
            Console.WriteLine("After num5 %= 3: " + num5); 

            Console.ReadLine();
        }
    }
}
