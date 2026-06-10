using UnityEngine;

public class shoot : MonoBehaviour
{
    public bool badLebronShot = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootGun();
        }
    }
    void shootGun()
    {
        Debug.Log("Shooting gun!");
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit))
        {
            Debug.Log("Hit: " + hit.collider.name);
            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("badLebronLayer"))
            {
                Destroy(hit.transform.gameObject);
                badLebronShot = true;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 100);
    }
}
