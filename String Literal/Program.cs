using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pathing
            string speech = "He said \"something\"";
            string path = "C:\\Users\\JavascriptCode\\Desktop\\C# Course\nNew Line";

            Console.WriteLine(path);
            Console.WriteLine(speech);
            // Pathing version 2
            path = @"C:\User\JavaScriptCode\Desktop\C# Course"+ "\nNew Line";
            Console.WriteLine(path);

            string name = @"Hello ""Someone"; 
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
