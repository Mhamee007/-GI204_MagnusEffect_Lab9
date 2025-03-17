using UnityEngine;

public class magnuseffect : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] Vector3 velocity, angularV;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            Kick();
        }
       ApplyMagnusEffect();
    }

    void Kick()
    {
  
        rb.linearVelocity = velocity;
        rb.angularVelocity = angularV;

      
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusforce = Vector3.Cross(velocity,angularV);
        rb.AddForce(magnusforce);
    }
}
