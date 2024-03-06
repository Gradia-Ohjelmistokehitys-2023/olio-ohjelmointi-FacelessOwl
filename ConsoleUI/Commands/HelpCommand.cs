using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConsoleUI.Commands
{
    class HelpCommand : ICommand
    {
        public string Name { get { return "?"; } }

        public string HelpText { get { return "Prints description of every command."; } }

        public string? Execute(string[] args)
        {
            string palautus = "\n";
            foreach (ICommand command in CommandHandler.commands)
            {
                 palautus = palautus +"["+command.Name+"]\t"+command.HelpText+"\n";
            }
        
            
            return palautus;            
        }
            

            
        
    }
}
