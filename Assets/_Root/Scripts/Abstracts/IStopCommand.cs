namespace Abstracts
{
    public interface IStopCommand : ICommand 
    {
        string ActionName { get; }
    }
}
