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
            Console.OutputEncoding = Encoding.UTF8;

            ////1.Osa C# Põhikonstruktsionid. Projekti loomine, ikooni lisamine ja arvutamine. Teoria+Praaktika

            //Console.OutputEncoding = Encoding.UTF8;

            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Black;

            //Console.WriteLine("Tere tulemast! Mis on sinu nimi?"); // Выводит текст на экран
            //string tekst = Console.ReadLine(); //Запрашивает ввод текста
            //Console.WriteLine($"{tekst}, Rõõm näha"); //Выводит то что указал пользователь $=f(Python)
            //int a = 1000;
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b=...");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2} ", a, b, a + b);
            //Console.WriteLine("Ujukomaarv");
            //double d = double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //float f = float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool tr = true;

            //a = rnd.Next(-100, 200);
            //Console.WriteLine(a);
            //float vas = Osa1_funktsioonid.Kalkulaator(f, a);
            //Console.WriteLine($"Kalkulaator tulemus: {vas}");


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------


            ////2.Osa C# Valikute konstruktsionid. Teoria+Ülesanded
            //Console.OutputEncoding = Encoding.UTF8;
            //int kuu_number = rnd.Next(1, 12);
            //string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number}.{nimetus}");

            //Console.WriteLine("Kas tahad dekodeerida arv -> nimetusse");
            //string vastus = Console.ReadLine();
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

            ////1.Ülesanne
            //Console.Write("Mis su nimi on? ");
            //vastus = Console.ReadLine();
            //if (vastus.ToLower() != "juku")
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

            ////2.Ülesanne
            ////V.1
            ////Console.Write("Mis su nimi on? ");
            ////string nimi1 = Console.ReadLine();
            ////Console.Write("Mis su nimi on? ");
            ////string nimi2 = Console.ReadLine();
            ////Console.WriteLine($"{nimi1} ja {nimi2}, teie istute täna pingis kõrvuti.");

            ////V.2
            //try
            //{
            //    Console.Write("Mis su nimi on? ");
            //    string nimi1 = Console.ReadLine();
            //    Console.Write("Mis su nimi on? ");
            //    string nimi2 = Console.ReadLine();
            //    string con = Osa1_funktsioonid.Pärt(nimi1, nimi2, "");
            //    Console.WriteLine(con);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            ////3.Ülesanne
            //try
            //{
            //    Console.Write("Kui pikk on su põrand? ");
            //    float pikk = float.Parse(Console.ReadLine());
            //    Console.Write("Kui lai on su põrand? ");
            //    float lai = float.Parse(Console.ReadLine());
            //    float pi = (Osa1_funktsioonid.Põrand(pikk, lai));
            //    Console.Write($"Su seina {pikk}x{lai} pindala = {pi} ");

            //    Console.WriteLine("Kas sa tahad remonti teha? ");
            //    vastus = Console.ReadLine();
            //    if (vastus.ToLower() != "jah")
            //    {
            //        Console.Write("Siis remonti ei tule. ");
            //    }
            //    else
            //    {
            //        Console.Write("Kui palju maksab ruutmeeter? ");
            //        float m2hind = float.Parse(Console.ReadLine());
            //        Console.Write($"Su seina {pikk}x{lai} pindala = {pi} ");
            //        float r = (Osa1_funktsioonid.Remont(m2hind, pi));
            //        Console.WriteLine($"Remondi hind on {r}.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            ////4.Ülesanne
            ////V.1
            ////float a = float.Parse(Console.ReadLine());
            ////float b = 0.7f;
            ////float n = a / b;
            ////Console.WriteLine(n);

            ////V.2
            //try
            //{
            //    Console.Write("Sisestage toote hind 30% soodustusega, et teada saada selle täishind. ");
            //    float s_hind = float.Parse(Console.ReadLine());
            //    float h = Osa1_funktsioonid.Thind(s_hind);
            //    Console.WriteLine($"Täishind on {h}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            ////5.Ülesanne
            //try
            //{
            //    Console.Write("Tere! Mis temperatuur praegu on? ");
            //    int temp = int.Parse(Console.ReadLine());
            //    string vast = Osa1_funktsioonid.Temperatuur(temp);
            //    Console.WriteLine(vast);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            ////6.Ülesanne
            //try
            //{
            //    Console.WriteLine("Kui pikk sa oled?");
            //    int pikk = int.Parse(Console.ReadLine());
            //    string v = Osa1_funktsioonid.Pikkus(pikk);
            //    Console.WriteLine(v);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}


            ////7.Ülesanne
            //Console.WriteLine("Tere!");
            //Console.Write("Mis su sugu on?");
            //string s = Console.ReadLine();
            //Console.Write("Kui pikk sa oled?");
            //int p = int.Parse(Console.ReadLine());
            //if (s.ToLower() == "mees")
            //{
            //    string v = Osa1_funktsioonid.P_mees(p);
            //    Console.WriteLine(v);
            //}
            //else if (s.ToLower() == "naine")
            //{
            //    string v = Osa1_funktsioonid.P_naine(p);
            //    Console.WriteLine(v);
            //}
            //else
            //{
            //    Console.WriteLine("Viga andmetega");
            //}

            ////8.Ülesanne
            //Console.WriteLine("Tere!");

            //Console.Write("Mida te tahate osta: piima, saia või leiba?");
            //string t = Console.ReadLine();
            //if (t.ToLower() == "piim" || t.ToLower() == "piima")
            //{
            //    Console.WriteLine("Mitu pakki te soovite osta?");
            //    int k = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //    string t2 = Console.ReadLine();
            //    if (t2.ToLower() != "ei")
            //    {
            //        if (t2.ToLower() == "sai" || t2.ToLower() == "saia")
            //        {
            //            Console.WriteLine("Mitu tükki te soovite osta?");
            //            int k2 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //            string t3 = Console.ReadLine();
            //            if (t3.ToLower() != "ei")
            //            {
            //                if (t3.ToLower() == "leib" || t3.ToLower() == "leiba")
            //                {
            //                    Console.WriteLine("Mitu tükki te soovite osta?");
            //                    int k3 = int.Parse(Console.ReadLine());
            //                    float pls = Osa1_funktsioonid.Hind(k, k2, k3);
            //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Vale andmed!");
            //                }
            //            }
            //            else
            //            {
            //                float ps = Osa1_funktsioonid.Hind(k, k2, 0.0f);
            //                Console.WriteLine($"Aitäh ostu eest, teie maksate {ps}.");
            //            }
            //        }
            //        else if (t2.ToLower() == "leib" || t2.ToLower() == "leiba")
            //        {
            //            Console.WriteLine("Mitu tükki te soovite osta?");
            //            int k3 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //            string t3 = Console.ReadLine();
            //            if (t3.ToLower() != "ei")
            //            {
            //                if (t3.ToLower() == "sai" || t3.ToLower() == "saia")
            //                {
            //                    Console.WriteLine("Mitu tükki te soovite osta?");
            //                    int k2 = int.Parse(Console.ReadLine());
            //                    float pls = Osa1_funktsioonid.Hind(k, k2, k3);
            //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Vale andmed!");
            //                }
            //            }
            //            else
            //            {
            //                float pl = Osa1_funktsioonid.Hind(k, 0.0f, k3);
            //                Console.WriteLine($"Aitäh ostu eest, teie maksate {pl}.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Vale andmed!");
            //        }
            //    }
            //    else
            //    {
            //        float p1 = Osa1_funktsioonid.Hind(k, 0.0f, 0.0f);
            //        Console.WriteLine($"Aitäh ostu eest, teie maksate {p1}.");
            //    }
            //}
            //else if (t.ToLower() == "sai" || t.ToLower() == "saia")
            //{
            //    Console.WriteLine("Mitu tükki te soovite osta?");
            //    int k2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //    string t2 = Console.ReadLine();
            //    if (t2.ToLower() != "ei")
            //    {
            //        if (t2.ToLower() == "piim" || t2.ToLower() == "piima")
            //        {
            //            Console.WriteLine("Mitu tükki te soovite osta?");
            //            int k = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //            string t3 = Console.ReadLine();
            //            if (t3.ToLower() != "ei")
            //            {
            //                if (t3.ToLower() == "leib" || t3.ToLower() == "leiba")
            //                {
            //                    Console.WriteLine("Mitu tükki te soovite osta?");
            //                    int k3 = int.Parse(Console.ReadLine());
            //                    float pls = Osa1_funktsioonid.Hind(k, k2, k3);
            //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Vale andmed!");
            //                }
            //            }
            //            else
            //            {
            //                float ps = Osa1_funktsioonid.Hind(k, k2, 0.0f);
            //                Console.WriteLine($"Aitäh ostu eest, teie maksate {ps}.");
            //            }
            //        }
            //        else if (t2.ToLower() == "leib" || t2.ToLower() == "leiba")
            //        {
            //            Console.WriteLine("Mitu tükki te soovite osta?");
            //            int k3 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //            string t3 = Console.ReadLine();
            //            if (t3.ToLower() != "ei")
            //            {
            //                if (t3.ToLower() == "piim" || t3.ToLower() == "piima")
            //                {
            //                    Console.WriteLine("Mitu tükki te soovite osta?");
            //                    int k = int.Parse(Console.ReadLine());
            //                    float pls = Osa1_funktsioonid.Hind(k, k2, k3);
            //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Vale andmed!");
            //                }
            //            }
            //            else
            //            {
            //                float ls = Osa1_funktsioonid.Hind(0.0f, k2, k3);
            //                Console.WriteLine($"Aitäh ostu eest, teie maksate {ls}.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Vale andmed!");
            //        }
            //    }
            //    else
            //    {
            //        float s1 = Osa1_funktsioonid.Hind(0.0f, k2, 0.0f);
            //        Console.WriteLine($"Aitäh ostu eest, teie maksate {s1}.");
            //    }
            //}
            //else if (t.ToLower() == "leib" || t.ToLower() == "leiba")
            //{
            //    Console.WriteLine("Mitu tükki te soovite osta?");
            //    int k3 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //    string t2 = Console.ReadLine();
            //    if (t2.ToLower() != "ei")
            //    {
            //        if (t2.ToLower() == "piim" || t2.ToLower() == "piima")
            //        {
            //            Console.WriteLine("Mitu tükki te soovite osta?");
            //            int k = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //            string t3 = Console.ReadLine();
            //            if (t3.ToLower() != "ei")
            //            {
            //                if (t3.ToLower() == "sai" || t3.ToLower() == "saia")
            //                {
            //                    Console.WriteLine("Mitu tükki te soovite osta?");
            //                    int k2 = int.Parse(Console.ReadLine());
            //                    float pls = Osa1_funktsioonid.Hind(k, k2, k3);
            //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Vale andmed!");
            //                }
            //            }
            //            else
            //            {
            //                float pl = Osa1_funktsioonid.Hind(k, 0.0f, k3);
            //                Console.WriteLine($"Aitäh ostu eest, teie maksate {pl}.");
            //            }
            //        }
            //        else if (t2.ToLower() == "sai" || t2.ToLower() == "saia")
            //        {
            //            Console.WriteLine("Mitu tükki te soovite osta?");
            //            int k2 = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
            //            string t3 = Console.ReadLine();
            //            if (t3.ToLower() != "ei")
            //            {
            //                if (t3.ToLower() == "piim" || t3.ToLower() == "piima")
            //                {
            //                    Console.WriteLine("Mitu tükki te soovite osta?");
            //                    int k = int.Parse(Console.ReadLine());
            //                    float pls = Osa1_funktsioonid.Hind(k, k2, k3);
            //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Vale andmed!");
            //                }
            //            }
            //            else
            //            {
            //                float ls = Osa2_funktsioonid.Hind(0.0f, k2, k3);
            //                Console.WriteLine($"Aitäh ostu eest, teie maksate {ls}.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Vale andmed!");
            //        }
            //    }
            //    else
            //    {
            //        float l1 = Osa1_funktsioonid.Hind(0.0f, 0.0f, k3);
            //        Console.WriteLine($"Aitäh ostu eest, teie maksate {l1}.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Vale andmed!");
            //}


