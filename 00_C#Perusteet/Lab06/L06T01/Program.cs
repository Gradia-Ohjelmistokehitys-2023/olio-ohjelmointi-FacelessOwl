using System.Threading.Channels;

namespace L06T01
{
    internal class Program
    {
        static void show_time(int second)
        {
            second = second % (24 * 3600);
            int hour = second / 3600;
            second %= 3600;
             int minute= second / 60;
            second %= 60;
            
        }
        static void Main(string[] args)
        {
            show_time(500);
            show_time(10000);
            show_time(1210000);
        }
    }
}
