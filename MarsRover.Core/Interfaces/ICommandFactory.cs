namespace MarsRover.Core.Interfaces
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Description { get; }

        ICommand MakeCommand(string[] arguments);
    }
}