using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public basicMovement basicmovement;
    public Vector3  currentCheckpoint;
    public Transform playerPosition;
    
    // Start is called before the first frame update
    void Start()
    {
  
        currentCheckpoint = this.gameObject.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "death") 
        {
            playerPosition.position = currentCheckpoint;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("checkpoint")) 
        {
            currentCheckpoint = playerPosition.position;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }

}
