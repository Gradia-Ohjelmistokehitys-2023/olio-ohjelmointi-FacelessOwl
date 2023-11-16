namespace L01T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euros: ");
            string Euros = Console.ReadLine();
            int a = int.Parse(Euros);
            Console.WriteLine("Cents: ");
            string Cent= Console.ReadLine();
            float y = int.Parse(Cent);
            float cent = y / 100;
            float sum = a + cent;
            Console.Write("You have:" + sum);
        }
    }
}
