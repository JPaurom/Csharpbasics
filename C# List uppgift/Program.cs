using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__List_uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> matlista = new List<string>(); //Skapar en tom lista med namnet matlista
            matlista.Add("Tomat");                      // lägger till "Tomat" i första öppna positionen i listan det vill säga värdet [0]
            matlista.Add("Gurka");
            matlista.Add("Paprika");
            for (int i = 0; i < matlista.Count; i++)    // loopen går igenom matlistan börjande från [0], ända tills alla element i listan har skrivits ut 
                Console.WriteLine(matlista[i]);         //Count är en funktion som ger längden på listan och möjliggör att loopen stannar i slutet av listan
            Console.ReadLine();
        }
    }
}
