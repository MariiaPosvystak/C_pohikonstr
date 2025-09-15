using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Film
    {
        string Pealkiri;
        int Aasta;
        string Žanr;
        public Film(string pealkiri, int aasta, string žanr)
        {
        this.Pealkiri = pealkiri;
        this.Aasta = aasta;
        this.Žanr = žanr;
        }
        public void Greeting()
        {
            Console.WriteLine($"Film: {Pealkiri}, Aasta: {Aasta}, Žanr: {Žanr}");
        }
        public static void Statistik(List<Film> filmid, Dictionary<string, List<Film>> žanri)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sisestage filmi pealkiri");
                string pealkiri = Console.ReadLine();
                Console.WriteLine("Sisesta filmi ilmumisaasta");
                int aasta = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisestage filmižanr");
                string žanr = Console.ReadLine();

                Film newFilm = new Film(pealkiri, aasta, žanr);
                filmid.Add(newFilm);

                if (!žanri.ContainsKey(žanr))
                {
                    žanri[žanr] = new List<Film>(); 
                }
                žanri[žanr].Add(newFilm);
            }
            foreach (Film film in filmid)
            {
                film.Greeting();
            }
        }
        public static void Dict(Dictionary<string, List<Film>> žanri)
        {
            Console.WriteLine("Kas soovite vaadata teatud žanri erinevaid filme? (jah/ei)");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "ei")
            {
                Console.WriteLine("Mis žanri filme sa vaadata tahad?");
                string žanr = Console.ReadLine();

                if (žanri.ContainsKey(žanr))
                {
                    foreach (Film film in žanri[žanr])
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
    }
}
//string pealinn = filmid[2];
//filmid[2] = "Eestimaa";
//filmid.Remove(3);


//Створіть клас Film, який має:
//Pealkiri(рядок)
//Aasta(ціл.)
//Žanr(рядок)
//Створіть List<Film>щонайменше 5 фільмів (вручну або за допомогою користувача).
//Напишіть функції, які:
//Знаходить усі фільми, що належать до певного жанру.
//Вони знаходять найновіший фільм.
//Групувати фільми за жанром (Dictionary<string, List<Film>>).