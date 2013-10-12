using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Commands;
using MarsRover.Core.Interfaces;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    public class CommandParserTests
    {
        private Dictionary<string, ICommand> _availableCommands;

        [SetUp]
        public void Setup()
        {
            _availableCommands = AvailableCommands.List;
        }

        [Test]
        public void Get_Correct_Command_To_Move_Forward()
        {
            var commandParser = new CommandParser(_availableCommands);
            var command = commandParser.ParseCommand("F");
            Assert.That(command, Is.TypeOf<ForwardCommand>());
        }

        [Test]
        public void Get_Correct_Command_To_Turn_Left()
        {
            var commandParser = new CommandParser(_availableCommands);
            var command = commandParser.ParseCommand("L");
            Assert.That(command, Is.TypeOf<TurnLeftCommand>());
        }

        [Test]
        public void Get_Correct_Command_To_Turn_Right()
        {
            var commandParser = new CommandParser(_availableCommands);
            var command = commandParser.ParseCommand("R");
            Assert.That(command, Is.TypeOf<TurnRightCommand>());
        }

        [Test]
        public void Get_NullCommand_With_Invalid_Command()
        {
            var commandParser = new CommandParser(_availableCommands);
            var command = commandParser.ParseCommand("G");
            Assert.That(command, Is.TypeOf<NotFoundCommand>());
        }

    }
}
