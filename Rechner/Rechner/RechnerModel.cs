using System;

namespace Rechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }

        /// <summary>
        /// Macht die Operation
        /// </summary>
        /// <param name="Nummer">Erster zahl vom User eingegeben</param>
        /// <param name="Nummer2">Zweiter zahl vom User eingegeben</param>
        /// <param name="Operator">Operator Symbol ("+-*/")</param>
        public void Berechne(double Nummer, double Nummer2, string operation)
        {
            this.Operation = operation;

            switch (operation)
            {
                case "+":
                    Resultat = Addiere(Nummer, Nummer2);
                    break;

                case "-":
                    Resultat = Subtrahiere(Nummer, Nummer2);
                    break;

                case "*":
                    Resultat = Multipliziere(Nummer, Nummer2);
                    break;

                case "/":
                    Resultat = Dividiere(Nummer, Nummer2);
                    break;
            }
        }

        /// <summary>
        /// Subtrahiert 2 vorgegebene Zahlen
        /// </summary>
        /// <param name="Nummer">Erster Zahl vom User</param>
        /// <param name="Nummer2">Zweiter Zahl vom User</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
        private double Dividiere(double Nummer, double Nummer2)
        {
            double div = Nummer / Nummer2;

            return div;
        }
    }
}
