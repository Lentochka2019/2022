using System;

namespace lesson_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max value:{ValMax(3, 5)}");
            Console.WriteLine($"Min value:{ValMin(3, 5)}");
        }
        static int ValMax(int a, int b)
        { return Math.Max(a, b); }
        static int ValMin(int a, int b)
        { return Math.Min(a, b); }
    }
}
