using UnityEngine;

public class Tank : MonoBehaviour
{
    [Tooltip("Determines how fast is the tank going to move forward and backward")]
    [SerializeField] private float moveSpeed = 5;
    
    [Tooltip("Determines how fast tank rotates left and right around it's axis")]
    [SerializeField] private float rotateSpeed = 360;

    [Tooltip("Drag here tank rigidbody reference")]
    [SerializeField] private Rigidbody rigidbody;
    
    void FixedUpdate()
    {
        // Samples input that corresponds to vertical axi, up down arrows on keyboard
        var moveInput = Input.GetAxis("Vertical");
        
        // Move in the direction that tank is facing
        var moveDistance = Time.fixedDeltaTime * moveSpeed * moveInput;
        var newPos = transform.position + moveDistance * transform.forward;
        rigidbody.MovePosition(newPos);

        // Rotate tank around it's up axis
        var rotateInput = Input.GetAxis("Horizontal");
        var rotateDistance = new Vector3(0, Time.fixedDeltaTime * rotateSpeed * rotateInput, 0);
        var newRot = Quaternion.Euler(rotateDistance) * transform.rotation;
        rigidbody.MoveRotation(newRot);
    }
}
