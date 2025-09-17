using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Lemmikloom
    {
        public string Nimi;
        public string Liik;
        public int Vanus;
        public Lemmikloom(string nimi, string liik, int vanus)
        {
            this.Nimi = nimi;
            this.Liik = liik;
            this.Vanus = vanus;
        }
        public void Greeting()
        {
            Console.WriteLine($"Liik: {Liik}, Nimi: {Nimi}, Vanus: {Vanus}.");
        }
        public static void Statistik(List<Lemmikloom> loomad, Dictionary<string, List<Lemmikloom>> liikid)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Sisestage lemmikloomi nimi");
                    string nimi = Console.ReadLine();
                    Console.WriteLine("Sisestage lemmikloomi liik");
                    string liik = Console.ReadLine();
                    Console.WriteLine("Sisesta lemikloomi vanus");
                    int vanus = int.Parse(Console.ReadLine());

                    Lemmikloom newLemmikloom = new Lemmikloom(nimi, liik, vanus);
                    loomad.Add(newLemmikloom);

                    if (!liikid.ContainsKey(liik))
                    {
                        liikid[liik] = new List<Lemmikloom>();
                    }
                    liikid[liik].Add(newLemmikloom);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            foreach (Lemmikloom loom in loomad)
            {
                loom.Greeting();
            }
        }
        public static void Dict(Dictionary<string, List<Lemmikloom>> liikid)
        {
            Console.WriteLine("Tahad teada, millised koduloomad kuuluvad kasside perekonda?");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "ei")
            {
                string liik = "kass";
                if (liikid.ContainsKey(liik))
                {
                    foreach (Lemmikloom loom in liikid[liik])
                    {
                        Console.WriteLine($" {loom.Nimi}, {loom.Vanus}");
                    }
                }
                else
                {
                    Console.WriteLine($"Loomad kass ei leitud.");
                }
            }
        }
        public static void KeskmineVanus(List<Lemmikloom> loomad)
        {
            Console.WriteLine("Kas sa tahad näha keskmist vanust?");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "ei")
            {
                if (loomad.Count > 0)
                {
                    double keskmine = loomad.Average(l => l.Vanus);
                    Console.WriteLine($"Keskmine vanus on: {keskmine}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Oke, head aega");
            }
        }
        public static void VanemLoom(List<Lemmikloom> loomad)
        {
            Console.WriteLine("Kas sa tahad näha vanemad loomad");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "ei")
            {
                if (loomad.Count > 0)
                {
                    Lemmikloom vanem = loomad.OrderByDescending(l => l.Vanus).First();
                    Console.WriteLine($"Vanemad loom on: {vanem.Nimi}, {vanem.Liik}, {vanem.Vanus}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Oke, head aega");
            }
        }
    }
}
