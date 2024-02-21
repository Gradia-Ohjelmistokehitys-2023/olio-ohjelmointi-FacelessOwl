using Eläinluokat;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace _10_OhjelmointipahkinaFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _vuoro;
            int _kissanvuoro;
            int _koiranvuoro;
            int _papukaijanvuoro;

            _kissanvuoro = 1;
            _koiranvuoro = 2;
            _papukaijanvuoro = 3;
            _vuoro = 1;

            List<Elain> elaimet = new List<Elain>();

            string[] nimet = new string[] 
            {
                "Matti","Pekka","Jukka","Nougat","Diego","Pedro","Tiitus","Kerttu","Manoliitto","Teresa"
            };
            



            Console.WriteLine("Kuinka monta eläintä luodaan: ");
            string cycle = Console.ReadLine();
            int x = int.Parse(cycle);
            for (int j = 0; j < x; j++)
            {
                if (_vuoro % 4 == 0)
                {
                    Hevonen hevonen = new Hevonen();
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);
                    Random random = new Random();
                    int index = random.Next(nimet.Length);
                    hevonen.AsetaNimi($"{nimet[index]}");
                    int _elainika = random.Next(1,16);
                    hevonen.AsetaIka( _elainika );
                    elaimet.Add(hevonen);
                }
                else if (_kissanvuoro == 1)
                {
                    Kissa kissa = new Kissa();
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);
                    Random random = new Random();
                    int index = random.Next(nimet.Length);
                    kissa.AsetaNimi($"{nimet[index]}");
                    int _elainika = random.Next(1, 16);
                    kissa.AsetaIka(_elainika);
                    elaimet.Add(kissa);
                }
                else if (_koiranvuoro == 1)
                {
                    Koira koira = new Koira();
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);
                    Random random = new Random();
                    int index = random.Next(nimet.Length);
                    koira.AsetaNimi($"{nimet[index]}");
                    int _elainika = random.Next(1, 16);
                    koira.AsetaIka(_elainika);
                    elaimet.Add(koira);
                }
                else 
                {
                    Papukaija papukaija = new Papukaija();
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);
                    Random random = new Random();
                    int index = random.Next(nimet.Length);
                    papukaija.AsetaNimi($"{nimet[index]}");
                    int _elainika = random.Next(1, 16);
                    papukaija.AsetaIka(_elainika);
                    elaimet.Add(papukaija);
                }
                _vuoro++;
            }
            
          //  elaimet.ForEach(i => Console.WriteLine("{0}\t", i));
            
            foreach(Kissa koe in elaimet.OfType<Kissa>())
            {
                Console.WriteLine( koe );
            }

        }
        
        private static int Muutavuoroa(int elukanVuoro)
        {
            if(elukanVuoro == 1)
            {
                return 3;
            }
            else
            {
                return --elukanVuoro;
            }
        }
    }
}
