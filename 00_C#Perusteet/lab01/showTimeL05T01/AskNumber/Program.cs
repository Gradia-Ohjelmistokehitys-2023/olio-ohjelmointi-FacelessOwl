namespace AskNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            bool onnistui;
            do
            {
                Console.WriteLine("Syötä luku, muu merkki lopettaa");
                string syote = Console.ReadLine();
                onnistui = int.TryParse(syote, out int luku);
                if (onnistui)
                {
                    switch (luku)
                    {
                        case 1:
                            Console.WriteLine("Ykkönen");
                            break;
                        case 2 or 4:
                            Console.WriteLine("Kakkonen tai nelonen");
                            break;
                        case 3:
                            Console.WriteLine("Kolmonen");
                            break;
                        default:
                            Console.WriteLine("Joku muu luku");
                            break;
                    }
                }


            } while (onnistui);
            string teksti = "Ohjelma loppui. Hyvää päivän jatkoa!";
            string[] sanat=teksti.Split(' ');
            foreach (string sana in sanat)
            {
                Console.WriteLine(sana);
            }
 
        }
    }
}