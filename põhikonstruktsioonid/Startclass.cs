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
            //3.Osa Massiivid, List, Kordused
            //List<string> nimed = new List<string>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{i + 1}. Nimi: ");
            //    nimed.Add(Console.ReadLine());
            //}
            //foreach (string nimi in nimed) 
            //{
            //    Console.WriteLine(nimi);
            //}

            //int[] arvud = new int[10];
            //int j = 0;
            //while (j < 10)
            //{
            //    Console.WriteLine(j + 1);
            //    arvud[j] = rnd.Next(1, 101);
            //    j++;
            //}
            //foreach (int arv in arvud)
            //{
            //    Console.WriteLine(arv);
            //}

            //List<Isik> isikud = new List<Isik>();
            //j = 0;
            //do
            //{
            //    Console.Write(j + 1);
            //    Isik isik = new Isik();
            //    Console.Write(". Eesnimi: ");
            //    isik.eesnimi = Console.ReadLine();
            //    isikud.Add(isik);
            //    j++;
            //} while (j < 10);
            //isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            //Console.WriteLine($"Kokku on: {isikud.Count()} isikud");
            //foreach (Isik isik in isikud)
            //{
            //    isik.Prindi_andmed();            
            //}
            //Console.WriteLine($"Kolmandal kohal on: {isikud[2]} isik");








            //1. Ülesanne - Квадраты случайных чисел
            //Задание:
            //Создайте класс ArvuTöötlus с методом GenereeriRuudud(int min, int max), который:
            //Генерирует 2 случайных целых числа в диапазоне[-100, 100] → N и M,
            //Находит все целые числа между ними(от меньшего к большему),
            //Возвращает массив, где каждое значение — квадрат соответствующего числа.
            //В методе Main выведите все результаты вместе с исходным значением(например, "4 → 16").
            int[] arv = new int[10];
            int min = -100;
            int max = 100;
            int N = rnd.Next(min, max);
            Console.WriteLine(N);
            int M = rnd.Next(min, max);



            //2. Ülesanne - Анализ пяти чисел
            //Задание:
            //Создайте метод AnalüüsiArve(double[] arvud), который:
            //Принимает массив в качестве входных данных(пользователь вводит через метод Tekstist_arvud()),
            //Возвращает кортеж Tuple<double, double, double> — сумма, среднее, произведение,
            //Выводит результат в удобном формате.
            double[] arvud = Osa3_funktsioonid.Tekstist_arvud();
            var tulemus = Osa3_funktsioonid.AnalüüsiArve(arvud);
            Console.WriteLine();

            //3. Ülesanne - Имена и возраст
            //Задание:
            //Создайте класс Inimene с полями { string Nimi; int Vanus; }.
            //Создайте метод Statistika(List < Inimene > inimesed), который:
            //Вычисляет сумму и средний возраст всех,
            //Находит самого старого и самого младшего человека,
            //Возвращает значения в кортеже Tuple<int, double, Inimene, Inimene>.
            //Пользователь вводит 5 человек(имя и возраст отдельно).


            //4. Ülesanne - "Купи слона!"
            //Задание:
            //Сделайте метод повторного ввода KuniMärksõnani(string märksõna, string fraas), который:
            //Запрашивает ввод пользователя до тех пор, пока введённое не будет точно совпадать с ключевым словом,
            //Перед каждым вводом выводит фразу,
            //Все введённые значения сохраняет и выводит в конце.

            //5. Ülesanne - Игра угадай число
            //Задание:
            //Компьютер выбирает случайное число от 1 до 100.
            //Пользователю даётся 5 попыток.
            //Создайте метод ArvaArv(), который:
            //При каждой попытке сообщает, число слишком большое, слишком маленькое или правильное,
            //Игра заканчивается при угадывании или после 5 попыток.

            //Дополнительно: после игры спрашивайте, хочет ли пользователь сыграть снова.

            //Наибольшее четырёхзначное число

            //1. Ülesanne
            //Задание:
            //Попросите пользователя ввести 4 числа(например, 1, 5, 7, 3).
            //Цель: составить из них наибольшее возможное четырёхзначное число(1573).
            //Создайте метод SuurimNeljarv(double[] arvud), который:

            //            Проверяет, что введённые значения — однозначные целые числа(0–9),

            //Комбинирует их в максимально возможное четырёхзначное число.

            //Таблица умножения

            //1. Ülesanne
            //Задание:
            //            Напишите метод GenereeriKorrutustabel(int ridadeArv, int veergudeArv), который:

            //            Создаёт и выводит таблицу умножения в заданных пользователем пределах,

            //Использует красивое форматирование с выравниванием(например, PadLeft, String.Format).

            //Бонус: сохраняет результаты в двумерный массив int[,] и позволяет потом искать любое значение(например, "какое число в 7 x 8?").

            //Работа с учениками

            //Дан массив из 10 имён учеников.
            //Напишите программу, которая:

            //Заменяет имена 3 - го и 6 - го учеников на "Kati" и "Mati",

            //Использует цикл while, чтобы приветствовать только тех учеников, чьё имя начинается с буквы "A",

            //Использует цикл for, чтобы вывести все имена и их индексы,

            //Использует цикл foreach, чтобы вывести все имена в нижнем регистре,

            //Использует цикл do -while, чтобы приветствовать учеников, пока не встретится имя "Mati".

            //Квадраты чисел

            //Дан массив целых чисел:

















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
            //    string vastus = Console.ReadLine();
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
            //        string vastus = Console.ReadLine();
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
            //        string vast = Osa1_funktsioonid.Temperatuur(t);
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
            //        int p = int.Parse(Console.ReadLine());
            //        string v = Osa1_funktsioonid.Pikkus(p);
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


            //    //1.Osa C# Põhikonstruktsionid. Projekti loomine, ikooni lisamine ja arvutamine. Teoria+Praaktika

            //    Console.OutputEncoding = Encoding.UTF8;

            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Tere tulemast! Mis on sinu nimi?"); // Выводит текст на экран
            //    string tekst = Console.ReadLine(); //Запрашивает ввод текста
            //    Console.WriteLine($"{tekst}, Rõõm näha"); //Выводит то что указал пользователь $=f(Python)
            //    int a = 1000;
            //    char taht = 'A';
            //    Console.Write($"Esimene arv on {a}, Sisesta b=...");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2} ", a, b, a + b);
            //    Console.WriteLine("Ujukomaarv");
            //    double d = double.Parse(Console.ReadLine());
            //    Console.WriteLine(d);
            //    float f = float.Parse(Console.ReadLine());
            //    Console.WriteLine(f);
            //    bool tr = true;

            //    a = rnd.Next(-100, 200);
            //    Console.WriteLine(a);
            //    float vas = Osa1_funktsioonid.Kalkulaator(f, a);
            //    Console.WriteLine($"Kalkulaator tulemus: {vas}");
            //}
        }
    }
}
