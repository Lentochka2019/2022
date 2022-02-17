using System;
using System.Text;

namespace lesson_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Serhii";
            string hisName = "Alex";
            Console.WriteLine("Hello " + name);
            Console.WriteLine(string.Format("Hello {0} and {1}", name, hisName));//hello Serhii and Alex

            var hello = $"Hello {name} and {hisName}";

            Console.WriteLine(hello.Contains("hii")); //true

            var helloPlaceholder = "Hello ";
            var index = helloPlaceholder.IndexOf(' ');//5

            Console.WriteLine(helloPlaceholder.Insert(index + 1, name)); //hello Serhii
            Console.WriteLine($"hello {name}".Replace(name, hisName));//hello Alex

            Console.WriteLine(hello.PadLeft(40));//добавили пробелы
            Console.WriteLine(hello.PadLeft(40).Trim());//убрали пробелы
            Console.WriteLine(hello.ToLower());//перевод в нижний регистр
            Console.WriteLine(hello.ToUpper());//перевод в верхнийрегистр

            Console.WriteLine(string.Compare("abc","bdc"));//сортировка строк

            Console.WriteLine("Hello " + name);

            var emptyString = string.Empty;
            const int N = 1000;

           

            for (int i = 0; i < N;i++)
            {
                emptyString += $" {i}";
            }

            var stringBuilder = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                stringBuilder.AppendFormat(" {0}",i);
            }

            Console.WriteLine(stringBuilder.ToString());//віделяет память тольк тогда, когда добавляется єлемент строки
            Console.WriteLine(emptyString);//сразу віделяет большой обїем памяти


        }
    }
}
