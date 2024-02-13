using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Maksukortti
{
    public class MaksuKortti
    {
        private double saldo;
        public MaksuKortti(double alkusaldo)
        {
            saldo = alkusaldo;
        }
        public override string ToString()
        {
            return "Kortilla on rahaa " + saldo.ToString("R") +  " euroa";
        }
        public void SyoEdullisesti()
        {
            if (saldo >= 2.60)
            {
                saldo = saldo - 2.60;
            }
            
        }
        public void SyoMaukkaasti()
        {
            if (saldo >= 4.60)
            {
                saldo = saldo - 4.60;
            }
            
        }
        public void LataaRahaa(double lisasaldo)
        {
            if (lisasaldo >= 0)
            {
                saldo = saldo + lisasaldo;
            }
        }

    }
}
