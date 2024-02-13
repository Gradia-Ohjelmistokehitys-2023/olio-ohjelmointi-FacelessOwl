using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tuote
{
    public class Tuote
    {
        public double _hinta;
        public int _lukumaara;
        public string _name;
        public Tuote(string Name, double Hinta, int Lukumaara) 
        { 
            _name = Name;
            _hinta = Hinta;
            _lukumaara = Lukumaara;
        }
        
        public void Tulostatuote()
        {
            Console.WriteLine(_name+", hinta "+_hinta+", "+_lukumaara+"kpl");
        }
    }
}
