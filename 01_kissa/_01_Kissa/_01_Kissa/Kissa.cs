using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _01_Kissa
{
    public class Kissa
    {
        private int _age;
        public string _name;

        public Kissa()
        {
            _age = 4;
            _name = "no name";
        }
        public Kissa(int Age, string Name)
        {
            _age = Age;
            _name = Name;
        }
        public void SetCatName(string NewName)
        {
            _name = NewName;
        }

        public string ReturnCatName()
        {
            return _name;
        }
        public int ReturnCatAge
        {
            get
            {
                return _age;
            }

        }
        public void SetCatAge(int NewAge)
        {
            if (NewAge >= 0) 
            {
                _age = NewAge;
            }
            
        }
        
        
        
    }
}
