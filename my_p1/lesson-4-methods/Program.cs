using System;

namespace lesson_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine($"Max value by method 1: {ValMax(3, 5)}");
            ValMax(3,5,7);
            ValMax(3, 5, 7,6);
            Console.WriteLine($"Min value by method 1: {ValMin(3, 5)}");
            Console.WriteLine($"Min value by method 2: {ValMin(10, 5, 7)}");
            Console.WriteLine($"Min value by method 3: {ValMin(1, 5, 7, 4)}");
            Console.WriteLine(TrySumIfOdd(5,8,out bool rez));
            Console.Write("Extra ex: ");
            Console.WriteLine(Repeat("abc",2,out string str));
=======
            Console.WriteLine($"Max value:{ValMax(3, 5)}");
            Console.WriteLine($"Min value:{ValMin(3, 5)}");
            Console.WriteLine(TrySumIfOdd(5, 8, out bool rez));
            Console.WriteLine("Extra ex: ");
            Console.WriteLine(Repeat("abc", 2));
>>>>>>> origin/issue-repeat
            Console.ReadKey();
        }
        /*Завдання 1 та 2 Визначення максимального та мінімального значення*/
        /*Максимально знаходжу через Math.Max та цикл*/
        static int ValMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        static void ValMax(params int[] znach)
        {
            int max = znach[0];
            
            for (int i = 1; i < znach.Length; i++)
            {
             
                if (znach[i] > max)
                    max = znach[i];
            }
            Console.WriteLine($"Max value by method 2: {max}");

        }

        /*Мінімальне через Math.Min та рекурсію*/
        static int ValMin(int a, int b)
        { return Math.Min(a, b); }
        static int ValMin(int a, int b,int c)
        {
            return Math.Min(ValMin(a,b),c);

        }
        static int ValMin(params int[] znach)
        {
            int min = znach[0];
            if(znach.Length==1) return znach[0];
            else return ValMin(min,znach[znach.Length-1]);
        }


        /*Завдання 3*/
<<<<<<< HEAD
        static bool TrySumIfOdd(int c,int d,out bool rezSum)
=======
        static bool TrySumIfOdd(int c, int d, out bool rezSum)
>>>>>>> origin/issue-repeat
        {
            int sum = c + d;
            Console.WriteLine($"Sum: {sum}");
            rezSum = true;
            if (sum % 2 == 0) return rezSum = true;
            else return rezSum = false;

        }
<<<<<<< HEAD
        /*Завданя 4 Рекурсія метод Repeat*/
        static string Repeat(string X, int N, out string stroka)
=======
        /*Завданя 4Рекурсія метод Repeat*/
        static string Repeat(string X, int N)
>>>>>>> origin/issue-repeat
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
