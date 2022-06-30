using UnityEngine;

namespace Abstracts
{
    public interface IProduceUnitCommand : ICommand
    {
        GameObject UnitPrefab { get; }
    }

    public interface IAttackCommand : ICommand { }
    public interface IMoveCommand : ICommand { }
    public interface IPatrolCommand : ICommand { }
    public interface IStopCommand : ICommand { }
}
