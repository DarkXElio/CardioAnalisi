using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MAX1()
        {
            string errore = " ";
            int eta = 20;
            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMAX(eta, ref errore);
            double aspetativa_max = 140;
            string aspetativa_errore = "Non esiste l'eta minire di 0 ";

            if (errore == " ")
            {
                Assert.AreEqual(aspetativa_max, return_max);
            }
            else
            {
                Assert.AreEqual(aspetativa_errore, errore);
            }

        }
        [TestMethod]

        public void MAX2()
        {
            string errore = " ";
            int eta = -5;
            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMAX(eta, ref errore);
            double aspetativa_max = 0;
            Assert.AreEqual(aspetativa_max, return_max);
            string aspetativa_errore = "Non esiste l'eta minire di 0 ";

            if (errore == " ")
            {
                Assert.AreEqual(aspetativa_max, return_max);
            }
            else
            {
                Assert.AreEqual(aspetativa_errore, errore);
            }

        }
        [TestMethod]
        public void MAX3()
        {
            string errore = " ";
            int eta = -1;
            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMAX(eta, ref errore);
            double aspetativa_max = 0;
            Assert.AreEqual(aspetativa_max, return_max);
            string aspetativa_errore = "Non esiste l'eta minire di 0 ";

            if (errore == " ")
            {
                Assert.AreEqual(aspetativa_max, return_max);
            }
            else
            {
                Assert.AreEqual(aspetativa_errore, errore);
            }

        }




        [TestMethod]
        public void Min1()
        {
            int eta = 20;
            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMIN(eta);
            double aspetativa_max = 180;
            Assert.AreEqual(aspetativa_max, return_max);
        }


    }
}
