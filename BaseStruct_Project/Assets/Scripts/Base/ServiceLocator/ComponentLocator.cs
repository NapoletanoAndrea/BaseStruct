using System;
using System.Collections.Generic;
using Base.Mono;
using UnityEngine;

namespace Base.ComponentLocation
{

	public class ComponentLocator : BaseMono
	{
		[SerializeField] private Component[] components;

		private Dictionary<Type, Component> _services;

		protected override void PreAwake()
		{
			foreach (var component in components)
			{
				ServiceUtils.Locators.TryAdd(component, this);
			}
		}

		public T Get<T>() where T : Component
		{
			return (T) _services[typeof(T)];
		}
	}

}


