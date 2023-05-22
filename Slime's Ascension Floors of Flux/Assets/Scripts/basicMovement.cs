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
    public Vector2 cMovement;
    public float maxCharge=20;


    // Start is called before the first frame update
    void Start()
    {
        Transform playerposition = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        cMovement=Charging();
        if (Input.GetKeyUp(KeyCode.W | KeyCode.A))
        {
            rb.MovePosition(rb.position + cMovement);
            movement.y = 0;
 
        }
        if (Input.GetKeyUp(KeyCode.S | KeyCode.D))
        {
            rb.MovePosition(rb.position + cMovement);
            movement.x = 0;
        }
    }


    public Vector2 Charging() {

            if (Input.GetKey(KeyCode.W)& movement.y<= maxCharge)
            {
                movement.y = movement.y + 0.01f;
                
            }
            if (Input.GetKey(KeyCode.S) & movement.y <= maxCharge)
            {
                movement.y = movement.y - 0.01f;
                
        }
            if (Input.GetKey(KeyCode.A) & movement.x <= maxCharge)
            {
                movement.x = movement.x  -0.01f;
                
        }
            if (Input.GetKey(KeyCode.D) & movement.x <= maxCharge)
            {
                movement.x = movement.x +0.01f;
               
        }
        

        return movement;
    }

}
