internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
        string Firstnumber = Console.ReadLine();
        int a = int.Parse(Firstnumber);
        Console.WriteLine("Give another number:");
        string Secondnumber = Console.ReadLine();
        int y = int.Parse(Secondnumber);
        int sum = a+y;
        Console.WriteLine("sum:" + sum);
        

    }
}