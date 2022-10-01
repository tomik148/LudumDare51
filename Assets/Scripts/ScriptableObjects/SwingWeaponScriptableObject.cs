using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/SwingWeapon")]
    public class SwingWeaponScriptableObject : WeaponScriptableObject
    {
        [Range(0,360)]
        public int swingArc = 90;
        [Range(1,int.MaxValue)]
        public int swingSpeed = 1;
    }
}