//-------------------------------------------------------------------------------------------------------------------------------------------------------------


            //3.Osa Massiivid, List, Kordused
            //выолнить задания и перепроверить
            List<string> nimed = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. Nimi: ");
                nimed.Add(Console.ReadLine());
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }

            int[] arvud = new int[10];
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j + 1);
                arvud[j] = rnd.Next(1, 101);
                j++;
            }
            foreach (int arv in arvud)
            {
                Console.WriteLine(arv);
            }

            List<Isik> isikud = new List<Isik>();
            j = 0;
            do
            {
                Console.Write(j + 1);
                Isik isik = new Isik();
                Console.Write(". Eesnimi: ");
                isik.eesnimi = Console.ReadLine();
                isikud.Add(isik);
                j++;
            } while (j < 10);
            isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            Console.WriteLine($"Kokku on: {isikud.Count()} isikud");
            foreach (Isik isik in isikud)
            {
                isik.Prindi_andmed();
            }
            Console.WriteLine($"Kolmandal kohal on: {isikud[2]} isik");

            //1. Ülesanne
            ArvuTöötlus.GenereeriRuudud(-100, 100);

            //2. Ülesanne
            double[] arvud1 = Osa3_funktsioonid.Tekstist_arvud();
            var tulemus = Osa3_funktsioonid.AnalüüsiArve(arvud1);
            Console.WriteLine($"Summa: {tulemus.Item1:F2}, Keskmine: {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");

            //3. Ülesanne
            List<Inimene> inimesed = new List<Inimene>();
            int l = 0;
            do
            {
                Console.WriteLine(l + 1);
                Inimene inimene = new Inimene();
                Console.Write("Nimi: ");
                inimene.nimi = Console.ReadLine();
                Console.Write("Vanus: ");
                try
                {
                    inimene.vanus = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Palun sisesta korrektne vanus");
                    continue;
                }
                inimesed.Add(inimene);
                l++;
            } while (l < 5);
            var statistika = Inimene.Statistika(inimesed);
            Console.WriteLine($"Kõigi inimeste vanuste summa: {statistika.Item1}");
            Console.WriteLine($"Keskmine vanus: {statistika.Item2:F2}");
            Console.WriteLine($"Vanim inimene: {statistika.Item3}");
            Console.WriteLine($"Noorim inimene: {statistika.Item4}");


            // 4. Ülesanne
            Console.Write("Sisesta märksõna: ");
            string märksõna = Console.ReadLine();
            Osa3_funktsioonid.KuniMärksõnani(märksõna, "Osta elevant ära! ");

            // 5. Ülesanne
            Osa3_funktsioonid.ArvaArv();

            // 6. Ülesanne
            int[] neliArvu = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Sisesta {i + 1}. ühekohaline arv (0-9): ");
                while (true)
                {
                    string sisend = Console.ReadLine() ?? "";
                    int arv;
                    if (int.TryParse(sisend, out arv) && arv >= 0 && arv <= 9)
                    {
                        neliArvu[i] = arv;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Viga: sisesta ühekohaline täisarv (0-9)!");
                    }
                }
            }
            int suurimNeljarv = Osa3_funktsioonid.SuurimNeliarv(neliArvu);
            Console.WriteLine($"Suurim võimalik neljakohaline arv: {suurimNeljarv}");

            //7. Ülesanne
            Console.Write("Sisesta veergude arv: ");
            int veergudeArv = int.Parse(Console.ReadLine());
            int ridadeArv = int.Parse(Console.ReadLine());
            var korrutustabel = Osa3_funktsioonid.GenereeriKorrutustabel(ridadeArv, veergudeArv);
            Osa3_funktsioonid.KysiKorrutustabelist(korrutustabel);

            // 8. Ülesanne
            string[] opilased = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Sisesta {i + 1}. õpilase nimi: ");
                opilased[i] = Console.ReadLine();
            }
            Osa3_funktsioonid.OpilasteMäng(opilased);

            // 9. Ülesanne
            int[] arvud9 = { 2, 4, 6, 8, 10, 12 };
            Osa3_funktsioonid.ArvudeRuududJaKahekordsed(arvud9);

            // 10. Ülesanne
            int[] arvud10 = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            Osa3_funktsioonid.PositiivsedNegatiivsedNullid(arvud10);



