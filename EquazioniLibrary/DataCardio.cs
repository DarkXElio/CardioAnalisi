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
            double x=0, max=0;
            if ( errore !=" ")
            {

            }
            else
            {

                try
                {
                    x = 220 - Convert.ToInt32(eta);
                    max = x * 0.7;
                }
                catch
                {
                    errore = "Non hai inserito un numero";
                }
            }
            if (x > 220)
            {
                max = 0;
                errore = "Non esiste l'eta minire di 0 ";
            }
            return max;
        }



        public static double FrequenzaBattitoCardiacoMIN(int eta)
        {
            double x = 220 - eta;
            double min = x * 0.9;
            return min;
        }


    }
}
