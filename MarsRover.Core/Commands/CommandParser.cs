using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Commands
{
    public class CommandParser
    {
        private readonly Dictionary<string, ICommand> _commands;

        public CommandParser(Dictionary<string, ICommand> commands)
        {
            _commands = commands;
        }

        public ICommand ParseCommand(string command)
        {
            if (_commands.ContainsKey(command))
                return _commands[command];
            return new NotFoundCommand();
        }
    }
}
