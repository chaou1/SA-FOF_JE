using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public basicMovement basicmovement;
    public float maxStamina=50;
    public float stamina=50;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (basicmovement.slowdown == true) {
            staminaCountdown();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "death") { GameObject.Destroy(this.gameObject); }
    }
    public void staminaCountdown() {
        while (stamina >= 0f) { 
            stamina = stamina - 0.4f; 
       }
        if (stamina == 0) {
            basicmovement.slowdown = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "grounded"&& stamina<=maxStamina) {
            stamina = stamina + 0.4f;
        }
    }
}
