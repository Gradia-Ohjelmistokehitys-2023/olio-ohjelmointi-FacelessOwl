﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    public  class CommandHandler
    {
        // Add here all new commands
        public static List<ICommand> commands = new List<ICommand>()
        {
            new HelpCommand(),new ClearCommand(),new ExitCommand(),new AboutCommand()
            
        };
        
        

        public static void RegisterCommands()
        {
            foreach (ICommand command in commands)
            {
                Program.Registry.RegisterCommand(command);
            }
        }
    }
}
