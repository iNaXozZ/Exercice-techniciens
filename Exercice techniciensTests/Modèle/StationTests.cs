using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice_techniciens.Modèle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle.Tests
{
    [TestClass()]
    public class StationTests
    {
        [TestMethod()]
        public void GetIDTest()
        {
            //Jeu d'essai 
            Station S1 = new Station(1, "Numero1");
            //Méthode
            int resultat = S1.GetID();
            Assert.AreEqual(1, resultat);
        }

        [TestMethod()]
        public void GetLibelleEmplacementTest()
        {
            //Jeu d'essai 
            Station S1 = new Station(1, "Numero1");
            //Méthode
            string resultat = S1.GetLibelleEmplacement();
            Assert.AreEqual("Numero1", resultat);
            
        }
    }
}