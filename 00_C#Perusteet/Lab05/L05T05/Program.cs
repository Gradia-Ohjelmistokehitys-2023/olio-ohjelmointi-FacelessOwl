namespace L05T05
{
    internal class Program
    {
        static void get_cost(Double length,Double usage,Double price)
        {
            Double len = length / 100;
            Double use = usage * len;
            double cost=price * use;
            Console.WriteLine(Double.Round(cost,2));

        }
        static void Main(string[] args)
        {
            get_cost(100, 7.5, 1.88);
            get_cost(220, 6.9, 1.88);
        }
    }
}
