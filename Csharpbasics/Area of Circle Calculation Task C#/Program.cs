using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle_Calculation_Task_C_
{
    internal class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(1.5);

            double area = myCircle.CalculateArea();
            Console.WriteLine($"Area of the circle is: {area}");

            Console.ReadLine();
        }
    }
}
