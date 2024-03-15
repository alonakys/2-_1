using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var filterDelegate = new Func<int, bool>(n => n % k == 0);
            int[] newArray1 = FilterWithWhere(originalArray, filterDelegate);
            int[] newArray2 = FilterWithCustomImplementation(originalArray, filterDelegate);

            Console.WriteLine("Result using Where method:");
            PrintArray(newArray1);

            Console.WriteLine("\nResult using custom implementation:");
            PrintArray(newArray2);
        }

        static int[] FilterWithWhere(int[] array, Func<int, bool> filter)
        {
            return array.Where(filter).ToArray();
        }

        static int[] FilterWithCustomImplementation(int[] array, Func<int, bool> filter)
        {
            int count = 0;

            foreach (int value in array)
            {
                if (filter(value))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            foreach (int value in array)
            {
                if (filter(value))
                {
                    result[index++] = value;
                }
            }

            return result;
        }

        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }
    }
}