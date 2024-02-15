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
        public Elain(int Ika, string Name)
        {
            _ika = Ika;
            _nimi = Name;
        }

        

        public void AsetaOnLihanSyoja(bool onLihanSyoja)
        {
            _onLihanSyoja = onLihanSyoja;
        }
        public bool PalautaOnLihanSyoja()
        {
            return _onLihanSyoja;
        }
            public bool AsetaIka(int Uusiika)
        {
            if (Uusiika >= 0)
            {
                _ika = Uusiika;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void AsetaNimi(string Uusinimi)
        {
            _nimi = Uusinimi;
        }
        public int PalautaIka()
        {
            return _ika;
        }
        public string PalautaNimi()
        {
            return _nimi;
        }
        public override string ToString()
        {
            return "Nimi on "+_nimi+" ja ikä on "+_ika;
        }



    }
}
