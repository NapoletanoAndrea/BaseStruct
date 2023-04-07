namespace Base.Mono
{

	public abstract class VolatileMono : BaseMono
	{
		protected override void Awake()
		{
			base.Awake();
			MonoManager.Add(this);
			PreAwake();
		}

		protected virtual void OnDestroy()
		{
			MonoManager.Remove(this);
		}
	}

}