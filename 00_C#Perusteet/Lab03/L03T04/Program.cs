namespace L03T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ponits:");
            string input = Console.ReadLine();
            int Points = int.Parse(input);
            int Grade = 0;
            if (Points == 0 || Points == 1)
            {
                Grade = 0;
                Console.WriteLine("Grade:" + Grade);
            }
            else if (Points == 2 || Points == 3)
            {
                Grade = 1;
                Console.WriteLine("Grade:" + Grade);
            }
            else if (Points == 4 || Points==5) 
            {
                Grade = 2;
                Console.WriteLine("Grade:" + Grade);
            }
            else if (Points == 6 || Points==7) 
            {
                Grade = 3;
                Console.WriteLine("Grade:" + Grade);
            }
            else if (Points==8 || Points == 9)
            {
                Grade = 4;
                Console.WriteLine("Grade:" + Grade);
            }
            else if (Points>=10 || Points <= 12)
            {
                Grade = 5;
                Console.WriteLine("Grade:" + Grade);
            }
        }
    }
}
