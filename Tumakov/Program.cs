using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Solution 2.1");
            Console.WriteLine("Hello! What is your name?");    ///Вывод
            string a = Console.ReadLine();
            Console.WriteLine($"Hello,{a}!");

            Console.WriteLine();

            Console.WriteLine("Solution 2.2");
            Console.WriteLine("Put in the first number, than the second");
            float a1 = int.Parse(Console.ReadLine());
            float b1 = int.Parse(Console.ReadLine());
            float c1 = a1 / b1;
            if (b1 == 0) {
                Console.WriteLine("Mistake. You can't use 0 as the second number"); 
                    }
            else { 
                Console.WriteLine($"Result: {c1}");
                    }

            Console.WriteLine();

            Console.WriteLine("Solution HomeWork 2.1");
            Console.WriteLine("Please, put the letter in");
            char a2 = char.Parse(Console.ReadLine());
            a2++;
            Console.WriteLine($"Next letter is: {a2}");

            Console.WriteLine();

            Console.WriteLine("Упражнение 2.2");
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
            Console.ReadLine();
        }
    }
}
