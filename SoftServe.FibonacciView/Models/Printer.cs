using System;
using System.IO;

namespace SoftServe.FibonacciView
{
    class Printer : IPrinter
    {
        public void PrintSequence(Fibonacci.Fibonacci fibonacci, int startSequence, int finishSequence)
        {
            string result = String.Join(", ", fibonacci.FibonacciSequence);

            Console.WriteLine($"Range: {startSequence} - {finishSequence}");
            Console.WriteLine(result);
        }

        public void PrintInstraction(string instractionFilePath)
        {
            StreamReader sr = new StreamReader(instractionFilePath);
            string line = sr.ReadLine();

            Console.Clear();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
