using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public class Elain
    {
        private int _age;
        public string _name;
        public Elain()
        {
            _age = 0;
            _name = "ei nimeä";
        }
        public Elain(int Age, string Name)
        {
            _age = Age;
            _name = Name;
        }
        public bool AsetaIka(int Uusiika)
        {
            if (Uusiika >= 0)
            {
                _age = Uusiika;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void AsetaNimi(string Uusinimi)
        {
            _name = Uusinimi;
        }
        public int PalautaIka()
        {
            return _age;
        }
        public string PalautaNimi()
        {
            return _name;
        }
        public override string ToString()
        {
            return "Eläimen nimi on "+_name+" ja ikä on "+_age;
        }



    }
}
