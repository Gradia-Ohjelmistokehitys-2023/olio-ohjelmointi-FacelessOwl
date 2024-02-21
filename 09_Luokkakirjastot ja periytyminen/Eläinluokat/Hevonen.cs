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
            if (_onkilpahevonen==true)
            {
                return "Hevosen " + base.ToString()+" ja se on kilpahevonen";
            }
            else
            {
                return "Hevosen " + base.ToString()+" ja se ei ole kilpahevonen";
            }
            
        }
    }
}
