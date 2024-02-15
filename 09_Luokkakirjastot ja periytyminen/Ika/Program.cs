using Eläinluokat;
namespace Ika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eläinluokat.Elain koe = new Eläinluokat.Elain();
            Kissa katti = new Kissa(4, "Pekka", "hrrr");
            Koira dog = new Koira(6,"Nougat","wuf wuf");
            Console.WriteLine(koe);
            Console.WriteLine(katti);
            Console.WriteLine(dog);


        }
    }
}
