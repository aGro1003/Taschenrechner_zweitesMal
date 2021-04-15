using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        // Konstruktor; initialisiert Werte (in diesem Fall initialisieren wir das Resultat zum Anfang immer mit dem Wert 0)
        public RechnerModel()
        {
            
            Operation = "unbekannt";
        }
        public void Berechne()
        {
            
            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;

            }
        }

        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        private double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }

        private double Multipliziere(double ersterFaktor, double zweiterFaktor)
        {
            //verkürzte Form der Berechnung
            return ersterFaktor * zweiterFaktor;
        }

        private double Dividiere(double dividend, double divisor)
        {
            return dividend / divisor;
        }
    }
}
