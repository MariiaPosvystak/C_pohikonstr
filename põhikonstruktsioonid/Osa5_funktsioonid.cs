using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Osa5_funktsioonid
    {
        public static void ArrayList()
        {
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }
        public static void List()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void LinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);
        }
        public static void Dictionary()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);
        }
        public static void Dictionary2()
        {
            Dictionary<char, Person> inimesed = new Dictionary<char, Person>();
            inimesed.Add('k', new Person() { Name = "Kadi" });
            inimesed.Add('m', new Person() { Name = "Mait" });

            foreach (var entry in inimesed)
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
        }
        public static void Maakond_linnad(string vastus, Dictionary<string, string> nimi)
        {
            if (vastus == "maakond")
            {
                Console.WriteLine("Sisesta maakond: ");
                string maakond = Console.ReadLine();
                if (nimi.ContainsKey(maakond))
                {
                    Console.WriteLine(nimi[maakond]);
                }
                else
                {
                    Console.WriteLine("Lisame su linna ja maakonna");
                    Console.Write("Sisesta maakond: ");
                    string maakond1 = Console.ReadLine();
                    Console.Write("Sisesta linn: ");
                    string linn1 = Console.ReadLine();
                    nimi.Add(maakond1, linn1);
                    Console.WriteLine("Andmed on lisatud!");
                }
            }
            else if (vastus == "linn")
            {
                Console.WriteLine("Sisesta linn: ");
                string linn = Console.ReadLine();
                if (nimi.ContainsValue(linn))
                {
                    foreach (var paar in nimi)
                    {
                        if (paar.Value == linn)
                            Console.WriteLine(paar.Key);
                    }
                }
                else
                {
                    Console.WriteLine("Lisame su linna ja maakonna");
                    Console.Write("Sisesta maakond: ");
                    string maakond = Console.ReadLine();
                    Console.Write("Sisesta linn: ");
                    string linn1 = Console.ReadLine();
                    nimi.Add(maakond, linn1);
                    Console.WriteLine("Andmed on lisatud!");
                }
            }
            else
            {
                Console.WriteLine("Viga!");
            }
        }
        public static void Mang(Dictionary<string, string> nimi)
        {
            Console.WriteLine("Kas sa tahad mängida mängu? (jah/ei)");
            string vastus = Console.ReadLine().ToLower();
            if (vastus == "jah")
            {
                Console.WriteLine("Ma kirjutan sulle mingi maakonna ja sina pead arvama, mis on selle maakonna pealinn.");
                int oige = 0;
                for (int i = 0; i < 3; i++)
                {
                    Random rand = new Random();
                    int index = rand.Next(nimi.Count);
                    var paar = nimi.ElementAt(index);
                    Console.WriteLine($"Mis on {paar.Key} pealinn?");
                    string vastus1 = Console.ReadLine();
                    if (vastus1.ToLower() == paar.Value.ToLower())
                    {
                        Console.WriteLine("Õige vastus!");
                        oige++;
                    }
                    else
                    {
                        Console.WriteLine($"Vale vastus! Õige vastus on {paar.Value}");
                    }
                }
                float skoor = (float)oige / 3 * 100;
                Console.WriteLine($"Sinu skoor on {skoor}.");
                Console.WriteLine("Mäng läbi! Loodan, et sulle meeldis!");
            }
            else if (vastus == "ei")
            {
                Console.WriteLine("Okei, head päeva!");
            }
            else
            {
                Console.WriteLine("Palun vasta jah või ei!");
            }
        }
    }
}

