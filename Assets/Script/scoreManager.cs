using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI GreenLebronCount;
    public TextMeshProUGUI RedLebronCount;

    public Collection collectedAmmount;
    public spawner goodLebronCount;
    public spawner badLebronCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GreenLebronCount.text = "Green Lebron Left: " + (goodLebronCount.goodLebronToSpawn - collectedAmmount.amountCollected);
        RedLebronCount.text = "Red Lebron Left: " + badLebronCount.badLebronLeft;
    }
}
