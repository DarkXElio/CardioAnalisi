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


        public static string CaloriaBruciate(string sesso, string fcardiaca, string peso, string eta, string tempo)
            {
               
                string risp = "";

                try
                {
                   
                    double Fcardiaca = Convert.ToDouble(fcardiaca);
                    double Peso = Convert.ToDouble(peso);
                    double Eta = Convert.ToDouble(eta);
                    double Tempo = Convert.ToDouble(tempo);

                    
                    if (Fcardiaca < 0 || Peso < 0 || Eta < 0 || Tempo < 0)
                    {
                        if (Fcardiaca < 0)
                        {
                            risp = "La frequenza cardiaca da lei inserita è negativa";
                        }

                        if (Peso < 0)
                        {
                            risp = "Il peso da lei inserito è negativo";
                        }

                        if (Eta < 0)
                        {
                            risp = "L'età da lei inserita è negativa";
                        }

                        if (Tempo < 0)
                        {
                            risp = "Il Tempo da lei inserito è negativo";
                        }
                    }
                    else
                    {
                        
                        double Calorie_Bruciate = 0;
                    
                        if (sesso == "M")
                        {
                            Calorie_Bruciate = ((Eta * 0.2017) + (Peso * 0.199) + (Fcardiaca * 0.6309) - 55.0969) * Tempo / 4.184;
                            
                            if (Calorie_Bruciate < 0)
                            {
                                risp = "Resultato resulta negativo, i dati inseriti non sono corretti";
                            }
                            else
                            {
                                risp = Convert.ToString(Calorie_Bruciate);
                            }
                        }
                        else if (sesso == "F")
                        {
                            Calorie_Bruciate = ((Eta * 0.074) - (Peso* 0.126) + (Fcardiaca * 0.4472) - 20.4022) * Tempo / 4.184;
                           
                            if (Calorie_Bruciate < 0)
                            {
                                risp = "Resultato resulta negativo, i dati inseriti non sono corretti";
                            }
                            else
                            {
                                risp = Convert.ToString(Calorie_Bruciate);
                            }
                        }
                        else
                        {
                            risp = "Sesso non e valido non è valido";
                        }
                    }
                }
                catch (Exception)
                {
                    risp = "Errore";
                }

                return risp;
            }

//nr4
    public static string Spesa_energetica(string passo, string spazio, string peso)
    {

        string risp = "";

        try
        {
           
            double Spazio = Convert.ToDouble(spazio);
            double Peso = Convert.ToDouble(peso);

            if (Peso < 0 || Spazio < 0)
            {
                if (Spazio < 0)
                {
                    risp = "Lo spazio che hai inserito è negativo";
                }

                if (Peso < 0)
                {
                    risp = "Il peso che hai inserito è negativo";
                }
            }
            else
            {
                
                double SEnergetica = 0;

               
                if (passo == "corsa")
                {
                    SEnergetica = 0.9 * Spazio * Peso;

                    risp = Convert.ToString(SEnergetica);
                }
                else if (passo == "camminata")
                {
                    SEnergetica = 0.5 * Spazio * Peso;

                    risp = Convert.ToString(SEnergetica);
                }
                else
                {
                    risp = "L'caso che hai inserito non è valido";
                }
            }
        }
        catch (Exception)
        {
            risp = "Errore";
        }

        return risp;
    }
    }
}



