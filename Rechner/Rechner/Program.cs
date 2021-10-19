using System;

namespace Rechner
{
    class Program
    {
        /// <summary>
        /// So wird einen Summary erstellt
        /// </summary>
        /// <param name="args"></param>
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
            //bool ersterGanzZahl = true;
            //bool zweiterGanzZahl = true;

            Console.WriteLine("Geben Sie der erster Zahl ein: ");
            ersterZahl = Console.ReadLine();
            Console.WriteLine("Die Zahl was Sie eingegeben haben lautet: {0}", ersterZahl);
            // Console.WriteLine("Der Summando was Sie eingegeben haben lautet: " + ersterZahl); Gleich wie oben. MIT {0}!!!!!!
            Console.WriteLine("Geben Sie der zweiter Zahl ein: ");
            zweiterZahl = Console.ReadLine();
            Console.WriteLine("Die Zahl was Sie eingegeben haben lautet: {0}", zweiterZahl);
            Console.WriteLine("Was möchten Sie mit dieser Zahlen machen? / Addieren (+), Abziehen (-), Multiplizieren (*) oder dividieren (/) /:");
            Operator = Console.ReadLine();

            // Überpruft ob die Zahlen ganz Zahlen sind
            //IdentifyDecimal(ersterZahl, ref ersterGanzZahl);
            //IdentifyDecimal(zweiterZahl, ref zweiterGanzZahl);

            // Wandel Text in Zahlen
            /*try
            {
                if (ersterGanzZahl)
                {
                    ersterSummando = Convert.ToInt32(ersterZahl);
                } else
                {
                    ersterSummando = Convert.ToDouble(ersterZahl);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geben Sie einen Nummer ein!");
            }

            try
            {
                if (zweiterGanzZahl)
                {
                    zweiterSummando = Convert.ToInt32(zweiterZahl);
                }
                else
                {
                    zweiterSummando = Convert.ToDouble(zweiterZahl);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geben Sie einen Nummer ein!");
            }*/

            // Berechnung ausführen
            //Operation(ref ersterSummando, ref zweiterSummando, Operator, result);

            // Wandel Text in Zahlen
            ersterSummando = Convert.ToDouble(ersterZahl);
            zweiterSummando = Convert.ToDouble(zweiterZahl);

            result = Operation(ersterSummando, zweiterSummando, Operator);


            // Ausgabe der Summe in der Console
            Console.WriteLine("Die Berechnung lautet: {0}", result);
            Console.ReadLine();
        }

        /// <summary>
        /// Überpruft ob die Zahlen ganz Zahlen sind
        /// </summary>
        /// <param name="Nummer">Zahl vom User gegeben</param>
        /// <param name="Ganz">Boolischer Wert</param>
        /*static void IdentifyDecimal(string Nummer, ref bool Ganz)
        {
            char[] test = Nummer.ToCharArray();

            for (int i = 0; i <= test.Length; i++)
            {
                if (test[i] == '.')
                {
                    Ganz = false;
                } else
                {
                    Ganz = true;
                }
            }
        }*/

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
    }
}
