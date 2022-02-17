using System;

namespace lesson_6_arrays
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             int[] array = new int[] { 6, 8, 1, 4, 5 };
            int[] array1 = new int[] { 6, 2, 6, 4, 5 };
            int[] array2 = new int[] { 6, 2, 6, 4, 5 };


            int[] array3 = new int[] { 6, 2, 10, 4, 5 };


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
            foreach (int item in SortSelection(array1))
            {
                Console.Write($" {item},");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Insertion");
            foreach (int item in SortIn(array2))
            {
                Console.Write($" {item},");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Array3:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i] + " ");
            }
            Console.WriteLine("Select sort order (ask or desk) ");
            string methodSort = Console.ReadLine();
          
            
           
            array3 =SortAskDesk(array3,methodSort);

            foreach (int item in array3)
            {
                Console.Write($" {item},");
            }

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
        static int[] SortSelection(int[] array)
        {
            int temp;
            int min;
            for (int i = 0; i < array.Length; i++)
            {
                min = i;
               // Console.WriteLine(min);
                for (int j = i; j < array.Length; j++)
                {
                  //  Console.WriteLine($"array[j]: {array[j]}, min: {array[min]}");
                    if (array[j] < array[min])
                    {
                        min = j; 
                       
                    }
                }
                if (array[min] == array[i]) 
                    continue;
               
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;

            }
            return array;
        }
        static int[] SortIn(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int key = array[i];
                int j = i - 1;

                 while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

            return array;
        }

        /**/
        static void swap( ref int firstEl, ref int secondEl)
        {
            int temp;
            temp = firstEl;
            firstEl = secondEl;
            secondEl = temp;

        }

        static int[] SortAskDesk(int[] array, string method_sort)
        {if(method_sort!="ask" && method_sort!="desk") { Console.WriteLine("Select sort order (ask or desk) ");  method_sort = Console.ReadLine(); }
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (method_sort == "ask")
                    {
                        if (array[i] > array[j])
                        {

                            swap(ref array[i], ref array[j]);
                        }
                    }
                    else if (method_sort == "desk")
                    {
                        if (array[i] < array[j])
                        {
                            swap(ref array[i], ref array[j]);
                        }

                    }
                    else method_sort = "ask";
                }
            }

            return array;
        }



    }
}