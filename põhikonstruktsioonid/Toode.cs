using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Toode
    {
        public string nimi;
        public float kalorid100g;
        public Toode(string nimi, float kalorid)
        {
            this.nimi = nimi;
            this.kalorid100g = kalorid;
        }
        public static void SalvestaTootedFaili()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Toode.txt");
                using (StreamWriter writer = new StreamWriter(path, false)) ; // false = üle kirjutab faili
                using (StreamWriter writer = new StreamWriter(path, true)) // true = lisab faili lõppu
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Sisesta toote nimi: ");
                        string nimi = Console.ReadLine();
                        Console.Write("Sisesta kalorid 100g kohta: ");
                        float kalorid = float.Parse(Console.ReadLine());
                        Toode toode = new Toode(nimi, kalorid);
                        writer.WriteLine($"{toode.nimi};{toode.kalorid100g}");
                    }
                }
                Console.WriteLine("Andmed on edukalt salvestatud.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Viga faili töötlemisel: " + ex.Message);
            }
        }
    }
}
