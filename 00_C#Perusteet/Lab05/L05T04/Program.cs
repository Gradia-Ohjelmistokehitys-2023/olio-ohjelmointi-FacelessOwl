namespace L05T04
{
    internal class Program
    {
        static void get_fuel(Double num1,Double num2)
        {
            Double length = num1 / 100;
            Double gas_usage = num2 * length;
            Console.WriteLine(Double.Round(gas_usage,1)+"ltr");
        }
        static void Main(string[] args)
        {
            get_fuel(100,7.5);
            get_fuel(220,6.9);
        }
    }
}
