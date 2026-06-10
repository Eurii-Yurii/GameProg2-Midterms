using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject badLebron;
    [SerializeField] GameObject goodLebron;

    int goodAmountSpawned = 0;
    int badAmountSpawned = 0;

    public int badLebronLeft = 0;

    int badLebronToSpawn = 1;
    public int goodLebronToSpawn = 3;

    public Collection collectedAmmount;
    public Collection BedLebronTouched;

    public shoot badLebronShot;

    private void Start()
    {
    }

    void Update()
    {
        if (collectedAmmount.amountCollected >= goodLebronToSpawn)
        {
            collectedAll();
        }

        if (goodAmountSpawned <= goodLebronToSpawn - 1)
        {
            spawnGoodLebron();
        }

        if (badAmountSpawned <= badLebronToSpawn - 1)
        {
            spawnbadLebron(); 
        }

        if (BedLebronTouched.touchedBadLebron)
        {
            collectedBad();
        }

        if (badLebronShot.badLebronShot)
        {
            badLebronLeft--;
            badLebronShot.badLebronShot = false;
        }
    }

    void collectedAll()
    {
        destroyAll();
        collectedAmmount.amountCollected = 0;
        goodAmountSpawned = 0;
        badAmountSpawned = 0;
        badLebronLeft = 0;

        goodLebronToSpawn +=2;
        badLebronToSpawn++;
    }

    void collectedBad()
    {
        destroyAll();

        goodAmountSpawned = 0;
        badAmountSpawned = 0;
        collectedAmmount.amountCollected = 0;
        BedLebronTouched.touchedBadLebron = false;
    }

    void destroyAll()
    {
        GameObject[] lebrons = GameObject.FindGameObjectsWithTag("lebron");

        foreach (GameObject lebron in lebrons)
        {
            Destroy(lebron);
        }
    }

    void spawnGoodLebron()
    {
        Instantiate(goodLebron, transform.position, Quaternion.identity);
        goodAmountSpawned++;
    }

    void spawnbadLebron()
    {
        Instantiate(badLebron, transform.position, Quaternion.identity);
        badAmountSpawned++;
        badLebronLeft++;
    }
}
