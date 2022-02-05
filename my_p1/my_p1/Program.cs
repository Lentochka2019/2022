using System;



namespace my_p1
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                // int n1 = 5;
                //int n2 = 10;
                Console.Write("Значення1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Значення2: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int maxVar = Math.Max(n1, n2);
                Console.WriteLine($"Найбiльше значення: {maxVar}");


            }
        }
    }

