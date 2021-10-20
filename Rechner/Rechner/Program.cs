using System;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Title: Taschenrechner
             * Story: Als Benutzer möchte ich zwei Zahlen Mit möglicherweise Nachkommazahlen eingeben, um deren Summe berechnen zu lassen
             * Akzeptanzkriterien: Zahlen zwischen 0 und 10 rechnen können
             **/

            // Definition Variablen
            string ersterZahl, zweiterZahl, Operator;
            double ersterSummando, zweiterSummando, result;

            Console.WriteLine("Geben Sie der erster Zahl ein: ");
            ersterZahl = Console.ReadLine();

            Console.WriteLine("Geben Sie der zweiter Zahl ein: ");
            zweiterZahl = Console.ReadLine();

            Console.WriteLine("Was möchten Sie mit dieser Zahlen machen? / Addieren (+), Abziehen (-), Multiplizieren (*) oder dividieren (/) /:");
            Operator = Console.ReadLine();

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

        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("Drucken Sie eine beliebige Taste um das Programm zu beenden.");
            Console.ReadLine();
        }
    }
}
