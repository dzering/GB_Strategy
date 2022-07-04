using Abstracts;
using UnityEngine;

namespace Core.Units
{
    public class MainUnit : MonoBehaviour, ISelectable
    {
        [SerializeField] private float health;
        [SerializeField] private float maxHealth;
        [SerializeField] private Sprite icon;

        public float Health => health;

        public float MaxHealth => maxHealth;

        public Sprite Icon => icon;

        public string Name => gameObject.name;
    }

}
