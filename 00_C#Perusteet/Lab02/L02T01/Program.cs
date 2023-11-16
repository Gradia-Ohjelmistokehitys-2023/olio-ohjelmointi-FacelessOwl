namespace L02T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your lastname:");
            string lastname = Console.ReadLine();
            int length = lastname.Length;
            Console.WriteLine(length);
        }
    }
}
