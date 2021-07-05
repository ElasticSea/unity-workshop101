using UnityEngine;

public class Tank : MonoBehaviour
{
    [Tooltip("Determines how fast is the tank going to move forward and backward")]
    [SerializeField] private float moveSpeed = 5;
    
    [Tooltip("Determines how fast tank rotates left and right around it's axis")]
    [SerializeField] private float rotateSpeed = 360;
    
    void Update()
    {
        // Samples input that corresponds to vertical axi, up down arrows on keyboard
        var moveInput = Input.GetAxis("Vertical");
        
        // Move in the direction that tank is facing
        var moveDistance = Time.deltaTime * moveSpeed * moveInput;
        transform.position += moveDistance * transform.forward;

        // Rotate tank around it's up axis
        var rotateInput = Input.GetAxis("Horizontal");
        var rotateDistance = new Vector3(0, Time.deltaTime * rotateSpeed * rotateInput, 0);
        transform.Rotate(rotateDistance, Space.Self);
    }
}
