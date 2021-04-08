namespace SoftServe.Fibonacci
{
    public class Validator : IValidator
    {
        public bool ArgsIsEmpty(string[] args)
        {
            bool isEmpty = true;

            if (args.Length == 0 || (string.IsNullOrEmpty(args[1]) && string.IsNullOrEmpty(args[0])))
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        public bool IsNumInt(string arg)
        {
            bool isNum = true;

            if (!int.TryParse(arg, out _))
            {
                isNum = false;
            }
            return isNum;
        }
    }
}
