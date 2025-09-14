//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace põhikonstruktsioonid
//{
//    class Startclass3
//    {
//        public static void Main(string[] args)
//        {
//            //Random rnd = new Random();
//            //Console.OutputEncoding = Encoding.UTF8;

//            ////3.Osa Massiivid, List, Kordused
//            ////выолнить задания и перепроверить
//            //List<string> nimed = new List<string>();
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.Write($"{i + 1}. Nimi: ");
//            //    nimed.Add(Console.ReadLine());
//            //}
//            //foreach (string nimi in nimed)
//            //{
//            //    Console.WriteLine(nimi);
//            //}

//            //int[] arvud = new int[10];
//            //int j = 0;
//            //while (j < 10)
//            //{
//            //    Console.WriteLine(j + 1);
//            //    arvud[j] = rnd.Next(1, 101);
//            //    j++;
//            //}
//            //foreach (int arv in arvud)
//            //{
//            //    Console.WriteLine(arv);
//            //}

//            //List<Isik> isikud = new List<Isik>();
//            //j = 0;
//            //do
//            //{
//            //    Console.Write(j + 1);
//            //    Isik isik = new Isik();
//            //    Console.Write(". Eesnimi: ");
//            //    isik.eesnimi = Console.ReadLine();
//            //    isikud.Add(isik);
//            //    j++;
//            //} while (j < 10);
//            //isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
//            //Console.WriteLine($"Kokku on: {isikud.Count()} isikud");
//            //foreach (Isik isik in isikud)
//            //{
//            //    isik.Prindi_andmed();
//            //}
//            //Console.WriteLine($"Kolmandal kohal on: {isikud[2]} isik");

//            //1. Ülesanne - Квадраты случайных чисел
//            //Задание:
//            //Создайте класс ArvuTöötlus с методом GenereeriRuudud(int min, int max), который:
//            //Генерирует 2 случайных целых числа в диапазоне[-100, 100] → N и M,
//            //Находит все целые числа между ними(от меньшего к большему),
//            //Возвращает массив, где каждое значение — квадрат соответствующего числа.
//            //В методе Main выведите все результаты вместе с исходным значением(например, "4 → 16").
//            //int[] arv = new int[10];
//            //int min = -100;
//            //int max = 100;
//            //int N = rnd.Next(min, max);
//            //Console.WriteLine(N);
//            //int M = rnd.Next(min, max);



//            //2. Ülesanne - Анализ пяти чисел
//            //Задание:
//            //Создайте метод AnalüüsiArve(double[] arvud), который:
//            //Принимает массив в качестве входных данных(пользователь вводит через метод Tekstist_arvud()),
//            //Возвращает кортеж Tuple<double, double, double> — сумма, среднее, произведение,
//            //Выводит результат в удобном формате.
//            //double[] arvud = Osa3_funktsioonid.Tekstist_arvud();
//            //var tulemus = Osa3_funktsioonid.AnalüüsiArve(arvud);
//            //Console.WriteLine();

//            //3. Ülesanne - Имена и возраст
//            //Задание:
//            //Создайте класс Inimene с полями { string Nimi; int Vanus; }.
//            //Создайте метод Statistika(List < Inimene > inimesed), который:
//            //Вычисляет сумму и средний возраст всех,
//            //Находит самого старого и самого младшего человека,
//            //Возвращает значения в кортеже Tuple<int, double, Inimene, Inimene>.
//            //Пользователь вводит 5 человек(имя и возраст отдельно).

