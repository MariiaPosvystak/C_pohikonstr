using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    class Startclass2
    {
        //public static void Main(string[] args)
        //{
        //    Random rnd = new Random();
        //    Console.OutputEncoding = Encoding.UTF8;

        //    //2.Osa C# Valikute konstruktsionid. Teoria+Ülesanded
        //    Console.OutputEncoding = Encoding.UTF8;
        //    int kuu_number = rnd.Next(1, 12);
        //    string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
        //    Console.WriteLine($"Nr: {kuu_number}.{nimetus}");

        //    Console.WriteLine("Kas tahad dekodeerida arv -> nimetusse");
        //    string vastus = Console.ReadLine();
        //    if (vastus.ToLower() != "jah")
        //    {
        //        Console.WriteLine("Ei taha, siis ei taha");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            Console.Write("Nr: ");
        //            kuu_number = int.Parse(Console.ReadLine());
        //            Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }

        //    //1.Ülesanne
        //    Console.Write("Mis su nimi on? ");
        //    vastus = Console.ReadLine();
        //    if (vastus.ToLower() != "juku")
        //    {
        //        Console.WriteLine("Me ei lähe kinno");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            Console.Write("Kui vana sa oled?: ");
        //            int vanus = int.Parse(Console.ReadLine());
        //            string pilet = Osa1_funktsioonid.Pilet(vanus);
        //            Console.WriteLine($"Juku su pilet on {pilet}");
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }

        //    //2.Ülesanne
        //    //V.1
        //    //Console.Write("Mis su nimi on? ");
        //    //string nimi1 = Console.ReadLine();
        //    //Console.Write("Mis su nimi on? ");
        //    //string nimi2 = Console.ReadLine();
        //    //Console.WriteLine($"{nimi1} ja {nimi2}, teie istute täna pingis kõrvuti.");

        //    //V.2
        //    try
        //    {
        //        Console.Write("Mis su nimi on? ");
        //        string nimi1 = Console.ReadLine();
        //        Console.Write("Mis su nimi on? ");
        //        string nimi2 = Console.ReadLine();
        //        string con = Osa1_funktsioonid.Pärt(nimi1, nimi2, "");
        //        Console.WriteLine(con);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    //3.Ülesanne
        //    try
        //    {
        //        Console.Write("Kui pikk on su põrand? ");
        //        float pikk = float.Parse(Console.ReadLine());
        //        Console.Write("Kui lai on su põrand? ");
        //        float lai = float.Parse(Console.ReadLine());
        //        float pi = (Osa1_funktsioonid.Põrand(pikk, lai));
        //        Console.Write($"Su seina {pikk}x{lai} pindala = {pi} ");

        //        Console.WriteLine("Kas sa tahad remonti teha? ");
        //        vastus = Console.ReadLine();
        //        if (vastus.ToLower() != "jah")
        //        {
        //            Console.Write("Siis remonti ei tule. ");
        //        }
        //        else
        //        {
        //            Console.Write("Kui palju maksab ruutmeeter? ");
        //            float m2hind = float.Parse(Console.ReadLine());
        //            Console.Write($"Su seina {pikk}x{lai} pindala = {pi} ");
        //            float r = (Osa1_funktsioonid.Remont(m2hind, pi));
        //            Console.WriteLine($"Remondi hind on {r}.");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    //4.Ülesanne
        //    //V.1
        //    //float a = float.Parse(Console.ReadLine());
        //    //float b = 0.7f;
        //    //float n = a / b;
        //    //Console.WriteLine(n);

        //    //V.2
        //    try
        //    {
        //        Console.Write("Sisestage toote hind 30% soodustusega, et teada saada selle täishind. ");
        //        float s_hind = float.Parse(Console.ReadLine());
        //        float h = Osa1_funktsioonid.Thind(s_hind);
        //        Console.WriteLine($"Täishind on {h}");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    //5.Ülesanne
        //    try
        //    {
        //        Console.Write("Tere! Mis temperatuur praegu on? ");
        //        int temp = int.Parse(Console.ReadLine());
        //        string vast = Osa1_funktsioonid.Temperatuur(temp);
        //        Console.WriteLine(vast);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    //6.Ülesanne
        //    try
        //    {
        //        Console.WriteLine("Kui pikk sa oled?");
        //        int pikk = int.Parse(Console.ReadLine());
        //        string v = Osa1_funktsioonid.Pikkus(pikk);
        //        Console.WriteLine(v);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }


        //    //7.Ülesanne
        //    Console.WriteLine("Tere!");
        //    Console.Write("Mis su sugu on?");
        //    string s = Console.ReadLine();
        //    Console.Write("Kui pikk sa oled?");
        //    int p = int.Parse(Console.ReadLine());
        //    if (s.ToLower() == "mees")
        //    {
        //        string v = Osa1_funktsioonid.P_mees(p);
        //        Console.WriteLine(v);
        //    }
        //    else if (s.ToLower() == "naine")
        //    {
        //        string v = Osa1_funktsioonid.P_naine(p);
        //        Console.WriteLine(v);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Viga andmetega");
        //    }

        //    //8.Ülesanne
        //    Console.WriteLine("Tere!");

        //    Console.Write("Mida te tahate osta: piima, saia või leiba?");
        //    string t = Console.ReadLine();
        //    if (t.ToLower() == "piim" || t.ToLower() == "piima")
        //    {
        //        Console.WriteLine("Mitu pakki te soovite osta?");
        //        int k = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //        string t2 = Console.ReadLine();
        //        if (t2.ToLower() != "ei")
        //        {
        //            if (t2.ToLower() == "sai" || t2.ToLower() == "saia")
        //            {
        //                Console.WriteLine("Mitu tükki te soovite osta?");
        //                int k2 = int.Parse(Console.ReadLine());

        //                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //                string t3 = Console.ReadLine();
        //                if (t3.ToLower() != "ei")
        //                {
        //                    if (t3.ToLower() == "leib" || t3.ToLower() == "leiba")
        //                    {
        //                        Console.WriteLine("Mitu tükki te soovite osta?");
        //                        int k3 = int.Parse(Console.ReadLine());
        //                        float pls = Osa1_funktsioonid.Hind(k, k2, k3);
        //                        Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Vale andmed!");
        //                    }
        //                }
        //                else
        //                {
        //                    float ps = Osa1_funktsioonid.Hind(k, k2, 0.0f);
        //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {ps}.");
        //                }
        //            }
        //            else if (t2.ToLower() == "leib" || t2.ToLower() == "leiba")
        //            {
        //                Console.WriteLine("Mitu tükki te soovite osta?");
        //                int k3 = int.Parse(Console.ReadLine());

        //                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //                string t3 = Console.ReadLine();
        //                if (t3.ToLower() != "ei")
        //                {
        //                    if (t3.ToLower() == "sai" || t3.ToLower() == "saia")
        //                    {
        //                        Console.WriteLine("Mitu tükki te soovite osta?");
        //                        int k2 = int.Parse(Console.ReadLine());
        //                        float pls = Osa1_funktsioonid.Hind(k, k2, k3);
        //                        Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Vale andmed!");
        //                    }
        //                }
        //                else
        //                {
        //                    float pl = Osa1_funktsioonid.Hind(k, 0.0f, k3);
        //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pl}.");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Vale andmed!");
        //            }
        //        }
        //        else
        //        {
        //            float p1 = Osa1_funktsioonid.Hind(k, 0.0f, 0.0f);
        //            Console.WriteLine($"Aitäh ostu eest, teie maksate {p1}.");
        //        }
        //    }
        //    else if (t.ToLower() == "sai" || t.ToLower() == "saia")
        //    {
        //        Console.WriteLine("Mitu tükki te soovite osta?");
        //        int k2 = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //        string t2 = Console.ReadLine();
        //        if (t2.ToLower() != "ei")
        //        {
        //            if (t2.ToLower() == "piim" || t2.ToLower() == "piima")
        //            {
        //                Console.WriteLine("Mitu tükki te soovite osta?");
        //                int k = int.Parse(Console.ReadLine());

        //                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //                string t3 = Console.ReadLine();
        //                if (t3.ToLower() != "ei")
        //                {
        //                    if (t3.ToLower() == "leib" || t3.ToLower() == "leiba")
        //                    {
        //                        Console.WriteLine("Mitu tükki te soovite osta?");
        //                        int k3 = int.Parse(Console.ReadLine());
        //                        float pls = Osa1_funktsioonid.Hind(k, k2, k3);
        //                        Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Vale andmed!");
        //                    }
        //                }
        //                else
        //                {
        //                    float ps = Osa1_funktsioonid.Hind(k, k2, 0.0f);
        //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {ps}.");
        //                }
        //            }
        //            else if (t2.ToLower() == "leib" || t2.ToLower() == "leiba")
        //            {
        //                Console.WriteLine("Mitu tükki te soovite osta?");
        //                int k3 = int.Parse(Console.ReadLine());

        //                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //                string t3 = Console.ReadLine();
        //                if (t3.ToLower() != "ei")
        //                {
        //                    if (t3.ToLower() == "piim" || t3.ToLower() == "piima")
        //                    {
        //                        Console.WriteLine("Mitu tükki te soovite osta?");
        //                        int k = int.Parse(Console.ReadLine());
        //                        float pls = Osa1_funktsioonid.Hind(k, k2, k3);
        //                        Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Vale andmed!");
        //                    }
        //                }
        //                else
        //                {
        //                    float ls = Osa1_funktsioonid.Hind(0.0f, k2, k3);
        //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {ls}.");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Vale andmed!");
        //            }
        //        }
        //        else
        //        {
        //            float s1 = Osa1_funktsioonid.Hind(0.0f, k2, 0.0f);
        //            Console.WriteLine($"Aitäh ostu eest, teie maksate {s1}.");
        //        }
        //    }
        //    else if (t.ToLower() == "leib" || t.ToLower() == "leiba")
        //    {
        //        Console.WriteLine("Mitu tükki te soovite osta?");
        //        int k3 = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //        string t2 = Console.ReadLine();
        //        if (t2.ToLower() != "ei")
        //        {
        //            if (t2.ToLower() == "piim" || t2.ToLower() == "piima")
        //            {
        //                Console.WriteLine("Mitu tükki te soovite osta?");
        //                int k = int.Parse(Console.ReadLine());

        //                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //                string t3 = Console.ReadLine();
        //                if (t3.ToLower() != "ei")
        //                {
        //                    if (t3.ToLower() == "sai" || t3.ToLower() == "saia")
        //                    {
        //                        Console.WriteLine("Mitu tükki te soovite osta?");
        //                        int k2 = int.Parse(Console.ReadLine());
        //                        float pls = Osa1_funktsioonid.Hind(k, k2, k3);
        //                        Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Vale andmed!");
        //                    }
        //                }
        //                else
        //                {
        //                    float pl = Osa1_funktsioonid.Hind(k, 0.0f, k3);
        //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {pl}.");
        //                }
        //            }
        //            else if (t2.ToLower() == "sai" || t2.ToLower() == "saia")
        //            {
        //                Console.WriteLine("Mitu tükki te soovite osta?");
        //                int k2 = int.Parse(Console.ReadLine());

        //                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
        //                string t3 = Console.ReadLine();
        //                if (t3.ToLower() != "ei")
        //                {
        //                    if (t3.ToLower() == "piim" || t3.ToLower() == "piima")
        //                    {
        //                        Console.WriteLine("Mitu tükki te soovite osta?");
        //                        int k = int.Parse(Console.ReadLine());
        //                        float pls = Osa1_funktsioonid.Hind(k, k2, k3);
        //                        Console.WriteLine($"Aitäh ostu eest, teie maksate {pls}.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Vale andmed!");
        //                    }
        //                }
        //                else
        //                {
        //                    float ls = Osa1_funktsioonid.Hind(0.0f, k2, k3);
        //                    Console.WriteLine($"Aitäh ostu eest, teie maksate {ls}.");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Vale andmed!");
        //            }
        //        }
        //        else
        //        {
        //            float l1 = Osa1_funktsioonid.Hind(0.0f, 0.0f, k3);
        //            Console.WriteLine($"Aitäh ostu eest, teie maksate {l1}.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Vale andmed!");
        //    }
        //}
    }
}
