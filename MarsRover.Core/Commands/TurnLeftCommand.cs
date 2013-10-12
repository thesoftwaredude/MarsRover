using System;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Commands
{
    public class TurnLeftCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}