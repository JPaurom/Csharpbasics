using System;
using System.Collections.Generic;

namespace Dictionary_Case_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjectsAndTeachers = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Show All");
                Console.WriteLine("4. Exit");
                Console.Write("Choose a option between 1 and 4: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the new subject: ");
                        string newSubject = Console.ReadLine();
                        Console.Write("Teacher's name: ");
                        string teacherName = Console.ReadLine();

                        if (!subjectsAndTeachers.ContainsKey(newSubject))
                        {
                            subjectsAndTeachers.Add(newSubject, teacherName);
                            Console.WriteLine("Subject and teacher added.");
                        }
                        else
                        {
                            Console.WriteLine("This subject already exists.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter the name of the subject to remove: ");
                        string subjectToRemove = Console.ReadLine();

                        if (subjectsAndTeachers.ContainsKey(subjectToRemove))
                        {
                            subjectsAndTeachers.Remove(subjectToRemove);
                            Console.WriteLine("Subject removed.");
                        }
                        else
                        {
                            Console.WriteLine("Subject not found.");
                        }
                        break;

                    case "3":
                        if (subjectsAndTeachers.Count > 0)
                        {
                            foreach (var item in subjectsAndTeachers)
                            {
                                Console.WriteLine($"Subject: {item.Key}, Teacher: {item.Value}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No subjects available.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Exiting");
                        return;

                    default:
                        Console.WriteLine("Please choose between 1 and 4.");
                        break;
                }
            }
        }
    }
}
