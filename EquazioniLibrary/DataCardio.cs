using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class DataCardio
    {
        public static double FrequenzaBattitoCardiacoMAX(string eta, ref string errore)
        {
            double x = 0, max = 0;


            try
            {
                x = 220 - Convert.ToInt32(eta);
                max = x * 0.7;
            }
            catch
            {
                errore = "Non hai inserito un numero";
            }

            if (x > 220)
            {
                max = 0;
                errore = "Non esiste l'eta minire di 0 ";
            }
            return max;
        }



        public static double FrequenzaBattitoCardiacoMIN(string eta, ref string errore)
        {
            double x = 0, min = 0;


            try
            {
                x = 220 - Convert.ToInt32(eta);
                min = x * 0.9;
            }
            catch
            {
                errore = "Non hai inserito un numero";
            }

            if (x > 220)
            {
                min = 0;
                errore = "Non esiste l'eta minire di 0 ";
            }
            return min;
        }

        public static string cardiacariposo(int cardiacanumero)
        {
            string msg = " ";
            if (cardiacanumero < 60) msg = " Badicardia ";

            if (59 < cardiacanumero && cardiacanumero < 101) msg = " Normale ";

            if (cardiacanumero > 100) msg = " Tachicardia ";

            return msg;

        }


        public static double CalorieBruciato(string sesso ,double FC, double P , double E , double T ,ref string msg)
        {
            double Calorie_Bruciate = 0;


            if (FC<60 || FC >100)
            {

            }
            else if (P<0)
            {

            }
            else if (E<0)
            {

            }


            if (sesso=="F"||sesso == "f")
            {
                Calorie_Bruciate = ((E * 0.074) - (P * 0.126) + (FC * 0.4472) - 20.4022) * T / 4.184;
            }
            else if(sesso == "M"||sesso == "m") {
            Calorie_Bruciate = ((E * 0.2017) + (P * 0.199) + (FC * 0.6309) - 55.0969) * T / 4.184;
            }
            else if (sesso != "M" && sesso != "m" && sesso != "F" && sesso != "f")  { msg = "Errore il sesso non non e correto "; }






            return Calorie_Bruciate;
        }






    }
}
