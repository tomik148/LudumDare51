using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/RangeWeapon")]
    public class RangeWeaponScriptableObject : WeaponScriptableObject
    {
        public GameObject projectile;
        public int projectileSpeed = 1;
        public int projectileNumber = 1;
        [Range(0,360)]
        public int projectileSpread = 90;

        public override void Activate(GameObject weaponObj)
        {
            throw new System.NotImplementedException();
        }
    }
}
