namespace _01_Kissa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa cat = new Kissa();
            cat._name = "Pekka";
            Console.WriteLine(cat._name);
            cat.SetCatName(cat._name = "Jalmari");
            Console.WriteLine(cat._name);
            Console.WriteLine(cat.ReturnCatAge);
        }
    }
}
