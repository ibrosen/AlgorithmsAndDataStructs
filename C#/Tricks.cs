using System;
using System.Collections.Generic;

namespace csharp
{
    class Tricks
    {
        class Lists
        {
            public static void Tricks()
            {

                List<int> list = new List<int>();

                /*.BinarySearch returns a negative number if 
                the item isn't there, the bitwise NOT of this 
                item (~index) returns the index of the first item
                larger thanthe item we're looking for
                so if we wanted to find 1 in 
                [-1 0 4 5 6], ~index would be 2 as you'd want
                to insert 1 between 0 and 4
                */
                int index = list.BinarySearch(1);
                list.Insert(~index, 3);
            }
        }
    }
}