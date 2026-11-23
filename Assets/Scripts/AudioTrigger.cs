using System;
using UnityEngine;
using UnityEngine.Events;
public class AudioTrigger : MonoBehaviour
{
    public UnityEvent OnTrigger;

    private void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Player")
        {
            OnTrigger.Invoke();
            
            
            Debug.Log("Player");
        }
    }
}
