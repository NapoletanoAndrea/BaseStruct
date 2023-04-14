namespace Base.Mono
{

	public abstract class VolatileMono : BaseMono
	{
		protected virtual void Awake()
		{
			MonoManager.Add(this);
			PreAwake();
		}

		protected virtual void OnDestroy()
		{
			MonoManager.Remove(this);
		}
	}

}