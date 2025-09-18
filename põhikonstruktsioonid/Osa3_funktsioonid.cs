using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    public static class Osa3_funktsioonid
    {

        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] { ' ' };

            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);

            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                arvud[i] = Convert.ToDouble(osad[i]);
            }
            return arvud;
        }

        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }

        // 4. Ülesanne
        public static void KuniMärksõnani(string märksõna, string fraas)
        {   
            List<string> sisestused = new List<string>();
            string sisend;
            do
            {
                Console.Write(fraas);
                sisend = Console.ReadLine();
                sisestused.Add(sisend);
            } while (sisend != märksõna);

            Console.WriteLine("Kõik sisestused:");
            foreach (var s in sisestused)
            {
                Console.WriteLine(s);
            }
        }

        // 5. Ülesanne
        public static void ArvaArv()
        {
            Random rnd = new Random();
            bool uuesti;
            do
            {
                int arv = rnd.Next(1, 101);
                int katsed = 0;
                bool arvas = false;
                Console.WriteLine("Arva ära arv vahemikus 1 kuni 100! Sul on 5 katset.");
                while (katsed < 5 && !arvas)
                {
                    Console.Write($"Katse {katsed + 1}: ");
                    string sisend = Console.ReadLine();
                    int pakkumine;
                    if (!int.TryParse(sisend, out pakkumine))
                    {
                        Console.WriteLine("Palun sisesta täisarv.");
                        continue;
                    }
                    katsed++;
                    if (pakkumine == arv)
                    {
                        Console.WriteLine("Õige! Tubli!");
                        arvas = true;
                    }
                    else if (pakkumine < arv)
                    {
                        Console.WriteLine("Liiga väike.");
                    }
                    else
                    {
                        Console.WriteLine("Liiga suur.");
                    }
                }
                if (!arvas)
                {
                    Console.WriteLine($"Kahjuks ei arvanud ära. Õige vastus oli {arv}.");
                }
                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                string vastus = Console.ReadLine();
                uuesti = vastus.Trim().ToLower() == "jah";
            } while (uuesti);
        }

        // 6. Ülesanne
        public static int SuurimNeliarv(int[] arvud)
        {
            foreach (var arv in arvud)
            {
                if (arv < 0 || arv > 9)
                {
                    Console.WriteLine("Arvud peavad olema ühekohalised (0-9).");
                }
            }
            var suurim = arvud.OrderByDescending(x => x).Aggregate(0, (acc, x) => acc * 10 + x);
            return suurim;
        }

        // 7. Ülesanne
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            int laius = (ridadeArv * veergudeArv) + 1;
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j]);
                }
                Console.WriteLine();
            }
            return tabel;
        }
        public static void KysiKorrutustabelist(int[,] tabel)
        {
            while (true)
            {
                Console.Write("Sisesta rida (või enter lõpetamiseks): ");
                string ridaSisend = Console.ReadLine();
                if (string(ridaSisend)) break;
                Console.Write("Sisesta veerg: ");
                string veergSisend = Console.ReadLine();
                if (string(veergSisend)) break;
                if (int.TryParse(ridaSisend, out int rida) && int.TryParse(veergSisend, out int veerg)
                    && rida > 0 && veerg > 0 && rida <= tabel.GetLength(0) && veerg <= tabel.GetLength(1))
                {
                    Console.WriteLine($"{rida} x {veerg} = {tabel[rida - 1, veerg - 1]}");
                }
                else
                {
                    Console.WriteLine("Vigane sisestus.");
                }
            }
        }
        // 8. Ülesanne
        public static void OpilasteMäng(string[] opilased)
        {
            Console.WriteLine("Õpilased:");
            foreach (var op in opilased)
            {
                Console.WriteLine(op);
            }
            Random rnd = new Random();
            while (true)
            {
                Console.Write("Sisesta õpilase nimi (või enter lõpetamiseks): ");
                string sisend = Console.ReadLine();
                if (string(sisend)) break;
                var leitud = opilased.FirstOrDefault(o => o.Equals(sisend, StringComparison));
                if (leitud != null)
                {
                    Console.WriteLine($"Leitud: {leitud}");
                    int index = Array.IndexOf(opilased, leitud);
                    int uusIndex;
                    do
                    {
                        uusIndex = rnd.Next(opilased.Length);
                    } while (uusIndex == index);
                    Console.WriteLine($"Vahetame {leitud} asemel välja {opilased[uusIndex]}");
                    opilased[index] = opilased[uusIndex];
                    opilased[uusIndex] = leitud;
                }
                else
                {
                    Console.WriteLine("Õpilast ei leitud.");
                }
            }
            Console.WriteLine("Lõplik nimekiri:");
            foreach (var op in opilased)
            {
                Console.WriteLine(op);
            }
        }
        // 9. Ülesanne 
        public static void ArvudeRuududJaKahekordsed(int[] arvud)
        {
            Console.WriteLine("Arvude ruudud (for):");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"{arvud[i]}^2 = {arvud[i] * arvud[i]}");
            }

            Console.WriteLine("Arvude kahekordsed väärtused (foreach):");
            foreach (var arv in arvud)
            {
                Console.WriteLine($"{arv} x 2 = {arv * 2}");
            }

            int jagubKolmega = 0;
            int j = 0;
            while (j < arvud.Length)
            {
                if (arvud[j] % 3 == 0)
                    jagubKolmega++;
                j++;
            }
            Console.WriteLine($"Arve, mis jaguvad 3-ga: {jagubKolmega}");
        }

        // 10. Ülesanne - Positiivsed ja negatiivsed
        public static void PositiivsedNegatiivsedNullid(int[] arvud)
        {
            int pos = 0, neg = 0, nullid = 0;
            foreach (var arv in arvud)
            {
                if (arv > 0) pos++;
                else if (arv < 0) neg++;
                else nullid++;
            }
            Console.WriteLine($"Positiivseid: {pos}, Negatiivseid: {neg}, Nulle: {nullid}");
        }
    }
}
