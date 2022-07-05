using System;
using System.Reflection;
using UnityEngine;

public static class AssetInjector
{
	private static readonly Type injectAssetAttribute = typeof(InjectAssetAttribute);

	public static T Inject<T>(this AssetContext context, T target)
	{
		Type targetType = target.GetType();
		FieldInfo[] targetFields = targetType.GetFields(BindingFlags.NonPublic |
												BindingFlags.Instance |
												BindingFlags.Public);

        for (int i = 0; i < targetFields.Length; i++)
        {
			FieldInfo fieldInfo = targetFields[i];
			InjectAssetAttribute _injectAssetAttrubute = fieldInfo.GetCustomAttribute(injectAssetAttribute) as InjectAssetAttribute;
			if (_injectAssetAttrubute == null)
				continue;

			var objectToInject = context.GetObjectOfType(fieldInfo.FieldType, _injectAssetAttrubute.assetName);
			fieldInfo.SetValue(target, objectToInject);
		}



		return target;
	}
}

