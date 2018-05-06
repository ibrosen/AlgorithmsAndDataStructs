using System;

namespace csharp
{

    class ReverseNum
    {
        public static void RunReverseNum()
        {
            int num = 123;
            //find the largest column of the num
            int i = 123;
            int col = 1;

            while (i > 10)
            {
                col *= 10;
                i = num / col;
            }

            //col is now the largest power of 10

            int output = 0;
            int currDigit;
            int currPower = 1;
            while (col >= 1)
            {
                currDigit = num / col;
                num %= col;
                output += currDigit * currPower;
                col /= 10;
                currPower *= 10;
            }

            Console.WriteLine(output);
        }
    }
}