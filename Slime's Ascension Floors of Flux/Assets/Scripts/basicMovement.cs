using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float pSpeed;
    public float force;
    public Transform playerposition;
    public Vector2 movement;
    public float chargeX;
    public float chargeY;
    public float slowmotionFactor;
    float deltaTime;
    public float maxCharge;
    public float minCharge;


    // Start is called before the first frame update
    void Start()
    {
        deltaTime = Time.deltaTime;
        Transform playerposition = player.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement=Charging();
        
        

    }
 void Update()
    {
        if ((Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) & Mathf.Abs(movement.y) >= minCharge)
        {

            rb.velocity = new Vector2(rb.velocity.x, movement.y);
            movement.y = 0;

        }
        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) & Mathf.Abs(movement.x) >= minCharge)
        {
            rb.velocity = new Vector2(movement.x, rb.velocity.y);
            movement.x = 0;
        }

        //Slow Motion
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = slowmotionFactor;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
        else {
            Time.timeScale = 1;
            Time.fixedDeltaTime = deltaTime;
        }
    }

    //Charging the Movement
    public Vector2 Charging() {

            if (Input.GetKey(KeyCode.W)& movement.y<= maxCharge)
            {
                movement.y = movement.y + chargeY;
                
            }
            if (Input.GetKey(KeyCode.S) & movement.y >= -maxCharge)
            {
                movement.y = movement.y - chargeY;
                
        }
            if (Input.GetKey(KeyCode.A) & movement.x >= -maxCharge)
            {
                movement.x = movement.x  - chargeX;
                
        }
            if (Input.GetKey(KeyCode.D) & movement.x <= maxCharge)
            {
                movement.x = movement.x + chargeX;
               
        }
        

        return movement;
    }
    
}