//            //List<Inimene> inimesed = new List<Inimene>();
//            //int l = 0;
//            //do
//            //{
//            //    Console.WriteLine(l + 1);
//            //    Inimene inimene = new Inimene();
//            //    Console.Write("Nimi: ");
//            //    inimene.nimi = Console.ReadLine();
//            //    Console.Write("Vanus: ");
//            //    try
//            //    {
//            //        inimene.vanus = int.Parse(Console.ReadLine());
//            //    }
//            //    catch (FormatException)
//            //    {
//            //        Console.WriteLine("Palun sisesta korrektne vanus");
//            //        continue;
//            //    }
//            //    inimesed.Add(inimene);
//            //    l++;
//            //} while (l < 5);
//            //var statistika = Inimene.Statistika(inimesed);
//            //Console.WriteLine($"Kõigi inimeste vanuste summa: {statistika.Item1}");
//            //Console.WriteLine($"Keskmine vanus: {statistika.Item2:F2}");
//            //Console.WriteLine($"Vanim inimene: {statistika.Item3}");
//            //Console.WriteLine($"Noorim inimene: {statistika.Item4}");


//            //4. Ülesanne - "Купи слона!"
//            //Задание:
//            //Сделайте метод повторного ввода KuniMärksõnani(string märksõna, string fraas), который:
//            //Запрашивает ввод пользователя до тех пор, пока введённое не будет точно совпадать с ключевым словом,
//            //Перед каждым вводом выводит фразу,
//            //Все введённые значения сохраняет и выводит в конце.

//            //Console.Write("Sisesta märksõna: ");
//            //Console.WriteLine();

//            //5. Ülesanne - Игра угадай число
//            //Задание:
//            //Компьютер выбирает случайное число от 1 до 100.
//            //Пользователю даётся 5 попыток.
//            //Создайте метод ArvaArv(), который:
//            //При каждой попытке сообщает, число слишком большое, слишком маленькое или правильное,
//            //Игра заканчивается при угадывании или после 5 попыток.
//            //Дополнительно: после игры спрашивайте, хочет ли пользователь сыграть снова.

//            //Random rn = new Random();
//            //int arv = rn.Next(0, 100);
//            //Console.WriteLine(Osa3_funktsioonid.ArvaArv(arv));


//            //6. Ülesanne - Наибольшее четырёхзначное число
//            //Задание:
//            //Попросите пользователя ввести 4 числа(например, 1, 5, 7, 3).
//            //Цель: составить из них наибольшее возможное четырёхзначное число(1573).
//            //Создайте метод SuurimNeljarv(double[] arvud), который:
//            //Проверяет, что введённые значения — однозначные целые числа(0–9),
//            //Комбинирует их в максимально возможное четырёхзначное число.

//            //int[] arvud = new int[4];
//            //for (int i = 0; i < 4; i++)
//            //{
//            //    Console.Write("Sisesta üks arv: ");
//            //    Console.ReadLine();
//            //}
//            //Console.WriteLine(Osa3_funktsioonid.SuurimNeljarv(arvud));

//            //7. Ülesanne - Таблица умножения
//            //Задание:
//            //Напишите метод GenereeriKorrutustabel(int ridadeArv, int veergudeArv), который:
//            //cоздаёт и выводит таблицу умножения в заданных пользователем пределах,
//            //Использует красивое форматирование с выравниванием(например, PadLeft, String.Format).
//            //Бонус: сохраняет результаты в двумерный массив int[,]
//            //и позволяет потом искать любое значение(например, "какое число в 7 x 8?").



//            //8. Ülesanne - Работа с учениками
//            //Дан массив из 10 имён учеников.
//            //Напишите программу, которая:
//            //Заменяет имена 3 - го и 6 - го учеников на "Kati" и "Mati",
//            //Использует цикл while, чтобы приветствовать только тех учеников,
//            //чьё имя начинается с буквы "A",
//            //Использует цикл for, чтобы вывести все имена и их индексы,
//            //Использует цикл foreach, чтобы вывести все имена в нижнем регистре,
//            //Использует цикл do -while, чтобы приветствовать учеников,
//            //пока не встретится имя "Mati".

//            //List<string> nimed = new List<string>();
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.Write($"{i + 1}. Nimi: ");
//            //    nimed.Add(Console.ReadLine());
//            //}
//            //while (nimed == )
//            //{
//            //    Console.WriteLine(nimed);
//            //}
//            //foreach (string nimi in nimed)
//            //{
//            //    Console.WriteLine(nimi);
//            //}
//        }
//    }
//}
