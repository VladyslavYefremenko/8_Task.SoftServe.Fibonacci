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

            IValidator validator = new Validator();
            IPrinter printer = new Printer();

            if (validator.ArgsIsEmpty(args) && (validator.IsNumInt(args[0]) && validator.IsNumInt(args[1])))
            {
                startSequence = int.Parse(args[0]);
                finishSequence = int.Parse(args[1]);

                if ((startSequence > 0 && finishSequence > 0) && finishSequence > startSequence)
                {
                    Fibonacci.Fibonacci fibonacci = new Fibonacci.Fibonacci( startSequence, finishSequence);

                    printer.PrintSequence(fibonacci, startSequence, finishSequence);
                    Console.ReadKey();
                    return;
                }                
            }

            printer.PrintInstraction(DefaultSettings.InstractionPath);
            Console.ReadKey();
            return;
        }
    }
}
