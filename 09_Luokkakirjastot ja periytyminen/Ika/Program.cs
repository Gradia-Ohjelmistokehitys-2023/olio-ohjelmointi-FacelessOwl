using Eläinluokat;
namespace Ika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            int k;
            for (int x =0; x < 10; x++) 
            {
                Kissa cat = new Kissa(0,"Mauku","hrr");
                Koira dog = new Koira(0,"Rauski","wuf wuf");
                Random rnd = new Random();
                for (int j = 0; j < 1; j++)
                {
                    k=rnd.Next(1, 16);
                    c= rnd.Next(1, 11);
                    cat.AsetaIka(c);
                    dog.AsetaIka(k);
                    Console.WriteLine("Koira on: " + dog.PalautaIka + " vuotta.");
                    Console.WriteLine("Kissa on: " + cat.PalautaIka+" vuotta.");
                    if (dog.PalautaIka>cat.PalautaIka) 
                    {
                        Console.WriteLine("Koira on vanhempi");
                    }
                    else if (dog.PalautaIka==cat.PalautaIka)
                    {
                        Console.WriteLine("Kissa ja koira ovat saman ikäisiä");
                    }
                    else
                    {
                        Console.WriteLine("Kissa on vanhempi");
                    }
                }
            }


            

        }
    }
}
