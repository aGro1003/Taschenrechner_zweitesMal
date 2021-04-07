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
            RechnerModel model = new RechnerModel();
            double ergebnis = model.Berechne(ersteZahl, zweiteZahl, operation);


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

    }
}
