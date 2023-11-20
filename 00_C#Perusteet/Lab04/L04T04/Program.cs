namespace L04T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number between 1-10:");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            int luku = 0;
            for (int i = 0; i < num; i++)
            {
                luku=luku + 1;
                int sum = luku * luku;
                Console.WriteLine("Number "+luku+" squared is "+sum);
            }
        }
    }
}
