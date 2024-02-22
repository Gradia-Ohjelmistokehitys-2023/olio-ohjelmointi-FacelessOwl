using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public class Kissa : Nisakkaat
    {
        string _kehrays;
        bool _raapii_ihmisia;
        int _pentujenmaara;

        List<Elain> emonpennut = new List<Elain>();
       
        public Kissa() : base()
        {
            _kehrays = "hrrr";
            _raapii_ihmisia = true;

        }

        public Kissa(int ika,string name, string kehrays) : base(ika,name)
        {
            _kehrays = kehrays;
           
        }
        public void Kehrays()
        {
            Console.WriteLine(_kehrays);
        }
        
        public override string ToString()
        {
            if (_raapii_ihmisia==true)
            {
                return "Kissan " + base.ToString() + ", raapii ihmisiä ja se kehrää näin " + _kehrays;
            }
            else
            {
                return "Kissan " + base.ToString() + ", ei raavi ihmisiä ja se kehrää näin " + _kehrays;
            }
            
        }
        public override string Aantele()
        {
            Console.WriteLine("Miau!");
            return base.Aantele();
        }
        public int LisaaPentu()
        {
            Kissa kissa = new Kissa();
            emonpennut.Add(kissa);
            _pentujenmaara = emonpennut.Count;
            return _pentujenmaara;
        }
    }
}
