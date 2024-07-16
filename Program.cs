using System;

namespace SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            PrintArray(arr1);
            BubbleSort(arr1);
            PrintArray(arr1);
            int[] arr2 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            PrintArray(arr2);
            SelectionSort(arr2);
            PrintArray(arr2);
            int[] arr3 = { 6, 1, 7, 4, 2, 9, 8, 5, 3 };
            PrintArray(arr3);
            InsertionSort(arr3);
            PrintArray(arr3);
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public static void InsertionSort(int[] arr)
        {
            // A for loop to iterate the array to sort the elements
            for (int i = 1; i < arr.Length; i++)
            {
                // Temporary store an elements in the 'temp' variable
                int temp = arr[i];

                // Evaluate the elements to the left of the array with 'temp' element
                // In this case we start at index 1 and the array started with index 0
                int priorIndex = i - 1;

                // If out prior element is greater than our stored ('temp') element
                // and we have not reached the end of the array
                while (arr[priorIndex] > temp && priorIndex >= 0)
                {
                    arr[priorIndex + 1] = arr[priorIndex];
                    priorIndex--;
                }

            }
            Console.WriteLine();
        }

        public static int BubbleSort(int[] arrToSort)
        {
            int totalOuterIterations = 0;
            int temp;
            // Overall O(n^2) runtime - Big O
            // Big Omega - O(n^2)
            for (int i = 0; i < arrToSort.Length - 1; i++) // O(n) how many times we need to go though the unsorted array
            {
                totalOuterIterations++;
                int swaps = 0;
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)  // O(n)
                {
                    // we need to swap
                    if (arrToSort[j] > arrToSort[j + 1])           // can modify if '>' change to '<'
                    {
                        swaps++;
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }

                if (swaps == 0) break; // break out of the for loop
            }

            return totalOuterIterations;
        }

        public static void SelectionSort(int[] arrToSort)
        {
            // minIndex keeps track of the smallest index in each iteration
            // temp is used as temporary storage
            int minIndex, temp;

            // O(n) how many times we need to go though the unsorted array
            for (int i = 0; i < arrToSort.Length; i++)
            {
                minIndex = i; // set the minIdex equal to current smallest index
                for (int j = i; j < arrToSort.Length; j++) // loop through each element starting at i
                {
                    // if the element is smaller than the current minIndex
                    if (arrToSort[j] < arrToSort[minIndex])
                    {
                        // swap
                        minIndex = j;
                    }
                }

                // swap elements
                // swap current i (which is smallest position with the smallest/min element)
                temp = arrToSort[i];
                arrToSort[i] = arrToSort[minIndex];
                arrToSort[minIndex] = temp;
            }
        }
    }
}