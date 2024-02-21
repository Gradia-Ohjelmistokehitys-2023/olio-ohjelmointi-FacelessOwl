﻿using System;
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
            return "Kissan " + base.ToString()+" ja se kehrää näin "+_kehrays;
        }
        public override string Aantele()
        {
            Console.WriteLine("Miau!");
            return base.Aantele();
        }
    }
}
