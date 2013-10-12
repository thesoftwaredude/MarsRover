using MarsRover.Core;
using MarsRover.Core.Direction;
using MarsRover.Core.Interfaces;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class TestDirection
    {
        ILandscape _landscape;

        [SetUp]
        public void Setup()
        {
            _landscape = new Landscape(5);
        }

        [Test]
        public void When_North_And_Turn_Left_Direction_Should_Be_West()
        {
            var direction = new North(_landscape);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<West>());
        }

        [Test]
        public void When_North_And_Turn_Right_Direction_Should_Be_East()
        {
            var direction = new North(_landscape);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<East>());
        }

        [Test]
        public void When_East_And_Turn_Left_Direction_Should_Be_North()
        {
            var direction = new East(_landscape);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<North>());
        }

        [Test]
        public void When_East_And_Turn_Right_Direction_Should_Be_South()
        {
            var direction = new East(_landscape);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<South>());
        }

        [Test]
        public void When_South_And_Turn_Left_Direction_Should_Be_East()
        {
            var direction = new South(_landscape);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<East>());
        }

        [Test]
        public void When_South_And_Turn_Right_Direction_Should_Be_West()
        {
            var direction = new South(_landscape);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<West>());
        }

        [Test]
        public void When_West_And_Turn_Left_Direction_Should_Be_South()
        {
            var direction = new West(_landscape);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<South>());
        }

        [Test]
        public void When_West_And_Turn_Right_Direction_Should_Be_North()
        {
            var direction = new West(_landscape);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<North>());
        }

        [Test]
        public void When_At_Start_And_Facing_South_And_Move_Do_Not_Pass_Boundary()
        {
            var direction = new South(_landscape);
            direction.Move();
            Assert.That(_landscape.CoordinateX, Is.EqualTo(0));
            Assert.That(_landscape.CoordinateY, Is.EqualTo(0));
        }

        [Test]
        public void When_At_Start_And_Facing_West_And_Move_Do_Not_Pass_Boundary()
        {
            var direction = new West(_landscape);
            direction.Move();
            Assert.That(_landscape.CoordinateX, Is.EqualTo(0));
            Assert.That(_landscape.CoordinateY, Is.EqualTo(0));
        }
        
        [Test]
        public void When_Moving_North_At_Y_Boundary_Do_Not_Pass_Boundary()
        {
            var direction = new North(_landscape);
            for (int i = 0; i < 10; i++)
            {
                direction.Move();
            }
            Assert.That(_landscape.CoordinateX, Is.EqualTo(0));
            Assert.That(_landscape.CoordinateY, Is.EqualTo(5));
        }

        [Test]
        public void When_Moving_East_At_X_Boundary_Do_Not_Pass_Boundary()
        {
            var direction = new East(_landscape);
            for (int i = 0; i < 10; i++)
            {
                direction.Move();
            }
            Assert.That(_landscape.CoordinateX, Is.EqualTo(5));
            Assert.That(_landscape.CoordinateY, Is.EqualTo(0));
        }
    }
}
