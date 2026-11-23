using System;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public enum ElementalPower
{
    Fire,
    Water,
    Earth,
    Air
}

[System.Serializable]
public struct CharacterInformation
{
    public string name;
    public ElementalPower elementSignal;
    private float speed;
    public int health;
    public bool canFly;
    public int damagePower;




}

public class WS2 : MonoBehaviour
{
    public ElementalPower elementSignal;
    public CharacterInformation characterInformation;
    // En variablen av en struct

    public EventReference eventRef;
    public EventInstance eventInstance;
    
    
    public int[] highScores;


    private void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventRef);
        //eventInstance.start();
        
        eventInstance.getPlaybackState(out PLAYBACK_STATE state);
        Debug.Log(state);
        
        //PLAYBACK_STATE.STOPPED;
        
        
       
                
        
        
        
        if (characterInformation.canFly == true)
        {
            Debug.Log(characterInformation.name);
        }
        
        if (highScores[0] > highScores[1])
        {
            Debug.Log(highScores[0]);
        }

        foreach (int score in highScores)
        {
            Debug.Log(score);
        }
        
    }
    
    


    private void Update()
    {
        
            
            
            
        
    }
    
}
 
