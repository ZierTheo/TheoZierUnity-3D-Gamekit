using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit3D;


public class HealthP : MonoBehaviour
{

    [SerializeField] private string requiredTag = "Player";
    [SerializeField] private bool destroyOnTrigger = true;
    private HungerM hM;


    [SerializeField] private bool fullRegain = false;
    [SerializeField] private int healtAmount = 1;
    
    void Start()
    {
        //Fyller Hm med innehållet under
        hM = GameObject.Find("HungerManager").GetComponent<HungerM>();

    }


    private void OnTriggerEnter(Collider other)
    {

        //Kollar player tag
        
        if (other.tag == requiredTag)
        {
            //Tar från rad 60 i damageable

            if (fullRegain == true)
            {
                //Hittar damaeable object och ger healtg
                other.GetComponent<Damageable>().ResetDamage();
                Debug.Log("fullRegain = " + fullRegain);
            }
            else
            {
                other.GetComponent<Damageable>().GainSetHealth(healtAmount);
                Debug.Log("fullRegain = " + fullRegain);
            }
           
            hM.ResetTimer();
            if (destroyOnTrigger == true)
            {
                Destroy(gameObject);
                
            }
        }
    }   

}
