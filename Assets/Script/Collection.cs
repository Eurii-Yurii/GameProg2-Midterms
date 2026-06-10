using UnityEngine;

public class Collection : MonoBehaviour
{
    public LayerMask goodLebronLayer;
    public LayerMask badLebronLayer;

    public int amountCollected = 0;
    public bool touchedBadLebron = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("badLebronLayer"))
        {
            touchedBadLebron = true;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("goodLebronLayer"))
        {
            Destroy(collision.gameObject);
            amountCollected++;
        }
    }
}
