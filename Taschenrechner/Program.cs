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
            string ersteZahlalsString = HoleBenutzerEingabe("Gib die erste Zahl ein: ");
            string zweiteZahlalsString = HoleBenutzerEingabe("Gib die zweite Zahl ein: ");
            string operation = HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein (+ oder -): ");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            // Berechnung
            double resultat = 0;
            if (operation == "+")
            {
                 resultat = Addiere(ersteZahl, zweiteZahl);
                Console.WriteLine($"Das Ergebnis lautet {resultat}");
            }
            else if (operation == "-")
            {
                resultat = Subtrahiere(ersteZahl, zweiteZahl);
                Console.WriteLine($"Das Ergebnis lautet {resultat}");
            }
            else
            {
                Console.WriteLine("Dies war eine ungültige Auswahl");
            }
            

            // Ausgabe
            HoleBenutzerEingabe("Zum Beenden bitte Return drücken");

        }
        static string HoleBenutzerEingabe(string ausgabeText)
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
        
        static double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }
        

    }
}
