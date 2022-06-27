using Abstacts;
using UnityEngine;

namespace InputSystem
{
    public class MouseInteractionPresenter : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private SelectableValue selectableValue;
        private void Update()
        {
            ChooseObject();
        }

        private void ChooseObject()
        {
            if (!Input.GetMouseButtonDown(0))
                return;

            RaycastHit[] hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));
            if (hits.Length == 0)
            {
                selectableValue.ResetCurrentSelection();
                return;
            }
            for (int i = 0; i < hits.Length; i++)
            {
                ISelectable selectable;
                bool isProduces = hits[i].collider.TryGetComponent<ISelectable>(out selectable);
                if (isProduces)
                {
                    selectableValue.SetValue(selectable);
                    return;
                }

            }
        }
    }
}