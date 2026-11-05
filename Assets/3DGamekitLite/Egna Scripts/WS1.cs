using UnityEngine;
using UnityEngine.Events;
using Gamekit3D;

using Gamekit3D;

public class WS1 : MonoBehaviour
{
    
    string name = "RAGGHHHHH";
    
    public Rigidbody2D rb;


    
    public UnityEvent onStart;

    private float timer = 0;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        //myNumber += 1;
        
        //Looping
        for (int counter = 0; counter < 10; counter++)
        {
            Debug.Log(counter);
            if (counter == 7)
            {
                Destroy(gameObject);
                Debug.Log("Jag förstörd :[");
            }
            
        }
    }
    

   
    void Update()
    {
        //+= är tid plus sen senaste frame
        timer += Time.deltaTime;
        Debug.Log(timer);
        
        Debug.Log(name);
        if (Input.GetKey(KeyCode.Space))
        {
            YSpeed();
        }
        
        
        
    }
    
    
    void YSpeed()
    {
        rb.linearVelocityY = 3f;
    }
}
