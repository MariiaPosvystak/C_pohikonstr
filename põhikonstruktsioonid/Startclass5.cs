using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace põhikonstruktsioonid
{
    class Startclass5
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            //Osa 5
            //сделать конспект и выполнить задание 1 и 2
            Osa5_funktsioonid.ArrayList();

            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");

            Osa5_funktsioonid.List();
            Osa5_funktsioonid.LinkedList();
            Osa5_funktsioonid.Dictionary();
            Osa5_funktsioonid.Dictionary2();
        }
    }
}
