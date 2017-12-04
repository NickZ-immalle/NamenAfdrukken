using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamenAfdrukken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string>() { "A", "B", "C" };

            List<string> andereNamen = new List<string>();

            andereNamen.Add("Appel");
            andereNamen.AddRange(new List<string>() { "Joske", "Jantje" });
            andereNamen.AddRange(new string[] { "Freddy", "Filip" });
            
            PrintNamen(namen);
            Console.WriteLine(new string('-', 20));
            PrintNamen(andereNamen);
        }

        static void PrintNamen(List<string> namen)
        { 
          foreach (var naam in namen)
          {

                Console.WriteLine(naam);
           }
            
        }
    }
}
