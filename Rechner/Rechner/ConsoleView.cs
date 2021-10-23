﻿using System;


namespace Rechner
{
    class ConsoleView
    {

        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        /// <summary>
        /// Gib das Resultat in der Console aus Anhand der Operator und das Resultat
        /// </summary>
        /// <param name="operation">Das Operator was dem User eingegeben hat</param>
        public void GibResultatAus(string operation)
        {
            switch (operation)
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

        /// <summary>
        /// Holt die Eingabe (Zahl) vom Benutzer
        /// </summary>
        /// <returns></returns>
        public string HoleZahlVomBenutzer()
        {
            Console.WriteLine("Bitte gib eine Zahl für die Berechnung ein: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Holt die Eingabe (Operator) vom Benutzer
        /// </summary>
        /// <returns></returns>
        public string HoleOperatorVomBenutzer()
        {
            Console.WriteLine("Bitte gib die auszuführende Operation ein( +, -, /, * )");
            return Console.ReadLine();
        }

        /// <summary>
        /// Wartet bis der Benutzer eine Taste drückt, um das Programm zu beenden
        /// </summary>
        public void WarteAufEndeDurchBenutzer()
        {
            Console.WriteLine("Zum beenden bitte Return drücken!");
            Console.ReadLine();
        }
    }
}