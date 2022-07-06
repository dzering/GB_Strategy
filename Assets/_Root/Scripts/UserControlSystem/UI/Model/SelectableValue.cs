using Abstracts;
using System;
using UnityEngine;

namespace InputSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObject
    {
        public ISelectable CurrentSelection;
        public event Action<ISelectable> OnSelected;

        public void SetValue(ISelectable selectable)
        {
            CurrentSelection = selectable;
            OnSelected?.Invoke(selectable);
        }

        public void ResetCurrentSelection()
        {
            CurrentSelection = null;
            OnSelected?.Invoke(CurrentSelection);
        }
    }
}