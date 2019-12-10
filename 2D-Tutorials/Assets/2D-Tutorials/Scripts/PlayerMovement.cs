using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement:MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private Rigidbody2D _RB2D;

    private Vector2 _moveInput;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Movement();
    }

    void Movement() {
        _moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw( "Vertical" ));

        _moveInput.Normalize();

        _RB2D.velocity = _moveInput * _speed;
    }
}
