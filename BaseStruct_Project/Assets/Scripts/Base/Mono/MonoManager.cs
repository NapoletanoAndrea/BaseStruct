using System.Collections.Generic;
using UnityEngine;

namespace Base.Mono
{

	public class MonoManager : MonoBehaviour
	{
		private static List<BaseMono> _baseMonoList;

		private void Awake()
		{
			_baseMonoList = new(FindObjectsOfType<BaseMono>());
			for (int i = 0; i < _baseMonoList.Count; i++)
			{
				_baseMonoList[i].Public_PreAwake();
			}
		}

		private void Update()
		{
			for (int i = 0; i < _baseMonoList.Count; i++)
			{
				_baseMonoList[i].Public_MonoUpdate();
			}
		}
		
		private void FixedUpdate()
		{
			for (int i = 0; i < _baseMonoList.Count; i++)
			{
				_baseMonoList[i].Public_MonoFixedUpdate();
			}
		}

		private void LateUpdate()
		{
			for (int i = 0; i < _baseMonoList.Count; i++)
			{
				_baseMonoList[i].Public_MonoLateUpdate();
			}
		}

		public static void Add(BaseMono baseMono)
		{
			_baseMonoList.AddUnique(baseMono);
		}

		public static void Remove(BaseMono baseMono)
		{
			_baseMonoList.TryRemove(baseMono);
		}
	}

}
