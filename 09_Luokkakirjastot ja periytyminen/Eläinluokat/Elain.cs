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
        private int _ika;
        public string _nimi;
        public bool _onLihanSyoja;
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

        public int Test {  get { return _ika; } }

        public void AsetaOnLihanSyoja(bool onLihanSyoja)
        {
            _onLihanSyoja = onLihanSyoja;
        }
        public bool PalautaOnLihanSyoja()
        {
            return _onLihanSyoja;
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
            return "Nimi on " + _nimi + " ja ikä on " + _ika;
        }



    }
}
