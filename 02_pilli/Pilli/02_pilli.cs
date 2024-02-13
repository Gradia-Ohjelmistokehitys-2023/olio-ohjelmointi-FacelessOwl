using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pilli
{
    public class Pilli
    {
        private string _aani;

        public Pilli(string PilliAani)
        {
            _aani = PilliAani;
        }
        public void Soi()
        {
            Console.WriteLine(_aani);
        }
    }
}

