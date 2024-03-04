using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Singer : IPerformAction
    {
        public void PerformAction(string newaction)
        {
            Console.WriteLine(newaction);
        }
    }
}
