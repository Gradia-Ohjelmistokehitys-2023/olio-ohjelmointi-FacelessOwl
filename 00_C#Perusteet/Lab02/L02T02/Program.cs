namespace L02T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your firstname:");
            string first = Console.ReadLine();
            Console.WriteLine("Give your lastname:");
            string last = Console.ReadLine();
            string up = first.ToUpper();
            string up2 = last.ToUpper();
            Console.WriteLine(up + " " + up2);
        }
    }
}
