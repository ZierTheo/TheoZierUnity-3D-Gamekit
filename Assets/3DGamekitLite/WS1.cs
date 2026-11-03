using UnityEngine;

public class WS1 : MonoBehaviour
{
    //private bool bingbong = true;
    //string name = "Theo";
    //private float speed = 13.36f;
    //private int age = 37;
    private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }
    

    // Update is called once per frame
    void Update()
    {
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
