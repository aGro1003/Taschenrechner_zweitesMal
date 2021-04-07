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

        public RechnerModel()
        {
            Resultat = 0;
        }
        public void Berechne(double nummereins, double nummerzwei, string opr)
        {
            switch (opr)
            {
                case "+":
                    Resultat = Addiere(nummereins, nummerzwei);
                    break;

                case "-":
                    Resultat = Subtrahiere(nummereins, nummerzwei);
                    break;

                case "/":
                    Resultat = Dividiere(nummereins, nummerzwei);
                    break;

                case "*":
                    Resultat = Multipliziere(nummereins, nummerzwei);
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
