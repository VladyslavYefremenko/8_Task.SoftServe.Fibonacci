using System.Collections.Generic;

namespace SoftServe.Fibonacci
{
    public class Fibonacci : IFibonacciCreator
    {
        private List<int> fibonacciSequence = new List<int>();

        public List<int> FibonacciSequence { get => fibonacciSequence; }

        public Fibonacci(int minNum, int maxNum)
        {
            int counter = 0;
            int number = 0;

            while (number < maxNum)
            {
                number = FibonacciCreator(counter++);

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

        public int FibonacciCreator(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }
            else
            {
                return FibonacciCreator(num - 1) + FibonacciCreator(num - 2);
            }
        }
    }
}
