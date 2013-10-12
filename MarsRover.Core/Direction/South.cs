using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Direction
{
    public class South : IDirection
    {
        private readonly ILandscape _landscape;

        public South(ILandscape landscape)
        {
            _landscape = landscape;
        }

        public IDirection TurnLeft()
        {
            return new East(_landscape);
        }

        public IDirection TurnRight()
        {
            return new West(_landscape);
        }

        public void Move()
        {
            _landscape.MoveYBackward();
        }

        public override string ToString()
        {
            return "South";
        }
    }
}