//----------------------------------------------------------------------------------------------------------------------------------------------------


            ////Osa 4 
            ////проверить коды и доделать конспект
            //Osa4_funktsioonid.Kirjuta_failisse();
            //Console.WriteLine("Sisesta faili nimi: ");
            //string failinimi = Console.ReadLine();
            //Osa4_funktsioonid.Faili_lugemine(failinimi);
            //Console.WriteLine("Sisesta faili nimi: ");
            //string fail = Console.ReadLine();
            //Osa4_funktsioonid.Ridade_lugemine(fail);
            //Osa4_funktsioonid.Listi_muutmine_kuvamine();


            //------------------------------------------------------------------------------------------------------------------------------------------------


            //Osa 5
            //сделать конспект и выполнить задание 1 и 2
            //Osa5_funktsioonid.ArrayList();

            //Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            //Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");

            //Osa5_funktsioonid.List();
            //Osa5_funktsioonid.LinkedList();
            //Osa5_funktsioonid.Dictionary();
            //Osa5_funktsioonid.Dictionary2();

            //Завдання:
            //Створити два класи:
            //+Toode– характеристики: Nimi,Kalorid100g
            //+Inimene– характеристики: Nimi, , Vanus, Sugu, Pikkus, Kaal,Aktiivsustase
            //Складіть програму, яка:
            //Зчитує Toodeоб'єкти з файлу або вручну додає їх до списку.
            //Запитує дані у користувача та розраховує добову потребу в енергії за формулою Гарріса - Бенедикта.
            //Надає користувачеві список продуктів, де для кожного продукту розраховується, скільки його слід з'їдати на день (г), щоб покрити потреби в калоріях.
            //💡 Порада: поділивши калорії на калорії на 100 г = кількість у грамах.

            //Console.WriteLine("1. Ülesanne");
            //Console.WriteLine("Tere tulemast kalorite kalkulaatorisse!");

            //Toode.SalvestaTootedFaili();
            //Inimene_k.SisestaAndmed();

            //Console.WriteLine("2. Ülesanne");
            //Dictionary<string, string> maakonnad = new Dictionary<string, string>();
            //maakonnad.Add("Harju maakond", "Tallinn");
            //maakonnad.Add("Hiiu maakond", "Kärdla");
            //maakonnad.Add("Ida-Viru maakond", "Jõhvi");
            //maakonnad.Add("Järva maakond", "Paide");
            //maakonnad.Add("Lääne maakond", "Haapsalu");
            //Console.WriteLine("Tere! Tahad teada, mis maakonnad on ja mis nende pealinnad?");
            //string v = Console.ReadLine();
            //if (v.ToLower() == "jah")
            //{
            //    Console.WriteLine("Kui tahad teada linna, sisesta maakond, aga kui tahad teada maakonda, sisesta linn.");
            //    string vastus = Console.ReadLine();
            //    Osa5_funktsioonid.Maakond_linnad(vastus, maakonnad);
            //    Osa5_funktsioonid.Mang(maakonnad);
            //}
            //else if (v.ToLower() == "ei")
            //{
            //    Console.WriteLine("Okei, head päeva!");
            //}
            //else
            //{
            //    Console.WriteLine("Palun vasta jah või ei!");
            //}
            //List<Film> filmid = new List<Film>();
            //Dictionary<string, List<Film>> žanri = new Dictionary<string, List<Film>>();
            //Film.Statistik(filmid, žanri);
            //Film.Dict(žanri);
            //Film.UusimFilm(filmid);

        }
    }
}