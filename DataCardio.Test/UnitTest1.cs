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
        string eta = "20";




        double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMAX(eta, ref errore);
        double aspetativa_max = 140;
        string aspetativa_errore1 = "Non esiste l'eta minire di 0 ";
        string aspetativa_errore2 = "Non hai inserito un numero";

            if (errore == " ")
            {
                Assert.AreEqual(aspetativa_max, return_max);
            }
            else
            {
                try
                {
                    Convert.ToInt32(eta);
                    Assert.AreEqual(aspetativa_errore1, errore);
                }
                catch
                {
                    Assert.AreEqual(aspetativa_errore2, errore);
                }
               
            }

        }
        [TestMethod]

        public void MAX2()
        {

            string errore = " ";
            string eta = "a";




            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMAX(eta, ref errore);
            double aspetativa_max = 140;
            string aspetativa_errore1 = "Non esiste l'eta minire di 0 ";
            string aspetativa_errore2 = "Non hai inserito un numero";

            if (errore == " ")
            {
                Assert.AreEqual(aspetativa_max, return_max);
            }
            else
            {
                try
                {
                    Convert.ToInt32(eta);
                    Assert.AreEqual(aspetativa_errore1, errore);
                }
                catch
                {
                    Assert.AreEqual(aspetativa_errore2, errore);
                }
               
            }

        }
        [TestMethod]
        public void MAX3()
        {
            string errore = " ";
            string eta = "a";




            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMAX(eta, ref errore);
            double aspetativa_max = 140;
            string aspetativa_errore1 = "Non esiste l'eta minire di 0 ";
            string aspetativa_errore2 = "Non hai inserito un numero";

            if (errore == " ")
            {
                Assert.AreEqual(aspetativa_max, return_max);
            }
            else
            {
                try
                {
                    Convert.ToInt32(eta);
                    Assert.AreEqual(aspetativa_errore1, errore);
                }
                catch
                {
                    Assert.AreEqual(aspetativa_errore2, errore);
                }

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
