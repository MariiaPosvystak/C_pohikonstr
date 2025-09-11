using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Inimene
    {
        string nimi;
        int vanus;
        
        public Inimene (string nimi, int vanus)
        {
            this.nimi = nimi;
            this.vanus = vanus;
        }
        public static Tuple<double, double, int, int> Statistika(List<Inimene> inimesed)
        {
            double summa = inimesed.Sum(i => i.vanus);
            double keskmine = inimesed.Average(i => i.vanus);
            int max = inimesed.Max(i => i.vanus);
            int min = inimesed.Min(i => i.vanus);
            return Tuple.Create(summa, keskmine, max, min);
        }
    }
}
