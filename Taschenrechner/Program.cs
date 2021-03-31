using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        // METHODE DEFINIEREN (in 7 Schritten)
        // (optional) Modifizierer defienieren
        // Datentyp des Rückgabewertes definieren
        // Methodennamen definieren
        // Rundeklammern an den Methodennamen anfügen
        // Überlegen welche Parameter benötigt werden (optional diese definieren)
        // Geschweifte Klammern einfügen
        // Methode implementieren (Anweisungen in den Methodenrumpf schreiben)

        
        static void Main(string[] args)
        {
            string ersterSummand = HoleSummanden("Gib deinen ersten Summanden ein: ");
            string zweiterSummand = HoleSummanden("Gib deinen zweiten Summanden ein: ");

            // Wandel Text in ganze Zahlen
            double ersterSummandalsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung
            double summe = Addiere(ersterSummandalsZahl, zweiterSummandalsZahl);

            // Ausgabe
            Console.WriteLine($"Das Ergebnis der Summe lautet {summe}");
            WarteaufBenutzerEIngabe();

        }
        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
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
