using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/Weapon")]
    public class WeaponScriptableObject : ScriptableObject
    {
        public Sprite visual;
        public int damage = 1;
    }
}
