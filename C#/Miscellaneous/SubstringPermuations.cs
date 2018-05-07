using System;
using System.Collections.Generic;

namespace csharp
{


    /*
     * Given a smaller string 5 and a bigger string b, design an algorithm to find all permutations
     * of the shorter string within the longer one. Print the location of each permutation.
    **/

    /* This solution is actually O(n) where n is the size of b,
     * As we can assume that aDict has max 26 keys (number of letters)
     * in the alphabet, so comparing is actually constant
     **/
    class SubstringPermuations
    {
        public static void Run()
        {

            Solution("abca", "abcacdbcabcdbababcbababcacbacbacdba");
        }

        private static void Solution(string a, string b)
        {
            Dictionary<char, int> aDict = new Dictionary<char, int>();
            Dictionary<char, int> bDict = new Dictionary<char, int>();
            int windowSize = a.Length;

            foreach (char c in a)
            {
                increment(aDict, c, 1);
            }

            int i;

            for (i = 0; i < windowSize; i++)
            {
                increment(bDict, b[i], 1);
            }

            while (i < b.Length)
            {

                if (compareDicts(aDict, bDict))
                {
                    Console.WriteLine(b.Substring(i - windowSize, windowSize));
                }

                char bChar = b[i];


                increment(bDict, bChar, 1);
                increment(bDict, b[i - windowSize], -1);



                // if(!aDict.ContainsKey(bChar))
                // {
                //     i+= windowSize;

                //     continue;
                // }





                i++;


            }

        }

        private static bool compareDicts<T>(Dictionary<T, int> dictA, Dictionary<T, int> dictB)
        {
            foreach (T key in dictA.Keys)
            {
                if (!dictB.ContainsKey(key) || dictB[key] != dictA[key])
                    return false;
            }
            return true;

        }

        private static void increment<T>(Dictionary<T, int> dict, T key, int i)
        {
            if (!dict.ContainsKey(key))
                dict.Add(key, 0);
            dict[key] += i;

            if (dict[key] == 0)
            {
                dict.Remove(key);
            }
        }
    }
}