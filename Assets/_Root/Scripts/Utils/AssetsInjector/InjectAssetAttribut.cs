using System;
using UnityEngine;


[AttributeUsage(AttributeTargets.Field)]

public class InjectAssetAttribute : Attribute
{
    public readonly string assetName;
    public InjectAssetAttribute(string assetName = null)
    {
        this.assetName = assetName;
    }

}
