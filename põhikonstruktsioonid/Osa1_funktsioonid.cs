using System;
using System.Collections.Generic;
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

        //2.
        //Спроси имена двух человек и сообщи, что они сегодня сидят рядом в парте.


        //3.
        //Спроси длины стен прямоугольной комнаты и вычисли площадь пола.
        //Спроси у пользователя, хочет ли он делать ремонт, если ответ положительный,
        //спроси, сколько стоит квадратный метр, и вычисли стоимость замены пола.
        public static (float S, float E) Põrand(float pikk, float lai, float metr)
        {
            float S = pikk * lai;
            float E = S * metr;
            return (S, E);
        }

        //4.
        //Найди исходную цену по цене с 30 % скидкой.

        //5.
        //Спроси температуру и сообщи, превышает ли она восемнадцать градусов(рекомендуемая комнатная температура зимой).

        //6.
        //Спроси рост человека и сообщи, он низкий, средний или высокий(пределы установи сам).

        //7.
        //Спроси рост и пол человека и сообщи, он низкий, средний или высокий(может быть несколько вложенных условий).

        //8.
        //Спроси у человека, хочет ли он купить молоко, булочку, хлеб в магазине.Подсчитай стоимость и сообщи, сколько стоит весь купленный товар.

    }
}
