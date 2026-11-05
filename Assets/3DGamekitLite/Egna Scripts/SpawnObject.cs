using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    
    public void SpawnSetObject()
    {
        Instantiate(spawnObject, gameObject.transform.position, Quaternion.identity);
        Debug.Log("Spawning a objectoid");
    }
}
