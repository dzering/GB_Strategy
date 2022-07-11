using Abstracts;
using UnityEngine;

namespace Core.Buildings
{
    public class MainBuilding : MonoBehaviour, ISelectable
    {
        [SerializeField] float health;
        [SerializeField] float maxHealth;
        [SerializeField] Sprite icon;
        public float Health => health;

        public float MaxHealth => maxHealth;

        public Sprite Icon => icon;

        public string Name => gameObject.name;
    }
}