using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public abstract class Linnut : Elain
    {
        int _siipivali;
        public Linnut() :base()
        {
            _siipivali = 5;
        }
        public Linnut(int ika, string nimi) : base(ika,nimi)
        {

        }
        public void AsetasiipiVali(int uusisiipivali)
        {
            _siipivali = uusisiipivali;
        }
        public int PalautaSiipiVali()
        {
            Console.WriteLine("Siipivali on: "+_siipivali+"cm");
            return _siipivali;
        }
    }
}
