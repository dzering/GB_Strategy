using Abstacts;
using UnityEngine;

namespace Buildings
{
    public class MainBuilding : MonoBehaviour, IUnitProducer, ISelectable
    {
        [SerializeField] float health;
        [SerializeField] float maxHealth;
        [SerializeField] Sprite icon;
        public float Health => health;

        public float MaxHealth => maxHealth;

        public Sprite Icon => icon;

        public string Name => gameObject.name;

        public void ProduceUnit()
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere).
                transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        }
    }
}