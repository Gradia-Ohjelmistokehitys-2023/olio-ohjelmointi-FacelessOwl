namespace L01T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string Firstnumber = Console.ReadLine();
            int a = int.Parse(Firstnumber);
            Console.WriteLine("Give another number:");
            string Secondnumber= Console.ReadLine();
            int y=int.Parse(Secondnumber);
            int sum = a + y;
            int sub = a - y;
            int Multiplication = a * y;
            Console.WriteLine("Summary: " + sum);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + Multiplication);
        }
    }
}
