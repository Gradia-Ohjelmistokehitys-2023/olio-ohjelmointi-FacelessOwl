namespace L03T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            if (number == 10 || number == 20 )
            {
                Console.WriteLine("Your number is 10 or 20");
            }
            else if (number == 100 || number == 200)
            {
                Console.WriteLine("Your number is 100 or 200");
            }
            else
            {
                Console.WriteLine("Your number is " + number);
            }
        }
    }
}
