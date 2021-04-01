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
            string operation = HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein: ");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            // Berechnung
            double ergebnis;
            ergebnis = Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
            Ergebnisausgabe(ergebnis, operation);
            HoleBenutzerEingabe("Zum Beenden bitte Return drücken");

        }
        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }

        static void Ergebnisausgabe(double ergebnis, string opr)
        {
            

            switch (opr)
            {
                case "+":
                    Console.WriteLine($"Die Summe lautet: {ergebnis}");
                    break;

                case "-":
                    Console.WriteLine($"Die Differenz lautet: {ergebnis}");
                    break;

                case "/":
                    Console.WriteLine($"Der Quotient lautet: {ergebnis}");
                    break;

                case "*":
                    Console.WriteLine($"Das Produkt lautet: {ergebnis}");
                    break;
                default:
                    Console.WriteLine("Keine gültige Operation!");
                    break;
            }
            
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

        static double Multipliziere(double ersterFaktor, double zweiterFaktor)
        {
            //verkürzte Form der Berechnung
            return ersterFaktor * zweiterFaktor;
        }

        static double Dividiere(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        static double Berechne(double nummereins, double nummerzwei, string opr)
        {
            double resultat = 0;
            switch (opr)
            {
                case "+":
                    resultat = Addiere(nummereins, nummerzwei);
                    break;

                case "-":
                    resultat = Subtrahiere(nummereins, nummerzwei);
                    break;

                case "/":
                    resultat = Dividiere(nummereins, nummerzwei);
                    break;

                case "*":
                    resultat = Multipliziere(nummereins, nummerzwei);
                    break;

            }
            return resultat;
        }


    }
}
