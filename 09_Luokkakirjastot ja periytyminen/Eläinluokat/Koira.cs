using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
   public class Koira : Elain
    {
        string _haukku;

        public Koira() : base() 
        {
            _haukku = "hau hau";
        }
        public Koira(int ika, string nimi, string haukkuminen) : base(ika, nimi)
        {
            _haukku = haukkuminen;
        }
        public override string ToString()
        {
            return "Koiran " + base.ToString() + " ja se haukkuu näin " + _haukku;
        }

    }
}
