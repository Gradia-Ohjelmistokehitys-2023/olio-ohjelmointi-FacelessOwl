using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Singer : IPerformAction, IPublish
    {
        public void PerformAction()
        {
            Console.WriteLine("The singer performs a beatiful opera");
        }
        private List<string> _discoraphy {  get; set; }
        
        public void Publish(string name)
        {
            if (_discoraphy == null) 
                _discoraphy = new List<string>();
            _discoraphy.Add(name);
            foreach (string test in _discoraphy)
                Console.WriteLine(test);
        }
        public List<string> Discoraphy { get; }
    }
}
