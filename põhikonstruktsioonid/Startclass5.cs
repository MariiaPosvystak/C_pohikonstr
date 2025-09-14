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
            //Osa5_funktsioonid.ArrayList();

            //Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            //Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");

            //Osa5_funktsioonid.List();
            //Osa5_funktsioonid.LinkedList();
            //Osa5_funktsioonid.Dictionary();
            //Osa5_funktsioonid.Dictionary2();

            //Завдання:
            //Створити два класи:
            //+Toode– характеристики: Nimi,Kalorid100g
            //+Inimene– характеристики: Nimi, , Vanus, Sugu, Pikkus, Kaal,Aktiivsustase
            //Складіть програму, яка:
            //Зчитує Toodeоб'єкти з файлу або вручну додає їх до списку.
            //Запитує дані у користувача та розраховує добову потребу в енергії за формулою Гарріса - Бенедикта.
            //Надає користувачеві список продуктів, де для кожного продукту розраховується, скільки його слід з'їдати на день (г), щоб покрити потреби в калоріях.
            //💡 Порада: поділивши калорії на калорії на 100 г = кількість у грамах.

            Console.WriteLine("1. Ülesanne");
            Console.WriteLine("Tere tulemast kalorite kalkulaatorisse!");
            
            Toode.SalvestaTootedFaili();
            Inimene_k.SisestaAndmed();
        }
    }
}
