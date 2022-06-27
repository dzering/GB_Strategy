using UnityEngine;
using Abstacts;


namespace InputSystem
{
    public class OutlinerPresenter : MonoBehaviour
    {
        private GameObject outline;
        [SerializeField] private Transform parantTransform;
        [SerializeField] private SelectableValue selectableValue;

        private void Start()
        {
            outline ??= CreateOutliner();
            outline.transform.SetParent(parantTransform);
            outline.transform.localPosition = Vector3.zero;
            selectableValue.OnSelected += ShowSelected;
            ShowSelected(selectableValue.CurrentSelection);
        }

        private GameObject CreateOutliner()
        {
            GameObject outline = GameObject.CreatePrimitive(PrimitiveType.Plane);
            outline.GetComponent<Renderer>().material.color = Color.yellow;
            return outline;
        }

        private void ShowSelected(ISelectable selectable) 
        {
            outline.SetActive(false);
            if (selectableValue.CurrentSelection == null)
                return;
            if (selectableValue.CurrentSelection.Name == parantTransform.gameObject.name)
                outline.SetActive(true);


        }

        private void OnDestroy()
        {
            selectableValue.OnSelected-=ShowSelected;
        }
    }
}
