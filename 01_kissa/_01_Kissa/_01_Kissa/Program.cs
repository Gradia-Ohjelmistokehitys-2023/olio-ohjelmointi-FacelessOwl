namespace _01_Kissa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa cat = new Kissa();
            Kissa kissa = new Kissa(2, "Marko");
            cat._name = "Pekka";
            Console.WriteLine(cat._name);
            cat.SetCatName("Patrick");
            Console.WriteLine(cat._name);
            Console.WriteLine(cat.ReturnCatAge);
            Console.WriteLine(kissa._name + " " + kissa.ReturnCatAge);
            cat.SetCatAge(1);
            Console.WriteLine(cat.ReturnCatAge);
            cat.SetNewCatName("Pate");
            Console.WriteLine(cat._name);
        
            {
                Kissa katti = new Kissa();

                katti.SetNewCatName("Anneli");
                Console.WriteLine(katti._name);
                katti.SetNewCatName("Hilda");
                Console.WriteLine(katti._name);
            }
            {
                Kissa kissa1 = new Kissa();
                Console.WriteLine(kissa1);
            }
        }   

    }
}
