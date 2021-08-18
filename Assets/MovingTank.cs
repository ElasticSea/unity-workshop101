using UnityEngine;

public class MovingTank : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotateSpeed = 0.2f;
    
    private void FixedUpdate()
    {
        var time = Time.time * rotateSpeed;
        var x = Mathf.Cos(time * Mathf.PI * 2);
        var z = Mathf.Sin(time * Mathf.PI * 2);
        var direction = new Vector3(x, 0, z);
        var newPosition = transform.position + direction * moveSpeed * Time.fixedDeltaTime;
        
        transform.rotation = Quaternion.LookRotation(direction);
        GetComponent<Rigidbody>().MovePosition(newPosition);
    }
}