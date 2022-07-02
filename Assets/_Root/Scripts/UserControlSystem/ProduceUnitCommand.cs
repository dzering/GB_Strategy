using Abstracts;
using UnityEngine;

namespace InputSystem
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => unitPfefab;
        [SerializeField] private GameObject unitPfefab;

    }
}
