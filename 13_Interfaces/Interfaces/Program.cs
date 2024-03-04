namespace Interfaces
{


    interface IPerformAction
    {
        void PerformAction(string action);
    }
    interface IPublish
    {
        

        void Publish(string name);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dancer dancer = new Dancer();
            Singer singer = new Singer();
            dancer.PerformAction("The dancer performs a stage dance");
            singer.PerformAction("The singer performs a beatiful opera");
        }
        


    }
    
}
