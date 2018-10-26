using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]
public class CubeCollision : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3 ForceTransfered;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var rbComponent = other.gameObject.GetComponent<Rigidbody>();
            ForceTransfered = rbComponent.velocity;

            Debug.Log(ForceTransfered);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            

            var dir = transform.position - other.transform.position;


            //Debug.Log(rbComponent.velocity.magnitude);

           
            rb.AddForce(dir + ForceTransfered);

            

        }
    }
}