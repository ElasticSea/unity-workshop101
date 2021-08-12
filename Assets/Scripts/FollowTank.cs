using UnityEngine;

public class FollowTank : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(5, 5, 5);
    [SerializeField] private float followSpeed = 0.05f;
    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, followSpeed);
        //transform.position = target.position + offset;
        // transform.LookAt(target);
    }
}