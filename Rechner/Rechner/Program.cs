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
            RechnerModel model = new RechnerModel();
            model.Berechne(ersterZahlAlsInt, zweiterZahlAlsInt, operation);

            // Ausgabe der Summe in der Console
            GibResultatAus(model.Resultat, operation);
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

        /// <summary>
        /// Hol sich die Zahlen vom User
        /// </summary>
        /// <param name="ausgabeText">Was wird in der Console für den User geschrieben</param>
        /// <returns></returns>
        static string HolBenutzerEingabe( string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            string zahl = Console.ReadLine();

            return zahl;
        }
    }
}
