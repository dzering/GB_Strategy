namespace Abstracts
{
    public interface IAttackCommand : ICommand 
    {
        string ActionName { get; }
    }
}
