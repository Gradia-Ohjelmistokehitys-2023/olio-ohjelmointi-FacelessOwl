namespace L04T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 7; i++) 
            {
                Console.WriteLine("Give rain amount:");
                string number = Console.ReadLine();
                int num = int.Parse(number);
                if (num > 0)
                {
                    sum=sum+num;
                }
            }
            Console.WriteLine("rain amount total:"+sum);
        }
    }
}
