using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHelp();
            var landscape = new Landscape(5);
            var rover = new Rover(landscape);
            Console.WriteLine(rover.ToString());
            string commandsToExecute = string.Empty;
            while (commandsToExecute != "E")
            {
                Console.Write("Enter Commands: ");
                commandsToExecute = Console.ReadLine().ToUpper();
                rover.ExecuteCommands(commandsToExecute);
                Console.WriteLine();
                Console.WriteLine(string.Format("Current Rover Position Heading: {0}",rover.ToString()));
            }
        }

        private static void WriteHelp()
        {
            Console.WriteLine("Valid Commands are:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("F - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Enter to execute commands");
        }
    }
}
