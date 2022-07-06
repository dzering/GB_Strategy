using UnityEngine;
using Abstracts;

public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
{
    public override void ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log($"{command.ActionName} command is in progress");
    }
}