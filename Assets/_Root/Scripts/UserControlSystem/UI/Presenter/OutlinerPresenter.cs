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
            InitOutline();

            selectableValue.OnSelected += ShowSelected;
            ShowSelected(selectableValue.CurrentSelection);
        }

        private void InitOutline()
        {
            outline.transform.SetParent(parantTransform);
            outline.transform.localPosition = Vector3.zero;

            outline.transform.Rotate(90, 0, 0);
            outline.transform.localScale = Vector3.one * 1.4f;


            Vector3 position = parantTransform.GetComponent<BoxCollider>().size;
            outline.transform.position = parantTransform.position + Vector3.down * position.y / 2;


        }

        private GameObject CreateOutliner()
        {
            GameObject outline = GameObject.CreatePrimitive(PrimitiveType.Quad);
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
