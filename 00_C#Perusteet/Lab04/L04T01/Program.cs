namespace L04T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers:");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum=sum + 1;
                Console.WriteLine(sum+" number: "+i*10);
            }
        }
    }
}
