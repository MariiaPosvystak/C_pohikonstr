using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Osa3_funktsioonid
    {
        //public static int[] GenereeriRuudud(int min, int max)
        //{
        //    string ruudu = "";
        //    Random rnd = new Random();
        //    min = -100;
        //    max = 100;
        //    int N = rnd.Next(min, max);
        //    Console.WriteLine(N);
        //    int M = rnd.Next(min, max);
        //    if (N < M)
        //    {
        //        do
        //        {
        //            int N2 = N * N;
        //            ruudu = $"{N} -> {N2}";
        //            N++;
        //        } while (N <= M);
        //        return ruudu;
        //    }
        //    else
        //    {
        //        do
        //        {
        //            int M2 = M * M;
        //            ruudu = $"{M} -> {M2}";
        //            M++;
        //        } while (M <= N);
        //        return ruudu;
        //    }

        //}

        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] {' '};

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

    }
}
