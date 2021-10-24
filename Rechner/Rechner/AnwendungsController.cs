using System;

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
            view.HoleEingabenVomBenutzer();

            // Berechnung ausführen
            model.Berechne();

            // Ausgabe
            view.GibResultatAus();
            view.WarteAufEndeDurchBenutzer();

        }
    }
}
