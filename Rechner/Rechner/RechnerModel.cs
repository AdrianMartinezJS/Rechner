using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class RechnerModel
    {
        /// <summary>
        /// Macht die Operation
        /// </summary>
        /// <param name="Nummer">Erster zahl vom User eingegeben</param>
        /// <param name="Nummer2">Zweiter zahl vom User eingegeben</param>
        /// <param name="Operator">Operator Symbol ("+-*/")</param>
        public double Berechne(double Nummer, double Nummer2, string operation)
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
