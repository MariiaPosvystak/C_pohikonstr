using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    class ArvuTöötlus
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
            int N = rnd.Next(min, max + 1);
            int M = rnd.Next(min, max + 1);

            int algus = Math.Min(N, M);
            int lõpp = Math.Max(N, M);

            int[] tulemus = new int[lõpp - algus + 1];
            for (int i = 0; i < tulemus.Length; i++)
            {
                int arv = algus + i;
                tulemus[i] = arv * arv;
            }
            Console.WriteLine($"Genereeritud arvud: {N}, {M}");
            for (int i = 0; i < tulemus.Length; i++)
            {
                int arv = algus + i;
                Console.WriteLine($"{arv} → {tulemus[i]}");
            }
            return tulemus;
        }
    }
}
