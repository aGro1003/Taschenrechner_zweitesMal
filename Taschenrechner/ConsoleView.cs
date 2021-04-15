using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }

        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlvomBenutzer();
            model.Operation = HoleOperatorvomBenutzer();
            model.ZweiteZahl = HoleZahlvomBenutzer();
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {

            string eingabe = HoleNaechsteAktionVomBenutzer();

            if (eingabe == "FERTIG")
            {
            
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }

        }

        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (FERTIG zum Beenden): ");
            return Console.ReadLine();
        }

        private double HoleZahlvomBenutzer()
        {
            string zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            zahl = Console.ReadLine();

            return Convert.ToDouble(zahl);
        }

        private string HoleOperatorvomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, *, /): ");
            return Console.ReadLine();
        }


        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }

        public void Ergebnisausgabe()
        {


            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine($"Die Summe lautet: {model.Resultat}");
                    break;

                case "-":
                    Console.WriteLine($"Die Differenz lautet: {model.Resultat}");
                    break;

                case "/":
                    Console.WriteLine($"Der Quotient lautet: {model.Resultat}");
                    break;

                case "*":
                    Console.WriteLine($"Das Produkt lautet: {model.Resultat}");
                    break;
                default:
                    Console.WriteLine("Keine gültige Operation!");
                    break;
            }


        }
    }
}
