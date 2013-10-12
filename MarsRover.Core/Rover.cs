using MarsRover.Core.Commands;
using MarsRover.Core.Direction;
using MarsRover.Core.Interfaces;

namespace MarsRover.Core
{
    public class Rover : IRover
    {
        private readonly ILandscape _landscape;

        public IDirection Direction { get; private set; }

        public Rover(ILandscape landscape)
        {
            _landscape = landscape;
            Direction = new North(_landscape);
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void Forward()
        {
            Direction.Move();
        }


        public int CoordinateX
        {
            get { return _landscape.CoordinateX; }
        }

        public int CoordinateY
        {
            get { return _landscape.CoordinateY; }
        }

        public override string ToString()
        {
            return string.Format("X : {0}, Y : {1}, Direction : {2}", CoordinateX, CoordinateY, Direction);
        }


        public void ExecuteCommands(string commandString)
        {
            var commands = AvailableCommands.List;
            var commandParser = new CommandParser(commands);

            for (int index = 0; index < commandString.Length; index++)
            {
                var command = commandString[index].ToString();
                var commandToExecute = commandParser.ParseCommand(command);
                commandToExecute.Execute(this);
            }
        }

    }
}
