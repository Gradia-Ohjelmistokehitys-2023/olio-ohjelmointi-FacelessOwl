namespace L05T03
{
    internal class Program
    {
        static void Average(int num1,int num2,int num3) 
        { 
            int plus = num1 + num2 + num3;
            var sum: float = plus/3;
            Console.WriteLine(Decimal.Round(sum,1));
        }

        static void Main(string[] args)
        {
            Average(2, 4, 6);
            Average(5, 5, 6);
        }
    }
}
