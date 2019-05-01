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


            string errore = " ";
            string eta = "a";




            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMIN(eta, ref errore);
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
        public void Min2()
        {


            string errore = " ";
            string eta = "-9";




            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMIN(eta, ref errore);
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
        public void Min3()
        {


            string errore = " ";
            string eta = "20";




            double return_max = EquazioniLibrary.DataCardio.FrequenzaBattitoCardiacoMIN(eta, ref errore);
            double aspetativa_max = 180;
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
        public void cardiaca_a_riposo1()
        {
            int cardiaca_a_riposo = 80;
            string return_msg = EquazioniLibrary.DataCardio.cardiacariposo(cardiaca_a_riposo);
            string aspetativa_msg = " Normale ";

            Assert.AreEqual(aspetativa_msg, return_msg);



        }

        [TestMethod]
        public void cardiaca_a_riposo2()
        {
            int cardiaca_a_riposo = 50;
            string return_msg = EquazioniLibrary.DataCardio.cardiacariposo(cardiaca_a_riposo);
            string aspetativa_msg = " Badicardia ";

            Assert.AreEqual(aspetativa_msg, return_msg);



        }

        [TestMethod]
        public void cardiaca_a_ripos3()
        {
            int cardiaca_a_riposo = 110;
            string return_msg = EquazioniLibrary.DataCardio.cardiacariposo(cardiaca_a_riposo);
            string aspetativa_msg = " Tachicardia ";

            Assert.AreEqual(aspetativa_msg, return_msg);



        }

        [TestMethod]



        //      sesso  fcardiaca , peso , eta , teampo , atessa
        [DataRow("F" , "65" ,"56" ,"23" ,"60", "47,4923518164436")]
        [DataRow("M", "65", "56", "23", "60", "24,3025812619504")]
        [DataRow("A", "65", "56", "23", "60", "Sesso non e valido non è valido")]
        [DataRow("F", "65", "a", "50", "60", "Errore")]
        [DataRow("F", "65", "-15", "50", "60", "Il peso da lei inserito è negativo")]
        [DataRow("F", "65", "56", "-59", "30", "L'età da lei inserita è negativa")]
        [DataRow("M", "65", "56", "50", "-80", "Il Tempo da lei inserito è negativo")]
        [DataRow("F", "1", "1", "1", "1", "Resultato resulta negativo, i dati inseriti non sono corretti")]
        [DataRow("M", "1", "1", "1", "1", "Resultato resulta negativo, i dati inseriti non sono corretti")]
        public void calcoriebruciato(string sesso, string fcardiaca , string peso , string eta , string tempo,string attesa)
        {
            string CaloriaBruciate_Calcolato = EquazioniLibrary.DataCardio.CaloriaBruciate(sesso, fcardiaca, peso, eta, tempo);
            Assert.AreEqual(attesa, CaloriaBruciate_Calcolato);
        }

    }
}
