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
        if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            float force = 700f;
            _landerRigidBody2D.AddForce(force * transform.up*Time.deltaTime);
            
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            float turnSpeed = -100f;
            _landerRigidBody2D.AddTorque(turnSpeed * Time.deltaTime);
            
        }
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            float turnSpeed = 100f;
            _landerRigidBody2D.AddTorque(turnSpeed * Time.deltaTime);
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.relativeVelocity.magnitude >= 3)
        {
            Debug.Log("Sert Ýniþ");
        }
        float dotVector = Vector2.Dot(Vector2.up, transform.up);
        float minDotVector = 0.90f;

        if (dotVector < minDotVector)
        {
            Debug.Log("Uzay Aracý Dik açýyla iniþ yaptý");
        }

        if (collision2D.relativeVelocity.magnitude < 3)
        {
            Debug.Log("Yumuþak Ýniþ");
        }

    }
}
