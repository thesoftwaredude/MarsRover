using MarsRover.Core;
using MarsRover.Core.Direction;
using MarsRover.Core.Interfaces;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    public class RoverTests
    {
        private ILandscape _landscape;
        
        [SetUp]
        public void Setup()
        {
            _landscape = new Landscape(5);
        }

        [Test]
        public void When_Rover_Is_Created_Start_At_North()
        {
            var rover = new Rover(_landscape);
            Assert.That(rover.Direction, Is.TypeOf<North>());
        }

        [Test]
        public void When_Rover_Is_Created_And_Turn_Left_The_Direction_Is_West()
        {
            var rover = new Rover(_landscape);
            rover.TurnLeft();
            Assert.That(rover.Direction, Is.TypeOf<West>());
        }

        [Test]
        public void When_Rover_Is_Created_And_Turn_Right_The_Direction_Is_East()
        {
            var rover = new Rover(_landscape);
            rover.TurnRight();
            Assert.That(rover.Direction, Is.TypeOf<East>());
        }
        
        [Test]
        public void When_Rover_Is_Created_Is_Facing_North_And_Move_Rover_Will_Be_At_Coordinates_0_1()
        {
            var rover = new Rover(_landscape);
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }

        [Test]
        public void When_The_Rover_Is_Created_Turn_Right_And_Move_Rover_Will_Be_At_Coordinates_1_0()
        {
            var rover = new Rover(_landscape);
            rover.TurnRight();
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(1));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));            
        }

        [Test]
        public void When_The_Rover_Is_Created_And_Move_So_That_Facing_South_And_Move_Coordinates_Will_Be_0_1()
        {
            var rover = new Rover(_landscape);
            rover.Forward();
            rover.Forward();
            rover.TurnRight();
            rover.TurnRight();
            Assert.That(rover.Direction, Is.TypeOf<South>());
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }

        [Test]
        public void When_The_Rover_Is_Created_And_Move_So_That_Facing_West_And_Move_Coordinates_Will_Be_1_0()
        {
            var rover = new Rover(_landscape);
            rover.TurnRight();
            rover.Forward();
            rover.Forward();
            rover.TurnRight();
            rover.TurnRight();
            Assert.That(rover.Direction, Is.TypeOf<West>());
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(1));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }

        [Test]
        public void When_Start_Move_Turn_Turn_Move_Back_To_Home_Coordindates()
        {
            var rover = new Rover(_landscape);
            rover.Forward();
            rover.TurnLeft();
            rover.TurnLeft();
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }
        
        [Test]
        [TestCase("RFLFFRF", 2, 2, "East")]
        [TestCase("RFLLF", 0, 0, "West")]
        public void TestMovement(string commandString, int xCoordinateExpected, int yCoordinateExpected, string directionExpected)
        {
            var rover = new Rover(_landscape);
            rover.ExecuteCommands(commandString);
            Assert.That(rover.CoordinateX, Is.EqualTo(xCoordinateExpected));
            Assert.That(rover.CoordinateY, Is.EqualTo(yCoordinateExpected));
            Assert.That(rover.Direction.ToString(), Is.EqualTo(directionExpected));
        }
    }
}
