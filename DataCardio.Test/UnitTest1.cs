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



        //      sesso  FCArdiaca , Pesso , ETA , Teampo , Atessa
        [DataRow("F" , "65" ,"56" ,"23" ,"60", "47,4923518164436")]
        [DataRow("M", "65", "56", "23", "60", "24,3025812619504")]
        [DataRow("A", "65", "56", "23", "60", "24,3025812619504")]
        [DataRow("F", "65", "a", "50", "60", "24,3025812619504")]
        public void calcoriebruciato(string sesso, string fcardiaca , string pesso , string eta , string tempo,string atessa)
        {

            double return_res = 0;
            string errore_msg = " ";
            string msg = " ";
            try { 
            return_res = EquazioniLibrary.DataCardio.CalorieBruciato(sesso , Convert.ToDouble(fcardiaca), Convert.ToDouble(pesso), Convert.ToDouble(eta), Convert.ToDouble(tempo),ref msg);
            errore_msg = "Errore il sesso non non e correto ";
                if (msg == " ")
                {
                    Assert.AreEqual(Convert.ToString(return_res), atessa);
                }
                else
                {
                    Assert.AreEqual(errore_msg, msg);
                }

            }
            catch
            {
                errore_msg = "Errore devi inserrire un numero e no un lattera";
                msg = "Errore devi inserrire un numero e no un lattera";
                Assert.AreEqual(errore_msg, msg);
                
               

            }
            

           



        }

    }
}
