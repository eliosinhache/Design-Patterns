using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command
{
    class Invoker
    {
        private List<Command> _commands = new List<Command>();

        public void AddCommand(Command command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands() { 
            _commands.ForEach(x => x.execute());
            _commands.Clear();
        }

    }
}
