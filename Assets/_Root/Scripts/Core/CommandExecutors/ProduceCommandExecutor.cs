using UnityEngine;
using Abstracts;

public class ProduceCommandExecutor : CommandExecutorBase<IProduceUnitCommand>
{
    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(
            command.UnitPrefab,
            new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)),
            Quaternion.identity);
    }
}
