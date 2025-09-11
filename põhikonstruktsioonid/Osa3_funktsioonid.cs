using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

        public static string KuniMärksõnani(string märksõna, string fraas)
        {
            fraas = "";
            do
            {
                Console.WriteLine("Arvata ära!");
                fraas = Console.ReadLine();
            }
            while (fraas.ToLower() != märksõna.ToLower());
            return fraas;
        }

        public static int ArvaArv(int arv)
        {
            string v = "";
            Random rnd = new Random();
            do
            {
                arv = rnd.Next(0, 100);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Arva arv: ");
                    try
                    {
                        int a = int.Parse(Console.ReadLine());
                        if (a == arv)
                        {
                            Console.WriteLine("Tubli, siis arv on Õige");
                        }
                        else if (a > arv)
                        {
                            Console.WriteLine("Su arv on liiga suur");
                        }
                        else if (a < arv)
                        {
                            Console.WriteLine("Su arv on liiga väike");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine($"Õige vastus on {arv}");
                Console.WriteLine("Kas sa soovib uuesti mängida.");
                v = Console.ReadLine();
            }
            while (v.ToLower() != "ei");
            Console.WriteLine("Mängi lõpuks");
            return arv;
        }

        public static int SuurimNeljarv(int[] arvud)
        {
            for (int i = 0;i < 4;i++)
            {
                Console.Write("Sisesta üks arv");
                Console.ReadLine();
            }
        }
    }
}
