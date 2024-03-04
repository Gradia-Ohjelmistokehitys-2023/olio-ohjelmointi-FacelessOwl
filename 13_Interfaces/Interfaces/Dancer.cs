using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Dancer : IPerformAction
    {
        public void PerformAction()
        {
            Console.WriteLine("The dancer performs a stage dan");
        }
        
        

    }
}
