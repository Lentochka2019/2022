using System;

namespace lesson_3_conditional_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool result;
            Console.WriteLine("Ввести перше число");
            string inputX = Console.ReadLine();
            result = int.TryParse(inputX, out var x);
            if (result == true)
            {
                Console.WriteLine("Ввести друге число");
                string inputY = Console.ReadLine();
                result = int.TryParse(inputY, out var y);
                if (result == true)
                {
                    Console.Write("Sum=");
                    if (x == y) sum = x;
                    else
                    {
                        int max_zx = Math.Max(x, y);
                        int min_zn = Math.Min(x, y);
                        for (int i = min_zn; i <= max_zx; i++)
                        {
                            sum = sum + i;
                            if (i < max_zx) { Console.Write($"{i}+"); }
                            else { Console.Write(i); }
                        }
                        Console.Write("=");
                    }
                    Console.Write($"{sum}");
                }
                else
                    Console.WriteLine("Помилка коли вводимо Y");
            }
            else
                Console.WriteLine("Помилка коли вводимо X");
        }
    }
}
