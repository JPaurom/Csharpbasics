using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculation_Task_in_C_
{
    internal class Program
    {
        static double CalculateArea(double width, double height)
        {
            return (width * height) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write the width: ");
                double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write the height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                double area = CalculateArea(width, height); 
            Console.WriteLine($"The triangles area is {area}");

            Console.ReadLine();
        }
    }
}
