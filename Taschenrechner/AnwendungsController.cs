using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfuehren()
        {
            string ersteZahlalsString = view.HoleZahlvomBenutzer();
            string operation = view.HoleOperatorvomBenutzer();
            string zweiteZahlalsString = view.HoleZahlvomBenutzer();

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            // Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
            view.Ergebnisausgabe(operation);
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
