using System;



namespace my_p1
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                 int a = 2;
                int b = 3;
            
           
            int i = 5;
            int result = ++i + i++;
            Console.WriteLine(result);
            bool isTrue= false;
            Console.WriteLine(!isTrue);/*true*/
            int m = a * b;
            Console.WriteLine(m);/*6*/

            short biigInt = 32000;
            short biigInt1 = 32000;
            Console.WriteLine(biigInt + biigInt1);
           unchecked
            {
                short result1 = (short)(biigInt + short.Parse("32000"));
            }
            Console.WriteLine(a << b);/*16*/
            //2- 00000010=> 00010000

            var now = DateTime.Now;
            Console.WriteLine(now);/**/
            Console.WriteLine(now.Year - 1);/**2021*/
            var yesterday = now.AddDays(-1);/*4*/
             
        }
        }
    }

