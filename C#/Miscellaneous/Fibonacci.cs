using System;

namespace csharp
{


    class Fibonacci
    {

        public static void RunFibonacci()
        {
            FibonacciDynamic(20);

        }


        private static void FibonacciDynamic(int n)
        {
            int[] memory = new int[n + 1];
            memory[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                memory[i] = memory[i - 2] + memory[i - 1];
            }
            Console.WriteLine("Iterative Fib");
            Console.WriteLine(memory[n]);

            int[] memoryRecurse = new int[n + 1];
            memoryRecurse[1] = 1;
            FibonacciDynamicRecurse(n, memoryRecurse);

            Console.WriteLine("Recursive Fib");
            Console.WriteLine(memoryRecurse[n]);
        }

        private static void FibonacciDynamicRecurse(int n, int[] memory)
        {
            if (n <= 1)
                return;
            if (memory[n] == 0)
            {
                FibonacciDynamicRecurse(n - 1, memory);
                memory[n] = memory[n - 1] + memory[n - 2];
            }

        }
    }
}