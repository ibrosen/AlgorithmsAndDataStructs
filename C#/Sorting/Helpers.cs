using System;
using System.Collections.Generic;

namespace csharp
{
    public class Helpers
    {

        private static int randMax = 100;
        private static int randMin = 0;
        public static Random r = new Random();
        public static int[] RandomIntArray(int size)
        {

            int[] array = new int[size];



            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(randMin, randMax);
            }
            return array;
        }

        public static int RandomInt()
        {
            return r.Next(randMin, randMax);
        }
    }
}