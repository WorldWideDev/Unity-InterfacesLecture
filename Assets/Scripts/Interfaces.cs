using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFunnyInterfaces
{
	interface IDammageable
	{
		void TakeDamage(int dmgAmount);

		void AssessDamage();
	}
}
