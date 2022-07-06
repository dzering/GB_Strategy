using UnityEngine;
using System;
using Object = UnityEngine.Object;

[CreateAssetMenu(menuName ="Strategy/" + nameof(AssetContext), order =0, fileName = nameof(AssetContext))]
public class AssetContext : ScriptableObject
{
	[SerializeField] private Object[] objects;

	public object GetObjectOfType(Type type, string name = null)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            var obj = objects[i];
            if (obj.GetType().IsAssignableFrom(type))
            {
                if(objects[i].name == null || objects[i].name == name)
                {
                    return objects[i];
                }
            }

        }
        return null;
    }
	
}

