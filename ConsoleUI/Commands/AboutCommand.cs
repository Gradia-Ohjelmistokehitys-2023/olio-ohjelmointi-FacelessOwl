using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    class AboutCommand : ICommand
    {
        public string f = "Tekijä on Jussi";
        public string s = "Upphovsman är Jussi";
        public string Name { get { return "about"; } }

        public string HelpText { get { return "Prints developer. Possible atributes:" +
                    "\t\t-f Shows text also in Finnish" +
                    "\t\t-s Shows text also in Swedish"; } }

        public string? Execute(string[] args) 
        {
            foreach (string arg in args)
            {
                if (arg == "f")
                {
                    return f;
                }
                else if (arg == "s")
                {
                    return s;
                }
                
            }
            return "Made by Jussi";
            
        }
    }
}
