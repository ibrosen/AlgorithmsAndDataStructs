using System;
using System.Collections.Generic;
using csharp.Graphs;

namespace csharp.Sorting
{
    class MergeSort
    {
        public static void RunMergeSort()
        {
            var randomArray = Helpers.RandomIntArray(20);
            var sortedArray = Sort(randomArray);
            foreach (int num in sortedArray)
            {
                Console.Write(num + " ");
            }
        }

        public static int[] Sort(int[] array)
        {
            int len = array.Length;
            if (len <= 1)
                return array;
            int middle = len / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[len - middle];
            for (int i = 0; i < len; i++)
            {
                if (i < middle)
                    leftArray[i] = array[i];
                else
                    rightArray[i - middle] = array[i];

            }
            var leftArraySorted = Sort(leftArray);
            var rightArraySorted = Sort(rightArray);

            return Merge(leftArraySorted, rightArraySorted);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            List<int> merged = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;
            while (merged.Count < left.Length + right.Length)
            {
                if (leftIndex == left.Length)
                {
                    merged.Add(right[rightIndex]);
                    rightIndex++;
                    continue;
                }
                if (rightIndex == right.Length)
                {
                    merged.Add(left[leftIndex]);
                    leftIndex++;
                    continue;
                }
                if (left[leftIndex] <= right[rightIndex])
                {
                    merged.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    merged.Add(right[rightIndex]);
                    rightIndex++;
                }
            }
            return merged.ToArray();
        }
    }
}