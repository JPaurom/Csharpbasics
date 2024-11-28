using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Password_Checker_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password: ");
            string password1 = Console.ReadLine();

            Console.WriteLine("Write your password again: ");
            string password2 = Console.ReadLine();

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Please enter a password: ");
            }
            else if (password1.Length < 6 || password2.Length < 6)
            {
                Console.WriteLine("Password needs to be 6 characters: ");
            }
            else if (password1 == password2)
            {
                Console.WriteLine("Password match");
            }
            else 
            {
                Console.WriteLine("Password do not match ");
            }

            Console.ReadLine();
        }
    }
}
