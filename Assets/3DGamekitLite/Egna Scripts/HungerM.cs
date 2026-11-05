using UnityEngine;
using Gamekit3D;



public class HungerM : MonoBehaviour
{
    private Damageable damageTarget;
    
    
    //Timers, Serialized field visar parameter i unity
    [SerializeField] private float hungerTime = 10.0f;
    private float timer = 0.0f;
    private float maxDamageTime;
    
    //Damageable
    [SerializeField] private int damageAmount = 1;
    
    //Bools
    
    public bool feelHunger = true;
    
    
    
    
    //Start
    
    void Start()
    {
        
        damageTarget = GameObject.Find("Ellen").GetComponent<Damageable>();
        maxDamageTime = hungerTime;
    }
    
    //Update
    void Update()
    {
        // så länge can Feel Hunger är sant så kör vi hunger timern
        
        if (feelHunger) 
        {
            timer += Time.deltaTime;

            if (timer >= hungerTime)
            {
                //Damage

                //Tar värdet från damage amount, gör det möjligt att ändra via inspector

                Damageable.DamageMessage msg = new Damageable.DamageMessage
                {
                    damager = this,

                    amount = damageAmount,

                    damageSource = new Vector3(x: 0, y: 0, z: 0).normalized,

                    direction = new Vector3(x: 0, y: 0, z: 0).normalized,

                    throwing = false,

                    stopCamera = false
                };




                //skickar data till damageable, rad 85

                damageTarget.ApplyDamage(msg);
                ResetTimer();

            }
        }
        else
        {
            Debug.Log("AAAAHHGGGHH RAGHHHHHHHHHHHHH");
        }
        
    }

    public void ResetTimer()
    {
        //Debug.Log("Resetting timer" + timer);
        timer = 0.0f;
    }

    public void SubtractHungerTime(float reduction)
    {
        hungerTime -= reduction;
        Debug.Log("damagetime = " + hungerTime);
    }

    public void ResetHungerTime()
    {
        hungerTime = maxDamageTime;
        Debug.Log("damagetime = " + hungerTime);
    }
        
}
