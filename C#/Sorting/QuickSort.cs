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
            Random r = new Random();
            int randIndex = r.Next(indexLow, indexHigh);
            int pivot = array[randIndex];
            int left = indexLow;
            int right = indexHigh;
            while (left < right)
            {


                //if our current item is the pivot, we don't want to move past it, hence it's only < and >, not
                //<= and >=. This ensures that our pivot ends up in the right spot
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    int tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;
                }



                //prevents deadlock if both left and right == pivot
                if (array[left] == pivot)
                    right--;

            }

            return left;
        }
    }
}