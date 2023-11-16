namespace L02T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your firstname: ");
            string name = Console.ReadLine();
            int length = name.Length;
            string first = name.Substring(0,1);
            //int v = int.Parse(first);
            Console.WriteLine("Your name " + name + " has " + length + " letters.");
            for (int i = 0; i<length;i++)
            {
                char merkki = name[0];
                Console.Write(merkki);
            }

            
            
        }
    }
}
