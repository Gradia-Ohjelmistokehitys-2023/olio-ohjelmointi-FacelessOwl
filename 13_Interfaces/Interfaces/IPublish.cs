using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IPublish
    {
        
        private List<string> _discoraphy { get { return _discoraphy; } }
        public List<string> Discoraphy { get; }

        void Publish(string name);
    }
}
