using System.Reflection;
using System;
public static class AssetInjector
{
	private static readonly Type injectAssetAttributeType = typeof(InjectAssetAttribute); 
	public static T Inject<T>(this AssetContext context, T target)
	{
		
		Type targetType = target.GetType();
		while(targetType != null)
        {
			FieldInfo[] allFields = targetType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < allFields.Length; i++)
			{
				FieldInfo fieldInfo = allFields[i];
				InjectAssetAttribute injectAssetAttribute =  fieldInfo.GetCustomAttribute(injectAssetAttributeType) as InjectAssetAttribute;

				if(injectAssetAttribute == null)
				{
					continue;
				}
				var objectToInject = context.GetObjectOfType(fieldInfo.FieldType, injectAssetAttribute.assetName);
				fieldInfo.SetValue(target, objectToInject);
			}
			targetType = targetType.BaseType;

        }
		return target;
	}
}

