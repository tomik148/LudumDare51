using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/ThrustWeapon")]
    public class ThrustWeaponScriptableObject : WeaponScriptableObject
    {
        [Range(0,360)]
        public int swingArc = 90;
        [Range(1,int.MaxValue)]
        public int swingSpeed = 1;
    }
}
