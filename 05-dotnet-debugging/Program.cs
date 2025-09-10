using System;
using System.Diagnostics;

// Challenge: Debug and instrument the Fibonacci program
// 1. Use the debugger to find and fix the bug in Fibonacci.
// 2. Add Debug.WriteLine at the start of Fibonacci and inside the loop.
// 3. Use Debug.WriteLineIf to log when sum == 1.
// 4. Add Debug.Assert before returning to check the result.
// 5. Try running in Debug and Release modes.

class Program
{
    static void Main(string[] args)
    {
        int result = Fibonacci(5);
        Console.WriteLine(result);
    }

    static int Fibonacci(int n)
    {
        // TODO: Add Debug.WriteLine to log method entry and n
        int n1 = 0;
        int n2 = 1;
        int sum;

        // TODO: Use the debugger to find and fix the bug in the loop condition
        for (int i = 2; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            // TODO: Add Debug.WriteLineIf to log when sum == 1
        }

        // TODO: Add Debug.Assert to check the result before returning
        return n == 0 ? n1 : n2;
    }
}
