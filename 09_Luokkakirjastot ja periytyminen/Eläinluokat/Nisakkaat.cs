using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinluokat
{
    public abstract class Nisakkaat : Elain
    {
        private int _turkinpaksuus;
        public Nisakkaat() :base()
        {
            _turkinpaksuus = 3;
        }
        public Nisakkaat(int ika, string nimi) : base(ika, nimi) 
        {

        }
        public void AsetaTurkinPaksuus(int uusiturkinpaksuus)
        {
            _turkinpaksuus = uusiturkinpaksuus;
        }
        public int PalautaTurkinPaksuus()
        {
            Console.WriteLine("Turkinpaksuus on: "+_turkinpaksuus+"cm");
            return _turkinpaksuus;
        }
    }
}
