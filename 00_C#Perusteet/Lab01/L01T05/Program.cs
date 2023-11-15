namespace L01T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euros: ");
            string Euros = Console.ReadLine();
            int a = int.Parse(Euros);
            Double eur = a;
            Console.WriteLine("Cents: ");
            string Cent= Console.ReadLine();
            int y = int.Parse(Cent);
            Double D = (y/100 );
            Double sum = eur + D;
            Console.Write("You have:" + sum+D);
        }
    }
}
