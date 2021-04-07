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
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            string ersteZahlalsString = view.HoleBenutzerEingabe("Gib die erste Zahl ein: ");
            string zweiteZahlalsString = view.HoleBenutzerEingabe("Gib die zweite Zahl ein: ");
            string operation = view.HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein: ");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            // Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
            view.Ergebnisausgabe(operation);
            view.HoleBenutzerEingabe("Zum Beenden bitte Return drücken");

        }

            
    }

}
