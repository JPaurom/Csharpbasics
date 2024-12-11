using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassGrader
{
    internal class Program
    {
        class Student
        {
            private int Marks;
            private int ObtainedMarks;

            //Constructor
            public Student(int marks, int obtainedMarks)
            {
                //OBS ändra till små bokstäver
                Marks = marks;
                ObtainedMarks = obtainedMarks;

            }
            //Method to calculate the %
            public double CalculatePercentage()
            {
                return (double)ObtainedMarks / Marks * 100;
            }
            // Method to generate a message
            public string GetMessage()
            {
                double percentage = CalculatePercentage();

                if (percentage >= 90)
                {
                    return $"Excellent! {percentage:F2}%";
                }
                else if (percentage >= 75)
                {
                    return $"You passed with! {percentage:F2}%.Keep improving";
                }
                else if (percentage >= 50)
                {
                    return $"You passed with! {percentage:F2}%. Better luck next time";
                }
                else
                {
                    return $"You scored! {percentage:F2}%. Better luck next time";
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the total marks: ");
            int Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks obtained: ");
            int obtainedMarks = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(Marks, obtainedMarks);

            double percentage = student.CalculatePercentage();
            string message = student.GetMessage();

            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}   
