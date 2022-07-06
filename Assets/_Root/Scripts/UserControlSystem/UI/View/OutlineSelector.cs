using System;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class OutlineSelector : MonoBehaviour
{
    private Transform target;
    private GameObject outlineSelector;
    private float offsetSize = 1.4f;
    private bool isSelectedCash;

    private void Start()
    {
        target = transform;
        outlineSelector ??= CreateOutlineSelector();
        outlineSelector.SetActive(isSelectedCash);
    }

    private GameObject CreateOutlineSelector()
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Quad);
        go.transform.Rotate(90,0, 0);

        Vector3 size = transform.gameObject.GetComponent<BoxCollider>().size;
        go.transform.localScale = new Vector3(size.x * offsetSize, size.z * offsetSize, 0.01f);

        go.transform.position = transform.position + Vector3.down * size.y / 2;
        go.transform.SetParent(transform);

        //Create material
        Material mat = new Material(Shader.Find("Standard"));

        mat.SetColor("_Color", new Color(1, 0, 0, 0.5f));
        mat.SetFloat("_Mode", 3);
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        mat.EnableKeyword("_ALPHABLEND_ON");
        mat.renderQueue = 3000;

        go.GetComponent<Renderer>().material = mat;

        return go;
    }

    public void SetSelection(bool isSelected)
    {
        if (isSelectedCash == isSelected)
            return;

        if(isSelected)
            outlineSelector.SetActive(isSelected);
        else
            outlineSelector.SetActive(false);

        isSelectedCash = isSelected;

    }
}
