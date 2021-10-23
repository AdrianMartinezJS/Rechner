﻿using System;

namespace Rechner
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

        public void Ausführen()
        {
            // Hol Zahlen vom User
            double ersteZahl = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenutzer();
            double zweiteZahl = view.HoleZahlVomBenutzer();

            // Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe
            view.GibResultatAus();
            view.WarteAufEndeDurchBenutzer();

        }
    }
}
