using UnityEngine;
using Abstracts;

public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log($"{command.ActionName} command is in progress");
    }
}

