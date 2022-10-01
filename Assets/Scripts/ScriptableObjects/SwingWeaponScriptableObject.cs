using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "WeaponScriptableObject",menuName = "ScriptableObjects/SwingWeapon")]
    public class SwingWeaponScriptableObject : WeaponScriptableObject
    {
        [Range(0,360)]
        public float swingArc = 90f;
        public float swingSpeed = 1f;
        public float swingLength = 1f;
        public override void Activate(GameObject weaponObj)
        {
            //Vector3 ang = Vector3.RotateTowards(weaponObj.transform.up, -weaponObj.transform.up, ( * 2,0f);
            
            Vector3 forward = weaponObj.transform.up;
            Vector3 pos = weaponObj.transform.position;
            Vector3 ang = Quaternion.AngleAxis((swingArc/2f), Vector3.forward) * forward;
            Vector3 ang2 = Quaternion.AngleAxis(-(swingArc/2f), Vector3.forward) * forward;

            ang *= swingLength;
            ang2 *= swingLength;
            forward *= swingLength;
            Debug.DrawRay(pos, ang, Color.red);
            Debug.DrawRay(pos, ang2, Color.red);
            Debug.DrawRay(pos, forward, Color.red);
            Debug.Log(Physics2D.CircleCast(pos, swingLength,ang,swingArc));
        }
    }
}
