using UnityEngine;

public class ControllerCharacter : MonoBehaviour
{
    public float _speed;
    public float _jump;
    public bool _isJump;
    public Rigidbody Rigidbody;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0 , v);

        Rigidbody.linearVelocity = new Vector3(move.x * _speed, Rigidbody.linearVelocity.y, move.z * _speed);

        if (Input.GetButtonDown("Jump") && !_isJump)
        {
            Rigidbody.AddForce(new Vector3(0, _jump, 0), ForceMode.Impulse);
            _isJump = true;

        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        _isJump = false;
    }
}
