using System;

namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            PrintArray(arr1);
            BubbleSort(arr1);
            PrintArray(arr1);
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public static Array BubbleSort(int[] arrToSort)
        {
            int temp;
            for (int i = 0; i < arrToSort.Length - 1; i++)          // how many times it's going through unsorted array
            {
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)
                {
                    // need to swap
                    if (arrToSort[j] > arrToSort[j + 1])
                    {
                        temp = j;
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }
            }

            return arrToSort;
        }
    }
}
