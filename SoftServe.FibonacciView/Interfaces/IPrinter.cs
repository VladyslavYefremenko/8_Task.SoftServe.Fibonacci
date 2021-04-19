namespace SoftServe.FibonacciView
{
    interface IPrinter
    {
        void PrintSequence(Fibonacci.Fibonacci fibonacci, int startSequence, int finishSequence);

        void PrintInstraction(string instractionFilePath);
    }
}
