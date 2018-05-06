using System;
using System.Collections.Generic;

namespace csharp
{
    class Permutations
    {
        public static void RunPermutations()
        {
            string str = "abcd";
            List<string> permutations = new List<string>();
            Permutation("", str, permutations);

            foreach (string s in permutations)
            {
                Console.WriteLine(s);
            }
        }


        public static void Permutation(string prefix, string str, List<string> perms)
        {
            if (str.Length == 1)
            {
                perms.Add(prefix + str);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string tempStr = str.Remove(i, 1);
                    char tempChar = str[i];
                    Permutation(prefix + tempChar, tempStr, perms);
                }
            }
        }
    }

}