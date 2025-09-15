using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Lemmikloom
    {
        string Nimi;
        string Liik;
        int Vanus;
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
        public static void Statistik(List<Lemmikloom> loomid, Dictionary<string, List<Lemmikloom>> liikid)
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
                    loomid.Add(newLemmikloom);

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
            foreach (Lemmikloom loom in loomid)
            {
                loom.Greeting();
            }
        }
        //Доделать
        public static void Dict(Dictionary<string, List<Lemmikloom>> liikid)
        {
            Console.WriteLine("Kas soovite vaadata teatud žanri erinevaid filme? (jah/ei)");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "ei")
            {
                Console.WriteLine("Mis žanri filme sa vaadata tahad?");
                string liik = Console.ReadLine();

                if (liikid.ContainsKey(liik))
                {
                    foreach (Film film in liikid[liik])
                    {
                        Console.WriteLine($" {film.Pealkiri}, {film.Aasta}");
                    }
                }
                else
                {
                    Console.WriteLine($"Žanr {žanr} ei leitud.");
                }
            }
        }
        public static void UusimFilm(List<Lemmikloom> filmid)
        {
            Console.WriteLine("Kas sa tahad näha uusimat filmi?");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "ei")
            {
                if (filmid.Count > 0)
                {
                    Film uusim = filmid.OrderByDescending(f => f.Aasta).First();
                    Console.WriteLine($"\nUusim film on: {uusim.Pealkiri}, {uusim.Aasta}, {uusim.Žanr}");
                }
                else
                {
                    Console.WriteLine("Filmide nimekiri on tühi.");
                }
            }
            else
            {
                Console.WriteLine("Oke, head aega");
            }
        }
    }
}
