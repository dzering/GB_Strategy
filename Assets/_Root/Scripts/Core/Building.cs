using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour, IProduce
{
    public void Produce()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere).
            transform.position = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10,10));        
    }
}
