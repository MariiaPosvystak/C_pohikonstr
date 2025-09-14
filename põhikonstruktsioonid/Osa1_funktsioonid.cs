using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Osa1_funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;
                default:
                    kuu = "Vale vähendus!";
                    break;
            }
            return kuu;
        }
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //1,2,12
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6) //3,4,5
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9) //6,7,8
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
            return hoo;
        }
    }
}
