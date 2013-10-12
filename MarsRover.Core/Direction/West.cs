using MarsRover.Core.Interfaces;

namespace MarsRover.Core.Direction
{
    public class West : IDirection
    {
        private readonly ILandscape _landscape;

        public West(ILandscape landscape)
        {
            _landscape = landscape;
        }

        public IDirection TurnLeft()
        {
            return new South(_landscape);
        }

        public IDirection TurnRight()
        {
            return new North(_landscape);
        }

        public void Move()
        {
            _landscape.MoveXBackward();
        }

        public override string ToString()
        {
            return "West";
        }
    }
}