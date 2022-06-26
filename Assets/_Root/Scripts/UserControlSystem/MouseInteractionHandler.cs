using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractionHandler : MonoBehaviour
{
    [SerializeField] private Camera _camera;
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
            return;
        for (int i = 0; i < hits.Length; i++)
        {
            IProduce produce;
            bool isProduces = hits[i].collider.TryGetComponent<IProduce>(out produce);
            if(isProduces && produce != null)
            {
                produce.Produce();
                return;
            }

        }
    }
}
