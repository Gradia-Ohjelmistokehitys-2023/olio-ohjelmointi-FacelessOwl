using System.Formats.Asn1;

namespace L03T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Give 1. number:");
            string num = Console.ReadLine();
            int first = int.Parse(num);
            Console.WriteLine("Give 2. number:");
            string num2 = Console.ReadLine();
            int second = int.Parse(num2);
            Console.WriteLine("Give 3. number:");
            string num3 = Console.ReadLine();
            int third = int.Parse(num3);
            Console.WriteLine("Give 4. number:");
            string num4 = Console.ReadLine();
            int fourth = int.Parse(num4);
            Console.WriteLine("Give 5. number:");
            string num5 = Console.ReadLine();
            int fifth = int.Parse(num5);
            int sum = 0;
            if (first > 0)
            {
                sum = sum + first;
            }
            if (second > 0)
            {
                sum = sum + second;
            }
            if (third > 0)
            {
                sum = sum + third;
            }
            if (fourth > 0)
            {
                sum = sum + fourth;
            }
            if (fifth > 0)
            {
                sum = sum + fifth;
            }
            Console.WriteLine("Total:" + sum);
            
        }
    }
}
