using System;
using System.Collections.Generic;

namespace csharp.Sorting
{
    public class Helpers
    {
        public static int[] RandomIntArray(int size)
        {

            int[] array = new int[size];

            Random r = new Random();
            // int[] testArr = { 0, 1 };
            // test(testArr);
            // Console.WriteLine(testArr[0]);


            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(0, 100);
            }
            return array;
        }
    }
}