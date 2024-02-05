namespace _01_Kissa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa cat = new Kissa();
            Kissa kissa = new Kissa(2,"Marko");
            cat._name = "Pekka";
            Console.WriteLine(cat._name);
            cat.SetCatName("Patrick");
            Console.WriteLine(cat._name);
            Console.WriteLine(cat.ReturnCatAge);
            Console.WriteLine(kissa._name +" "+ kissa.ReturnCatAge);
            cat.SetCatAge(1);
            Console.WriteLine(cat.ReturnCatAge);
        }
    }
}
