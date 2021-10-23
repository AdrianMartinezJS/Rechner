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
            string ersterZahlAlsString = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenutzer();
            string zweiterZahlAlsString = view.HoleZahlVomBenutzer();

            // Wandel Text in Zahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersterZahlAlsInt = Convert.ToDouble(ersterZahlAlsString);
            double zweiterZahlAlsInt = Convert.ToDouble(zweiterZahlAlsString);

            // Berechnung ausführen
            model.Berechne(ersterZahlAlsInt, zweiterZahlAlsInt, operation);

            // Ausgabe der Summe in der Console
            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();

        }
    }
}
