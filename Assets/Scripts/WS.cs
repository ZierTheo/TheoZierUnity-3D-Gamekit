using UnityEngine;
using FMODUnity;
using FMOD.Studio;


public class WS : MonoBehaviour
{
    public EventInstance instance;
    public EventReference reference;
    void Start()
    {
        instance = RuntimeManager.CreateInstance(reference);
        instance.start();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
