using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Kissa
{
    public class Kissa
    {
        private int _age;
        public string _name;

        public Kissa()
        {
            _age = 0;
            _name = "no name";
        }
        public Kissa(int age, string name)
        {
            _age = age;
            _name = name;
        }
        public void SetCatName(string newname)
        {
            _name = newname;
        }
        public string ReturnCatName()
        {
            return _name;
        }
        public int ReturnCatAge()
        {
            return _age;
        }
    }
}
