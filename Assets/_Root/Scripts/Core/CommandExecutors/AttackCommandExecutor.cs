﻿using UnityEngine;
using Abstracts;

public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
{
    public override void ExecuteSpecificCommand(IAttackCommand command)
    {
        Debug.Log($"{command.ActionName} command is in progress");
    }
}
