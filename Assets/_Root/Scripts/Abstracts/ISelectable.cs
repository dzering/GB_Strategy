using UnityEngine;

namespace Abstacts
{
    public interface ISelectable
    {
        float Health { get; }
        float MaxHealth { get; }
        Sprite Icon { get; }
        string Name { get; }
    }
}