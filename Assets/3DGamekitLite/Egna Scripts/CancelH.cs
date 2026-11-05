using UnityEngine;

public class CancelH : MonoBehaviour
{
    [SerializeField] private string requiredTag = "Player";
    private HungerM hM;

    void Start()
    {
        hM = GameObject.Find("HungerManager").GetComponent<HungerM>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Letar efter tag, som är player
        if (other.tag == requiredTag)
        {
            hM.feelHunger = false;
            Destroy(gameObject);
        }
    }
}