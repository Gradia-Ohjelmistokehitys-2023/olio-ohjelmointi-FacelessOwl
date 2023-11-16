namespace L03T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gice first number:");
            string first = Console.ReadLine();
            int a =int.Parse(first);
            Console.WriteLine("Give second number:");
            string second = Console.ReadLine();
            int b =int.Parse(second);
            Console.WriteLine("Give third number:");
            string third = Console.ReadLine();
            int c =int.Parse(third);
            if (a>b)
            {
                if (a > c)
                {
                    Console.WriteLine("Biggest:" + a);
                }
                else {
                    Console.WriteLine("Biggest:" + c);
                        }
            }else if (b>c)
            {
                Console.WriteLine("Biggest:"+b);
            }
            else { Console.WriteLine("Biggest:" + c);
            }

        }
    }
}
