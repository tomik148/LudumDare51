using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/ThrustWeapon")]
    public class ThrustWeaponScriptableObject : WeaponScriptableObject
    {
        public int thrustLength;
        public bool dash = false;


        public override void Activate(GameObject weaponObj)
        {
            throw new System.NotImplementedException();
        }
    }
}
