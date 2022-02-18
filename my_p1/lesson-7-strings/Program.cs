using System;

namespace lesson_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method returns true if 2 strings are equal, otherwise false");
            Console.WriteLine("Input first string: ");

            string str1 = Console.ReadLine();

            Console.WriteLine("Input second string: ");

            string str2 = Console.ReadLine();

            Console.WriteLine(Compare(str1, str2));
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Method returns number of alphabetic chars in first string, digits and another special characters");

            Analyze(str1, out int num1, out int num2, out int num3);
            Console.WriteLine($"Alphabetic chars: {num1}");
            Console.WriteLine($"Digits: {num2}");
            Console.WriteLine($"Another special characters: {num3}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Method returns string sorted in alphabetical order");
            Console.WriteLine("Input string: ");

            string str3 = Console.ReadLine();
            Console.WriteLine(Sort(str3));

            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Method returns array of characters that are duplicated in input string");
            Console.WriteLine("Input string: ");

            string str4 = Console.ReadLine();

            Console.WriteLine(Duplicate(str4));
            Console.ReadKey();
        }
        static bool Compare(string str1, string str2)
        {
            bool rez = (str1 == str2) ? true : false;
            return rez;
        }

        static int Analyze(string str, out int numAlp, out int numStr, out int numSpecChar)
        {
            numAlp = 0;
            numStr = 0;
            numSpecChar = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    numAlp++;
                }
                else if (Char.IsDigit(str[i]))
                {
                    numStr++;
                }
                else
                {
                    numSpecChar++;
                }
            }
            return 0;

        }
        static string Sort(string str)
        {
            char temp;
            string strLow = str.ToLower();
            char[] charstr = strLow.ToCharArray();
            for (int i = 0; i < charstr.Length - 1; i++)
            {

                for (int j = i + 1; j < charstr.Length; j++)
                {

                    if (charstr[i] > charstr[j])
                    {
                        temp = charstr[i];
                        charstr[i] = charstr[j];
                        charstr[j] = temp;
                    }

                }
            }

            return new string(charstr);
        }
        static string DuplicateTemp(string str)
        {

            string strLow = str.ToLower();
            string string2 = string.Empty;

            for (int i = 0; i < strLow.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {

                    if (strLow[i] == strLow[j])
                    {
                        string2 += strLow[j];
                    }

                }

            }

            return string2;
        }
        static string Duplicate(string str)
        {
            str = DuplicateTemp(str);
            int i = 0;

            while (true)
            {
                var tmp = str[i].ToString();
                str = str.Replace(tmp, "");
                str = str.Insert(i, tmp);
                i++;
                if (str.Length - 1 < i)
                    break;
            }
            return str;
        }
    }
}
