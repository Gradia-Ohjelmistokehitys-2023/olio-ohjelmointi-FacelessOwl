using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public abstract class Elain
    {
        private int _ika;
        private string _nimi;
        private bool _onLihanSyoja;
        public Elain()
        {
            _ika = 0;
            _nimi = "ei nimeä";
        }
        public Elain(int ika, string nimi)
        {
            _ika = ika;
            _nimi = nimi;
        }
        public void AsetaOnLihanSyoja(bool onLihanSyoja)
        {
            _onLihanSyoja = onLihanSyoja;
        }
        
        public bool PalautaOnLihanSyoja()
        {
            if (_onLihanSyoja == true)
            {
                Console.WriteLine("on lihansyöjä.");
                return true;
            }
            else
            {
                Console.WriteLine("ei ole lihansyöjä.");
                return false;
            }
            
        }
            public bool AsetaIka(int uusiika)
        {
            if (uusiika >= 0)
            {
                _ika = uusiika;
                return true;
            }
            else
            {
                return false;

            }

            
            
        }
        public void AsetaNimi(string uusinimi)
        {
            _nimi = uusinimi;
        }
        public int PalautaIka 
        {  get 
            { 
                return _ika; 
            } 
        }
        
        public string PalautaNimi()
        {
            return _nimi;
        }
        public override string ToString()
        {
            if (_onLihanSyoja == true)
            {
                return "nimi on " + _nimi + ", ikä on " + _ika+", on lihansyöjä";
            }
            else 
            {
                return "nimi on " + _nimi + ", ikä on " + _ika + ", ei ole lihansyöjä";
            }
            
        }

        public virtual string Aantele()
        {
            return "Umph!";
        }

    }
}
