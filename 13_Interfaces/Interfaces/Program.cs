namespace Interfaces
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Dancer dancer = new Dancer();
            Singer singer = new Singer();
            dancer.PerformAction();
            singer.PerformAction();
            singer.Publish("Movie");
        }
        


    }
    
}
