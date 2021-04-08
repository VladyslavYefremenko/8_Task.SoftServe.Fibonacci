using System;

namespace SoftServe.FibonacciView
{
    class SequencePrinter
    {
        public static void Print(Fibonacci.Fibonacci fibonacci, int startSequence, int finishSequence)
        {
            Console.WriteLine($"Range: {startSequence} - {finishSequence}");
            for (int i = startSequence - 1; i <= finishSequence - 1; i++)
            {
                Console.Write(fibonacci.FibonacciSequence[i] + ",");
            }
        }
    }
}
