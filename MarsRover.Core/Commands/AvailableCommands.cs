using System.Collections.Generic;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Commands
{
    public static class AvailableCommands
    {
        public static Dictionary<string, ICommand> List
        {
            get
            {
                var commands = new Dictionary<string, ICommand>
                    {
                        {"F", new ForwardCommand()},
                        {"L", new TurnLeftCommand()},
                        {"R", new TurnRightCommand()}
                    };
                return commands;
            }
        }
    }
}