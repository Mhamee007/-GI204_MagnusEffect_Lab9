using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] Vector3 angularV;
    [SerializeField] Vector3 torque;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
