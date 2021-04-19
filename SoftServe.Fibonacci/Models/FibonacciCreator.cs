namespace SoftServe.Fibonacci
{
    public class FibonacciCreator : IFibonacciCreator
    {
        public int Create(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }
            else
            {
                return Create(num - 1) + Create(num - 2);
            }
        }
    }
}
