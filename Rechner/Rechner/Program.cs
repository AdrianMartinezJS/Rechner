using System;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hol Zahlen vom User
            string ersterZahlAlsString = HolBenutzerEingabe("Geben Sie die erste Zahl ein: ");
            string operation = HolBenutzerEingabe("Welche Berechnung möchten Sie machen? Addieren (+), Subtrahieren (-), Multiplizieren (*) oder dividieren (/): ");
            string zweiterZahlAlsString = HolBenutzerEingabe("Geben Sie die zweite Zahl ein: ");
            
            // Wandel Text in Zahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersterZahlAlsInt = Convert.ToDouble(ersterZahlAlsString);
            double zweiterZahlAlsInt = Convert.ToDouble(zweiterZahlAlsString);

            // Berechnung ausführen
            double result = Berechnung(ersterZahlAlsInt, zweiterZahlAlsInt, operation);

            // Ausgabe der Summe in der Console
            GibResultatAus(result, operation);
            HolBenutzerEingabe("Drucken Sie eine beliebige Taste um das Programm zu beenden. ");
        }

        /// <summary>
        /// Gib das Resultat in der Console aus Anhand der Operator und das Resultat
        /// </summary>
        /// <param name="resultat">Das Resultat aus der Berechnung Funktion</param>
        /// <param name="operation">Das Operator was dem User eingegeben hat</param>
        static void GibResultatAus(double resultat, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Wert des Quotienten ist: {0}", resultat);
                    break;

                default:
                    Console.WriteLine("Es ist etwas schief gelaufen..");
                    break;
            }
        }

        ///// <summary>
        ///// Macht die Operation
        ///// </summary>
        ///// <param name="Nummer">Erster zahl vom User eingegeben</param>
        ///// <param name="Nummer2">Zweiter zahl vom User eingegeben</param>
        ///// <param name="Operator">Operator Symbol ("+-*/")</param>
        static double Berechnung(double Nummer, double Nummer2, string operation)
        {
            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(Nummer, Nummer2);
                    break;

                case "-":
                    resultat = Subtrahiere(Nummer, Nummer2);
                    break;

                case "*":
                    resultat = Multipliziere(Nummer, Nummer2);
                    break;

                case "/":
                    resultat = Dividiere(Nummer, Nummer2);
                    break;
            }
            return resultat;
        }

        /// <summary>
        /// Subtrahiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns></returns>
        static double Subtrahiere(double Nummer, double Nummer2)
        {
            double sub = Nummer - Nummer2;

            return sub;
        }

        /// <summary>
        /// Addiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns></returns>
        static double Addiere(double Nummer, double Nummer2)
        {
            double add = Nummer + Nummer2;

            return add;
        }

        /// <summary>
        /// Multipliziert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns></returns>
        static double Multipliziere(double Nummer, double Nummer2)
        {
            double mult = Nummer * Nummer2;

            return mult;
        }

        /// <summary>
        /// Dividiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns></returns>
        static double Dividiere(double Nummer, double Nummer2)
        {
            double div = Nummer / Nummer2;

            return div;
        }

        /// <summary>
        /// Hol sich die Zahlen vom User
        /// </summary>
        /// <param name="ausgabeText">Was wird in der Console für den User geschrieben</param>
        /// <returns></returns>
        static string HolBenutzerEingabe( string ausgabeText, double resultat = 0)
        {
            Console.WriteLine(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }
    }
}
