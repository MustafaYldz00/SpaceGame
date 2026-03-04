using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{
    private Rigidbody2D _landerRigidBody2D;

    private void Awake()
    {
        _landerRigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            float force = 700f;
            _landerRigidBody2D.AddForce(force * transform.up*Time.deltaTime);
            
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            float turnSpeed = -100f;
            _landerRigidBody2D.AddTorque(turnSpeed * Time.deltaTime);
            
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            float turnSpeed = 100f;
            _landerRigidBody2D.AddTorque(turnSpeed * Time.deltaTime);
           
        }
    }
}
