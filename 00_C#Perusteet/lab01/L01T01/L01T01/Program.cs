namespace L01T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello olen Jussi");
            string syote = Console.ReadLine();         
            Console.WriteLine("Sanoitko " + syote[0] + "?");
            int maara=syote.Length;
            char ekaKirjain = syote[0];
            string merkit = new string(ekaKirjain, maara);
            Console.WriteLine(merkit);
        }
    }
}