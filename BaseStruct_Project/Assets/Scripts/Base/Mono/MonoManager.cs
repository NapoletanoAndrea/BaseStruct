using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Base.Mono
{

	public class MonoManager : MonoBehaviour
	{
		private static List<BaseMono> _baseMonoList;
		
		private void Awake()
		{
			_baseMonoList = FindObjectsOfType<BaseMono>().ToList();
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
