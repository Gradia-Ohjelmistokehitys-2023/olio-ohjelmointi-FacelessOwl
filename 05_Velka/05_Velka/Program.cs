namespace _05_Velka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Velka pikaVippi = new Velka(1000, 0.12);
            pikaVippi.TulostaSaldo();
            pikaVippi.OdotaVuosi();
            pikaVippi.TulostaSaldo();
        }
    }
}
