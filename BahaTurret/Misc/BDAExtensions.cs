using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace BahaTurret
{
	public static class BDAExtensions
	{


		public static IEnumerable<AvailablePart> BDAParts(this List<AvailablePart> parts)
		{
			return (from avPart in parts.Where(p => p.partPrefab)
				let missile = avPart.partPrefab.GetComponent<MissileLauncher>()
				let moduleWeapon = avPart.partPrefab.GetComponent<ModuleWeapon>()
				let missileFire = avPart.partPrefab.GetComponent<MissileFire>()
				let moduleRadar = avPart.partPrefab.GetComponent<ModuleRadar>()
				let cm = avPart.partPrefab.GetComponent<CMDropper>()
				let tgp = avPart.partPrefab.GetComponent<ModuleTargetingCamera>()
				let rocket = avPart.partPrefab.GetComponent<RocketLauncher>()
				let otherModule = avPart.partPrefab.GetComponent<BDACategoryModule>()
				where missile || moduleWeapon || missileFire || moduleRadar || cm || tgp || rocket || otherModule
		        select avPart).ToList();
		}
	}
}

