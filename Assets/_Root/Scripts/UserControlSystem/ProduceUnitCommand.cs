using Abstracts;
using UnityEngine;

namespace InputSystem
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => unitPfefab;
        [InjectAsset("Enemy01")] private GameObject unitPfefab;

    }
}
