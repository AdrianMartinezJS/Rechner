using System;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {

            // Definition Variablen
            double ersterSummando, zweiterSummando, result;

            // Hol Zahlen vom User
            string ersterZahl = HolZahl("Geben Sie der erster Zahl ein: ");
            string zweiterZahl = HolZahl("Geben Sie der zweiter Zahl ein: ");
            string Operator = HolZahl("Was möchten Sie mit dieser Zahlen machen? Addieren (+), Subtrahieren (-), Multiplizieren (*) oder dividieren (/): ");

            // Wandel Text in Zahlen
            ersterSummando = Convert.ToDouble(ersterZahl);
            zweiterSummando = Convert.ToDouble(zweiterZahl);

            // Berechnung ausführen
            result = Operation(ersterSummando, zweiterSummando, Operator);

            // Ausgabe der Summe in der Console
            Console.WriteLine("Die Berechnung lautet: {0}", result);
            WarteAufBenutzerEingabe();
        }

        /// <summary>
        /// Macht die Operation
        /// </summary>
        /// <param name="Nummer">Erster zahl vom User eingegeben</param>
        /// <param name="Nummer2">Zweiter zahl vom User eingegeben</param>
        /// <param name="Operator">Operator Symbol ("+-*/")</param>
        static double Operation(double Nummer, double Nummer2, string Operator)
        {
            switch (Operator)
            {
                case "+":
                    return Nummer + Nummer2;

                case "-":
                    return Nummer - Nummer2;

                case "*":
                    return Nummer * Nummer2;

                case "/":
                    return Nummer / Nummer2;

                default:
                    return 0;
            }
        }

        /// <summary>
        /// Sagt den User was er tun muss um den Programm zu beenden
        /// Beendet das Program
        /// </summary>
        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("Drucken Sie eine beliebige Taste um das Programm zu beenden.");
            Console.ReadLine();
        }

        /// <summary>
        /// Hol sich die Zahlen vom User
        /// </summary>
        /// <param name="ausgabeText">Was wird in der Console für den User geschrieben</param>
        /// <returns></returns>
        static string HolZahl( string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }
    }
}
