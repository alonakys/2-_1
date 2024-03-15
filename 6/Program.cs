using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] allData = RecordData();
            foreach (var data in allData)
            {
                Console.WriteLine("Сортування вибором:");
                TestSorting(StandardSelection.Sort, StudentSelection.Sort, data);
                Console.WriteLine("Шейкерне сортування:");
                TestSorting(StandardShaker.Sort, StudentShaker.Sort, data);
            }

            Console.WriteLine("Кiнець сортування.");
            Console.ReadLine();
        }
        static int[][] RecordData()
        {
            Random random = new Random();
            int[][] allData = new int[3][];
            for (int i = 0; i < allData.Length; i++)
            {
                int size = random.Next(10000, 20000);
                allData[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    allData[i][j] = random.Next(10000);
                }
            }
            return allData;
        }
        //static int[][] RecordData()
        //{
        //    int[][] allData = new int[2][];
        //    for (int i = 0; i < allData.Length; i++)
        //    {
        //        string line = File.ReadAllLines($"file{i}.txt").First();
        //        string[] numbers = line.Split(", ");
        //        allData[i] = new int[numbers.Length];

        //        for (int j = 0; j < numbers.Length; j++)
        //        {
        //            allData[i][j] = int.Parse(numbers[j]);
        //        }
        //    }
        //    return allData;
        //}
        class StandardSelection
        {
            static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            public static int[] Sort(int[] originalData)
            {
                int[] data = new int[originalData.Length];
                Array.Copy(originalData, data, originalData.Length);
                for (int i = 0; i < data.Length - 1; i++)
                {
                    int min_index = i;
                    for (int j = i + 1; j < data.Length; j++)
                    {
                        if (data[j] < data[min_index])
                        {
                            min_index = j;
                        }
                    }
                    if (min_index != i)
                    {
                        Swap(ref data[i], ref data[min_index]);
                    }
                }
                return data;
            }
        }
        class StandardShaker
        {
            static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            public static int[] Sort(int[] originalData)
            {
                int[] data = new int[originalData.Length];
                Array.Copy(originalData, data, originalData.Length);
                for (var i = 0; i < data.Length / 2; i++)
                {
                    var swapFlag = false;
                    for (var j = i; j < data.Length - i - 1; j++)
                    {
                        if (data[j] > data[j + 1])
                        {
                            Swap(ref data[j], ref data[j + 1]);
                            swapFlag = true;
                        }
                    }

                    for (var j = data.Length - 2 - i; j > i; j--)
                    {
                        if (data[j - 1] > data[j])
                        {
                            Swap(ref data[j - 1], ref data[j]);
                            swapFlag = true;
                        }
                    }

                    if (!swapFlag)
                    {
                        break;
                    }
                }
                return data;
            }
        }

        class StudentSelection
        {
            public static int[] Sort(int[] originalData)
            {
                int[] data = new int[originalData.Length];
                Array.Copy(originalData, data, originalData.Length);
                int n = data.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    int min_idx = i;
                    for (int j = i + 1; j < n; j++)
                        if (data[j] < data[min_idx])
                            min_idx = j;
                    int temp = data[min_idx];
                    data[min_idx] = data[i];
                    data[i] = temp;
                    //Swap(ref min_idx, ref i);
                }
                return data;
            }
            static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;

            }
        }
        class StudentShaker
        {
            private static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            public static int[] Sort(int[] originalData)
            {
                int[] data = new int[originalData.Length];
                Array.Copy(originalData, data, originalData.Length);
                bool flag = false;
                while (!flag)
                {
                    int[] start = { 1, data.Length - 1 };
                    int[] end = { data.Length, 0 };
                    int[] inc = { 1, -1 };

                    for (int it = 0; it < 2; ++it)
                    {
                        flag = true;

                        for (int i = start[it]; i != end[it]; i += inc[it])
                        {
                            if (data[i - 1] > data[i])
                            {
                                Swap(ref data[i - 1], ref data[i]);
                                flag = false;
                            }
                        }

                        if (flag)
                            break;
                    }
                }
                return data;
            }
        }
        static void TestSorting(Func<int[], int[]> etalonSort, Func<int[], int[]> studentSort, int[] dataset)
        {
            int[] copy = new int[dataset.Length];
            Array.Copy(dataset, copy, dataset.Length);

            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] etalonSortedArray = etalonSort(copy);
            stopwatch.Stop();
            long etalonTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            int[] studentSortedArray = studentSort(copy);
            stopwatch.Stop();
            long studentTime = stopwatch.ElapsedMilliseconds;

            bool sortedCorrectly = IsArraySorted(etalonSortedArray, studentSortedArray);
            bool timeWithinBounds = IsTimeWithinBounds(etalonTime, studentTime);
            string result = sortedCorrectly && timeWithinBounds ? "Правильно" : "Неправильно";
            Console.WriteLine($"Сортування: {result}. Час студента: {studentTime} мс, час еталону: {etalonTime} мс");
        }
        static bool IsArraySorted(int[] etalon, int[] student)
        {
            if (etalon.Length == student.Length)
            {
                for (int i = 0; i < etalon.Length; i++)
                {
                    if (etalon[i] != student[i])
                        return false;
                }
                return true;
            }
            else
                return false;
        }
        static bool IsTimeWithinBounds(long etalonTime, long studentTime)
        {
            long lowerBound = Math.Max(0, etalonTime / 5 - 200);
            long upperBound = etalonTime * 5 + 200;

            return studentTime >= lowerBound && studentTime <= upperBound;
        }
    }
}
