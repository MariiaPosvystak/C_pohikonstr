using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            //2.Osa C# Valikute konstruktsionid. Teoria+Ülesanded

            //int kuu_number = rnd.Next(1, 12);
            //string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number}.{nimetus}");

            //Console.WriteLine("Kas tahad dekodeerida arv -> nimetusse");
            //string vastus=Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha, siis ei taha");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.Write("Nr: ");
            //        kuu_number = int.Parse(Console.ReadLine());
            //        Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}

            //1. Ülesanne
            //Console.Write("Mis su nimi on? ");
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower() !="juku")
            //{
            //    Console.WriteLine("Me ei lähe kinno");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.Write("Kui vana sa oled?: ");
            //        int vanus = int.Parse(Console.ReadLine());
            //        string pilet = Osa1_funktsioonid.Pilet(vanus);
            //        Console.WriteLine($"Juku su pilet on {pilet}");
            //    }
            //    catch (Exception e)
            //    { 
            //        Console.WriteLine(e);
            //    }
            //}

            //2. Ülesanne !!!!!!!
            //Спроси имена двух человек и сообщи, что они сегодня сидят рядом в парте.
            //Console.Write("Mis su nimi on? ");
            //string nimi1 = Console.ReadLine();
            //Console.Write("Mis su nimi on? ");
            //string nimi2 = Console.ReadLine();
            //if ()
            //else
            //{
            //    try
            //    {
            //        Console.Write("Kui vana sa oled?: ");
            //        int vanus = int.Parse(Console.ReadLine());
            //        string pilet = Osa1_funktsioonid.Pilet(vanus);
            //        Console.WriteLine($"Juku su pilet on {pilet}");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}

            //3.
            //Спроси длины стен прямоугольной комнаты и вычисли площадь пола.Спроси у пользователя,
            //хочет ли он делать ремонт, если ответ положительный, спроси, сколько стоит квадратный метр, и вычисли стоимость замены пола.
            try
            {
                Console.Write("Kui pikk on su põrand? ");
                float pikk = float.Parse(Console.ReadLine());
                Console.Write("Kui lai on su põrand? ");
                float lai = float.Parse(Console.ReadLine());

                Console.WriteLine("Kas sa tahad remonti teha? ");
                string vastus = Console.ReadLine();
                if (vastus.ToLower() != "jah")
                {
                    string S = (Osa1_funktsioonid.Põrand(pikk, lai));
                    Console.WriteLine($"Su seina {pikk}x{lai} pindala = {S}");
                    Console.WriteLine("Siis remonti ei tule.");
                }
                else
                {
                    Console.WriteLine("Kui palju maksab ruutmeeter?");
                    float metr = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Su seina {pikk}x{lai} pindala = {S}");
                    float E = (Osa1_funktsioonid.Põrand(metr, S));
                    Console.WriteLine(E);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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

            //1.Osa C# Põhikonstruktsionid. Projekti loomine, ikooni lisamine ja arvutamine. Teoria+Praaktika

            //Console.OutputEncoding = Encoding.UTF8;

            //Console.BackgroundColor = ConsoleColor.Red; 
            //Console.ForegroundColor = ConsoleColor.Black;

            //Console.WriteLine("Tere tulemast! Mis on sinu nimi?"); // Выводит текст на экран
            //string tekst =Console.ReadLine(); //Запрашивает ввод текста
            //Console.WriteLine($"{tekst}, Rõõm näha"); //Выводит то что указал пользователь $=f(Python)
            //int a = 1000;
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b=...");
            //int b=int.Parse(Console.ReadLine());
            //Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2} ", a, b, a+b);
            //Console.WriteLine("Ujukomaarv");
            //double d = double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //float f = float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool t = true;

            //a = rnd.Next(-100, 200);
            //Console.WriteLine(a);
            //float vastus=Osa1_funktsioonid.Kalkulaator(f, a);
            //Console.WriteLine($"Kalkulaator tulemus: {vastus}");
        }
    }
}
