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

            if (eingabe.ToUpper() == "FERTIG")
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
            string eingabe;
            double zahl;
            Console.WriteLine("Bitte gib eine Zahl für die Berechnung ein: ");
            eingabe = Console.ReadLine();

            while (!Double.TryParse(eingabe, out zahl))
            {
                Console.WriteLine("Du muss eine gültige GleitkommaZahl eingeben!");
                Console.WriteLine("Neben den Ziffern 0-9 sind lediglich die folgenden Sonderzeichen erlaubt: ,.-");
                Console.WriteLine("Dabei muss das - als erstes Zeichen vor einer Ziffer gesetzt werden");
                Console.WriteLine("Der . fungiert als Trennzeichen an Tausenderstellen");
                Console.WriteLine("Das , ist das Trennzeichen für die Nachkommastellen");
                Console.WriteLine("Alle drei Sonderzeichen sind optional!");
                Console.WriteLine();
                Console.WriteLine("Bitte gib erneut eine Zahl für die Berechnung ein: ");
                eingabe = Console.ReadLine();
            }

            return zahl;
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
