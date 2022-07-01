using InputSystem;
using Abstracts;
using UnityEngine;

namespace UI
{
    public class OutlineSelectorPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue selectableValue;
        private OutlineSelector[] outlineSelectors;
        private ISelectable currentSelectable;


        private void Start()
        {
            selectableValue.OnSelected += onSelected;
            onSelected(selectableValue.CurrentSelection);
        }

        private void onSelected(ISelectable selectable)
        {
            if (currentSelectable == selectable)
                return;

            currentSelectable = selectable;

            setSelected(outlineSelectors, false);
            outlineSelectors = null;

            if(selectable != null)
            {
                outlineSelectors = (selectable as Component).GetComponents<OutlineSelector>();
                setSelected(outlineSelectors, true);
            }


        }

        private void setSelected(OutlineSelector[] outlineSelectors, bool value)
        {
            if(outlineSelectors != null)
            {
                for (int i = 0; i < outlineSelectors.Length; i++)
                {
                    outlineSelectors[i].SetSelection(value);
                }
            }
        }
    }
}