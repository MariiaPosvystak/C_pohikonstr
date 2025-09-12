using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Osa4_funktsioonid
    {
        public static void Kirjuta_failisse()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\\..\\..\\Kuud.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        public static void Faili_lugemine(string failinimi)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\\..\\..\\{failinimi}.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static void Ridade_lugemine(string fail)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\\..\\..\\{fail}.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }
        public static void Listi_muutmine_kuvamine()
        {
            List<string> kuude_list = new List<string>();
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            Console.WriteLine("Mis sa tahab kustuda");
            string r_s = Console.ReadLine();
            kuude_list.Remove(r_s);

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine($"--------------Kustutasime {r_s}-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

        }
    }
}
