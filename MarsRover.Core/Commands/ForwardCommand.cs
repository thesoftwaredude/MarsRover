using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Commands
{
    public class ForwardCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.Forward();
        }
    }
}
