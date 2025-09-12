using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    internal class Inimene_k
    {
        string nimi;
        int vanus;
        string sugu;
        int pikkus;
        float kaal;
        string aktiivsustase;
        public Inimene_k(string nimi, int vanus, string sugu, int pikkus, float kaal, string akts)
        {
            this.nimi = nimi;
            this.vanus = vanus;
            this.sugu = sugu;
            this.pikkus = pikkus;
            this.kaal = kaal;
            this.aktiivsustase = akts;
        }
    }
}
