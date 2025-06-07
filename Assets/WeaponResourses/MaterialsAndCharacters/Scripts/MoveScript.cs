using System;
using UnityEngine;


public class MoveScript : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpForce = 5f;
    private bool _isJumping = false;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float h = Input.GetAxis("");
        float v = Input.GetAxis("V");
        Vector3 move = new Vector3(h, 0f, v);

        _rb.linearVelocity = new Vector3(move.x * _speed, _rb.linearVelocity.y, move.z * _speed);

        if(Input.GetButtonDown("Jump") && !_isJumping)
        {
            _rb.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.Impulse);
            _isJumping = true;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _isJumping = false;
        }
    }
}
