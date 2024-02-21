using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public class Hevonen : Nisakkaat
    {
        bool _onkilpahevonen;
        public Hevonen() : base() 
        {
            _onkilpahevonen = false;
        }
        public Hevonen(int ika,string nimi) : base(ika,nimi)
        {

        }
        public override string ToString() 
        {
            return "Hevosen "+base.ToString();
        }
    }
}
