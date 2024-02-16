using Eläinluokat;
namespace Periytyminen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa katti = new Kissa(3,"Mauku","hrrr");
            katti.AsetaNimi("Miuku");
            katti.AsetaIka(4);
            katti.AsetaOnLihanSyoja(true);
            Console.WriteLine(katti.PalautaNimi()+katti.PalautaIka+katti.PalautaOnLihanSyoja());
            katti.Kehrays();
        }
    }
}
