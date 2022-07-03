public static class AssetInjector
{
	public static T Inject<T>(this AssetContext context, T target)
	{
		return target;
	}
}

