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
            float ersterSummandalsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandalsZahl = Convert.ToSingle(zweiterSummand);

            // Berechnung
            float summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            // Ausgabe
            Console.Write($"Das Ergebnis der Summe lautet {summe}");
            Console.ReadLine();

            
        }
    }
}
