using System;
using UnityEngine;

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

    public int[] highScores;

//Check Enum
    private void Start()
    {
        if (elementSignal == ElementalPower.Air)
        {
            Debug.Log(elementSignal);
        }
        
        
        if (characterInformation.canFly == true)
        {
            Debug.Log(characterInformation.name);
        }
        
        if (highScores[0] > highScores[1])
        {
            Debug.Log(highScores[0]);
        }
        
    }
    
    


    private void Update()
    {
        
            
            
            
        
    }
    
}
 
