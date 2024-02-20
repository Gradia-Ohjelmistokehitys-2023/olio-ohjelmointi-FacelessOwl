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
            

            Console.WriteLine("Kuinka monta eläintä luodaan: ");
            string cycle = Console.ReadLine();
            int x = int.Parse(cycle);
            for (int j = 0; j < x; j++)
            {
                if (_vuoro % 4 == 0)
                {
                    Console.WriteLine("Hevonen");
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);

                }
                else if (_kissanvuoro == 1)
                {
                    Console.WriteLine("Kissa");
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);

                }
                else if (_koiranvuoro == 1)
                {
                    Console.WriteLine("Koira");
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);
                }
                else 
                {
                    Console.WriteLine("Papukaija");
                    _kissanvuoro = Muutavuoroa(_kissanvuoro);
                    _koiranvuoro = Muutavuoroa(_koiranvuoro);
                    _papukaijanvuoro = Muutavuoroa(_papukaijanvuoro);
                }
                _vuoro++;
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
