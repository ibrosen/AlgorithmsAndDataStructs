using System;

namespace csharp
{
    class QuickSelect
    {

        public static void RunQuickSelect()
        {

            int size = 10;

            int[] array = Helpers.RandomIntArray(size);

            int num = Helpers.r.Next(1, size);

            Console.WriteLine("Looking for {0}th smallest number", num);


            int pos = Select(array, 0, array.Length - 1, num - 1);

            Console.WriteLine("Found at position {0}, has a value of {1}", pos, array[pos]);

            var sortedArray = Sorting.MergeSort.Sort(array);
            foreach (int n in sortedArray)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("When sorted, the array's {0}th smallest item is {1}", num, array[num - 1]);


        }

        private static int Select(int[] array, int indexLow, int indexHigh, int num)
        {
            if (indexLow < indexHigh)
            {
                int p = Partition(array, indexLow, indexHigh);
                if (p == num)
                    return p;
                else if (p > num)
                {
                    return Select(array, indexLow, p, num);
                }
                else //(p < num)
                {
                    return Select(array, p + 1, indexHigh, num);

                }



            }
            else
            {
                return indexLow;
            }

        }

        private static int Partition(int[] array, int indexLow, int indexHigh)
        {
            int randomIndex = Helpers.r.Next(indexLow, indexHigh);
            int pivot = array[randomIndex];
            int left = indexLow;
            int right = indexHigh;

            while (left < right)
            {

                while (array[left] < pivot)
                    left++;
                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    int tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;
                }

                if (array[left] == pivot)
                    right--;
            }
            return left;
        }

    }
}