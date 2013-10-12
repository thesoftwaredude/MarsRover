using System;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Commands
{
    public class TurnRightCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }
    }
}