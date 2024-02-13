using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Musiikkikappale
{
    public class Musiikkikappale
    {
        public string _nimi;
        public int _pituus;

        public Musiikkikappale(string Nimi, int Pituus) 
        { 
            _nimi = Nimi;
            _pituus = Pituus;
        }
        public string Nimi()
        {
            return _nimi;
        }
        public int Pituus()
        {
            return _pituus;
        }
    }
}
