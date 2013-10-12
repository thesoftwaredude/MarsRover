using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    public class LandscapeTests
    {
        [Test]
        public void When_Create_The_Landscape_That_Rover_Position_Will_Be_0_0()
        {
            var landscape = new Landscape(5);
            Assert.That(landscape.CoordinateX, Is.EqualTo(0));
            Assert.That(landscape.CoordinateY, Is.EqualTo(0));
        }
    }
}
