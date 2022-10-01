using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/Weapon")]
    public abstract class WeaponScriptableObject : ScriptableObject
    {
        public Sprite visual;
        public int damage = 1;
        public int cooldown = 1;

        public abstract void Activate(GameObject weaponObj);
    }
}
