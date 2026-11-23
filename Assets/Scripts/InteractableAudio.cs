using UnityEngine;
using FMOD.Studio;
using FMODUnity;

[CreateAssetMenu(fileName = "InteractableAudio", menuName = "Scriptable Objects/InteractableAudio")]
public class InteractableAudio : ScriptableObject
{
    //Deklarerar event referenser, som routeas till FMOD Studio via string/struct path
    [SerializeField] private EventReference Scene1Event, boxDestroyEvent, keyPickEvent;

    public void PlayScene1Event()
    
    
    {
        RuntimeManager.PlayOneShot(Scene1Event);
        
    }
    else
    public void StopScene1Event()
    {
        RuntimeManager.PlayOneShot(Scene1Event);
    }

    //() Referenserar till transform position för Fmod 3D spatialiser distans
    public void BoxDestroyPlay(Transform objTransform)
    {
        RuntimeManager.PlayOneShot(boxDestroyEvent, objTransform.position);
    }
    
    public void KeyPickEvent(Transform objTransform)
    
    {
        RuntimeManager.PlayOneShot(keyPickEvent, objTransform.position);
    }
    
}
