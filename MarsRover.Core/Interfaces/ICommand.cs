namespace MarsRover.Core.Interfaces
{
    public interface ICommand
    {
        void Execute(IRover rover);
    }
}
