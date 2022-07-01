using Abstracts;
using System.Collections.Generic;
using UnityEngine;

public class ProduceUnitCommand : IProduceUnitCommand
{
    public GameObject UnitPrefab => unitPfefab;
    [SerializeField] private GameObject unitPfefab;

}
