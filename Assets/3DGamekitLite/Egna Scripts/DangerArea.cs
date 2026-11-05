using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DangerArea : MonoBehaviour
{
    private HungerM hM;
    
    [SerializeField] private float timerReduction = 5f;
    
    void Start()
    {
        hM = GameObject.Find("HungerManager").GetComponent<HungerM>();
    }

    private void OnTriggerEnter(Collider other)
    {
        hM.SubtractHungerTime(timerReduction);
    }
    
    private void OnTriggerExit(Collider other)
    {
        hM.ResetHungerTime();
    }

}
