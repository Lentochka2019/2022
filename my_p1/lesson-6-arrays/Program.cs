using System;

namespace lesson_6_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 2, 1, 4, 5 };
           
            
            Console.Write("Array: ");
            foreach (int item in InitArray(array))
            {
                Console.Write($" {item},");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Bubble sort");
            foreach (int item in SortBubble(array))
            { Console.Write($" {item},"); }
            Console.WriteLine("\n");

           

            Console.WriteLine("selection sort");
            Console.WriteLine("Insertion");
        }
        static int[] InitArray(int[] array)
        {
           
            for(int i = 0; i < array.Length; i++)
            { array[i] = array[i]; }
            return array;
        } 
        static int[] SortBubble(int[] array)
        {
            int temp;
            for(int i = 0; i < array.Length; i++)
            { for(int j=i+1;j<array.Length; j++)
                {
                    if(array[i]>array[j])
                    {
                        temp= array[i];
                        array[i]=array[j];
                        array[j]=temp;
                    }
                }
            
            }
            return array;
        }
       

    }
}
