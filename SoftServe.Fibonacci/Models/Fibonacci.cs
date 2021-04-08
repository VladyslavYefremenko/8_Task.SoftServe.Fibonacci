namespace SoftServe.Fibonacci
{
    public class Fibonacci : IFibonacciCreator
    {
        private int[] fibonacciSequence;

        public int[] FibonacciSequence { get => fibonacciSequence; }

        public Fibonacci(int maxNum)
        {
            fibonacciSequence = new int[maxNum];

            for (int i = 0; i < maxNum; i++)
            {
                fibonacciSequence[i] = FibonacciCreator(i);
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
