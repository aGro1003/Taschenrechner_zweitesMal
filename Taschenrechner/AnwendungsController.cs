﻿using System;
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
            double ersteZahl = view.HoleZahlvomBenutzer();
            string operation = view.HoleOperatorvomBenutzer();
            double zweiteZahl = view.HoleZahlvomBenutzer();

            // Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
            view.Ergebnisausgabe(operation);
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
