using UnityEngine;

public class goodLebronMove : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    public LayerMask whatIsGround;

    private Rigidbody rb;
    bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f, whatIsGround);
    }

    private void FixedUpdate()
    {
        if (isGrounded)
        {
            movement();
        }
    }
    void movement()
    {
        rb.AddForce(transform.forward * speed, ForceMode.Force);
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }
}
