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

            //2. Ülesanne
            //V.1
            //Console.Write("Mis su nimi on? ");
            //string nimi1 = Console.ReadLine();
            //Console.Write("Mis su nimi on? ");
            //string nimi2 = Console.ReadLine();
            //Console.WriteLine($"{nimi1} ja {nimi2}, teie istute täna pingis kõrvuti.");
            //V.2
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

            //3. Ülesanne
            //try
            //{
            //    Console.Write("Kui pikk on su põrand? ");
            //    float pikk = float.Parse(Console.ReadLine());
            //    Console.Write("Kui lai on su põrand? ");
            //    float lai = float.Parse(Console.ReadLine());
            //    float p = (Osa1_funktsioonid.Põrand(pikk, lai));
            //    Console.Write($"Su seina {pikk}x{lai} pindala = {p} ");

            //    Console.WriteLine("Kas sa tahad remonti teha? ");
            //    string vastus = Console.ReadLine();
            //    if (vastus.ToLower() != "jah")
            //    {
            //        Console.Write("Siis remonti ei tule. ");
            //    }
            //    else
            //    {
            //        Console.Write("Kui palju maksab ruutmeeter? ");
            //        float m2hind = float.Parse(Console.ReadLine());
            //        Console.Write($"Su seina {pikk}x{lai} pindala = {p} ");
            //        float r = (Osa1_funktsioonid.Remont(m2hind, p));
            //        Console.WriteLine($"Remondi hind on {r}.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            //4. Ülesanne
            //Найди исходную цену по цене с 30 % скидкой.
            //V.1
            //float a = float.Parse(Console.ReadLine());
            //float b = 0.7f;
            //float n = a / b;
            //Console.WriteLine(n);

            //V.2
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

            //5. Ülesanne
            //Спроси температуру и сообщи, превышает ли она восемнадцать градусов(рекомендуемая комнатная температура зимой).
            //try
            //{
            //    Console.Write("Tere! Mis temperatuur praegu on? ");
            //    int t = int.Parse(Console.ReadLine());
            //    string vastus = Osa1_funktsioonid.Temperatuur(t);
            //    Console.WriteLine(vastus);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            //6. Ülesanne
            //Спроси рост человека и сообщи, он низкий, средний или высокий(пределы установи сам).
            //try
            //{
            //    Console.WriteLine("Kui pikk sa oled?");
            //    int p = int.Parse(Console.ReadLine());
            //    string v = Osa1_funktsioonid.Pikkus(p);
            //    Console.WriteLine(v);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}


            //7. Ülesanne
            //Спроси рост и пол человека и сообщи, он низкий, средний или высокий(может быть несколько вложенных условий).
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

            //8. Ülesanne
            //Спроси у человека, хочет ли он купить молоко, булочку, хлеб в магазине.Подсчитай стоимость и сообщи, сколько стоит весь купленный товар.
            Console.WriteLine("Tere!");

            Console.Write("Mida te tahate osta: piima, saia või leiba?");
            string t = Console.ReadLine();
            if (t.ToLower() == "piim" || t.ToLower() == "piima")
            {
                Console.WriteLine("Mitu pakki te soovite osta?");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                string t2 = Console.ReadLine();
                if (t2.ToLower() != "ei")
                {
                    if (t2.ToLower() == "sai" || t2.ToLower() == "saia")
                    {
                        Console.WriteLine("Mitu tükki te soovite osta?");
                        int k2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                        string t3 = Console.ReadLine();
                        if (t3.ToLower() != "ei")
                        {
                            if (t3.ToLower() == "leib" || t3.ToLower() == "leiba")
                            {
                                Console.WriteLine("Mitu tükki te soovite osta?");
                                int k3 = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Vale andmed!");
                            }
                        }
                        else
                        {
                            //подщет суми
                        }
                    }
                    else if (t2.ToLower() == "leib" || t2.ToLower() == "leiba")
                    {
                        Console.WriteLine("Mitu tükki te soovite osta?");
                        int k3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                        string t3 = Console.ReadLine();
                        if (t3.ToLower() != "ei")
                        {
                            if (t3.ToLower() == "sai" || t3.ToLower() == "saia")
                            {
                                Console.WriteLine("Mitu tükki te soovite osta?");
                                int k2 = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Vale andmed!");
                            }
                        }
                        else
                        {
                            //подщет суми
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vale andmed!");
                    }
                }
                else
                {
                    //подщет суми
                }
            }



            else if (t.ToLower() == "sai" || t.ToLower() == "saia")
            {
                Console.WriteLine("Mitu tükki te soovite osta?");
                int k2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                string t2 = Console.ReadLine();
                if (t2.ToLower() != "ei")
                {
                    if (t2.ToLower() == "piim" || t2.ToLower() == "piima")
                    {
                        Console.WriteLine("Mitu tükki te soovite osta?");
                        int k = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                        string t3 = Console.ReadLine();
                        if (t3.ToLower() != "ei")
                        {
                            if (t3.ToLower() == "leib" || t3.ToLower() == "leiba")
                            {
                                Console.WriteLine("Mitu tükki te soovite osta?");
                                int k3 = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Vale andmed!");
                            }
                        }
                        else
                        {
                            //подщет суми
                        }
                    }
                    else if (t2.ToLower() == "leib" || t2.ToLower() == "leiba")
                    {
                        Console.WriteLine("Mitu tükki te soovite osta?");
                        int k3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                        string t3 = Console.ReadLine();
                        if (t3.ToLower() != "ei")
                        {
                            if (t3.ToLower() == "piim" || t3.ToLower() == "piima")
                            {
                                Console.WriteLine("Mitu tükki te soovite osta?");
                                int k = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Vale andmed!");
                            }
                        }
                        else
                        {
                            //подщет суми
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vale andmed!");
                    }
                }
                else
                {
                    //подщет суми
                }
            }



            else if (t.ToLower() == "leib" || t.ToLower() == "leiba")
            {
                Console.WriteLine("Mitu tükki te soovite osta?");
                int k3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                string t2 = Console.ReadLine();
                if (t2.ToLower() != "ei")
                {
                    if (t2.ToLower() == "piim" || t2.ToLower() == "piima")
                    {
                        Console.WriteLine("Mitu tükki te soovite osta?");
                        int k = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                        string t3 = Console.ReadLine();
                        if (t3.ToLower() != "ei")
                        {
                            if (t3.ToLower() == "sai" || t3.ToLower() == "saia")
                            {
                                Console.WriteLine("Mitu tükki te soovite osta?");
                                int k2 = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Vale andmed!");
                            }
                        }
                        else
                        {
                            //подщет суми
                        }
                    }
                    else if (t2.ToLower() == "sai" || t2.ToLower() == "saia")
                    {
                        Console.WriteLine("Mitu tükki te soovite osta?");
                        int k2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kas te soovite nimekirjast veel midagi osta (kui jah, siis mida)?");
                        string t3 = Console.ReadLine();
                        if (t3.ToLower() != "ei")
                        {
                            if (t3.ToLower() == "piim" || t3.ToLower() == "piima")
                            {
                                Console.WriteLine("Mitu tükki te soovite osta?");
                                int k = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Vale andmed!");
                            }
                        }
                        else
                        {
                            //подщет суми
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vale andmed!");
                    }
                }
                else
                {
                    //подщет суми
                }
            }
            else
            {
                Console.WriteLine("Vale andmed!");
            }



            //Console.WriteLine("Mitu tükki (pakki) te soovite osta?");
            //Console.WriteLine("Kas te tahate osta piima, saiakese, leiba?");

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
