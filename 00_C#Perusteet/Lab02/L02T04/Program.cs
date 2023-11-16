namespace L02T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your firstname: ");
            string name = Console.ReadLine();
            Console.WriteLine("Give your birth year: ");
            string Birth_year = Console.ReadLine();
            int birth_year = int.Parse(Birth_year);
            var today = DateTime.Today;
            var age = today.Year - birth_year;
            Console.WriteLine("Hi "+name+", you are "+age+" years old.");
        }
    }
}
