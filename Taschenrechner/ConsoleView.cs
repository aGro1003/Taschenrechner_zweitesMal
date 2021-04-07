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
