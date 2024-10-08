﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
   public class Koira : Nisakkaat
    {
        string _haukku;
        bool _ihmisenparaskaveri;

        public Koira() : base() 
        {
            _haukku = "hau hau";
            _ihmisenparaskaveri = true;
        }
        public Koira(int ika, string nimi, string haukkuminen) : base(ika, nimi)
        {
            _haukku = haukkuminen;
        }
        public override string ToString()
        {
            if (_ihmisenparaskaveri==true)
            {
                return "Koiran " + base.ToString() + 
                    ", on ihmisen paraskaveri ja se haukkuu näin " + _haukku;
            }
            else
            {
                return "Koiran " + base.ToString() + 
                    ", ei ole ihmisen paraskaveri jase haukkuu näin " + _haukku;
            }
            
        }
        public override string Aantele()
        {
            Console.WriteLine("Hau!");
            return base.Aantele();
        }

    }
}
