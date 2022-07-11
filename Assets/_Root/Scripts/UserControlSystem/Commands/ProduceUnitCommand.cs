using Abstracts;
using UnityEngine;

namespace InputSystem.Commands
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => unitPfefab;
        [InjectAsset("Enemy01")]private GameObject unitPfefab;
    }
}
