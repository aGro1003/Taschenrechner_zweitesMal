using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Berechne(double nummereins, double nummerzwei, string opr)
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
