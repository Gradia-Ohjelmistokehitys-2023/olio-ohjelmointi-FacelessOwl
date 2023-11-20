using System.Runtime.ExceptionServices;

namespace L05T02
{
    internal class Program
    {
        static void Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Subtract(1,2);
        }
    }
}
