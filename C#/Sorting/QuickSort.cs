using System;
using System.Collections.Generic;
using csharp.Graphs;

namespace csharp.Sorting
{

    class QuickSort
    {
        public static void RunQuickSort()
        {
            int[] array = Helpers.RandomIntArray(20);
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
                Sort(array, indexLow, p - 1);
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


                //if our current item is the pivot, we don't want to move past it, hence it's only < and >, not
                //<= and >=. This ensures that our pivot will end up in the centre, which is important
                //as when we sort, we sort from low -> p-1 and from p+1 -> high, as we need to assume that
                //we can skip p 
                while (array[left] < pivot && left < right)
                {
                    left++;
                }
                while (array[right] > pivot && left < right)
                {
                    right--;
                }





                int tmp = array[left];
                array[left] = array[right];
                array[right] = tmp;



                //prevents deadlock if both left and right == pivot
                if (array[left] == pivot)
                    right--;



            }

            return left;
        }
    }
}