using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public class Papukaija : Linnut
    {
        public Papukaija() :base()
        {
            
        }
        public Papukaija(int ika, string nimi) : base(ika,nimi)
        {

        }
        public override string ToString()
        {
            return "Papukaijan "+base.ToString();
        }
    }
}
