namespace _01_Kissa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa cat = new Kissa();
            cat._name = "Pekka";
            Console.WriteLine(cat._name);
        }
    }
}
