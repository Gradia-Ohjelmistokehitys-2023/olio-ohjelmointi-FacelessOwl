using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Velka
{
    public class Velka
    {
        public double _saldo;
        public double _korkoProsentti;
            public Velka(double saldoAlussa,double korkoProsentti) 
        {
            _saldo = saldoAlussa;
            _korkoProsentti = korkoProsentti;
        }  

        public void TulostaSaldo()
        {
            Console.WriteLine("Saldo: "+_saldo);
        }
        public void OdotaVuosi()
        {
            _saldo = _saldo * (1 + _korkoProsentti);
        }
    }
}
