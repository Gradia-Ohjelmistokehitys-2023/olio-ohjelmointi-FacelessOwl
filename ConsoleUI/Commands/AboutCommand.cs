using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    class AboutCommand : ICommand
    {
        string f = "Tekijä on Jussi";
        string s = "Upphovsman är Jussi";
        public string Name { get { return "about"; } }

        public string HelpText { get { return "Prints developer. Possible atributes:" +
                    "\n\t\t-f Shows text also in Finnish" +
                    "\n\t\t-s Shows text also in Swedish"; } }

        public string? Execute(string[] args) 
        {
            
            string palautus = "Made by Jussi";
            foreach (var arg in args)
            {
                
                switch (arg)
                {
                    case "f":
                        palautus = palautus + $"\n\t{f}";
                        break;
                    case "s":
                        palautus = palautus + $"\n\t{s}";
                        break;   

                }
               
            }

            return palautus;



        }
    }
}
