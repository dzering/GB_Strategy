namespace Abstracts
{
    public interface IMoveCommand : ICommand 
    {
        string ActionName { get; }
    }
}
