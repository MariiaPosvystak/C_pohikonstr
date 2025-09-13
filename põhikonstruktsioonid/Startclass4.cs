using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    class Startclass4
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            //Osa 4 
            //проверить коды и доделать конспект
            Osa4_funktsioonid.Kirjuta_failisse();
            Console.WriteLine("Sisesta faili nimi: ");
            string failinimi = Console.ReadLine();
            Osa4_funktsioonid.Faili_lugemine(failinimi);
            Console.WriteLine("Sisesta faili nimi: ");
            string fail = Console.ReadLine();
            Osa4_funktsioonid.Ridade_lugemine(fail);
            Osa4_funktsioonid.Listi_muutmine_kuvamine();
        }
    }
}
