using System;


namespace Rechner
{
    class ConsoleView
    {

        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }

        public bool BenutzerWillBeenden { get; private set; }

        /// <summary>
        /// Gib das Resultat in der Console aus Anhand der Operator und das Resultat
        /// </summary>
        /// <param name="operation">Das Operator was dem User eingegeben hat</param>
        public void GibResultatAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Es ist etwas schief gelaufen..");
                    break;
            }
        }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNächsteAktionVomBenutzer();

            if (eingabe == "Fertig")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string HoleNächsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (Fertig zum Beenden): ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Holt die Eingabe (Zahl) vom Benutzer
        /// </summary>
        /// <returns>double</returns>
        private double HoleZahlVomBenutzer()
        {
            string zahl;
            Console.WriteLine("Bitte gib eine Zahl für die Berechnung ein: ");
            zahl = Console.ReadLine();

            return Convert.ToDouble(zahl);
        }

        /// <summary>
        /// Holt die Eingabe (Operator) vom Benutzer
        /// </summary>
        /// <returns>string</returns>
        private string HoleOperatorVomBenutzer()
        {
            Console.WriteLine("Bitte gib die auszuführende Operation ein( +, -, /, * )");
            return Console.ReadLine();
        }
    }
}
