using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Fadeeva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задание 1");
            Console.WriteLine($"Число е - {2.7}");

            Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine();

            Console.WriteLine("Задание 3");
            Random rnd = new Random();
            int a = rnd.Next();
            int a1 = rnd.Next();
            int a2 = rnd.Next();
            int a3 = rnd.Next();
            Console.WriteLine(a);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Console.WriteLine();

            Console.WriteLine("Задание 4");
            int b = int.Parse(Console.ReadLine());
            b = b + 10;
            Console.WriteLine($"Искомое число = {b}");

            Console.WriteLine();

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите сторону квадрату:");
            int b1 = int.Parse(Console.ReadLine());
            int s = 4 * b1;
            Console.WriteLine($"Периметр квадрата = {s}");

            Console.WriteLine(); 

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите радиус окружности:");
            int b2 = int.Parse(Console.ReadLine());
            double s1 = 2 * Math.PI * b2;
            double s2 = Math.PI * b2 * b2;
            Console.WriteLine($"Длина круга = {Math.Round(s1, 2)}, Площадь круга = {Math.Round(s2, 2)}");

            Console.WriteLine();

            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите значение х:");
            int x = int.Parse(Console.ReadLine());
            double x1 = Math.Cos(x);
            Console.WriteLine($"Значение косинуса y = {Math.Round(x1, 2)}");

            Console.WriteLine();
            

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите нижнее основание трапеции:");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнее основание трапеции:");
            int w1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции:");
            int w3 = int.Parse(Console.ReadLine());
            double w2 = Math.Sqrt(((w -  w1)/2) * ((w -  w1)/2) + w3 * w3);
            double w4 = 2 * w2 + w + w1;
            Console.WriteLine($"Периметр трапеции = {w4}");

            Console.WriteLine();

            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите цену за 1 кг конфет:");
            int kon = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за 1 кг печенья:");
            int pec = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за 1 кг яблок:");
            int apple = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько кг конфет купили:");
            int kon1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько кг печенья купили:");
            int pec1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько кг яблок купили:");
            int apple1 = int.Parse(Console.ReadLine());
            double itogo = kon*kon1 + pec*pec1 + apple*apple1;
            Console.WriteLine($"Итоговая цена = {itogo}");
            


            Console.WriteLine();

            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");

            Console.WriteLine();

            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите 2 числовые переменные");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            Console.Write(second);
            Console.Write($" {first}");


            Console.ReadLine(); */

            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите Треугольник, Четырехугольник или Круг");
            string rand = Console.ReadLine();
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Площадь или Периметр");
            string rand1 = Console.ReadLine();
            string treug = "Треугольник";
            string chetyreh = "Четырехугольник";
            string krug = "Круг";
            string plo = "площадь";
            string per = "периметр";
            if ((rand == treug) & (rand1 == plo)) {
                 double ss = 0.5*side*side;
                Console.WriteLine($"Площадь треугольника = {ss}");
            }
            if ((rand == treug) & (rand1 == per))
            {
                double ss = side * 3;
                Console.WriteLine($"Периметр треугольника = {ss}");
            }
            if ((rand == chetyreh) & (rand1 == plo))
            {
                double ss = side * side;
                Console.WriteLine($"Площадь четырёхугольника = {ss}");
            }
            if ((rand == chetyreh) & (rand1 == per))
            {
                double ss = side * 4;
                Console.WriteLine($"Периметр четырёхугольника = {ss}");
            }
            if ((rand == krug) & (rand1 == plo))
            {
                double ss = side * side * Math.PI;
                Console.WriteLine($"Площадь круга = {ss}");
            }
            if ((rand == krug) & (rand1 == per))
            {
                double ss = 2 * Math.PI * side;
                Console.WriteLine($"Длина окружности = {ss}");
            } Console.ReadLine(); /*
            

            Console.WriteLine();

            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите число:");
            string chisl = Console.ReadLine();
            Console.WriteLine($"Вы ввели число: {chisl}");

            Console.WriteLine(); 

            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine();

            Console.WriteLine("Задание 15");
            Random rnd = new Random();
            int a = rnd.Next();
            int a1 = rnd.Next();
            int a2 = rnd.Next();
            int a3 = rnd.Next();
            Console.WriteLine(a);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3); 

            Console.WriteLine();

            Console.WriteLine("Задание 16");
            Console.WriteLine("Введите коэффициенты:");
            Console.WriteLine("Введите a:");
            float a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            float b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите c:");
            float c3 = int.Parse(Console.ReadLine());
            float dis = b3 * b3 - 4 * a3 * c3;
            if (dis > 0)
            {
                double x1 = ((-b3) + Math.Sqrt(dis)) / (2 * a3);
                double x2 = ((-b3) - Math.Sqrt(dis)) / (2 * a3);
                Console.WriteLine($"Корни уравнения: {x1} и {x2}");
            }
            if (dis == 0)
            {
                double x1 = (-b3) / (2 * a3);
                Console.WriteLine($"Корни уравнения: {x1}");
            }
            if (dis < 0)
            {
                Console.WriteLine($"Корни уравнения отсутсвуют");
            }

            Console.WriteLine();

            Console.WriteLine("Задание 17");
            Console.WriteLine("Введите 1 число");
            int chisl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int chisl2 = int.Parse(Console.ReadLine());
            int chisl3 = (chisl1 + chisl2) / 2;
            double chisl4 = Math.Sqrt(chisl1 * chisl2);
            Console.WriteLine($"Среднее арифметическое = {chisl3}");
            Console.WriteLine($"Среднее геометрическое = {chisl4}"); 

            Console.WriteLine();

            Console.WriteLine("Задание 18");
            Console.WriteLine("Введите х1 координату");
            int chislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите у1 координату");
            int chislo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите х2 координату");
            int chislo11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите у2 координату");
            int chislo22 = int.Parse(Console.ReadLine());
            double chisl4 = Math.Sqrt((chislo1 - chislo11) * (chislo1 - chislo11) + (chislo2 - chislo22) * (chislo2 - chislo22));
            Console.WriteLine($"Расстояние между точками: {chisl4}");

            Console.WriteLine();

            Console.WriteLine("Задание 19");
            Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            int c = int.Parse(Console.ReadLine());
            int d = a;
            a = b;
            b = c;
            c = d;
            Console.WriteLine($"a) a={a} b={b} c={c}");
            Console.WriteLine("Введите a");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            int c1 = int.Parse(Console.ReadLine());
            int d1 = a1;
            a1 = c1;
            c1 = b1;
            b1 = d1;
            Console.WriteLine($"b) a={a1} b={b1} c={c1}");

            Console.WriteLine();

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите n - количество секунд");
            int n = int.Parse(Console.ReadLine());
            int chas = n / 3600;
            int chas1 = (n - (chas * 3600)) / 60;
            int chas2 = (n - (n / 60) * 60);
            Console.WriteLine($" a)Количество полных часов={chas}  b) Количество минут с прошлого часа={chas1}  c) Количество секунд с прошлой минуты={chas2}");
            Console.ReadLine(); 

            Console.WriteLine();

            Console.WriteLine("Задание 21");
            Console.WriteLine("Дан прямоугольник со сторонами 543*130");
            int plosh1 = 543 * 130;
            int plosh2 = 130 * 130;
            int kolvo = plosh1 / plosh2;
            Console.WriteLine($"Количество целых квадратов={kolvo}");
            Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Задание 23");
            Console.WriteLine("Введите натуральное число n>999");
            int n = int.Parse(Console.ReadLine());
            int del1 = n/100;
            int del2 = n / 1000;
            Console.WriteLine($"Количество сотен={del1}  Количество тысяч={del2}");
            Console.ReadLine(); 

            Console.WriteLine();

            Console.WriteLine("Задание 22");
            Console.WriteLine("Введите натуральное число 1000>n>99");
            int n = int.Parse(Console.ReadLine());
            int del1 = (n / 100);
            int del2 = (n - del1*100) / 10;
            int del3 = n - del1*100 - del2 * 10;
            int del4 = del3 * 100 + del1 * 10 + del2;
            Console.WriteLine($"Новое число={del4}");
            Console.ReadLine(); 

            Console.WriteLine();

            Console.WriteLine("Задание 24");
            Console.WriteLine("Введите натуральное число 10000>n>999");
            int n = int.Parse(Console.ReadLine());
            int del1 = (n / 1000);
            int del2 = (n - del1 * 1000) / 100;
            int del3 = (n - del1 * 1000 - del2 * 100) / 10;
            int del4 = n - del1 * 1000 - del2 * 100 - del3 * 10;
            int del5 = del4 * 1000 + del3 * 100 + del2 * 10 + del1;
            Console.WriteLine($"a) Новое число={del5}");
            int del6 = del2 * 1000 + del1 * 100 + del4 * 10 + del3;
            Console.WriteLine($"b) Новое число={del6}");
            int del7 = del1 * 1000 + del3 * 100 + del2 * 10 + del4;
            Console.WriteLine($"c) Новое число={del7}");
            int del8 = del4 * 1000 + del3 * 100 + del2 * 10 + del1;
            Console.WriteLine($"d) Новое число={del8}");
            Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Задание 25");
            Console.WriteLine("Введите натуральное число 100>n>99");
            int n = int.Parse(Console.ReadLine());
            int ch666 = n / 100;
            int chislo = n - ch666*100;
            int chislo1 = chislo * 10;
            int chislo2 = chislo1 + ch666;
            Console.WriteLine($"Искомое х = {chislo2}");
            Console.ReadLine();

            Console.WriteLine("Задание 26");
            Console.WriteLine("Введите h - количество часов");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m - количество минут");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите s - количество секунд");
            int s = int.Parse(Console.ReadLine());
            int degr = ((h * 60 + m)/12)*6;
            if (degr > 360)
            {
                int degr1 = degr - 360;
                Console.WriteLine($"Угол между начальным и конечным положением = {degr1} градусов");
            }
            else
            {
                Console.WriteLine($"Угол между начальным и конечным положением = {degr} градусов");
            }

                Console.ReadLine(); 
            Console.WriteLine("Задание 29");
            Console.WriteLine("Введите a - первое число");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b - второе число");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c - третье число");
            double c = int.Parse(Console.ReadLine());
            double min = Math.Min(Math.Min(a, b), c);
            double max = Math.Max(Math.Max(a, b), c);
            double summa = min + max;
            Console.WriteLine($"Сумма минимума и максимума равна = {summa}"); 

            Console.WriteLine("Задание 28");
            Console.WriteLine("Введите a - первое число");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b - второе число");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c - третье число");
            double c = int.Parse(Console.ReadLine());
            double a1 = Math.Abs(a);
            double b1 = Math.Abs(b);
            double c1 = Math.Abs(c);
            double min = Math.Min(Math.Min(a1, b1), c1);
            Console.WriteLine($"Mинимум = {min}");
            Console.ReadLine(); 

            Console.WriteLine("Задание 30");
            Console.WriteLine("Введите a - число, у которого необходимо посчитать количество делителей");
            int a = int.Parse(Console.ReadLine());
            int kolvo = 0;
            for (int i = 1; i*i  <= a; i++)
            {
                if (a%i == 0)
                {
                    if (i*i != a)
                    {
                        kolvo += 2;
                    }
                    if (i*i == a)
                    {
                        kolvo++;
                    }
                }
            }
            Console.WriteLine($"Количество делителей = {kolvo}");
            Console.ReadLine(); 



            Console.WriteLine("Задание 31");
            Console.WriteLine("Введите a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите d ");
            int d = int.Parse(Console.ReadLine());
            for (int x = -100; x <= 100; x++)
            {
              if ((a*x*x*x+b*x*x+c*x+d)==0)
                {
                    Console.WriteLine($"Корень уравнения = {x}");
                }

            }
            Console.ReadLine();

            Console.WriteLine("Задание 32");
            Console.WriteLine("Введите a1 ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a2 ");
            int a2 = int.Parse(Console.ReadLine());
            int d = a2 - a1;
            Console.Write("Введите номер члена прогрессии: - ");
            int n = int.Parse(Console.ReadLine());
            int an = a1 + (n - 1) * d;
            Console.WriteLine($"Член прогрессии равен = {an}");
            Console.ReadLine(); 

            Console.WriteLine("Задание 33");
            Console.WriteLine("Кто я? Студент,пенсионер, трудоустроен или не трудоустроен ");
            string p = Console.ReadLine();
            string a1 = "студент";
            string a2 = "пенсионер";
            string a3 = " не трудоустроен";
            string a4 = " трудоустроен";
            if (p == (a1 + a3)) 
            {
                Console.WriteLine("Получаю кредит");
            }
            if (p == (a2 + a3))
            {
                Console.WriteLine("Получаю кредит");
            }
            if (p == (a1 + a4))
            {
                Console.WriteLine("Не получаю кредит");
            }
            if (p == (a2 + a4))
            {
                Console.WriteLine("Не получаю кредит");
            }
            if (p == (a1 + a2))
            {
                Console.WriteLine("Не получаю кредит");
            }
            string e = a1 + a2;
            Console.ReadLine();

            Console.WriteLine("Задание 34");
            Console.WriteLine("Введите своё имя: ");
            string p = Console.ReadLine();
            Console.WriteLine($"a) Ваше имя - {p}");
            Console.WriteLine($"b) Привет, {p}!");
            Console.ReadLine(); 
            */
        }
    }
    
}
    
