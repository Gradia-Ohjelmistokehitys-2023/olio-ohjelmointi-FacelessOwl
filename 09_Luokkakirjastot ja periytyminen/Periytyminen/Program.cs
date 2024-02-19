using Eläinluokat;
namespace Periytyminen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa katti = new Kissa(3, "Mauku", "hrrr");
            katti.AsetaNimi("Miuku");
            katti.AsetaIka(4);
            katti.AsetaOnLihanSyoja(true);
            Console.WriteLine(katti.PalautaNimi() + katti.PalautaIka + katti.PalautaOnLihanSyoja());
            katti.Kehrays();
            Koira dog = new Koira(6,"Nougat","Wuf Wuf");
            dog.AsetaNimi("Diego");
            dog.AsetaIka(4);
            dog.AsetaOnLihanSyoja(true);
            Console.WriteLine(dog.PalautaNimi() + dog.PalautaIka + dog.PalautaOnLihanSyoja());
            dog.Aantele();
            Koira pup = new Koira(5,"Nuksu","Wuf Wuf");
            Kissa cat = new Kissa(1,"Miuku","hrrrr");
            pup.AsetaOnLihanSyoja(true);
            Console.WriteLine(cat);
            Console.WriteLine(pup);
            pup.AsetaTurkinPaksuus(10);
            pup.PalautaTurkinPaksuus();
            Papukaija papu = new Papukaija(1, "Jaakko");
            papu.AsetasiipiVali(65);
            papu.PalautaSiipiVali();
            papu.AsetaOnLihanSyoja(false);
            Console.WriteLine(papu);
            papu.PalautaOnLihanSyoja();
        }
    }
}
