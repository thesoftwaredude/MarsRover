using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Interfaces
{
    public interface ILandscape
    {
        int CoordinateX { get; }
        int CoordinateY { get; }
        void MoveXForward();
        void MoveXBackward();
        void MoveYForward();
        void MoveYBackward();
    }
}
