using UnityEngine;
using Abstracts;

public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
{
    public override void ExecuteSpecificCommand(IStopCommand command)
    {
        Debug.Log($"{command.ActionName} command is in progress");
    }
}

