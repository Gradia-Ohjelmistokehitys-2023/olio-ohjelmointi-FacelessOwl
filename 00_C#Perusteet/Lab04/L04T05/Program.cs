namespace L04T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your firstname:");
            string name1 = Console.ReadLine();
            int length = name1.Length;
            Console.WriteLine("Give your lastname:");
            string name2 = Console.ReadLine();
            char[] stringArray = name2.ToCharArray();
            Array.Reverse(stringArray);
            for (int i = 0; i < length; i++) 
            { 
                char letter = name1[0];
                Console.Write(letter);
            }
            Console.Write(" ");
            Console.Write(stringArray);
        }
    }
}
