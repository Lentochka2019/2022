using System;

namespace lessondatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            int n2 = 6;
            Console.WriteLine($"Дано значення: {n1} та {n2}");
            int maxVar = Math.Max(n1, n2);
            Console.WriteLine($"Найбiльше значення: {maxVar}");
            Console.WriteLine($"Рахуємо приклад при значеннi: {n1}");
            var n3 = -6 * Math.Pow(n1, 3) + 5 * Math.Pow(n1, 2) - 10 * n1 + 15;
            Console.WriteLine($"-6*x^3+5*x^2-10*x+15= {n3}");
            double x = -1;
            Console.WriteLine($"Рахуємо два приклади при значеннi: {x}");
            x = Math.Abs(x) * Math.Sin(x);
            Console.WriteLine($"abs(x) * sin(x)= {x}");
            x = 2 * Math.PI * x;
            Console.WriteLine($"2 * pi * x= {x}");

            /*Функция даты*/
            DateTime ny2022 = new DateTime(DateTime.Today.Year, 1, 1);
            TimeSpan dateFromNy = DateTime.Today - ny2022;
            Console.WriteLine($"Пiсля нового року пройшло {dateFromNy.Days} днiв");

            DateTime ny2023 = new DateTime(DateTime.Today.Year+1, 1, 1);
            TimeSpan dateToNy = ny2023 - DateTime.Today;
            Console.WriteLine($"До нового року залишилося {dateToNy.Days} днiв");


        }
    }
}
