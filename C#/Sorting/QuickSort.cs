using System;
using System.Collections.Generic;
using csharp.Graphs;

namespace csharp.Sorting
{

    class QuickSort
    {
        public static void RunQuickSort()
        {
            int[] array = Helpers.RandomIntArray(100);
            Console.WriteLine("");
            Sort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void test(int[] a)
        {
            a[0] = 1111111111;

        }
        public static void Sort(int[] array, int indexLow, int indexHigh)
        {


            if (indexLow < indexHigh)
            {
                int p = Partition(array, indexLow, indexHigh);
                Sort(array, indexLow, p);
                Sort(array, p + 1, indexHigh);
            }
        }

        public static int Partition(int[] array, int indexLow, int indexHigh)
        {
            int pivot = array[indexLow];
            int left = indexLow;
            int right = indexHigh;
            while (left < right)
            {

                if (array[left] > pivot && array[right] <= pivot)
                {
                    //swap
                    int tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;


                }
                if (array[left] <= pivot)
                {
                    left++;
                }
                if (array[right] > pivot)
                {
                    right--;
                }

            }

            return left;
        }
    }
}