using System;

namespace Rechner
{
    public class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public RechnerModel()
        {
            Operation = "unbekannt";
        }

        /// <summary>
        /// Macht die Operation
        /// </summary>
        public void Berechne()
        {
            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    break;
            }
        }

        /// <summary>
        /// Subtrahiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns>double</returns>
        private double Subtrahiere(double Nummer, double Nummer2)
        {
            double sub = Nummer - Nummer2;

            return sub;
        }

        /// <summary>
        /// Addiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns>double</returns>
        private double Addiere(double Nummer, double Nummer2)
        {
            double add = Nummer + Nummer2;

            return add;
        }

        /// <summary>
        /// Multipliziert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns>double</returns>
        private double Multipliziere(double Nummer, double Nummer2)
        {
            double mult = Nummer * Nummer2;

            return mult;
        }

        /// <summary>
        /// Dividiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns>double</returns>
        private double Dividiere(double Nummer, double Nummer2)
        {
            double div = Nummer / Nummer2;

            return div;
        }
    }
}
