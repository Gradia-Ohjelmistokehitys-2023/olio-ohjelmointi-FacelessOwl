namespace Eläinluokat
{
    public class ElainLuokka
    {
     
        public bool _onLihanSyoja;

        public void AsetaOnLihanSyoja()
        {

        }
        public bool PalautaOnLihanSyoja()
        {
            return _onLihanSyoja;
        }
        public class Kissa
        {
            public int _ika;
            public string _nimi;
            public Kissa()
            {
                _ika = 0;
            }
        }
        public class Koira
        {
            public string _nimi;
            public int _ika;
            public Koira()
            {
                _ika= 0;
            }

        }


    }
}
