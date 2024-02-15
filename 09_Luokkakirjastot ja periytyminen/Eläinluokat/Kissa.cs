using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public class Kissa : Elain
    {
        string _kehrays;

        public Kissa() : base()
        {
            _kehrays = "hrrr";
        }

        public Kissa(int ika,string name, string kehrays) : base(ika,name)
        {
            _kehrays = kehrays;
           
        }
        public override string ToString()
        {
            return "Kissan " + base.ToString()+" ja se kehrää näin "+_kehrays;
        }

    }
}
