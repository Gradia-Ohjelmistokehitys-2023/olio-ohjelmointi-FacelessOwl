using System.Reflection.Emit;

namespace L02T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your first- and lastname");
            string name = Console.ReadLine();
            string[] temp = name.Split(' ');
            string name2 = "";
            name = temp[0];
            name2 = temp[1];
            Console.WriteLine("Firstname: " + name);
            Console.WriteLine("Lastname: " + name2);
        }
    }
}
