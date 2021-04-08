using System;

using SoftServe.Fibonacci;

namespace SoftServe.FibonacciView
{
    class Startup
    {
        public static void Start(string[] args)
        {
            int startSequence = 0;
            int finishSequence = 0;

            Validator validator = new Validator();

            if (validator.ArgsIsEmpty(args) && (validator.IsNumInt(args[0]) && validator.IsNumInt(args[1])))
            {
                startSequence = int.Parse(args[0]);
                finishSequence = int.Parse(args[1]);

                if (startSequence > 0 && finishSequence > 0)
                {
                    Fibonacci.Fibonacci fibonacci = new Fibonacci.Fibonacci(finishSequence);

                    SequencePrinter.Print(fibonacci, startSequence, finishSequence);
                    Console.ReadKey();
                    return;
                }                
            }

            Console.WriteLine("Instraction");
            Console.ReadKey();
            return;
        }
    }
}
