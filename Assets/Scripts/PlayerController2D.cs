using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2D : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D _rb;
    private Vector2 _moveDelta;
        
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveDelta = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _moveDelta = _moveDelta.normalized * speed;
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _moveDelta * Time.fixedDeltaTime);
    }
}
