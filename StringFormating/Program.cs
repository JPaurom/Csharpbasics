using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            int age = 23;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine();

            // StringFormating
            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine("Name:{0}\nAge: {1}", name, age);
            Console.WriteLine();

            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);

            //Interpolation
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your name is {name} your age is {age}");

            string test = string.Concat("Your name is ", name, "and your age is ", age);
            Console.WriteLine(test);
            Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", age));

            //Concatenation
            string[] names = new string[] {"Bob ", "Jacob ", "Alex" };
            Console.WriteLine(string.Concat(names));

            //Array
            Console.ReadLine();
        }
    }
}
