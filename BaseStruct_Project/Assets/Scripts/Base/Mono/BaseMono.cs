using System;
using UnityEngine;

namespace Base.Mono
{

	public abstract class BaseMono : MonoBehaviour
	{

		#region Fields

		protected bool _multiPreAwakeable = true;
		private bool _initialized = false;

		#endregion

		#region Overridable Methods

		protected virtual void Awake()
		{ }

		protected virtual void PreAwake()
		{ }

		protected virtual void MonoUpdate()
		{ }

		protected virtual void MonoFixedUpdate()
		{ }

		#endregion

		#region Public Methods

		public virtual void Public_PreAwake()
		{
			if (_initialized && !_multiPreAwakeable)
				return;

			_initialized = true;
			PreAwake();
		}

		public virtual void Public_MonoUpdate()
		{
			MonoUpdate();
		}

		public virtual void Public_MonoFixedUpdate()
		{
			MonoFixedUpdate();
		}

		#endregion

	}

}