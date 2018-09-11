using UnityEngine;

public class Bouncing : MonoBehaviour
{

    public Vector3 Loss = new Vector3(0.8f,0.8f,0.8f);

    [SerializeField]
    private Vector3 initialVelocity;

    [SerializeField]
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.gameObject.name == "basketball hoop" || collision.transform.gameObject.tag == "Glass")
        {
            Bounce((collision.contacts[0].normal)/2);
        } else
        {
            Bounce(collision.contacts[0].normal);
        }
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = (direction * Mathf.Max(speed, minVelocity));
        rb.velocity = rb.velocity * 0.88f;

    }
}