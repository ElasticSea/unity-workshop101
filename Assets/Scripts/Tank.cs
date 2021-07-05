using UnityEngine;

public class Tank : MonoBehaviour
{
    [Tooltip("Determines how fast is the tank going to move forward and backward")]
    [SerializeField] private float moveSpeed = 5;
    
    void Update()
    {
        // Samples input that corresponds to vertical axi, up down arrows on keyboard
        var moveInput = Input.GetAxis("Vertical");
        
        // Move in the direction that tank is facing
        var moveDistance = Time.deltaTime * moveSpeed * moveInput;
        transform.position += moveDistance * transform.forward;
    }
}
