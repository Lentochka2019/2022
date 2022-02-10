using System;

namespace lesson_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max value:{ValMax(3, 5)}");
            Console.WriteLine($"Min value:{ValMin(3, 5)}");
            Console.WriteLine(TrySumIfOdd(5, 8, out bool rez));
            Console.WriteLine("Extra ex: ");
            Console.WriteLine(Repeat("abc", 2));
            Console.ReadKey();
        }
        static int ValMax(int a, int b)
        { return Math.Max(a, b); }
        static int ValMin(int a, int b)
        { return Math.Min(a, b); }


        /*Завдання 3*/
        static bool TrySumIfOdd(int c, int d, out bool rezSum)
        {
            int sum = c + d;
            Console.WriteLine($"Sum: {sum}");
            rezSum = true;
            if (sum % 2 == 0) return rezSum = true;
            else return rezSum = false;

        }
        /*Завданя 4Рекурсія метод Repeat*/
        static string Repeat(string X, int N)
        {
            if (N == 1)
            {
                Console.WriteLine($"Отладка [N = {N}]: {X}");
                return X;
            }
            else
            {
                string stroka = X + Repeat(X, N - 1);
                Console.WriteLine($"Отладка [N = {N}]: {stroka}");
                return stroka;
            }
        }


    }
}
