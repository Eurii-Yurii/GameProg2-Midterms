using Unity.VisualScripting;
using UnityEngine;

public class lebronMove : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
}