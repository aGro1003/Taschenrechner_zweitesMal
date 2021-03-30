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
            double ersterSummandalsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung
            double summe = Addiere(ersterSummandalsZahl, zweiterSummandalsZahl);

            // Ausgabe
            Console.WriteLine($"Das Ergebnis der Summe lautet {summe}");
            WarteaufBenutzerEIngabe();

        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }
        
        

        static void WarteaufBenutzerEIngabe()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            Console.ReadLine();
        }
    }
}
