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
    public bool slowdown = false;
    public bool noStamina = false;
    public AudioSource dashSound;
    public float midairJump;
    public float cmidairJump;
    public float maxStamina = 40;
    public float stamina = 40;
    private groundCheck gC;


    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gC = this.gameObject.GetComponentInChildren<groundCheck>();
        cmidairJump = midairJump;
        deltaTime = Time.deltaTime;
        Transform playerposition = player.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cmidairJump != 0)
        {
            movement = Charging();
        }
        if (slowdown == true)
        {
            staminaCountdown();
        }

    }
 void Update()
    {
        if (gC.isGrounded == true)
        {
            cmidairJump = midairJump;
            stamina = maxStamina;
            noStamina = false;
            animator.SetBool("idle",true);
        }
        if (gC.isGrounded == false)
        {
            animator.SetBool("idle", false);

        }
        if (cmidairJump != 0)
        {
            if ((Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) & Mathf.Abs(movement.y) >= minCharge)
            {

                rb.velocity = new Vector2(rb.velocity.x, movement.y);
                movement.y = 0;
                dashSound.Play();
                cmidairJump--;

            }
            if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) & Mathf.Abs(movement.x) >= minCharge)
            {
                animator.Play("launch");
                
                rb.velocity = new Vector2(movement.x, rb.velocity.y);
                movement.x = 0;
                dashSound.Play();
                cmidairJump--;
            }
        }
        //Slow Motion
        if (Input.GetKey(KeyCode.Space) & noStamina == false)
        {
            Time.timeScale = slowmotionFactor;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            slowdown = true;
            animator.SetBool("charge", true);
        }
        else {
            Time.timeScale = 1;
            Time.fixedDeltaTime = deltaTime;
            slowdown = false;
            animator.SetBool("charge", false);
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
                animator.SetBool("left", true);   


        }
            if (Input.GetKey(KeyCode.D) & movement.x <= maxCharge)
            {
                movement.x = movement.x + chargeX;
                animator.SetBool("left", false);

        }
        

        return movement;
    }


    //stamina

    public void staminaCountdown()
    {   
        if (stamina > 0f)
        {
            stamina = stamina - 0.2f;
            
        }
        if (stamina <= 0)
        {
           noStamina = true;
        }
    }

}
