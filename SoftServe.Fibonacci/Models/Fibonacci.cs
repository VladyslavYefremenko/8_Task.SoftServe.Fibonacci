using System.Collections.Generic;

namespace SoftServe.Fibonacci
{
    public class Fibonacci
    {
        private List<int> fibonacciSequence = new List<int>();

        public List<int> FibonacciSequence { get => fibonacciSequence; }

        public Fibonacci(IFibonacciCreator fibonacciCreator, int minNum, int maxNum)
        {
            int counter = 0;
            int number = 0;

            while (number < maxNum)
            {
                number = fibonacciCreator.Create(counter++);

                if (number >= minNum && number < maxNum)
                {
                    fibonacciSequence.Add(number);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
