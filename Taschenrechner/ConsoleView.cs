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
        }

        public string HoleZahlvomBenutzer()
        {
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            return Console.ReadLine();
        }

        public string HoleOperatorvomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, *, /): ");
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            Console.ReadLine();
        }

        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }

        public void Ergebnisausgabe(string opr)
        {


            switch (opr)
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
