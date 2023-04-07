using System.Collections.Generic;
using UnityEngine;

namespace Base.ComponentLocation
{

	public static class ServiceUtils
	{
		public static Dictionary<Component, ComponentLocator> Locators = new();

		public static ComponentLocator GetLocator(this Component component)
		{
			if (Locators.TryGetValue(component, out var locator))
			{
				return locator;
			}
			return null;
		}

		public static T GetLocator<T>(this Component component) where T : ComponentLocator
		{
			return (T) GetLocator(component);
		}
	}

}