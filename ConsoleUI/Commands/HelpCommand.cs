using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    class HelpCommand : ICommand
    {
        public string Name { get { return "?"; } }

        public string HelpText { get { return ""; } }

        public string? Execute(string[] args)
        {
            return "";
        }
            

            
        
    }
}
