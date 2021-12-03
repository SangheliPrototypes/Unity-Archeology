using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sangheli.Game
{
	[CreateAssetMenu(fileName = "ConfigChance", menuName = "SangheliGame/CreateChanceConfig", order = 1)]
	public class ChanceController : ScriptableObject
	{
		[SerializeField]
		private float maxChanceForField;

		public float GetChanceForField()
		{
			float value = Random.value;

			if (value > this.maxChanceForField)
				value = maxChanceForField;

			return value;
		}
	}
}