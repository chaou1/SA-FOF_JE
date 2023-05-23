using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingMovement : MonoBehaviour
{
    public enemy enemy;
    public float speed;
    public int ranNumber;
    // Update is called once per frame
    void Update()
    {
        WalkingMovement();

    }
    private void FixedUpdate()
    {
        //ranNumber = Random.Range(0, 100);
    }


    public void WalkingMovement() { 
    
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, collision.transform.position, speed*Time.deltaTime);

        }
    }
}
