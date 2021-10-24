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
            view.HoleEingabenFuerErsteBerechnungVomBenutzer();

            // Berechnung ausführen
            model.Berechne();

            // Ausgabe
            view.GibResultatAus();

            // Hol wieder Zahlen vom User
            view.HoleEingabenFuerFortlaufendeBerechnung();

            // Wiederhole es solange der Benutzer nicht beenden will
            while (!view.BenutzerWillBeenden)
            {
                // Berechnung ausführen
                model.Berechne();

                // Ausgabe
                view.GibResultatAus();

                // Hol wieder Zahlen vom User
                view.HoleEingabenFuerFortlaufendeBerechnung();
            }
            Console.ReadLine();
        }
    }
}
