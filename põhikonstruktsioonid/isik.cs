using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Isik
    {
        public string eesnimi;
        public string perenimi = "Tray";
        public int synniaasta = 2000;

        public Isik(string eesnimi, string perenimi)
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
        }

        public void Prindi_andmed()
        {
            Console.WriteLine($"Isiku andmed: {perenimi} {eesnimi}. Sündinud: {synniaasta}");
        }
    }
}
