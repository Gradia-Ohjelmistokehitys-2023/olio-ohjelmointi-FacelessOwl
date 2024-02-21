

namespace showTimeL05T01
{
    internal class Program
    {
        static string CreateTime(int sekunnit)
        {
            string clockTime="";
            int tunnit = sekunnit/3600;
            int minuutit = (sekunnit - 3600 * tunnit) / 60;
            int sekunti = sekunnit%3600%60;
            clockTime=($"{tunnit:00}:{minuutit:00}:{sekunti:00}");

            return clockTime;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("5000");
            Console.WriteLine(CreateTime(5000));
            Console.WriteLine("100000");
            Console.WriteLine(CreateTime(100000));

            Console.WriteLine("500000");
            Console.WriteLine(CreateTime(500000));
        }
    }
}