namespace L04T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { 
                    bool con = true;
                    int sum = 0;
                    int num_given = 0;
                    while (con)
                    {
                    Console.WriteLine("Give a number:");
                    string number = Console.ReadLine();
                    if (number == "")
                    {
                        con = false;
                    }
                    else
                    {
                        int num = int.Parse(number);
                        sum = sum + num;
                        num_given = num_given + 1;
                    }

                }
                Console.WriteLine("Numbers given:" + num_given);
                Console.WriteLine("Number total:" + sum);
            }
        }
    }
}
