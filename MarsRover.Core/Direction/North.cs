using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Direction
{
    public class North : IDirection
    {
        private readonly ILandscape _landscape;

        public North(ILandscape landscape)
        {
            _landscape = landscape;
        }

        public IDirection TurnLeft()
        {
            return new West(_landscape);
        }

        public IDirection TurnRight()
        {
            return new East(_landscape);
        }

        public void Move()
        {
            _landscape.MoveYForward();
        }

        public override string ToString()
        {
            return "North";
        }
    }
}
