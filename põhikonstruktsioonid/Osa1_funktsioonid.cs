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
            float k=arv1 * arv2;
            return k;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar";break;
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

        //1. Ülesanne
        public static string Pilet(int vanus)
        {
            string pilet = "";
            if (vanus < 6)
            {
                pilet = "Tasuta";
            }
            else if (vanus > 5 && vanus < 15)
            {
                pilet = "Lastepilet";
            }
            else if (vanus > 14 && vanus < 66)
            {
                pilet = "Täispilet";
            }
            else if (vanus > 65)
            {
                pilet = "Sooduspilet";
            }
            else if (vanus < 0 && vanus < 100)
            {
                pilet = "Viga andmetega";
            }
            else
            {
                pilet = "Erorr";
            }
            return pilet;
        }

        //2. Ülesanne  
        //V.2
        public static string Pärt(string nimi1, string nimi2, string p)
        {
            p = "";
            if (nimi1.ToUpper() == "MARIIA" && nimi2.ToUpper() == "SASHA")
            {
                p = $"{nimi1} ja {nimi2} istuvad täna pingis kõrvuti.";
            }
            else if (nimi1.ToUpper() == "SASHA" && nimi2.ToUpper() == "MARIIA")
            {
                p = $"{nimi1} ja {nimi2} istuvad täna pingis kõrvuti.";
            }
            else
            {
                p = $"{nimi1} ja {nimi2}, te ei istu koos.";
            }
            return p;
        }

        //3. Ülesanne
        public static float Põrand(float pikk, float lai)
        {
            float p = pikk * lai;
            return p;
        }
        public static float Remont(float pind, float m2hind)
        {
            float r = pind * m2hind;
            return r;
        }

        //4. Ülesanne
        //V.2
        public static float Thind(float s_hind)
        {
            float h = s_hind / 0.7f;
            return h;
        }

        //5. Ülesanne
        //Спроси температуру и сообщи, превышает ли она восемнадцать градусов(рекомендуемая комнатная температура зимой).
        public static string Temperatuur(float t)
        {
            string v = "";
            if (t < 18)
            {
                v = "Temperatuur on alla 18 kraadi (ruumide keskmine temperatuur talvel).";
            }
            else if (t == 18)
            {
                v = "Temperatuur on täpselt 18 kraadi(ruumide keskmine temperatuur talvel).";
            }
            else if (t > 18)
            {
                v = "Temperatuur on üle 18 kraadi(ruumide keskmine temperatuur talvel).";
            }
            else
            {
                v = "Error";
            }
            return v;
        }

        //6. Ülesanne
        //Спроси рост человека и сообщи, он низкий, средний или высокий(пределы установи сам).
        public static string Pikkus(float p)
        {
            string v = "";
            if (p < 160)
            {
                v = "Sa oled lühike inimene.";
            }
            else if (p > 159 && p < 181)
            {
                v = "Sa oled keskmise pikkusega inimene.";
            }
            else if (p > 180)
            {
                v = "Sa oled pikk inimene.";
            }
            else
            {
                v = "Error";
            }
            return v;
        }

        //7. Ülesanne
        //Спроси рост и пол человека и сообщи, он низкий, средний или высокий(может быть несколько вложенных условий).
        public static string P_mees(int p)
        {
            string v = "";
            if (p < 166)
            {
                v = "Sa oled lühike mees.";
            }
            else if (p > 165 && p < 186)
            {
                v = "Sa oled keskmise pikkusega mees.";
            }
            else if (p > 190)
            {
                v = "Sa oled pikk mees.";
            }
            else if (p < 40 && p > 230)
            {
                v = "Error andmetega.";
            }
            else
            {
                v = "Error";
            }
            return v;
        }
        public static string P_naine(int p)
        {
            string v = "";
            if (p < 156)
            {
                v = "Sa oled lühike naine.";
            }
            else if (p > 155 && p < 176)
            {
                v = "Sa oled keskmise pikkusega naine.";
            }
            else if (p > 175)
            {
                v = "Sa oled pikk naine.";
            }
            else if (p < 40 && p > 230)
            {
                v = "Error andmetega.";
            }
            else
            {
                v = "Error";
            }
            return v;
        }   

        //8. Ülesanne
        //Спроси у человека, хочет ли он купить молоко, булочку, хлеб в магазине.Подсчитай стоимость и сообщи, сколько стоит весь купленный товар.

    }
}
