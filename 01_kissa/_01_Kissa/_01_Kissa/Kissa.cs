using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _01_Kissa
{
    public class Kissa
    {
        private int _age;
        public string _name;

        public override string ToString()
        {
            return "Kissa: " + _name + ", ikä " + _age;
        }
        public Kissa()
        {
            _age = 4;
            _name = "Miuku";
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
        
        public bool SetCatAge(int NewAge)
        {
            if (NewAge >= 0)
            {
                _age = NewAge;
                Console.WriteLine("Age has been changed");
                return true;
            }
            else
            {
                Console.WriteLine("Age was not changed");
                return false;
            }


        }

        /// <summary>
        /// <c>SetNewCatName</c> method changes Kissa's name but it doesn't accept the name to be hilda.
        /// </summary>   
        public bool SetNewCatName(string Newname)
        {
            
            string tempname = Newname;
            string lowtempname = tempname.ToLower();
            if (lowtempname == "hilda")
            {
                return false;
            }
            else
            {
                _name = Newname;
                return true;
            }
        }

        
    }
}
        
        
        
    

