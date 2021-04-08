namespace SoftServe.Fibonacci
{
    public interface IValidator
    {
        bool ArgsIsEmpty(string[] args);

        bool IsNumInt(string arg);
    }
}
