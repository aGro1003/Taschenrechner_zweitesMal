using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib deinen ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Gib deinen zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in ganze Zahlen
            int ersterSummandalsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandalsZahl = Convert.ToInt32(zweiterSummand);

            // Berechnung
            int summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            // Ausgabe
            Console.Write($"Das Ergebnis der Summe lautet {summe}");
            Console.ReadLine();

           
        }
    }
}
