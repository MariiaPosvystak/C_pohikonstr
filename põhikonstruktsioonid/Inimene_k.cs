using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Inimene_k
    {
        public string nimi;
        public int vanus;
        public string sugu;
        public int pikkus;
        public float kaal;
        public string aktiivsustase;
        public Inimene_k(string nimi, int vanus, string sugu, int pikkus, float kaal, string akts)
        {
            this.nimi = nimi;
            this.vanus = vanus;
            this.sugu = sugu;
            this.pikkus = pikkus;
            this.kaal = kaal;
            this.aktiivsustase = akts;
        }
        public static void SisestaAndmed()
        {
            Console.Write("Sisesta nimi: ");
            string nimi = Console.ReadLine();
            Console.Write("Sisesta vanus: ");
            int vanus = int.Parse(Console.ReadLine());
            Console.Write("Sisesta sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();
            Console.Write("Sisesta pikkus cm: ");
            int pikkus = int.Parse(Console.ReadLine());
            Console.Write("Sisesta kaal kg: ");
            float kaal = float.Parse(Console.ReadLine());
            Console.Write("Sisesta aktiivsustase (madal/keskmine/suur): ");
            string aktiivsus = Console.ReadLine().ToLower();
            Inimene_k inimene = new Inimene_k(nimi, vanus, sugu, pikkus, kaal, aktiivsus);
            float bmr;
            if (inimene.sugu == "mees")
                bmr = 88.36f + (13.4f * kaal) + (4.8f * pikkus) - (5.7f * vanus);
            else if (inimene.sugu == "naine")
                bmr = 447.6f + (9.2f * kaal) + (3.1f * pikkus) - (4.3f * vanus);
            else
            {
                Console.WriteLine("Sisesta sugu õigesti!");
                return;
            }
            Console.WriteLine($"Põhiainevahetus (BMR): {bmr} kcal/päevas");
            Toode.SalvestaTootedFaili();
            List<string> toode_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Toode.txt");
                toode_list = File.ReadAllLines(path).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            for (int i = 0; i < toode_list.Count; i++)
            {
                string[] osad = toode_list[i].Split(';');
                string toodeNimi = osad[0];
                float kalorid100g = float.Parse(osad[1]);

                float kogusGrammides = bmr / kalorid100g * 100;
                Console.WriteLine($"{i + 1}. {toodeNimi}: {kogusGrammides:F1} g");
            }
        }
    }
}
