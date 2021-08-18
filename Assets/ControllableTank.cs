using UnityEngine;

public class ControllableTank : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotateSpeed = 180f;
    
    private void FixedUpdate()
    {
        var moveInput = Input.GetAxis("Vertical");
        var rotateInput = Input.GetAxis("Horizontal");
        
        var newPosition = transform.position + transform.forward * moveSpeed * moveInput * Time.fixedDeltaTime;
        var rotation = rotateInput * rotateSpeed * Time.fixedDeltaTime;
        
        GetComponent<Rigidbody>().rotation *= Quaternion.Euler(0, rotation, 0);
        GetComponent<Rigidbody>().MovePosition(newPosition);
    }
}