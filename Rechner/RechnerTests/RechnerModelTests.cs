using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner.Tests
{
    [TestClass()]
    public class RechnerModelTests
    {
        [TestMethod()]
        public void Berechne_DivisionDurchNull_ErgibtUnendlich()
        {
            RechnerModel model = new RechnerModel();

            model.Operation = "/";
            model.ErsteZahl = 10;
            model.ZweiteZahl = 0;

            model.Berechne();

            Assert.AreEqual(Double.PositiveInfinity, model.Resultat);
        }

        [TestMethod()]
        public void Berechne_PunktZahlen_ErgibtZahlOhnePunkt()
        {
            RechnerModel model = new RechnerModel();

            model.Operation = "+";
            model.ErsteZahl = 1.5;
            model.ZweiteZahl = 2;

            model.Berechne();

            // Assert.AreEqual(Double., model.Resultat); Code zum vergleichen was kommt
        }
    }
}