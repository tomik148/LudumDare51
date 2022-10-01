using ScriptableObjects;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class WeaponHandler : MonoBehaviour
{
    public WeaponScriptableObject weapon;
    public Vector3 d = Vector3.forward;
    
    private GameObject _childObject;
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _childObject = new GameObject("WeaponHolder");
        _childObject.transform.SetParent(this.transform,false);
        _spriteRenderer = _childObject.AddComponent<SpriteRenderer>();
        if (weapon != null)
        {
            _spriteRenderer.sprite = weapon.visual;
        }
    }

    public void ChangeWeapon(WeaponScriptableObject weapon)
    {
        this.weapon = weapon;
        _spriteRenderer.sprite = weapon.visual;
    }
    
    // Update is called once per frame
    void Update()
    {
        var mouseWordPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWordPosition.z = 0;    
        //Debug.DrawLine(transform.position, mouseWordPosition);
        var dir =  mouseWordPosition - transform.position;
        var rot = _childObject.transform.rotation;
        rot.eulerAngles = (new Vector3(0,0, -Vector3.SignedAngle(dir,Vector3.up,Vector3.forward)));
        _childObject.transform.rotation = rot;
    }
}
