using Abstracts;
using UnityEngine;

namespace Core.Buildings
{
    public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable
    {
        [SerializeField] float health;
        [SerializeField] float maxHealth;
        [SerializeField] Sprite icon;
        public float Health => health;

        public float MaxHealth => maxHealth;

        public Sprite Icon => icon;

        public string Name => gameObject.name;

        public override void ExecuteSpecificCommand(IProduceUnitCommand command)
        {
            Instantiate(
                command.UnitPrefab,
                new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)),
                Quaternion.identity);
        }
    }
}