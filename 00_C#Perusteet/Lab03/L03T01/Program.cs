namespace L03T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string first = Console.ReadLine();
            int a = int.Parse(first);
            Console.WriteLine("Give another number:");
            string second = Console.ReadLine();
            int b = int.Parse(second);
            if (a>b)
            {
                Console.WriteLine("smaller:"+b);
         
            }
            else
            {
                Console.WriteLine("smaller:"+a);
            }
        }

    }
}
