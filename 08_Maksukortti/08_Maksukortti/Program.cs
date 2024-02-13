namespace _08_Maksukortti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaksuKortti pekankortti = new MaksuKortti(20);
            MaksuKortti matinkortti = new MaksuKortti(30);
            pekankortti.SyoMaukkaasti();
            matinkortti.SyoEdullisesti();
            Console.WriteLine("Pekka: "+pekankortti);
            Console.WriteLine("Matti: "+matinkortti);
            pekankortti.LataaRahaa(20);
            matinkortti.SyoMaukkaasti();
            Console.WriteLine("Pekka: "+pekankortti);
            Console.WriteLine("Matti: "+matinkortti);
            pekankortti.SyoEdullisesti();
            pekankortti.SyoEdullisesti();
            matinkortti.LataaRahaa(50);
            Console.WriteLine("Pekka: "+pekankortti);
            Console.WriteLine("Matti: "+matinkortti);
        }
    }
}
