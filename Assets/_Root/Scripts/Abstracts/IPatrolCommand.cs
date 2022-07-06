namespace Abstracts
{
    public interface IPatrolCommand : ICommand 
    {
        string ActionName { get; }
    }
}
